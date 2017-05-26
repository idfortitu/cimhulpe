Public Class FormNouvelleConcession
    Implements QuiModifieBdd

    Dim LeDemandeur As Acteur
    Dim LeConcessionnaire As Acteur
    Dim LeFormNvCon As DemandeNvConcession
    Dim LesBenefs As List(Of Acteur)
    Dim LesParentes As List(Of String)

#Region "onglets"
    Private TabsBloques As Boolean = True
    Sub ChangerPage(n As Integer)
        TabsBloques = False
        TabControl1.SelectTab(n)
        TabsBloques = True
    End Sub
    Private Sub TabControl1_Click(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        If TabsBloques Then
            e.Cancel = True
        End If
    End Sub
#End Region

    Public Event BddChanged() Implements QuiModifieBdd.BddChanged
    ' À FAIRE : ajouter liste demandeurs (pers mand) quand sera mise
    Public Sub OnBddChanged()
        RaiseEvent BddChanged()
    End Sub

    Public Sub FormNouvelleConcession_Load() Handles MyBase.Load
        ' masque les onglets
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.TabStop = False

        CbPersMand_CheckedChanged(Nothing, Nothing)  ' maj visibilité partie pmand
    End Sub

    Private Sub BtSuivantDeForm_Click(sender As Object, e As EventArgs) Handles BtSuivantDeForm.Click
        MajRecapitulatif()
        ChangerPage(1)
    End Sub

    Private Sub BtPrecedentDeRecap_Click(sender As Object, e As EventArgs) Handles BtPrecedentDeRecap.Click
        ChangerPage(0)
    End Sub

    Private Sub BtTerminer_Click(sender As Object, e As EventArgs) Handles BtTerminer.Click
        Finaliser()
    End Sub

    Sub MajRecapitulatif()
        LeFormNvCon = New DemandeNvConcession

        LeFormNvCon.TypeCon = PanelChoixTypeEmpl1.GetChoix
        LeFormNvCon.DateSign = Today.Date
        LeFormNvCon.SigneParPmand = CbPersMand.Checked

        If LeFormNvCon.SigneParPmand Then
            LeDemandeur = LbListeDemandeurs.ActeurSelectionne
            LeFormNvCon.IntegrerInfosPmand(LeDemandeur)
        End If

        LeConcessionnaire = LbListeDemandeurs.ActeurSelectionne
        LeFormNvCon.IntegrerInfosCsnr(LeConcessionnaire)

        ListeBeneficiaires.GetBeneficiaires(LesBenefs, LesParentes)
        LeFormNvCon.AjouterBeneficiaires(LesBenefs, LesParentes)

        LabDmdrNom.Text = LeConcessionnaire.NomComplet

        ' Affiche le récapitulatif
        ' ou màj ses infos

        If LeFormNvCon.SigneParPmand Then
            LabDmdrNom.Text = LeDemandeur.NomComplet(True)
            LabDmdrAdresse.Text = If(LeDemandeur.AdresseComplete <> "", LeDemandeur.AdresseComplete, "(adresse non spécifiée)")
            LabDmdrTel.Text = If(LeDemandeur.Tel <> "", LeDemandeur.Tel, "(pas de numéro de téléphone)")
            GbPersMand.Visible = True
        Else
            GbPersMand.Visible = False
        End If


        LabCsnrNomComplet.Text = LeConcessionnaire.NomComplet(True)
        Dim adrcsnr = LeConcessionnaire.AdresseComplete
        LabCsnrAdresseComplete.Text = If(adrcsnr <> "", adrcsnr, "Adresse non spécifiée")
        LabCsnrTel.Text = If(LeConcessionnaire.Tel <> "", LeConcessionnaire.Tel, "(pas de numéro de téléphone)")
        LabCsnrDateNaiss.Text = If(LeConcessionnaire.DateNaiss.HasValue, LeConcessionnaire.DateNaiss.Value.ToString("dd/MM/yyyy"), "(date de naissance non précisée)")
        LabCsnrNoNat.Text = If(LeConcessionnaire.NoRegistre, LeConcessionnaire.NoRegistre.Value, "(numéro de registre national non précisé)")

        ' À FAIRE : prix
        LabTypeConcession.Text = LeFormNvCon.TypeConToString


        GbRecapBenefs.Visible = LeFormNvCon.Beneficiaires.Count >= 1
        FlpLabsBeneficiaires.Controls.Clear()
        For n = 0 To LesBenefs.Count - 1
            FlpLabsBeneficiaires.Controls.Add(New Label With {.Text = LesBenefs(n).NomComplet & If(LesParentes(n) <> "", " (" & LesParentes(n) & ")", ""), .AutoSize = True})
        Next

    End Sub

    Public Sub OnTrucsChanged()
        UpdateBtSuivantDeForm()
    End Sub

    'désact btn suiv si emplacement ne demande pas de concession, si csnr non indiqué ou si pmand présente mais pas choisie
    Private Sub UpdateBtSuivantDeForm() Handles PanelChoixTypeEmpl1.SelectionChanged, LbListeConcessionnaires.ActeurChanged, LbListeDemandeurs.ActeurChanged, CbPersMand.CheckedChanged
        Dim emplchoisi As String = PanelChoixTypeEmpl1.GetChoix
        BtSuivantDeForm.Enabled = emplchoisi <> Nothing _
                                  AndAlso UzineAGaz.EmplacementImpliqueConcession(emplchoisi) _
                                  AndAlso LbListeConcessionnaires.ActeurSelectionne IsNot Nothing _
                                  AndAlso (Not CbPersMand.Checked OrElse LbListeDemandeurs.ActeurSelectionne IsNot Nothing)
    End Sub


    Private Sub Finaliser()
        ' form vers bdd (avec infos bénefs)


    End Sub

    Private Sub CbPersMand_CheckedChanged(sender As Object, e As EventArgs) Handles CbPersMand.CheckedChanged
        LbListeDemandeurs.Visible = CbPersMand.Checked
        LabTitrePmand.Visible = CbPersMand.Checked
    End Sub
End Class