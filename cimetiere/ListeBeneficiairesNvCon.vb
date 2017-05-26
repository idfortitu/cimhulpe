Public Class ListeBeneficiairesNvCon
    Public Event BddChanged()
    Private _titre As String = "Bénéficiaires"
    Public Property Titre As String
        Get
            Return _titre
        End Get
        Set(value As String)
            _titre = value
            LabTitre.Text = value
        End Set
    End Property


    Private ListeBenefs As New List(Of ElemListeBeneficiairesNvCon)
    Private ListeBenefsBdd As New List(Of ElemListeBenefBdd)
    ' Faire une autre liste pour les bénefs existants

    ' pas fini, abandonné
    'Private Property _aspectActif As Boolean = True
    'Public Property Aspect As Boolean
    '    Get
    '        Return _aspectActif
    '    End Get
    '    Set(value As Boolean)
    '        If Not value Then
    '            ' à faire : elems, elemsbdd et bouton +
    '        Else
    '            ' à faire : elems, elemsbdd et bouton +
    '        End If
    '    End Set
    'End Property

    Private _listeSuggestionsEstAttacheeA As ElemListeBeneficiairesNvCon
    Private Property ListeSuggestionEstAttacheeA As ElemListeBeneficiairesNvCon
        Get
            Return _listeSuggestionsEstAttacheeA
        End Get
        Set(value As ElemListeBeneficiairesNvCon)
            If value Is _listeSuggestionsEstAttacheeA Then Exit Property
            _listeSuggestionsEstAttacheeA = value
            If _listeSuggestionsEstAttacheeA Is Nothing Then
                'LbSuggestions.Visible = False
                Exit Property
            End If
            ' positionnait la liste sous le contrôle (pas dedans)
            'Dim indexbenef = FlowLayoutPanel1.Controls.GetChildIndex(_listeSuggestionsEstAttacheeA)
            'Dim indexlb = FlowLayoutPanel1.Controls.GetChildIndex(LbSuggestions)
            'nouvelindexlb = If(indexlb > indexbenef, indexbenef + 1, indexbenef)
            'FlowLayoutPanel1.Controls.SetChildIndex(LbSuggestions, nouvelindexlb)
            _listeSuggestionsEstAttacheeA = value
            _listeSuggestionsEstAttacheeA.Controls.Add(LbSuggestions)

        End Set
    End Property


    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        LbSuggestions.DisplayMember = "Nom"
        LbSuggestions.ValueMember = "Id"
        LbSuggestions.FonctionFiltre = AddressOf FiltrerElement
        ChargerListeSuggestions()


    End Sub

    Private Sub OnBddChanged()

    End Sub

    Sub ld() Handles Me.Load
        Static initialisationfaite As Boolean
        If Not initialisationfaite Then
            ' POUR TEST
            btAjoutBenef_Click(Nothing, New EventArgs)

            LbSuggestions.Location = New Point(30, 25)
            LbSuggestions.Size = New Size(132, 45)  ' 36

            ' si le form est susceptible d'émettre des évènements BddChanged, on s'"abonne" pour mettre la liste à jour quand ça arrive
            Dim formparent As Form = Me.FindForm
            If TypeOf formparent Is QuiModifieBdd Then
                AddHandler CType(formparent, QuiModifieBdd).BddChanged, AddressOf OnBddChanged
            End If
            initialisationfaite = True
        End If


    End Sub


    ' Renvoie les bénéficiaires entrés sous forme d'une liste de bénéficiaires (anciens et nouveaux en vrac ? l'absence d'Id pourrait servir à les différencier)
    ' et les liens de parenté aux mêmes index dans une liste séparée
    Public Sub GetBeneficiaires(ByRef ListeActeursRetour As List(Of Acteur), ByRef ListeParentes As List(Of String))
        ListeActeursRetour = New List(Of Acteur)
        ListeParentes = New List(Of String)
        Dim unben As Acteur
        For Each ctrlben In ListeBenefs
            If ctrlben.tbNom.Value IsNot Nothing Or ctrlben.TbPrenom.Value IsNot Nothing Then
                unben = New Acteur With {.Nom = ctrlben.tbNom.Value, .Prenom = ctrlben.TbPrenom.Value, .Adresse = ctrlben.TbAdresse.Value, .Cp = ctrlben.TbCp.Value, .Pays = ctrlben.TbPays.Value, .Ville = ctrlben.TbVille.Value} ', .MentionsCommeBenef = {New MentionBeneficiaire With {.EnQualiteDe = ctrlben.TbLienParente.Value}}}
                If ctrlben.DateNaiss.Checked Then
                    unben.DateNaiss = ctrlben.DateNaiss.Value
                Else
                    unben.DateNaiss = Nothing
                End If
                ListeActeursRetour.Add(unben)
                ListeParentes.Add(ctrlben.TbLienParente.Text.Trim)
            End If
        Next
        For Each ctrlbenbdd In ListeBenefsBdd
            ListeActeursRetour.Add(ctrlbenbdd.Benef)
            ListeParentes.Add(ctrlbenbdd.TbLienParente.Text.Trim)
        Next
    End Sub


    Private Sub btAjoutBenef_Click(sender As Object, e As EventArgs) Handles btAjoutBenef.Click
        Dim nvItemBenef As New ElemListeBeneficiairesNvCon
        With nvItemBenef
            '.Margin = New Padding(0)

            AddHandler .Retirer, AddressOf RetirerBenef
            ' handlers pour la liste des suggestions
            AddHandler .tbNom.TextChanged, AddressOf NomBenef_Changed
            AddHandler .TbPrenom.TextChanged, AddressOf NomBenef_Changed
            AddHandler .tbNom.Enter, AddressOf NomBenef_Enter
            AddHandler .TbPrenom.Enter, AddressOf NomBenef_Enter
            AddHandler .tbNom.KeyDown, AddressOf TbNom_KeyDown
            AddHandler .TbPrenom.KeyDown, AddressOf TbNom_KeyDown

            .TbLienParente.CueBanner = "Lien de parenté"
            .TbAdresse.CueBanner = "N° et rue"
            .TbCp.CueBanner = "CP"
            .tbNom.CueBanner = "Nom"
            .TbPrenom.CueBanner = "Prénom"
            .TbPays.CueBanner = "Pays"
            .TbVille.CueBanner = "Ville"

        End With

        ListeBenefs.Add(nvItemBenef)

        ' fait disparaître la liste suggestions, car suppose que le clic sur le bouton + a fait perdre le focus du benef
        ' en cas de gestion plus précise du focus, adapter le code suivant
        LbSuggestions.Visible = False

        FlowLayoutPanel1.Controls.Add(nvItemBenef)
        FlowLayoutPanel1.Controls.SetChildIndex(btAjoutBenef, FlowLayoutPanel1.Controls.Count - 1)
    End Sub

    Private Sub RetirerBenef(benef As ElemListeBeneficiairesNvCon)
        ' demande confirm si des champs ne sont pas vides
        If 0 = (benef.tbNom.Text & benef.TbPrenom.Text & benef.TbAdresse.Text).Trim.Count _
            OrElse MsgBoxResult.Ok = MessageBox.Show("Retirer le bénéficiaire ?", "Confirmation", MessageBoxButtons.OKCancel) Then
            Dim position = ListeBenefs.IndexOf(benef)
            If benef.Controls.Contains(LbSuggestions) Then benef.Controls.Remove(LbSuggestions)     ' éviter que la suppression du bénef entraîne la suppression de la liste si il la contient
            'Me.Controls.Remove(benef)
            ListeBenefs.Remove(benef)
            If ListeSuggestionEstAttacheeA Is benef Then LbSuggestions.Visible = False
            benef.Dispose()

            ' si possible, remettre le focus là où il était

        End If
    End Sub


    ' Gestion liste de suggestions

    ' 1) au focus sur un bénef (du moins sur nom ou prénom), déplacer la liste de suggestions sous le bénef
    ' au textchanged sur le nom/prénom du bénef, la liste doit devenir visible (et updater ses suggestions)
    ' (idéalement, elle ne doit pas présenter un bénef déjà présent dans la liste)
    ' [(la liste ne doit apparaître que si elle contient au moins une suggestion)] - à voir
    ' au défocus, la liste doit disparaître - tant pis
    ' vérifier qu'elle disparaît si on supprime le benef - NB : enter se produit avant leave ; leave ne se produit pas quand on elève le bénef
    ' le filtre doit tenir compte du nom et du prénom
    ' un appui sur "bas" dans nom/prénom bénef peut switcher sur la liste (si elle a un élément)
    ' réciproquement un appui sur haut quand sur le premier élément de la liste (ou aucun élément, selectedindex <= 1) doit ramener dans
    ' le champ où on était (variable FocusEx, intialisée quand on fait bas, supprimée quand on quitte le focus de la liste)
    ' les infos doivent être figées si on choisit un existant
    ' une checkbox/un carré/un indice avec un "V" de validation "Enregistrer nouveau" pourrait rappeler qu'un bénef va être créé ;
    ' un bouton "modifier" à côté d'un bénef existant (qui est figé sur le form) pourrait permettre de faire une modif par la même occasion, dans les règles


    Public Sub ChargerListeSuggestions()

    End Sub

    Private Sub NomBenef_Enter(sender As Object, e As EventArgs)
        Dim CtrlBenef As ElemListeBeneficiairesNvCon = sender.Parent
        LbSuggestions.Filtre = CtrlBenef.tbNom.Text & "¤" & CtrlBenef.TbPrenom.Text
        'LbSuggestions.Visible = CtrlBenef.tbNom.Text <> "" Or CtrlBenef.TbPrenom.Text <> ""
        LbSuggestions.Visible = True
        ListeSuggestionEstAttacheeA = CtrlBenef
    End Sub

    Sub NomBenef_Changed(sender As Object, e As EventArgs)

        ' en tout logique, le bénef dont le nom est changé est celui dont le nom a le focus et qui donc a la liste

        'LbSuggestions.Visible = ListeSuggestionEstAttacheeA.tbNom.Text <> "" Or ListeSuggestionEstAttacheeA.TbPrenom.Text <> ""
        LbSuggestions.Filtre = ListeSuggestionEstAttacheeA.tbNom.Text & "¤" & ListeSuggestionEstAttacheeA.TbPrenom.Text
    End Sub


    Sub TbNom_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True
            PasserFocusSurListe()
        ElseIf e.KeyCode = Keys.Enter Then
            LdBenef()
        End If
    End Sub
    Sub PasserFocusSurListe()
        If LbSuggestions.Visible Then
            LbSuggestions.Focus()
            'If LbSuggestions.Items.Count >= 1 AndAlso LbSuggestions.SelectedIndex = -1 Then
            If LbSuggestions.Items.Count - 1 > LbSuggestions.SelectedIndex Then
                LbSuggestions.SelectedIndex += 1
            End If

        End If

    End Sub


    ' Le filtre ne pouvant contenir qu'une chaîne, on utilisera "¤" comme séparateur (qui n'a aucune chance de figurer dans le nom d'une personne ni d'être tapé par erreur)
    Function FiltrerElement(elem As Object, f As String) As Boolean
        ' en bonus, pourrait ne pas afficher un bénéficiaire déjà présent dans la liste (à condition qu'il soit clairement identité comme un bénef de la bdd)

        ' si le nom n'est pas vide, ignore le prénom
        ' si il est vide, se base sur le prénom
        Dim nometprenom As String() = Split(f, "¤", 2)
        Dim nom = nometprenom(0).Trim
        If nom = "" Then
            If nometprenom.Count > 1 Then       ' au cas où le filtre n'aurait pas (encore) le format nom¤prenom
                nom = nometprenom(1).Trim
            End If
        End If

        ' comme la liste ne distingue pas le nom et le prénom dans le texte de ses éléments, le résultat sera approximatif, mais soit
        ' transmet la valeur jugée pertinente à la fonction de filtrage originale de la liste
        Return LbSuggestions.FiltrerElem(elem, nom)



    End Function


    ' activation d'un item de la liste : màj infos
    Sub LdBenef() Handles LbSuggestions.DoubleClick

    End Sub

    Sub LbSugg_KeyDown(sender As Object, e As KeyEventArgs) Handles LbSuggestions.KeyDown
        ' pourrait aussi accepter espace
        If e.KeyCode = Keys.Enter Then
            LdBenef()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Up AndAlso LbSuggestions.SelectedIndex = 0 Then
            ListeSuggestionEstAttacheeA.tbNom.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub


    ' EN TRAVAUX
    Sub RemplacerCtrlBenefParCtrlBenefBdd(CtrlBenef As ElemListeBeneficiairesNvCon, LeBenef As Acteur)
        Dim position As Integer = FlowLayoutPanel1.Controls.GetChildIndex(CtrlBenef)

        ' charger les infos

        Dim CtrlBenefBdd As New ElemListeBenefBdd

        CtrlBenefBdd.Benef = LeBenef

        CtrlBenefBdd.TbLienParente.Text = CtrlBenef.TbLienParente.Text

        ' PENSER à le mettre à jour si il est modifié ailleurs

        ' retirer le précédent

        If CtrlBenef.Controls.Contains(LbSuggestions) Then CtrlBenef.Controls.Remove(LbSuggestions)
        ListeBenefs.Remove(CtrlBenef)
        FlowLayoutPanel1.Controls.Remove(CtrlBenef)       ' dispose ?

        ' mettre l'autre au même endroit
        FlowLayoutPanel1.Controls.Add(CtrlBenefBdd)
        FlowLayoutPanel1.Controls.SetChildIndex(CtrlBenefBdd, position)
        AddHandler CtrlBenefBdd.Retirer, AddressOf RetirerBenefPrefait
        AddHandler CtrlBenefBdd.BtModifier.Click, AddressOf ModifierBenefBdd
        ListeBenefsBdd.Add(CtrlBenefBdd)


    End Sub


    Private Sub RetirerBenefPrefait(benef As ElemListeBenefBdd)
        Dim position = ListeBenefsBdd.IndexOf(benef)
        Me.Controls.Remove(benef)
        ListeBenefsBdd.Remove(benef)
        benef.Dispose()

        ' si possible, remettre le focus là où il était

    End Sub

    ' suppose encore que le contrôle benef bdd soit le parent direct du bouton
    Sub ModifierBenefBdd(sender As Object, e As EventArgs)
        Dim LeBen As Acteur = CType(sender.parent, ElemListeBenefBdd).Benef
        Dim leform As New FormEditActeur(LeBen.Id)
        If leform.ShowDialog = DialogResult.OK Then
            RaiseEvent BddChanged()
        End If
    End Sub

    Private Sub LdBenef(sender As Object, e As EventArgs) Handles LbSuggestions.DoubleClick

    End Sub
End Class
