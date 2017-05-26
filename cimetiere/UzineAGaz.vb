Imports System.Text.RegularExpressions
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Globalization

Module UzineAGaz



    ' À REVOIR (Acteur)
    Const CASE_COCHEE = ChrW(&H2612), CASE_VIDE = ChrW(9744), EURO = ChrW(8364)



    Function VerifDemandeur(dmdr As Acteur)
        With dmdr
            If String.IsNullOrEmpty(.Nom) Or String.IsNullOrEmpty(.Prenom) Or String.IsNullOrEmpty(.Adresse) Or String.IsNullOrEmpty(.Cp) Or String.IsNullOrEmpty(.Ville) Or String.IsNullOrEmpty(.Pays) Or String.IsNullOrEmpty(.Tel) Then
                MessageBox.Show("Veuillez entrer toutes les informations")
                Return 0
            Else
                If Regex.IsMatch(.Nom, "[A-Za-z-]") And Regex.IsMatch(.Prenom, "[A-Za-z-]") And Regex.IsMatch(.Adresse, "[A-Za-z0-9-]") And Regex.IsMatch(CType(.Cp, String), "[0-9]") And Regex.IsMatch(.Ville, "[A-Za-z-]") And Regex.IsMatch(.Pays, "[A-Za-z-]") And Regex.IsMatch(.Tel, "[0-9]") Then
                    Return 1
                Else
                    MessageBox.Show("Les informations encoder sont incorrectes")
                    Return 0
                End If
            End If
        End With
    End Function
    Function VerifConcessionnaire(csnr As Acteur)
        With csnr
            If String.IsNullOrEmpty(.Nom) Or String.IsNullOrEmpty(.Prenom) Or String.IsNullOrEmpty(.DateNaiss) Or String.IsNullOrEmpty(.Adresse) Or String.IsNullOrEmpty(.Cp) Or String.IsNullOrEmpty(.Ville) Or String.IsNullOrEmpty(.Pays) Or String.IsNullOrEmpty(.NoRegistre) Or String.IsNullOrEmpty(.Tel) Then
                MessageBox.Show("Veuillez entrer toutes les informations")
                Return 0
            Else
                If Regex.IsMatch(.Nom, "[A-Za-z-]") And Regex.IsMatch(.Prenom, "[A-Za-z-]") And Regex.IsMatch(.Adresse, "[A-Za-z0-9-]") And Regex.IsMatch(.Ville, "[A-Za-z-]") And Regex.IsMatch(.Pays, "[A-Za-z-]") And Regex.IsMatch(.Tel, "[0-9]") Then
                    If IsDate(.DateNaiss) Then
                        Return 1
                    Else
                        MessageBox.Show("Veuillez insérer une date au format jour/mois/année")
                        Return 0
                    End If
                Else
                    MessageBox.Show("Les informations encodées sont incorrectes")
                    Return 0
                End If
            End If
        End With
    End Function

    ' http://stackoverflow.com/a/11620625
    Function RetirerDiacritiques(s As String) As String
        Dim sDecomp As String = s.Normalize(System.Text.NormalizationForm.FormD)
        Dim res As String = ""
        Dim uc As UnicodeCategory
        For i As Integer = 0 To sDecomp.Length - 1
            uc = CharUnicodeInfo.GetUnicodeCategory(sDecomp(i))
            If Not {UnicodeCategory.NonSpacingMark,
                    UnicodeCategory.SpacingCombiningMark,
                    UnicodeCategory.EnclosingMark}.Contains(uc) Then
                res += sDecomp(i)
            End If
        Next
        Return res
    End Function

    ' comparaison "tolérante", ne compte pas la ponctuation, les espaces, les accents...
    ' malgré son nom, tient compte des chiffres
    Function MemesLettres(s1 As String, s2 As String) As Boolean
        'Dim tmp1 As String = RetirerDiacritiques(s1).ToUpper
        'Dim tmp2 As String = RetirerDiacritiques(s2).ToUpper
        'Dim res1 As String = ""
        'Dim res2 As String = ""
        'For Each c As Char In tmp1
        '    If (c >= "A" And c <= "Z") Or (c >= "0" And c <= "9") Then res1 += c
        'Next
        'For Each c As Char In tmp2
        '    If (c >= "A" And c <= "Z") Or (c >= "0" And c <= "9") Then res2 += c
        'Next
        'Return res1 = res2
        Return ReduireString(s1) = ReduireString(s2)
    End Function

    ' "réduit" une chaîne en enlevant la ponctuation, les espaces, les accents... pour une comparaison "tolérante"
    Function ReduireString(s As String) As String
        s = RetirerDiacritiques(s).ToUpper
        Dim res As String = ""
        For Each c In s
            If (c >= "A" And c <= "Z") Or (c >= "0" And c <= "9") Then res += c
        Next
        Return res
    End Function


    ' basique mais devrait suffire
    Function MemeNumeroTel(n1 As String, n2 As String) As Boolean
        Dim n1b As String = ""
        Dim n2b As String = ""
        n1b = Regex.Replace(n1, "[^0-9\+]", "")
        n2b = Regex.Replace(n2, "[^0-9\+]", "")
        Return n1b = n2b
    End Function


    'Public Sub PopupAjouterActeur(a As Acteur)
    '    Dim formajout As New FormEditActeur
    '    Return formajout.
    '    'If formajout.ShowDialog() = DialogResult.OK Then       ' si le nouveau est ajouté
    '    '    If formajout.IdActeur IsNot Nothing Then
    '    '        ''UpdateListeActeurs()                 ' recharge les données depuis la bdd
    '    '        'LbListe.UpdateListe() ' à remettre qd lb est lbact
    '    '        '                TbFiltre.Text = ""    ' le nouvel élément ne doit pas être masqué par le filtre
    '    '        'LbListe.DataSource.Filter = ""
    '    '        LbListe.SelectedValue = formajout.IdActeur
    '    '        'RaiseEvent BddChanged()
    '    '    End If
    '    'End If
    'End Sub


    Function EmplacementImpliqueConcession(e As String) As Boolean
        Return Not {"pl_ordinaire_cercueil", "pl_ordinaire_urne", "ouverture_caveau", "urne_colomb_ordinaire", "dispersion_cendres", ""}.Contains(e)
    End Function



End Module
