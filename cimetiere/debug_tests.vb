Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports Newtonsoft.Json
Imports System
Imports System.Net
Imports System.IO
Imports System.Text



Public Class debug_tests

    Public Sub dire_bonjour()
        MessageBox.Show("bonjour")
    End Sub

    Public Sub kruth()
        MessageBox.Show("arkuds")
    End Sub

    Public Sub orvoir()
        MessageBox.Show("orevouare")
    End Sub


    Sub osef() Handles Me.Load


    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub



    ' *** Divers




    ' **** Tests BDD


    'c/c de Bdd.vb
    Private Function Connexion() As MySqlConnection
        conn = New MySqlConnection
        conn.ConnectionString = "Server=" & ConfigLocale.BddHost & ";Database=" & ConfigLocale.BddNom & ";Uid=" & ConfigLocale.BddUser & ";Pwd=" & ConfigLocale.BddPass & ";"
        conn.Open()
        Return conn
    End Function



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MonForm = New DemandeInhumation With {.NumDefLh = 14,
            .NumDefAnnee = 23,
        .Commentaire = "c'est un beau formulaire",
        .AvisFossoy = True,
            .ConcSollic = "nouvelle",
            .DateSign = #8/01/2017#,
            .DefAdresse = "ici rue du eifjo",
            .DefCp = 2339,
            .DefDateDeces = #7/01/2017#,
            .DefDateNaiss = #8/13/1972#,
            .DefEtatCivil = "epoux",
            .DefEtatCivilDe = "Marie Kuchtwala",
            .DefLieuDeces = "dans la forêt",
            .DefLieuNaiss = "lalelu",
            .DefNom = "oaarj",
            .DefPays = "Belgique",
            .DefPrenom = "Ceizjfe",
            .DefVille = "La Hulpe",
            .DmdrAdresse = "82b parc à conteneurs",
            .DmdrCp = 88282,
            .DmdrNom = "Terre",
            .DmdrPays = "Belgique",
            .DmdrPrenom = "Jean",
            .DmdrTel = "56789",
            .DmdrVille = "Meulin",
            .RefAutresDef = "aucune",
            .RefEmpl = "au fond à gauche"} ',
        '            .FkDmdr = Nothing}

        MonForm.FormNvCon = New DemandeNvConcession With {.PmandNom = MonForm.DmdrNom,
            .PmandPrenom = MonForm.DmdrPrenom,
            .PmandTel = MonForm.DmdrTel,
            .PmandAdresse = MonForm.DmdrAdresse,
            .PmandVille = MonForm.DmdrVille,
            .PmandCp = MonForm.dmdrcp,
            .PmandPays = MonForm.dmdrpays,
            .CsnrNom = "Duschnock",
            .CsnrPrenom = "Gontrand",
            .CsnrDateNaiss = #4/29/1922#,
            .CsnrNoNational = 3,
            .CsnrAdresse = "28A clos ridride",
            .CsnrVille = "anvers",
            .CsnrCp = "87234",
            .CsnrPays = "Belgique",
            .CsnrTel = "6783",
            .DateSign = MonForm.DateSign,
            .SigneParPmand = True,
            .Commentaire = "de préférence orienté sud",
            .Beneficiaires = {New FnvConBenef With {.Nom = "MacAbbé", .Prenom = "Barnabé", .Pays = "Belgique", .DateNaiss = #4/29/1982#, .LienParente = "animal de compagnie", .Adresse = "Allée Alléallez", .Cp = 1337, .Ville = "Berques"}, New FnvConBenef With {.Ville = "Berques", .Cp = 1337, .Adresse = "Allée Alléallez", .DateNaiss = #4/29/1980#, .LienParente = "soeur", .Nom = "Van Beukelaer", .Pays = "Belgique", .Prenom = "Sandra"}}} ',
        '        .FkCon = Nothing,


        'MessageBox.Show(If(Bdd.PutFormInhumation(MonForm), "fait", "pas fait"))

    End Sub



    ' **** Tests sur popup recherche
    ' Doit correspondre à la définition d'une "Action" (un paramètre, pas de valeur de retour)

    Sub RemplirChampsAuto(selection As Object)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim osef As New PopupControl.Popup(New PopupRechercheDemandeur(AddressOf RemplirChampsAuto, TbTestNom.Text))
        osef.Show(Button1)
    End Sub

    ' **** Test Pdf
    ' à réécrire

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LeDem = New Acteur With {.Nom = "Ducon", .Prenom = "Laszlo", .Adresse = "Drève du Zèle", .Tel = "+7675765765"}
        LeDef = New Defunt With {.Nom = "MacAbbé", .Prenom = "Antoine", .Adresse = "90 boulevard iurfzeof", '.DateDeces = Today, .DateNaiss = Today, _
        .EtatCivil = "bon état, peu servi", .EtatCivilDe = "nunana", .LieuDeces = "ici", .LieuNaiss = "là"}
        Dim ep As New ExporteurPdf

        ' À FAIRE : rassembler les données dans un objet form
        'ep.CreePdfInhum(leformulaire)
        MessageBox.Show("fait")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("rien")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    ' test gestion évènement au clic sur un empl
    Private Sub gereclic(sender As PlanCimetiere, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.EmplClicked
        MessageBox.Show("cliqué : emplacement " & e.ZoneEmpl.EmplacementLie.Id)
    End Sub

    Private Sub geredclic(sender As PlanCimetiere, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.EmplDoubleClicked
        MessageBox.Show("double cliqué : emplacement " & e.ZoneEmpl.EmplacementLie.Id)
    End Sub
    Private Sub gereselect(sender As PlanCimetiere, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.SelectionChanged
        If e.ZoneEmpl IsNot Nothing Then
            MessageBox.Show("sélectionné : emplacement " & e.ZoneEmpl.EmplacementLie.Id)
        Else
            MessageBox.Show("plus d'emplacement sélectionné")
        End If
    End Sub


    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        '        Bdd.faire_quelquechose()
        'ledef.Nom = "Dupiton"
        'Bdd.faire_quelquechose2(ledef)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim oae As New dvlptAjEmpl
        oae.ShowDialog()

    End Sub

    Private Sub gereclic(sender As Object, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.EmplClicked

    End Sub

    Private Sub geredclic(sender As Object, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.EmplDoubleClicked

    End Sub

    Private Sub gereselect(sender As Object, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.SelectionChanged

    End Sub

    Private Sub btnfaireactionsdemande_Click(sender As Object, e As EventArgs) Handles btnfaireactionsdemande.Click
        testdemgen.FaireActions()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'MessageBox.Show(ListboxActeurs1.ActeurSelectionne.Nom)
        'MessageBox.Show("index " & ListboxActeurs1.SelectedIndex)
        'ListboxActeurs1.BindListe(Bdd.GetListeActeurs)
        'ListboxActeurs1.SelectedIndex = -1
        'ListboxActeurs1.ClearSelected()
        'AddHandler ListboxActeurs1.ActeurChanged, Sub() MessageBox.Show(If(ListboxActeurs1.ActeurSelectionne IsNot Nothing, ListboxActeurs1.ActeurSelectionne.NomComplet, "rien"))
    End Sub
    Private Sub oseb()
        'MessageBox.Show("changé : " & If(ListboxActeurs1.ActeurSelectionne IsNot Nothing, ListboxActeurs1.ActeurSelectionne.Nom, " rien"))
    End Sub

    'test contrôle demandegenerique


End Class