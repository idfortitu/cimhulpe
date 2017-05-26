Public Class PopupRecherche
    ' Classe abstraite (devrait être MustInherit, mais ça cause des problèmes avec le designer)
    ' Source de données pour la ListBox affichée. Les classes héritantes doivent redéfinir la sub UpdateListe pour qu'elle crée cette DataTable
    'Protected ElementsListe As IEnumerable(Of Object)
    Protected ElementsListe As List(Of Object)
    ' Quelles colonnes de la DataTable/source de données sont utilisées pour le contrôle ListBox ?
    ' Doivent être initialisées dans la classe-fille, devraient être MustOverride
    Protected Overridable Property ListeValueMember As String
    Protected Overridable Property ListeDisplayMember As String
    ' Contenu initial du champ recherche. Par défaut "". Au chargement du popup, UpdateListe est appelée une première fois avec ce champ.
    ' Peut être spécifié lors de la création de l'objet par le form.
    Public RechercheInitiale As String = ""
    ' Callback passée par le form qui crée l'objet : action à faire quand un item a été choisi (avec la fermeture du popup) - par exemple, remplir des champs du form avec les données de l'élément choisi)
    Public cbActionEnsuite As Action(Of Object)

    ' L'absence de New() sans arguments fait que les classes-filles ne sont pas visibles dans le designer, mais celle-ci l'est donc pas grave

    'Public Sub New(Optional ActionSuite As Action(Of Object) = Nothing, Optional RechInit As String = "")
    Public Sub New(Optional ActionSuite As Action(Of Object) = Nothing, Optional RechInit As String = "")
    MyBase.New()
        InitializeComponent()
        Me.cbActionEnsuite = ActionSuite
        Me.RechercheInitiale = RechInit
    End Sub

    ' Devrait être fait après apparition du contrôle (sorte de Form.Shown mais pour les contrôles ; VisibleChanged ?)
    ' Initalisation de la liste (au chargement)
    Protected Sub Initialisation(sender As Object, e As EventArgs) Handles Me.Load
        TbChampRecherche.Text = RechercheInitiale
        Me.UpdateListe(RechercheInitiale)
        LbListeEntrees.DisplayMember = Me.ListeDisplayMember
        LbListeEntrees.ValueMember = Me.ListeValueMember
        LbListeEntrees.DataSource = Me.ElementsListe
        'LbListeEntrees.DataSource = Me.ElementsListe.ToList
    End Sub


    ' Doit être redéfini par les classes-filles
    ' Doit remplir la liste (Me.ElementsListe) en fonction d'un texte recherché (limite de nombre ?)
    ' Si le texte est absent, pas de filtrage (tous les enregistrements...? Un nombre limité selon critère (récemment utilisés,...?))
    Protected Overridable Sub UpdateListe(recherche As String)
    End Sub


    ' Lance la recherche au clic sur le bouton Rechercher
    Protected Sub BtRechercher_Click(sender As Object, e As EventArgs) Handles BtRechercher.Click
        Me.UpdateListe(TbChampRecherche.Text.Trim)
        LbListeEntrees.DataSource = Me.ElementsListe    ' Nécessaire, parce que ElementsListe sera généralement remplacé par un nouvel objet plutôt que simplement modifié
        LbListeEntrees.Select()
        'LbListeEntrees.ClearSelected()
    End Sub


    ' Lance aussi la recherche quand on appuie sur entrée dans le champ recherche (simule un clic sur le bouton)
    Private Sub TbChampRecherche_KeyDown(sender As Object, e As KeyEventArgs) Handles TbChampRecherche.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.SuppressKeyPress = True
                Me.BtRechercher_Click(BtRechercher, New EventArgs())
            Case Keys.Up, Keys.Down, Keys.PageDown, Keys.PageUp
                e.SuppressKeyPress = True
                LbListeEntrees.Select()
                SendKeys.Send("{" & e.KeyCode.ToString & "}")
        End Select
    End Sub

    ' Au clic sur un item, appelle la callback de fin de recherche (seulement si un résultat a été choisi), puis ferme le popup
    Private Sub Finaliser(sender As Object, e As EventArgs) Handles LbListeEntrees.Click
        '        If LbListeEntrees.SelectedItem IsNot Nothing And Me.cbActionEnsuite IsNot Nothing Then Me.cbActionEnsuite.Invoke(LbListeEntrees.SelectedItem.Row)
        'If LbListeEntrees.SelectedItem IsNot Nothing And Me.cbActionEnsuite IsNot Nothing Then Me.cbActionEnsuite.Invoke(LbListeEntrees.SelectedItem.Row)
        If LbListeEntrees.SelectedItem IsNot Nothing And Me.cbActionEnsuite IsNot Nothing Then Me.cbActionEnsuite.Invoke(LbListeEntrees.SelectedItem)
        Me.Dispose()
    End Sub

    ' Idem si appui sur Entrée dans la liste
    Private Sub LbListeEntrees_KeyDown(sender As Object, e As KeyEventArgs) Handles LbListeEntrees.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Finaliser(LbListeEntrees, New EventArgs())
        End If
    End Sub

    ' Repasse dans le champ recherche si on tape du texte alors qu'on est dans la liste
    Private Sub LbListeEntrees_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LbListeEntrees.KeyPress
        If Not Char.IsControl(e.KeyChar) Then
            TbChampRecherche.Select()
            SendKeys.Send(e.KeyChar)
        End If
    End Sub

End Class
