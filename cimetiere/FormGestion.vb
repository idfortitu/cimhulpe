Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Public Class FormGestion
    Public dtPersonnes As DataTable
    Public dtcons As DataTable
    Public dtbenef As DataTable
    Public flagdefunt As Integer
    Public flagconssession As Integer
    Public flagacteur As Integer
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        flagacteur = 0
        flagconssession = 0


        DataTableDefunt()
        DataBindDefunt()
        flagdefunt = 1
    End Sub


    Sub DataTableDefunt()
        dtPersonnes = GetDataTable("select * FROM defunts INNER JOIN t_loc_ville ON defunts.locville_id = t_loc_ville.locville_id INNER JOIN t_pays on t_loc_ville.locville_id = t_pays.Pays_id INNER JOIN emplacements on defunts.empl_id = emplacements.empl_id")
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "def_nom"
        DTGV_Id_Colonne.HeaderText = "nom"
        DTGV_Id_Colonne.Name = "def_nom"

        DgvListeDefunts.Columns.Add(DTGV_Id_Colonne)
        ColonnePrenom.DataPropertyName = "def_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "def_prenom"
        DgvListeDefunts.Columns.Add(ColonnePrenom)
        DgvListeDefunts.AutoGenerateColumns = False
        DgvListeDefunts.DataSource = dtPersonnes
        DgvListeDefunts.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeDefunts.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Sub DataTableConsBeneficiaire()
        dtbenef = GetDataTable("SELECT * FROM beneficiaires INNER JOIN beneficier ON beneficiaires.ben_id = beneficier.ben_id where beneficier.con_id = " & dtcons.Rows(FCDGConss.CurrentRow.Index())("con_id") & "")
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "ben_nom"
        DTGV_Id_Colonne.HeaderText = "nom"
        DTGV_Id_Colonne.Name = "ben_nom"
        FCDGBeneficiaire.Columns.Add(DTGV_Id_Colonne)
        ColonnePrenom.DataPropertyName = "ben_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "ben_prenom"
        FCDGBeneficiaire.Columns.Add(ColonnePrenom)
        FCDGBeneficiaire.AutoGenerateColumns = False
        FCDGBeneficiaire.DataSource = dtbenef
        FCDGBeneficiaire.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FCDGBeneficiaire.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Sub DataTableConcess()
        dtPersonnes = GetDataTable("select * FROM concessionnaires INNER JOIN t_loc_ville ON concessionnaires.locville_id = t_loc_ville.locville_id INNER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id")
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "csnr_nom"
        DTGV_Id_Colonne.HeaderText = "nom"
        DTGV_Id_Colonne.Name = "csnr_nom"
        DgvListeConcessionnaire.Columns.Add(DTGV_Id_Colonne)
        ColonnePrenom.DataPropertyName = "csnr_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "csnr_prenom"
        DgvListeConcessionnaire.Columns.Add(ColonnePrenom)
        DgvListeConcessionnaire.AutoGenerateColumns = False
        DgvListeConcessionnaire.DataSource = dtPersonnes
        DgvListeConcessionnaire.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeConcessionnaire.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub



    Sub DataTableConcession()
        dtcons = GetDataTable("SELECT * FROM concessions INNER JOIN emplacements ON concessions.empl_id = emplacements.empl_id INNER JOIN t_histoire ON concessions.h_id = t_histoire.h_id INNER JOIN t_commentaire ON concessions.com_id = t_commentaire.com_id")
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "con_numero"
        DTGV_Id_Colonne.HeaderText = "numero"
        DTGV_Id_Colonne.Name = "con_numero"
        FCDGConss.Columns.Add(DTGV_Id_Colonne)
        ColonnePrenom.DataPropertyName = "empl_reference"
        ColonnePrenom.HeaderText = "emplacement"
        ColonnePrenom.Name = "empl_reference"
        FCDGConss.Columns.Add(ColonnePrenom)
        FCDGConss.AutoGenerateColumns = False
        FCDGConss.DataSource = dtcons
        FCDGConss.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FCDGConss.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub


    Sub DataTableDefuntCons()
        FCDGDefunt.DataBindings.Clear()
        FCDGDefunt.Columns.Clear()
        dtdefunt = GetDataTable("SELECT * FROM defunts WHERE empl_id = " & dtcons.Rows(FCDGConss.CurrentRow.Index())("empl_id") & "")
        Dim DTGV_Id_Colonne_def = New DataGridViewTextBoxColumn()
        Dim Colonne = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne_def.DataPropertyName = "def_nom"
        DTGV_Id_Colonne_def.HeaderText = "nom"
        DTGV_Id_Colonne_def.Name = "def_nom"
        FCDGDefunt.Columns.Add(DTGV_Id_Colonne_def)
        Colonne.DataPropertyName = "def_prenom"
        Colonne.HeaderText = "prenom"
        Colonne.Name = "def_prenom"
        FCDGDefunt.Columns.Add(Colonne)
        FCDGDefunt.AutoGenerateColumns = False
        FCDGDefunt.DataSource = dtdefunt
        FCDGDefunt.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FCDGDefunt.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Sub DataTableBeneficiaire()
        dtPersonnes = GetDataTable("select * FROM beneficiaires INNER JOIN t_loc_ville ON beneficiaires.locville_id = t_loc_ville.locville_id INNER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id")
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "ben_nom"
        DTGV_Id_Colonne.HeaderText = "nom"
        DTGV_Id_Colonne.Name = "ben_nom"
        DgvListeConcessionnaire.Columns.Add(DTGV_Id_Colonne)
        ColonnePrenom.DataPropertyName = "ben_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "ben_prenom"
        DgvListeConcessionnaire.Columns.Add(ColonnePrenom)
        DgvListeConcessionnaire.AutoGenerateColumns = False
        DgvListeConcessionnaire.DataSource = dtPersonnes
        DgvListeConcessionnaire.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeConcessionnaire.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Sub DataTablePersContact()
        dtPersonnes = GetDataTable("select * FROM personnes_contact INNER JOIN t_loc_ville ON personnes_contact.locville_id = t_loc_ville.locville_id INNER JOIN t_pays ON t_loc_ville.Pays_id = t_pays.Pays_id")
        Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        DTGV_Id_Colonne.DataPropertyName = "pc_nom"
        DTGV_Id_Colonne.HeaderText = "nom"
        DTGV_Id_Colonne.Name = "pc_nom"
        DgvListeConcessionnaire.Columns.Add(DTGV_Id_Colonne)
        ColonnePrenom.DataPropertyName = "pc_prenom"
        ColonnePrenom.HeaderText = "prenom"
        ColonnePrenom.Name = "pc_prenom"
        DgvListeConcessionnaire.Columns.Add(ColonnePrenom)
        DgvListeConcessionnaire.AutoGenerateColumns = False
        DgvListeConcessionnaire.DataSource = dtPersonnes
        DgvListeConcessionnaire.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DgvListeConcessionnaire.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub


    Private Sub DataBindConsDefunt()
        FCTBnumero.DataBindings.Add("Text", dtcons, "con_numero")
        FCTBEmplacement.DataBindings.Add("Text", dtcons, "empl_reference")


        FCTBMonumentClasse.DataBindings.Add("Text", dtcons, "empl_monum_classe")
        FCTBCommentaire.DataBindings.Add("Text", dtcons, "com_commentaire")
        FCTBHistoire.DataBindings.Add("Text", dtcons, "h_histoire")
        FCTBType.DataBindings.Add("Text", dtcons, "empl_type")
        FCTBDateDeb.DataBindings.Add("Text", dtcons, "con_date_debut")
        FCTBDateFin.DataBindings.Add("Text", dtcons, "con_date_fin")





    End Sub
    Private Sub DataBindConsbenef()


        TBconsBenefnom.DataBindings.Add("Text", dtbenef, "ben_nom")
        TBconsBenefprenom.DataBindings.Add("Text", dtbenef, "ben_prenom")
        TBconsBenefadress.DataBindings.Add("Text", dtbenef, "ben_adresse")
        TBconsBenefdatenaiss.DataBindings.Add("Text", dtbenef, "ben_date_naiss")


    End Sub
    Private Sub DataBindDefunt()
        FPTBNom.DataBindings.Add("Text", dtPersonnes, "def_nom")
        FPTBPrenom.DataBindings.Add("Text", dtPersonnes, "def_prenom")
        FPTBDateNaiss.DataBindings.Add("Text", dtPersonnes, "def_date_naiss")
        FPTBDateE.DataBindings.Add("Text", dtPersonnes, "Date_debut")
        FPTBSepulture.DataBindings.Add("Text", dtPersonnes, "empl_id")


        FPTBEtatCivil.DataBindings.Add("Text", dtPersonnes, "def_etat_civil")

        FPTBAdresse.DataBindings.Add("Text", dtPersonnes, "def_adresse")

        FPTBDateM.DataBindings.Add("Text", dtPersonnes, "def_date_deces")

        FPTBLieuNaiss.DataBindings.Add("Text", dtPersonnes, "def_lieu_naiss")
        FPTBCodeLieu.DataBindings.Add("Text", dtPersonnes, "def_etat_civil_de")

        FPTBCodePostal.DataBindings.Add("Text", dtPersonnes, "locville_cp")
        FPTBPays.DataBindings.Add("Text", dtPersonnes, "Pays_nom")
        FPTBVille.DataBindings.Add("Text", dtPersonnes, "locville_ville")
        FPTBEmplacement.DataBindings.Add("Text", dtPersonnes, "empl_reference")

    End Sub



    Private Sub DataBindConss()
        TBPersNom.DataBindings.Add("Text", dtPersonnes, "csnr_nom")
        TBPersPrenom.DataBindings.Add("Text", dtPersonnes, "csnr_prenom")
        TBPersTel.DataBindings.Add("Text", dtPersonnes, "csnr_tel")
        TBPersDN.DataBindings.Add("Text", dtPersonnes, "csnr_date_naiss")
        TBPersAdress.DataBindings.Add("Text", dtPersonnes, "csnr_adresse")
        TBPersCodePostal.DataBindings.Add("Text", dtPersonnes, "locville_cp")
        TBPersVille.DataBindings.Add("Text", dtPersonnes, "locville_ville")
        TBPersPays.DataBindings.Add("Text", dtPersonnes, "Pays_nom")
        TBPersNumNational.DataBindings.Add("Text", dtPersonnes, "csnr_no_registre")


    End Sub

    Private Sub DataBindBenef()
        TBPersNom.DataBindings.Add("Text", dtPersonnes, "ben_nom")
        TBPersPrenom.DataBindings.Add("Text", dtPersonnes, "ben_prenom")
        TBPersDN.DataBindings.Add("Text", dtPersonnes, "ben_date_naiss")
        TBPersAdress.DataBindings.Add("Text", dtPersonnes, "ben_adresse")
        TBPersNumNational.DataBindings.Add("Text", dtPersonnes, "ben_lien_parente")
        TBPersCodePostal.DataBindings.Add("Text", dtPersonnes, "locville_cp")
        TBPersVille.DataBindings.Add("Text", dtPersonnes, "locville_ville")
        TBPersPays.DataBindings.Add("Text", dtPersonnes, "Pays_nom")



    End Sub

    Private Sub DataBindPersContact()
        TBPersNom.DataBindings.Add("Text", dtPersonnes, "pc_nom")
        TBPersPrenom.DataBindings.Add("Text", dtPersonnes, "pc_prenom")
        TBPersTel.DataBindings.Add("Text", dtPersonnes, "pc_tel")
        TBPersAdress.DataBindings.Add("Text", dtPersonnes, "pc_adresse")
        TBPersCodePostal.DataBindings.Add("Text", dtPersonnes, "locville_cp")
        TBPersVille.DataBindings.Add("Text", dtPersonnes, "locville_ville")
        TBPersPays.DataBindings.Add("Text", dtPersonnes, "Pays_nom")

    End Sub

    Private Sub DataBindClear()
        TBPersNom.DataBindings.Clear()
        TBPersPrenom.DataBindings.Clear()
        TBPersTel.DataBindings.Clear()
        TBPersDN.DataBindings.Clear()
        TBPersAdress.DataBindings.Clear()
        TBPersCodePostal.DataBindings.Clear()
        TBPersNumNational.DataBindings.Clear()
        TBPersVille.DataBindings.Clear()
        TBPersPays.DataBindings.Clear()
    End Sub

    Private Sub DataBindClearConcessions()
        FCTBnumero.DataBindings.Clear()
        FCTBEmplacement.DataBindings.Clear()
        FCTBMonumentClasse.DataBindings.Clear()
        FCTBType.DataBindings.Clear()

        FCTBCommentaire.DataBindings.Clear()
        FCTBHistoire.DataBindings.Clear()
        FCTBDateDeb.DataBindings.Clear()
        FCTBDateFin.DataBindings.Clear()

    End Sub

    Private Sub DataBindClearConcessionsBeneficiaire()
        TBconsBenefnom.DataBindings.Clear()
        TBconsBenefprenom.DataBindings.Clear()
        TBconsBenefadress.DataBindings.Clear()
        TBconsBenefdatenaiss.DataBindings.Clear()
    End Sub

    Private Sub DataBindClearBeneficiaire()
        FPTBNom.DataBindings.Clear()
        FPTBPrenom.DataBindings.Clear()
        FPTBDateNaiss.DataBindings.Clear()
        FPTBDateE.DataBindings.Clear()
        FPTBEtatCivil.DataBindings.Clear()
        FPTBSepulture.DataBindings.Clear()
        FPTBDateM.DataBindings.Clear()

        FPTBEtatCivil.DataBindings.Clear()

        FPTBAdresse.DataBindings.Clear()

        FPTBEmplacement.DataBindings.Clear()

        FPTBLieuNaiss.DataBindings.Clear()
        FPTBCodePostal.DataBindings.Clear()
        FPTBPays.DataBindings.Clear()
        FPTBVille.DataBindings.Clear()

    End Sub



    '  Private Sub Deplacement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ' Inutile de tenter un déplacement si la DataTable ne contient aucune ligne.
    '   If dtPersonnes IsNot Nothing AndAlso dtPersonnes.Rows.Count > 0 Then
    ' Le BindingContext appartient à un conteneur, le formulaire dans ce cas.
    '     With Me.BindingContext(dtPersonnes)
    ' Modification de sa propriété Position en fonction du bouton.
    '       If sender.Equals(FPBPremier) Then
    '           .Position = 0
    '       ElseIf sender.Equals(FPBPrec) Then
    '           If .Position = 0 Then
    '               .Position = .Count - 1            ' Balayage circulaire
    '           Else
    '               .Position -= 1
    '           End If
    '       ElseIf sender.Equals(FPBSuivant) Then
    '          If .Position = .Count - 1 Then
    '             .Position = 0                 ' Balayage circulaire
    '         Else
    '           .Position += 1
    '       End If
    '   ElseIf sender.Equals(FPBDernier) Then
    '       .Position = .Count - 1
    '    End If
    '  End With
    '     End If
    ' End Sub






    Private Sub FPBDetails_Click(sender As Object, e As EventArgs) Handles FPBDetails.Click
        Dim FDetails As New FDetails
        FDetails.ShowDialog()
    End Sub

    Private Sub FCBDetails_Click(sender As Object, e As EventArgs) Handles FCBDetails.Click
        Dim FDetails As New FDetails
        FDetails.ShowDialog()
    End Sub

    Private Sub FPBAjouter_Click(sender As Object, e As EventArgs) Handles FPBAjouter.Click
    End Sub


    Private Sub FPBRechercher_Click(sender As Object, e As EventArgs)
        'If FPCBNom.Checked = True Then
        'Dim Source As New BindingSource()
        'Source.DataSource = Me.DgvListeDefunts.DataSource
        'Source.Filter = "def_nom Like '%" & FPTBRechercher.Text & "%'"
        'ElseIf FPCBEmplacement.Checked = True Then

        '        ElseIf FPCBDate.Checked = True Then
        ' erreur avec les dates
        ' Dim Source As New BindingSource()
        '  Source.DataSource = Me.DgvListeDefunts.DataSource
        '  Source.Filter = "def_date_naiss like '%" & FPTBRechercher.ToString & "%'"

        ' ElseIf FPCBDateD.Checked = True Then

        ' Else
        'MessageBox.Show("Veuillez inserer un choix")
        '  End If

    End Sub



    Private Sub BtDefChercher_Click(sender As Object, e As EventArgs) Handles BtDefChercher.Click

        Dim Source As New BindingSource()
            Source.DataSource = Me.DgvListeDefunts.DataSource
        Source.Filter = "def_nom Like '%" & TbDefChampRecherche.Text & "%'"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Source As New BindingSource()
        Source.DataSource = Me.DgvListeDefunts.DataSource

        Source.Filter = "def_nom like '%'"
    End Sub



    Private Sub PRBConcessionnaire_CheckedChanged(sender As Object, e As EventArgs) Handles PRBConcessionnaire.CheckedChanged
        DataBindClear()
        DgvListeConcessionnaire.DataBindings.Clear()
        DgvListeConcessionnaire.Columns.Clear()
        DataTableConcess()
        DataBindConss()
    End Sub

    Private Sub PRBPersCon_CheckedChanged(sender As Object, e As EventArgs) Handles PRBPersCon.CheckedChanged
        DataBindClear()
        DgvListeConcessionnaire.DataBindings.Clear()
        DgvListeConcessionnaire.Columns.Clear()
        DataTablePersContact()
        DataBindPersContact()
    End Sub

    Private Sub PRBBenef_CheckedChanged(sender As Object, e As EventArgs) Handles PRBBenef.CheckedChanged
        DataBindClear()
        DgvListeConcessionnaire.DataBindings.Clear()
        DgvListeConcessionnaire.Columns.Clear()
        DataTableBeneficiaire()
        DataBindBenef()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        If TabControl1.SelectedIndex.ToString = 0 Then
            If flagdefunt = 0 Then
                DataBindClearBeneficiaire()
                DgvListeDefunts.DataBindings.Clear()
                DgvListeDefunts.Columns.Clear()
                DataTableDefunt()
                DataBindDefunt()
                flagdefunt = 1
            End If

        ElseIf TabControl1.SelectedIndex.ToString = 1 Then
            If flagconssession = 0 Then
                FCDGConss.DataBindings.Clear()
                FCDGConss.Columns.Clear()
                FCDGDefunt.Columns.Clear()
                FCDGDefunt.DataBindings.Clear()
                FCDGBeneficiaire.DataBindings.Clear()
                FCDGBeneficiaire.Columns.Clear()
                DataTableConcession()
                flagconssession = 1
            End If

        ElseIf TabControl1.SelectedIndex.ToString = 2 Then
            If flagacteur = 0 Then
                DataBindClear()
                DgvListeConcessionnaire.DataBindings.Clear()
                DgvListeConcessionnaire.Columns.Clear()
                DataTableBeneficiaire()
                DataBindBenef()
                flagacteur = 1
            End If
        End If
    End Sub

    Private Sub FCDGConss_SelectionChanged(sender As Object, e As EventArgs) Handles FCDGConss.SelectionChanged

        DataBindClearConcessions()
        FCDGBeneficiaire.DataBindings.Clear()
        FCDGBeneficiaire.Columns.Clear()
        FCDGDefunt.DataBindings.Clear()
        FCDGDefunt.Columns.Clear()
        DataTableDefuntCons()
        DataTableConsBeneficiaire()
        DataBindConsDefunt()
        FCTBPlaceOccupe.Text = FCDGDefunt.RowCount - 1
        FCTBPlaceLibre.Text = dtcons.Rows(FCDGConss.CurrentRow.Index())("empl_nb_places") - (FCDGDefunt.RowCount - 1)
        Try
            TBconsBenefcodepostal.Text = GetValeurSql("SELECT * FROM t_loc_ville where locville_id = " & dtbenef.Rows(FCDGBeneficiaire.CurrentRow.Index())("locville_id") & "", "locville_cp")
            TBconsBenefville.Text = GetValeurSql("SELECT * FROM t_loc_ville where locville_id = " & dtbenef.Rows(FCDGBeneficiaire.CurrentRow.Index())("locville_id") & "", "locville_ville")
            TBconsBenefpays.Text = GetValeurSql("Select * From t_loc_ville INNER Join t_pays On t_loc_ville.locville_id = t_pays.Pays_id Where locville_id = " & dtbenef.Rows(FCDGBeneficiaire.CurrentRow.Index())("locville_id") & "", "Pays_nom")

        Catch ex As Exception
            MessageBox.Show("merde")
        End Try

    End Sub

    Private Sub FCDGBeneficiaire_SelectionChanged(sender As Object, e As EventArgs) Handles FCDGBeneficiaire.SelectionChanged
        DataBindClearConcessionsBeneficiaire()
        DataBindConsbenef()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Source As New BindingSource()
        Source.DataSource = Me.FCDGConss.DataSource
        Source.Filter = "empl_reference Like '%" & FCTBRechercher.Text & "%'"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Source As New BindingSource()
        Source.DataSource = Me.FCDGConss.DataSource

        Source.Filter = "empl_reference like '%'"
    End Sub






    ' Affiche les infos d'un défunt quand celui-ci est sélectionné dans la liste
    ' '   MsgBox("Num site : " & dtcons.Rows(FCDGConss.CurrentRow.Index())("empl_id"))
End Class
