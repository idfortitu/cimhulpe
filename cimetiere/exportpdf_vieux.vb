Imports itextsharp.text.pdf
Imports itextsharp.text
Imports System.IO

Module exportpdf_vieux

    ' *** Ancienne version, peut-être des trucs à récupérer



    Public Sub creepdf(nom As String, prenom As String, domicile As String, autre As String, nee As String, neele As String, decede As String, decedele As String, etatcivil As String)
        Dim pdf As New Document()
        Dim pdfwrite As PdfWriter = PdfWriter.GetInstance(pdf, New FileStream("simple.pdf", FileMode.Create))
        pdf.Open()
        'Dim bfArial As BaseFont
        'Dim fArial As Font
        Dim bfBaseFont As BaseFont
        Dim fNormal As Font

        'bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
        'remplacé par :
        Dim ArialFontPath As String
        ArialFontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF")
        bfBaseFont = BaseFont.CreateFont(ArialFontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED)

        fNormal = New Font(bfBaseFont, 9)
        Dim fSouligne = New Font(bfBaseFont, 10, Font.UNDERLINE)
        Dim P As New Paragraph()
        'Add two Phrases that will be placed side-by-side but with different font weights
        PEnMaj = New Paragraph("À compléter en MAJUSCULES", New Font(bfBaseFont, 10.0, Font.BOLD))
        PEnMaj.Alignment = Element.ALIGN_CENTER
        pdf.Add(PEnMaj)

        pdf.Add(New Paragraph("Personne défunte :", fSouligne))

        'Dim cb As PdfContentByte = pdfwrite.DirectContent

        'Dim Col As New ColumnText(cb)

        'Set the x,y,width,height
        'Col.SetSimpleColumn(220, 150, 500, 809)

        'Add the paragraph to the ColumnText
        'Col.AddText(P)
        'Call to stupid Go() method which actually writes the content to the stream.
        'Col.Go()
        'P.Clear()

        'Col.SetSimpleColumn(440, 150, 700, 809)

        'Create our paragraph

        P.Add(New Phrase("Cimetière communal de La Hulpe", New Font(bfBaseFont, 10.0, Font.BOLD)))

        'Add the paragraph to the ColumnText
        'Col.AddText(P)
        'Call to stupid Go() method which actually writes the content to the stream.
        'Col.Go()
        'P.Clear()

        'cb.SaveState()
        'cb.Rectangle(460, 749, 100, 40)

        'cb.MoveTo(200, 0)
        'cb.Stroke()

        'cb.RestoreState()

        Dim logo As Image = Image.GetInstance("logopetit.png")
        logo.SetAbsolutePosition(470, 780)
        pdf.Add(logo)
        pdf.Add(New Paragraph("Nom : " + nom, fNormal))
        pdf.Add(New Paragraph("Prénom(s) : " + prenom, fNormal))
        pdf.Add(New Paragraph("Domicile : " + domicile, fNormal))
        pdf.Add(New Paragraph("               " & ChrW(9744) & " 1310 La Hulpe - " & ChrW(9744) & " autre : " + autre, fNormal))
        pdf.Add(New Paragraph("Né(e) à " + If(nee.CompareTo("") = 0, ".................................................................................." _
                            & vbCrLf & "          le ", nee & " le ") _
                            & If(neele.CompareTo("") = 0, ".......................................................................", neele), fNormal))

        pdf.Add(New Paragraph("Décédé(e) à : .................................................................................., le .............................................................", fNormal))

        pdf.Add(New Paragraph("État civil : " & ChrW(9744) & " Célibataire - " & ChrW(9744) & " Epoux(se) de - " & ChrW(9744) & " Veuf(ve) de - " & ChrW(9744) & " Divorcé(e) de - " & ChrW(9744) & " Fils(lle) de", fNormal))

        pdf.Add(New Paragraph("           ................................................................................................................................................................", fNormal))

        'cb.SaveState()
        'cb.Rectangle(38, 677, 525, 0)

        'cb.MoveTo(200, 0)
        'cb.Stroke()

        'cb.RestoreState()

        pdf.Add(New Paragraph("Personne mandatée :", fSouligne))
        'Col.SetSimpleColumn(220, 150, 400, 683)
        P.Add(New Phrase("à compléter en MAJUSCULES", New Font(bfBaseFont, 10.0, Font.BOLD)))
        'Col.AddText(P)
        'Col.Go()
        P.Clear()
        pdf.Add(New Paragraph("Je, soussigné(e) ........................................................ Tél. : ..............................................................................................................", fNormal))
        pdf.Add(New Paragraph("Adresse complète : .......................................................................................................................................................................", fNormal))
        pdf.Add(New Paragraph("Sollicite au nom de la famille :", fNormal))
        pdf.Add(New Paragraph("           " & ChrW(9744) & " a) l'obtention d'un emplacement suivant :", fNormal))
        pdf.Add(New Paragraph("           " & ChrW(9744) & " b) la prolongation d'un emplacement existant de type :", fNormal))


        Dim prix As New PdfPTable(2)
        Dim cell As New PdfPCell(New Paragraph("Montants des redevances", fNormal))
        cell.Colspan = 2
        cell.HorizontalAlignment = 1
        prix.WidthPercentage = 25

        prix.HorizontalAlignment = 2
        prix.AddCell(cell)
        prix.AddCell(New Paragraph("La hulpois : ", fNormal))
        prix.AddCell(New Paragraph("Autres :", fNormal))

        pdf.Add(prix)

        'P.Add(New Phrase("Indiquez le type d'emplacement souhaité", New Font(bfArial, 10.0, itextsharp.text.Font.BOLD)))
        'Col.SetSimpleColumn(200, 150, 800, 590)          ' deplacehorizon , ? , largeur , hauteur
        'Add the paragraph to the ColumnText
        'Col.AddText(P)
        'Call to stupid Go() method which actually writes the content to the stream.
        'Col.Go()
        'P.Clear()


        'Create our paragraph
        Dim tableau As New PdfPTable(4)
        Dim intTblWidth() As Integer = {1, 33.5, 6.25, 6.25}

        tableau.WidthPercentage = 97
        tableau.SetWidths(intTblWidth)
        tableau.HorizontalAlignment = 2
        tableau.AddCell(New Paragraph(" ", fNormal))
        tableau.AddCell(New Paragraph("Inhumation ordinaire en pleine terre ( " & CASE_VIDE & " cercueil ou " & CASE_VIDE & " urne)", fNormal))
        tableau.AddCell(New Paragraph("       gratuit", fNormal))
        tableau.AddCell(New Paragraph("750 " & ChrW(8364) & "", fNormal))

        tableau.AddCell(New Paragraph(" ", fNormal))
        tableau.AddCell(New Paragraph("Inhumation en pleine terre (1 personne) - concession de 15 ans - " & ChrW(9744) & " cercueil - " & ChrW(9744) & " urne", fNormal))
        tableau.AddCell(New Paragraph("250 " & ChrW(8364) & "", fNormal))
        tableau.AddCell(New Paragraph("1.800 " & ChrW(8364) & "", fNormal))

        tableau.AddCell(New Paragraph(" ", fNormal))
        tableau.AddCell(New Paragraph("Inhumation en pleine terre (2 personnes) - concession de 15 ans -" & ChrW(9744) & " cercueil - " & ChrW(9744) & " urne", fNormal))
        tableau.AddCell(New Paragraph("500 " & ChrW(8364) & "", fNormal))
        tableau.AddCell(New Paragraph("3.600 " & ChrW(8364) & "", fNormal))

        tableau.AddCell(New Paragraph(" ", fNormal))
        tableau.AddCell(New Paragraph("Placement d'un caveau - concession de 30 ans - " & ChrW(9744) & " cercueil - " & ChrW(9744) & " urne  " & vbCrLf & " les cercueils sont placés horizontalement dans un alignement vertical, en profondeur " & vbCrLf & "(maximum 3 places)", fNormal))
        tableau.AddCell(New Paragraph("400 " & ChrW(8364) & " " & vbCrLf & "" & vbCrLf & "par pers.", fNormal))
        tableau.AddCell(New Paragraph("1.800 " & ChrW(8364) & " " & vbCrLf & "" & vbCrLf & "par pers.", fNormal))

        tableau.AddCell(New Paragraph(" ", fNormal))
        tableau.AddCell(New Paragraph("Ouverture de caveau uniquement si travail du Fossoyeur (ouv. par chemin)", fNormal))
        tableau.AddCell(New Paragraph("100 " & ChrW(8364) & "", fNormal))
        tableau.AddCell(New Paragraph("100 " & ChrW(8364) & "", fNormal))

        tableau.AddCell(New Paragraph(" ", fNormal))
        tableau.AddCell(New Paragraph("Une urne mise en columbarium - place ordinaire (cell. 1 place prioritairement)", fNormal))
        tableau.AddCell(New Paragraph("gratuit", fNormal))
        tableau.AddCell(New Paragraph("750 " & ChrW(8364) & "", fNormal))

        tableau.AddCell(New Paragraph(" ", fNormal))
        tableau.AddCell(New Paragraph("Une urne mise en columbarium - concession de 15 ans", fNormal))
        tableau.AddCell(New Paragraph("250 " & ChrW(8364) & "", fNormal))
        tableau.AddCell(New Paragraph("1800 " & ChrW(8364) & "", fNormal))

        tableau.AddCell(New Paragraph(" ", fNormal))
        tableau.AddCell(New Paragraph("Une urne mise en columbarium - concession de 30 ans", fNormal))
        tableau.AddCell(New Paragraph("400 " & ChrW(8364) & "", fNormal))
        tableau.AddCell(New Paragraph("2500 " & ChrW(8364) & "", fNormal))

        tableau.AddCell(New Paragraph(" ", fNormal))
        tableau.AddCell(New Paragraph("Dispersion des cendres", fNormal))
        tableau.AddCell(New Paragraph("gratuit", fNormal))
        tableau.AddCell(New Paragraph("gratuit", fNormal))
        pdf.Add(tableau)


        pdf.Add(New Paragraph("                   " & ChrW(9744) & " c) l'inhumation en concession existante : " & ChrW(9744) & " urne - " & ChrW(9744) & " cercueil / " & ChrW(9744) & " pleine terre - " & ChrW(9744) & " caveau - " & ChrW(9744) & " cellule de columbarium", fNormal))
        pdf.Add(New Paragraph("                                      Référence de l'emplacement : .............................................", fNormal))
        pdf.Add(New Paragraph("                                      Références des éventuels autres défunts dans la sépulture  : .............................................", fNormal))

        pdf.Add(New Phrase("" & vbCrLf & " " & vbCrLf & " Le paiement de la redevance doit être exécuté par la personne qui demande l'emplacement et est payable au comptant ", New Font(bfBaseFont, 8.5, Font.ITALIC)))
        pdf.Add(New Phrase("au moment", New Font(bfBaseFont, 8.5, Font.UNDERLINE)))
        pdf.Add(New Phrase(" de la demande.", New Font(bfBaseFont, 8.5, Font.ITALIC)))
        pdf.Add(New Paragraph("En cas de choix d'une concession, merci de compléter le verso du présent document.", New Font(bfBaseFont, 8.5, Font.BOLD)))
        pdf.Add(New Phrase("" & vbCrLf & "Je déclare avoir pris connaissance du réglement du cimetière (et redevances y afférentes).", New Font(bfBaseFont, 8.5, Font.NORMAL)))
        pdf.Add(New Phrase("" & vbCrLf & "Je m'engage à respecter les dispositions de ce règlement.", New Font(bfBaseFont, 8.5, Font.NORMAL)))

        pdf.Add(New Phrase("" & vbCrLf & "" & vbCrLf & "Date :", fNormal))

        pdf.Add(New Phrase("                                                                Signature de la personne mandatée", fNormal))

        pdf.Add(New Phrase("" & vbCrLf & "  Réservé à l'Administration :", New Font(bfBaseFont, 10, Font.BOLD)))

        Dim admin As New PdfPTable(2)
        Dim cellule As New PdfPCell(New Paragraph("" & vbCrLf & "Cimetière : Date : ................................ Heure : ............................." & vbCrLf & "" & vbCrLf & "Eglise : Date - heure : ................................................. - Incinération : Lieu - heure : ......................................" & vbCrLf & "   ", fNormal))
        cellule.Colspan = 2
        cellule.HorizontalAlignment = 3
        admin.WidthPercentage = 88

        admin.HorizontalAlignment = 3
        admin.AddCell(cellule)
        admin.AddCell(New Paragraph("" & vbCrLf & "Reçu le montant de : " & ChrW(8364) & " ....................................." & vbCrLf & "" & vbCrLf & "" & ChrW(9744) & " Liquide - " & ChrW(9744) & " Virement - " & ChrW(9744) & " Bancontact" & vbCrLf & "     ", fNormal))
        admin.AddCell(New Paragraph("Directeur financier : vérification faite " & ChrW(9744) & " oui - " & ChrW(9744) & " non" & vbCrLf & "" & vbCrLf & "Date : ...................... Signature,", fNormal))

        pdf.Add(admin)

        pdf.Add(New Phrase("" & vbCrLf & "", fNormal))
        Dim Permis As New PdfPTable(1)
        Dim encadre As New PdfPCell(New Paragraph("Permis " & ChrW(9744) & " d'INHUMER / " & ChrW(9744) & " de TRANSPORT / " & ChrW(9744) & " de DISPERSION DES CENDRES " & vbCrLf & "" & vbCrLf & " délivré à La Hulpe, le ........................         Signature de l'Officier de l'État civil ou de son représentant," & vbCrLf & "         " & vbCrLf & "     " & vbCrLf & "     ", fNormal))
        encadre.HorizontalAlignment = 3
        Permis.WidthPercentage = 100

        Permis.HorizontalAlignment = 3
        Permis.AddCell(encadre)

        pdf.Add(Permis)
        pdf.NewPage()


        Dim img As Image = Image.GetInstance("logo.png")
        pdf.Add(img)
        Dim titre As String = "DOCUMENT A COMPLETER EN CAS DE NOUVELLE CONCESSION"

        Dim para As New Paragraph("DOCUMENT A COMPLETER EN CAS DE NOUVELLE CONCESSION")
        para.Alignment = Element.ALIGN_CENTER
        pdf.Add(para)
        pdf.Add(New Paragraph(" "))
        pdf.Add(New Paragraph("Pour toute demande d'une concession relative au défunt mentionné au recto de la présente page. les bénéficiaires de la concession doivent être mentionnés ci-dessous (à défaut d'indiquer les bénéficiaires, veuillez lire le point b) en bas de page.)", fNormal))
        pdf.Add(New Paragraph("La personne qui sollicite la concession est le concessionnaire.", fNormal))
        pdf.Add(New Paragraph(" "))
        pdf.Add(New Paragraph("Nom et prénom du concessionnaire : ", fNormal))
        pdf.Add(New Paragraph("Date de naissance : ........................................................ N° de registre national : .........................................................", fNormal))
        pdf.Add(New Paragraph("Domicile : ........................................................................................................................................", fNormal))
        pdf.Add(New Paragraph("...................................................................................................................................................", fNormal))
        pdf.Add(New Paragraph("Téléphone : .......................................................................................................................................", fNormal))
        pdf.Add(New Paragraph(" "))
        fNormal.Size = 10
        Dim table As New PdfPTable(4)
        table.WidthPercentage = 100
        table.AddCell(New Paragraph("Nom(s) du/des) bénéficiaires(s):", fNormal))
        table.AddCell(New Paragraph("Prénom(s)", fNormal))
        table.AddCell(New Paragraph("Date(s) de naissance", fNormal))
        table.AddCell(New Paragraph("Lien(s) de parenté", fNormal))
        For nbr As Integer = 1 To 16
            table.AddCell(" ")
        Next
        pdf.Add(table)

        pdf.Add(New Paragraph("Date et signature du concessionnaire :", fNormal))
        pdf.Add(New Paragraph("Date, signature et identité de la personne mandatée :", fNormal))
        pdf.Add(New Phrase("BIFFEZ LA MENTION INUTILE, S.V.P.", New Font(bfBaseFont, 10.0, Font.ITALIC)))
        pdf.Add(New Paragraph(" "))
        pdf.Add(New Paragraph(" "))
        pdf.Add(New Paragraph(" "))
        pdf.Add(New Phrase("Personne mandatée :", fSouligne))
        pdf.Add(New Paragraph("La personne qui effectue la présente déclaration doit obligatoirement signer ce document. S'il s'agit d'une personne", fNormal))
        pdf.Add(New Paragraph("mandatée par la famille qui se trouve dans l'incapacité de signer, il lui incombe alors de faire remplir un formulaire de", fNormal))
        pdf.Add(New Paragraph("demande de concession par la famille (le concessionnaire) et de retourner ce document à l'administration communale de La Hulpe le plus rapidement possible.", fNormal))

        pdf.Add(New Phrase("IMPORTANT:    ", New Font(bfBaseFont, 10.0, Font.BOLD)))
        pdf.Add(New Phrase("À défaut, la présente déclaration n'est pas valable", fSouligne))
        pdf.Add(New Phrase(" car incomplète.", New Font(bfBaseFont, 10.0)))
        pdf.Add(New Paragraph(" "))
        pdf.Add(New Paragraph(" "))

        Dim paragr As New Paragraph("Règlement du 20/12/04 de police et d'administration du cimetière", fSouligne)
        paragr.Alignment = Element.ALIGN_CENTER
        pdf.Add(paragr)

        Dim cinquantehuit As New Paragraph("Article 58 traitant des concessions :", fSouligne)
        cinquantehuit.Alignment = Element.ALIGN_CENTER
        pdf.Add(cinquantehuit)

        Dim Article58 As New List(False, True, 20.0F)
        Article58.IsLowercase = True
        Article58.Add(New ListItem(New Phrase("Les demandes de concessions indiquent l'identité des bénéficiaires.", fNormal)))
        Article58.Add(New ListItem(New Phrase("À défaut d'indiquer l'identité du ou des bénéficiaire(s), tous les membres de la famille du concessionnaire sont " _
                                & "bénéficiaires, à concurrence du nombre de places, sans que, entre eux, il existe des priorités ; seule la chronologie des " _
                                & "décès détermine le rang.", fNormal)))
        Article58.Add(New ListItem(New Phrase("Le concessionnaire peut, à tout moment, modifier ou compléter la liste des bénéficiaires soit par lettre portant sa " _
                                              & "signature légalisée, adressée à l'Officier de l'État civil et spécifiant les modifications apportées, soit par un acte " _
                                              & "satisfaisant aux conditions de capacité et de forme des actes testamentaires.", fNormal)))
        Dim ItemListe As New Phrase("Après le décès du concessionnaire, ", fNormal)
        ItemListe.Add(New Chunk("aucune modification", fSouligne))
        ItemListe.Add(New Chunk("de l'état de la concession (transformation d'une concession pleine terre en caveau, agrandissement " _
                                & "ou approfondissement de la concession ou du caveau, transfert de l'urne) "))
        ItemListe.Add(New Chunk("N'est autorisée", fSouligne))
        ItemListe.Add(New Chunk(".", fNormal))
        Article58.Add(ItemListe)

        Article58.Add(New ListItem(New Phrase("Dans le cas où les bénéficiaires sont les membres d'une ou de plusieurs communautés religieuses, " _
                                              & "l'identité de ceux-ci sera reprise au moment de l'inhumation. Aucune déclaration de volonté " _
                                              & "de la part des membres de la communauté ne sera requise.", fNormal)))

        pdf.Add(Article58)



        pdf.Close()
    End Sub

End Module
