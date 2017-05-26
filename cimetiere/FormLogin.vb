'Imports MySql.Data
'Imports MySql.Data.MySqlClient
'Imports MySql.Data.Types
Imports System.Globalization
Imports Newtonsoft.Json
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class FormLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    'temporaire
    'Private Sub testhttp_click() Handles testhttp.Click
    '    tests_http.testrequete()
    'End Sub
    'Private Sub testhttps_click() Handles testhttps.Click
    '    'test fonctions php
    '    tests_http.testrequetesecu()
    'End Sub

    Sub iuy() Handles Me.Load
        '''''' TEST pdf form inhumation
        'LeDem = New Acteur With {.Nom = "Ngeghy", .Prenom = "Laszlo", .Adresse = "Drève du Zèle", .Tel = "+7675765765", .Cp = 12345, .DateNaiss = #12/09/1973#, .NoRegistre = 123456789, .Pays = "Iran", .Ville = "Al-Hulp"}
        'LeDef = New Defunt With {.Nom = "MacAbbé", .Prenom = "Antoine", .Adresse = "90 boulevard iurfzeof", .DateDeces = Today, .DateNaiss = Today, .LieuDeces = "Là-bas", .Ville = "La Hulpe", .Pays = "Italie", .NumeroAnnee = 2345, .NumeroLh = 123456, .LieuNaiss = "Ici-bas", .Cp = 23456, .EtatCivil = "epoux", .EtatCivilDe = "Simone Sesavet"}

        '''' ajouter form nv con
        'Dim csnr As New Acteur With {
        '.Adresse = "13 rue du IUDSIUHDIsudsf",
        '.Cp = "23123213",
        '.DateNaiss = Today,
        '.Nom = "Klupo",
        '.NoRegistre = 273737,
        '.Pays = "République populaire démocratique de Poiulande septentrionale du sud-ouest montagneux",
        '.Prenom = "Kroug",
        '.Tel = "23123123",
        '.Ville = "Bruxeilless"
        '}

        'Dim fnvc As New DemandeNvConcession With {
        '.DateSign = Today,
        '.TypeCon = "pl_2pers_15ans_urne",
        '.SigneParPmand = True,
        '.CsnrAdresse = "158b Schukruttstrasse",
        '.Commentaire = "Si possible orienté sud",
        '.CsnrCp = 567,
        '.CsnrDateNaiss = Today,
        '.CsnrNom = "Vanderbiest",
        '.CsnrNoNational = 345678,
        '.CsnrPays = "Belgique",
        '.CsnrPrenom = "Anaïs",
        '.CsnrTel = "45678945678",
        '.CsnrVille = "Binche",
        '.PmandAdresse = "76 rue de Rome",
        '.PmandCp = 45678,
        '.PmandDateNaiss = Today,
        '.PmandNom = "André",
        '.PmandPays = "Belgique",
        '.PmandPrenom = "Ernest",
        '.PmandTel = "34567890",
        '.PmandVille = "Tournai"
        '}

        'fnvc.IntegrerInfosCsnr(csnr)

        'Dim UnBenef As New Acteur With {.Adresse = "89 Hermelijnlaan", .Cp = 8765, .DateNaiss = Today, .Nom = "Verstraeten", .Prenom = "Kim", .Ville = "Kortrijk", .Pays = "Belgique"}

        ''fnvc.AjouterBeneficiaire(UnBenef)
        ''fnvc.AjouterBeneficiaire(UnBenef)
        ''fnvc.AjouterBeneficiaire(UnBenef)
        ''fnvc.AjouterBeneficiaire(UnBenef)


        'Dim leform As New DemandeInhumation With {
        '.AvisFossoy = True,
        '.Commentaire = "ràs",
        '.ConcSollic = "sans_concession",
        '.DateSign = Today,
        '.RefEmpl = "A3",
        '.RefAutresDef = "lui, elle et elle"
        '}

        'leform.FormNvCon = fnvc
        'leform.IntegrerInfosDefunt(LeDef)
        'leform.IntegrerInfosDemandeur(LeDem)

        'Dim ep As New ExporteurPdf
        'ep.CreePdfInhum(leform)
        'ep.CreePdfReservation(fnvc)
        'ep.CreePdfProlongation()





        'Dim kratz = Bdd.IdentifierConcessionnaire("jean", "claude")
        'Dim kroutz = Bdd.IdentifierConcessionnaire("concessionaire2", "prenom du cons2")

        'Dim LeCon As New Concessionnaire With {
        '    .Nom = "Rocpeuyi",
        '    .Ville = "Troupaumé",
        '    .NoRegistre = 23
        '}
        'Dim Lautrecon As New Concessionnaire With {
        '.Nom = "Verhelst",
        '.Ville = "Blainville",
        '.NoRegistre = 24
        '}

        'resyktat = LeCon.Differences(Lautrecon)
        ''MessageBox.Show("fini")


        'Dim unedate As Date = #10/10/1600#

        'Dim kr As New Demandeur With {.Nom = "Yamamoto"}
        'Bdd.Update(5, kr)
        'MessageBox.Show("fè")

        'Dim ledem As New Demandeur With {.Nom = "Beaumont"}
        'Bdd.Save(ledem)
        'ledem.Prenom = "Magalie"
        'Bdd.Save(ledem)
        'Dim benben As New Beneficiaire With {.Nom = "Ben F."}
        'Bdd.Add(benben)


        'Dim kroü = Bdd.GetConcession(4)
        'Dim thr = Bdd.GetListeConcessions
        'Dim dfiu = "r"


    End Sub

    ''''' fin debug


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        ' MessageBox.Show(TBPassword.Text)
        Dim Ident As Integer
        Dim MsgErrIdent As String = "Erreur non spécifiée"      ' Message par défaut
        ''Ident = Bdd.Identification(TBUsername.Text, TBPassword.Text, MsgErrIdent)
        Ident = 1

        Dim Fhome As New FormHome
                Me.Hide()
                Fhome.ShowDialog()
                Me.Close()


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub testcsns_Click(sender As Object, e As EventArgs) Handles testcsns.Click
        Dim a = New FormRechercheConcession
        a.ShowDialog()
    End Sub

    Private Sub BtTestFormeditempl_Click(sender As Object, e As EventArgs) Handles BtTestEditact.Click

    End Sub

End Class
