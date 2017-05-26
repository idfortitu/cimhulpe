Imports System.Runtime.InteropServices

'' --~- À RELIRE après màj bdd personnes -~-- ''

Public Class FormNouvelleInhumation
    Implements QuiModifieBdd


    ' le panneau FlpQuestions est juste au-dessus du panel terminer 6 il a une hauteur de 0 tant qu'il est vide

    Dim LeFormInh As DemandeInhumation
    Dim LeDefunt As Defunt
    Dim LeDemandeur As Acteur
    ' Resteront peut-être à Nothing si pas applicables pour la demande --
    ' ne pas se fier à leur valeur Not Nothing pour en conclure qu'ils sont utilisés, des allers-retours peuvent avoir laissé des traces 
    Dim LeConcessionnaire As Acteur
    Dim LeFormNvCon As DemandeNvConcession
    Dim LesBenefs As List(Of Acteur)
    Dim LesParentes As List(Of String)
    Dim Questions As New List(Of SimpleQuestion)

#Region "onglets"
    ' le form utilise des onglets pour les pages, mais on veut qu'il soit impossible de changer d'onglet autrement qu'en cliquant
    ' sur les boutons précédent/suivant
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
    ' quand une des listes change la bdd, elle émet un évènement (LbLaListe.BddChanged) que cette sub transmet (FormNouvelleInhumation.BddChanged) aux autres listes pour qu'elles se mettent à jour
    Public Sub OnBddChanged() Handles ListeBeneficiaires.BddChanged, LbListeConcessionnaires.BddChanged, LbListeDemandeurs.BddChanged
        RaiseEvent BddChanged()
    End Sub


    Public Sub New()
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' position du bouton Suivant
        BtSuivantDeInh.Location = New Point(PanChoixExistNv.Location.X + PanChoixExistNv.Width _
                                            - BtSuivantDeInh.Width - 6, PanChoixExistNv.Location.Y _
                                            + PanChoixExistNv.Height + 6)
        InitPartieConExistante()
    End Sub

    Private Sub FormNouvelleInhumation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' masque les onglets
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.TabStop = False

        MajAspectPartieConcession()
    End Sub

    Private Sub BtSuivantDeInh_Click(sender As Object, e As EventArgs) Handles BtSuivantDeInh.Click
        If rbDemandeObtEmplacement.Checked Then
            ChangerPage(1)
        Else
            MajRecapitulatif()
            ChangerPage(2)
        End If
    End Sub

    Private Sub BtSuivantDeCon_Click(sender As Object, e As EventArgs) Handles BtSuivantDeCon.Click
        MajRecapitulatif()
        ChangerPage(2)
    End Sub

    Private Sub BtPrecedentDeCon_Click(sender As Object, e As EventArgs) Handles BtPrecedentDeCon.Click
        ChangerPage(0)
    End Sub
    Private Sub BtPrecedentDeRecap_Click(sender As Object, e As EventArgs) Handles BtPrecedentDeRecap.Click
        If rbDemandeObtEmplacement.Checked Then
            ChangerPage(1)
        Else
            ChangerPage(0)
        End If
    End Sub


    ' EN COURS de rénovation
    ' reprend et regroupe en entités les infos des différents champs ; met à jour l'affichage des infos dans la 3ème page (le récapitulatif)
    Sub MajRecapitulatif()

        ' *** Collecte des infos ***

        ' À FAIRE (peut-être) : validation
        '  + gérer les ambiguïtés (demander quoi faire avec des SimpleQuestion ?)

        LeFormInh = New DemandeInhumation

        If rbDemandeConcessionExistante.Checked Then
            LeFormInh.ConcSollic = "existante"
        Else
            LeFormInh.TypeEmpl = PanTypeEmplNv.GetChoix
            If Not UzineAGaz.EmplacementImpliqueConcession(LeFormInh.TypeEmpl) Then
                LeFormInh.ConcSollic = "sans_concession"
            Else
                LeFormInh.ConcSollic = "nouvelle"
            End If
        End If
        LeFormInh.DateSign = Today.Date


        ' À FAIRE : numéro défunt la hulpe/année ; voir comment ils sont générés et trouver où mettre le compteur

        LeDemandeur = LbListeDemandeurs.ActeurSelectionne
        LeFormInh.IntegrerInfosDemandeur(LeDemandeur)

        LeDefunt = New Defunt With {
            .Nom = DefNom.Value,
            .Prenom = DefPrenom.Value,
            .Adresse = DefAdresse.Value,
            .Ville = DefVille.Value,
            .Cp = DefCodePostal.Value,
            .Pays = DefPays.Value,
            .LieuNaiss = DefLieuNaiss.Value,
            .LieuDeces = DefLieuDeces.Value,
            .EtatCivil = Me.GetDefEtatCivil,
            .EtatCivilDe = DefEtatCivilDe.Value
        }
        ' code pour le cas où la date est un seul champ date en sql
        LeDefunt.DateDeces = TbDefDateDeces.DateValue
        LeDefunt.DateNaiss = TbDefDateNaiss.DateValue
        ' code pour le cas où la date est en trois morceaux en bdd
        ' Dim defdatenaiss = TbDefDateNaiss.IntArrayValue
        ' etc.

        LeFormInh.IntegrerInfosDefunt(LeDefunt)


        ' Chemins :
        ' A. Checkbox "Concession existante" cochée
        '   1. Récupérer les infos sur l'emplacement
        '   2. LeFormInh.ConcSollic contient "existante"
        '   3. LeFormInh.TypeEmpl reste vide

        ' B. Checkbox "Nouvel emplacement" cochée
        '   1. Récupérer le type d'emplacement demandé
        '     a. L'emplacement ne demande pas de concession
        '       1. LeFormInh.ConcSollic contient "sans_concession"
        '       2. LeFormInh.TypeEmpl indique le type d'emplacement demandé
        '     b. L'emplacement demande une concession
        '       1. Récupérer les infos supplémentaires propres à la nouvelle concession
        '       2. Un nouveau formulaire de demande de concession est associé au formulaire d'inhumation
        '       3. LeFormInh.ConcSollic contient "nouvelle"
        '       4. LeFormInh.TypeEmpl contient le type d'emplacement demandé et est redondant avec le champ correspondant dans
        '          le nouveau formulaire de demande de concession

        ' La référence de l'emplacement devrait faire partie du form si c'est une concession existante (elle peut éventuellement être
        ' complétée après coup si un doute existe) ;
        ' À VOIR si il faut l'ajouter dans le cas d'un nouvel emplacement/nouvelle concession attribuée après avis du Collège


        If LeFormInh.ConcSollic = "existante" Then

            LeFormInh.RefEmpl = ExistanteRefEmpl.Value
            LeFormInh.RefAutresDef = TbExistanteRefAutresDefunts.Value
            '  À FAIRE
            ' type de sépulture + utilité/pertinence de ces trois champs à confirmer ;
            ' code qui sera peut-être amené à évoluer si ajout d'un "assistant" pour repérer la csn existante)
        Else        ' Nouvel emplacement
            ' Nota : DemandeInhumation.TypeEmpl devrait logiquement toujours être égal à son homologue dans le form nvcon associé,
            ' si celui-ci existe
            ' -- alternativement, pourrait être NULL si il y a une location associée, et si il n'y en a pas, ne devrait donc être rempli
            ' qu'avec un type d'emplacement ne donnant pas lieu à une concession
            LeFormInh.TypeEmpl = PanTypeEmplNv.GetChoix
            If LeFormInh.ConcSollic = "sans_concession" Then
                ' À FAIRE : voir si il faut récupérer d'autres infos dans ce cas
            Else        ' nouvelle concession
                LeFormNvCon = New DemandeNvConcession With {
                    .DateSign = LeFormInh.DateSign,
                    .TypeCon = LeFormInh.TypeEmpl,
                    .SigneParPmand = CbSigneParPmand.Checked
                }
                ListeBeneficiaires.GetBeneficiaires(LesBenefs, LesParentes)

                LeFormNvCon.AjouterBeneficiaires(LesBenefs, LesParentes)

                LeConcessionnaire = LbListeConcessionnaires.ActeurSelectionne
                LeFormNvCon.IntegrerInfosCsnr(LeConcessionnaire)

                LeFormInh.DemandeNvCon = LeFormNvCon

            End If
        End If

        ' À VOIR : avis du fossoyeur

        ' *** Affichage du récapitulatif ***


        ' *** à ce stade on a :
        ' - un formulaire d'inhumation (LeFormInh)
        ' - un demandeur (LeDemandeur)
        ' - un défunt (LeDefunt)
        ' - Peut-être une référence d'emplacement existant, voire un Id (pas implémenté actuellement)
        ' - éventuellement, un formulaire de nouvelle concession en tant qu'entité liée au form inh (LeFormNvcon, alias LeFormInh.FormNvCon)
        ' - dans ce cas, on a un concessionnaire (LeConcessionnaire)
        ' - et une liste de bénéficiaires qui peut être vide (LesBenefs)

        ' *** Met à jour l'affichage du récapitulatif des infos

        ' Quels panels doivent être masqués ?
        GbConcessionExistante.Visible = LeFormInh.ConcSollic = "existante"
        GbEmplSansCon.Visible = LeFormInh.ConcSollic = "sans_concession"
        GbRecapBenefs.Visible = LeFormInh.ConcSollic = "nouvelle" AndAlso LeFormInh.DemandeNvCon.Beneficiaires.Count >= 1
        FlpRecapPartieNouvelleCon.Visible = LeFormInh.ConcSollic = "nouvelle"

        ' Défunt
        LabDefNomComplet.Text = LeDefunt.NomComplet(True)
        LabDefAdrComplete.Text = If(LeDefunt.AdresseComplete <> "", LeDefunt.AdresseComplete, "(adresse non précisée)")           ' voir si if(,) considère qu'une chaîne "" compte comme nothing
        LabDefNe.Text = If(LeDefunt.DateNaiss.HasValue, LeDefunt.DateNaiss.Value.ToString("dd/MM/yyyy"), "(date de naissance inconnue)")
        LabDefDecede.Text = If(LeDefunt.DateDeces.HasValue, LeDefunt.DateDeces.Value.ToString("dd/MM/yyyy"), "(date de décès non précisée)")
        LabDefEtatCiv.Text = If(LeDefunt.EtatCivil <> "", LeDefunt.EtatCivilToString, "(état civil non précisé)")

        ' Demandeur
        LabDemNomComplet.Text = LeDemandeur.NomComplet(True)
        LabDemAdresseComplete.Text = If(LeDemandeur.AdresseComplete <> "", LeDemandeur.AdresseComplete, "(adresse non précisée)")

        If LeFormInh.ConcSollic = "sans_concession" Then
            LabTypeNouvelEmpl.Text = DemandeNvConcession.TypeConToString(LeFormInh.TypeEmpl)
            ' À faire ? : autres infos ?
        ElseIf LeFormInh.ConcSollic = "nouvelle" Then
            LabSignePar.Text = If(LeFormNvCon.SigneParPmand.Value, "Signé par la personne mandatée (" & LeDemandeur.NomComplet & ")", "Signé par le concessionnaire (" & LeConcessionnaire.NomComplet & ")")
            ' À FAIRE : ajouter prix
            LabNvConChoisie.Text = LeFormNvCon.TypeConToString
            ' À CONTINUER : afficher infos concessionnaire & bénéficiaires
            LabCsnrNomComplet.Text = LeConcessionnaire.NomComplet(True)
            LabCsnrNoNat.Text = If(LeConcessionnaire.NoRegistre, LeConcessionnaire.NoRegistre.Value, "(numéro de registre national non précisé)")
            LabCsnrDateNaiss.Text = If(LeConcessionnaire.DateNaiss.HasValue, LeConcessionnaire.DateNaiss.Value.ToString("dd/MM/yyyy"), "(date de naissance non précisée)")
            LabCsnrAdresseComplete.Text = If(LeConcessionnaire.AdresseComplete <> "", LeConcessionnaire.AdresseComplete, "(adresse non précisée")
            LabCsnrTel.Text = If(LeConcessionnaire.Tel <> "", LeConcessionnaire.Tel, "(pas de numéro de téléphone)")
            FlowPanelLabsBenefs.Controls.Clear()
            For n = 0 To LesBenefs.Count - 1
                FlowPanelLabsBenefs.Controls.Add(New Label With {.Text = LesBenefs(n).NomComplet & If(LesParentes(n) <> "", " (" & LesParentes(n) & ")", ""), .AutoSize = True})
            Next
        Else      ' concession existante
            ' À FAIRE : au nom de - quand l'"assistant" de recherche de l'ancienne concession sera fait (si il l'est un jour)
            LabRefCsnExistante.Text = LeFormInh.RefEmpl
            ' À FAIRE : type d'emplacement, si précisé
            LabEmplTypeCsnExistante.Text = LeFormInh.RefAutresDef
        End If





        ' À FAIRE : vérifier que tout y est


        ' *** Ici, mettre les cases pour enregistrer / ouvrir pdf ***


        ' pour enreg les bénefs en bdd: 
        ' créer l'objet concession, faire les liens bénef-mention-concession   --- gaffe, peut entraîner un lazy loading si pas préchargé...?
        ' enregistrer le tout
        ' cas particulier : le lien bénef-con existe déjà
        ' -> aucune chance
        ' faire une fct bdd pour faire une association bénef-concession (qui remplacerait une même association existante si celle-ci existe) ?

    End Sub


    ' code inutilisé pour le moment
    Private Sub posedesquestions()

        Dim TESTQ = New SimpleQuestion
        Questions.Add(TESTQ)

        For Each q In Questions
            FlpQuestions.Controls.Add(q)

            FlpQuestions.Controls.Add(New Button With {.Text = "btn ololo"})
        Next
        Dim prtzk As New Button With {.Text = "faire"}
        AddHandler prtzk.Click, AddressOf TMPFAIREACT
        FlpQuestions.Controls.Add(prtzk)

    End Sub
    Sub TMPFAIREACT()
        For Each sq As SimpleQuestion In Questions
            sq.FaireActions()
        Next
    End Sub

    Sub Finaliser()

        LeFormInh.Commentaire = If(TbCommentaire.Text <> "", TbCommentaire.Text, Nothing)
        If LeFormInh.DemandeNvCon IsNot Nothing Then
            LeFormInh.DemandeNvCon.Commentaire = LeFormInh.Commentaire
        End If

        ' entités à enregistrer en bdd :
        ' - un nouveau form inh
        ' - un nouveau form concession si présent, avec sa nouvelle liste de bénéficiaires (peut-être automatique avec Save(), peut-être pas)
        ' - si il y a, enregistrer nouveaux bénefs en tant qu'Acteurs
        ' - défunt
        ' - séjour ?
        ' - concession
        ' - mentions comme bénefs

        ' analyser les liens :
        ' ajouter acteur concessionnaire à propriété de navigation de concession (ou concession à la liste des concessions de la personne, mais ça demanderait sans doute un loading supplémentaire)
        ' ajouter mentionsbenefs avec liens acteur (qui existe - peut être fk) & con (qui est créée ici - peut être propriété) -- et tester


        ' À CONTINUER - transférer le code de la fonction d'en-dessous

    End Sub





    Sub poer()

        ' À CONTINUER - transférer le code vers la fonction au-dessus



        Dim enregpdf = CbEnregPdf.Checked
        Dim ouvrirpdf = CbOuvrirPdf.Checked
        Dim nomficpdf As String

        If enregpdf Then
            Dim SavDlg As New SaveFileDialog()
            With SavDlg
                .AddExtension = True
                .DefaultExt = "pdf"
                .AutoUpgradeEnabled = True
                .CheckPathExists = True
                '.InitialDirectory =    ' à adapter selon config
                .OverwritePrompt = True
                '.Title =       ' à voir
                .ValidateNames = True
                .Filter = "Fichier pdf (*.pdf)|*.pdf"
                ' + mettre nom de fichier par défaut
                .FileName = Format(Now.Year, "0000") & "_" & Format(Now.Month, "00") & "_" & Format(Now.Day, "00") & "_" & Format(Now.Hour, "00") & Format(Now.Minute, "00") & Format(Now.Second, "00") & ".pdf"
            End With
            If (SavDlg.ShowDialog = DialogResult.OK) Then
                nomficpdf = SavDlg.FileName
            Else enregpdf = False
            End If

        ElseIf ouvrirpdf Then
            nomficpdf = IO.Path.GetTempFileName
        End If

        If ouvrirpdf Or enregpdf Then
            Dim p = New ExporteurPdf With {.NomFic = nomficpdf}
            p.CreePdfInhum(LeFormInh)
            If ouvrirpdf Then
                Shell("explorer.exe """ & nomficpdf & """")      ' À FAIRE : ne pas ouvrir si fichier non sauvegardé (car erreur par exemple)
            End If
        End If


        ' enreg bdd

        ' proposer export pdf



        'If UzineAGaz.VerifDemandeur(PersMandNom.Text, PersMandPrenom.Text, PersMandAdr.Text, PersMandCodePostal.Text, PersMandVille.Text, PersMandPays.Text, PersMandTel.Text) Then
        'End If
        'declaration avec defunt



        'Me.Close()     ' ?
        'Me.Dispose()


    End Sub


    ' en affichant le panneau récapitulatif, gérer les parties visibles/cachées avant l'affichage



    ' Masque/affiche le panneau Emplacement existant selon le choix fait
    Private Sub rbDemandeConcessionExistante_CheckedChanged(sender As RadioButton, e As EventArgs) Handles rbDemandeConcessionExistante.CheckedChanged
        If sender.Checked Then
            'PanPartieNouvelleCon.Hide()    ' pas sur le même tab dtf
            PartieConcessionExistante.Show()
            BtSuivantDeInh.Location = New Point(PartieConcessionExistante.Location.X + PartieConcessionExistante.Width - BtSuivantDeInh.Width - 6, PartieConcessionExistante.Location.Y + PartieConcessionExistante.Height + 6)
        End If
        UpdateBtSuivantDeInh()
    End Sub
    Private Sub rbObtenirEmplacement_CheckedChanged(sender As RadioButton, e As EventArgs) Handles rbDemandeObtEmplacement.CheckedChanged
        If sender.Checked Then
            PartieConcessionExistante.Hide()
            'PanPartieNouvelleCon.Show()
            'BtSuivantDeInh.Location = New Point(PanPartieNouvelleCon.Location.X + PanPartieNouvelleCon.Width - BtSuivantDeInh.Width - 6, PanPartieNouvelleCon.Location.Y + PanPartieNouvelleCon.Height + 6)
            BtSuivantDeInh.Location = New Point(PanChoixExistNv.Location.X + PanChoixExistNv.Width - BtSuivantDeInh.Width - 6, PanChoixExistNv.Location.Y + PanChoixExistNv.Height + 6)
            UpdateBtSuivantDeInh()
        End If
    End Sub

    Private Sub OnDemandeurChanged() Handles LbListeDemandeurs.ActeurChanged
        UpdateBtSuivantDeInh()
    End Sub

    Private Sub OnConcessionnaireChanged() Handles LbListeConcessionnaires.ActeurChanged, PanTypeEmplNv.SelectionChanged
        UpdateBtSuivantDeCon()
    End Sub

    Private Sub InitPartieConExistante()
        BtRetirerConExist.Visible = False
        BtRetirerConExist.Location = BtRechercherConExist.Location
        PanInfosConExistBdd.Visible = False
        PanInfosConExistBdd.Location = PanChampsTexteConExist.Location
        PartieConcessionExistante.Visible = False
    End Sub

    Private Sub MajAspectPartieConcession() Handles PanTypeEmplNv.SelectionChanged
        Dim csnactif = UzineAGaz.EmplacementImpliqueConcession(PanTypeEmplNv.GetChoix)
        PanP2InfosCsnr.Enabled = csnactif
        ListeBeneficiaires.Enabled = csnactif

        ' code pour changer l'aspect tout en laissant les contrôles activés, mais après tout bof
        'If Not UzineAGaz.EmplacementImpliqueConcession(PanTypeEmplNv.GetChoix) Then
        '    GbCsnrNvCon.ForeColor = SystemColors.GrayText
        '    'PanP2InfosCsnr.BackColor = SystemColors.Control
        '    PanP2InfosCsnr.BackColor = SystemColors.ControlLight ''
        '    LbListeConcessionnaires.AspectActif = False
        'Else
        '    GbCsnrNvCon.ForeColor = SystemColors.ControlText
        '    PanP2InfosCsnr.BackColor = Color.GhostWhite
        '    LbListeConcessionnaires.AspectActif = True

        'End If
    End Sub



    ' récupère l'état civil du défunt (identifiant) selon le radiobutton sélectionné
    Private Function GetDefEtatCivil() As String
        Dim etatciv As String = Nothing
        Select Case True
            Case RbDefEtatCivilCelib.Checked
                etatciv = "celibataire"           ' valeurs doivent correspondre aux possibilités du champ enum dans la bdd
            Case RbDefEtatCivilEpx.Checked
                etatciv = "epoux"
            Case RbDefEtatCivilVeuf.Checked
                etatciv = "veuf"
            Case RbDefEtatCivilDivorc.Checked
                etatciv = "divorce"
            Case RbDefEtatCivilFils.Checked
                etatciv = "enfant"
        End Select
        Return etatciv
    End Function
    Private Function GetTypeEmplConExistanteToString() As String
        Dim tp As String = Nothing
        Select Case True
            Case RbConExistTypeCaveau.Checked
                tp = "Caveau"
            Case RbConExistTypeCavurne.Checked
                tp = "Cavurne"
            Case RbConExistTypeCercueil.Checked
                tp = "Cercueil"
            Case RbConExistTypeColomb.Checked
                tp = "Cellule de colombarium"
            Case RbConExistTypePleineTerre.Checked
                tp = "Pleine terre"
            Case RbConExistTypeUrne.Checked
                tp = "Urne"
        End Select
        Return tp
    End Function

    ' taille un peu adaptable pour les SimpleQuestion dans le panel des remarques
    Private Sub RedimQuestions(sender As Object, e As EventArgs) ' Handles FlpQuestions.SizeChanged
        For Each q As Control In FlpQuestions.Controls
            If q.GetType Is GetType(SimpleQuestion) Then
                q.MaximumSize = New Size(FlpQuestions.Width - 3, 0)
            End If
        Next
    End Sub


    ' A CONTINUER

    ' TEST
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ListeBeneficiaires.ChargerListeSuggestions()
        Dim listact As List(Of Acteur)
        Dim listring As List(Of String)
        ListeBeneficiaires.GetBeneficiaires(listact, listring)
        'LbListeConcessionnaires.AspectActif = Not LbListeConcessionnaires.AspectActif
        '      LbListeConcessionnaires.Enabled = False
        '       CbSigneParPmand.Enabled = False
        '        ListeBeneficiaires.Enabled = False
        '        ListeBeneficiaires.ForeColor = Color.Yellow
        '       LbListeConcessionnaires.ForeColor=color.Yellow
        LbListeConcessionnaires.AspectActif = Not LbListeConcessionnaires.AspectActif

    End Sub

    Private Sub UpdateBtSuivantDeInh()
        BtSuivantDeInh.Enabled = (rbDemandeConcessionExistante.Checked OrElse rbDemandeObtEmplacement.Checked) AndAlso LbListeDemandeurs.ActeurSelectionne IsNot Nothing
    End Sub

    Private Sub UpdateBtSuivantDeCon()
        Dim emplchoisi As String = PanTypeEmplNv.GetChoix
        BtSuivantDeCon.Enabled = emplchoisi <> Nothing _
                                 AndAlso
                                   LbListeDemandeurs.ActeurSelectionne IsNot Nothing _
                                 AndAlso
                                   Not UzineAGaz.EmplacementImpliqueConcession(emplchoisi) _
                                   OrElse LbListeConcessionnaires.ActeurSelectionne IsNot Nothing
    End Sub

    Private Sub BtRechercherConExist_Click(sender As Object, e As EventArgs) Handles BtRechercherConExist.Click

    End Sub

    Private Sub BtRetirerConExist_Click(sender As Object, e As EventArgs) Handles BtRetirerConExist.Click
        PanInfosConExistBdd.Hide()
        BtRetirerConExist.Hide()
        PanChampsTexteConExist.Show()
        BtRechercherConExist.Show()
    End Sub

End Class