' générique ce serait pas mal
Public Class ListBoxCustomActeurs
    'Public ReadOnly Property ActeurSelectionne As Acteur
    '    Get
    '        Return LbListe.ActeurSelectionne
    '    End Get
    '    ' readonly, peut-être amené à changer moyennant quelques adaptations dans la classe listboxacteurs
    'End Property

    Public Event ActeurChanged()

    Private _acteurSelectionne As Acteur = Nothing
    Public ReadOnly Property ActeurSelectionne As Acteur
        Get
            Return _acteurSelectionne
        End Get
    End Property

    Public Property DataSource As Object
        Get
            Return LbListe.DataSource
        End Get
        Set(value As Object)
            LbListe.DataSource = value
        End Set
    End Property

#Region "passage en mode grisé (inutilisé)"
    Private CoBack, CoFore, CoBackListe, CoForeListe, CoBackTb, CoForeTb, CoBackBouton, CoForeBouton, CoBackLabel, CoForeLabel As Color

    ' si false, donne un aspect grisé au contrôle
    ' TESTER via designer
    Private _aspectActif As Boolean = True
    Public Property AspectActif As Boolean
        Get
            Return _aspectActif
        End Get
        Set(value As Boolean)
            If value = _aspectActif Then Exit Property
            If value Then
                Me.BackColor = CoBack
                Me.ForeColor = CoFore
                For Each c As Control In Me.Controls
                    If TypeOf c Is TextBox Then
                        c.BackColor = CoBackTb
                        c.ForeColor = CoForeTb
                    ElseIf TypeOf c Is Button Then
                        c.BackColor = CoBackBouton     ' les boutons & labels prennent peut-être automatiquement le ForeColor du parent (ListBoxCustomActeurs), mais soit
                        c.ForeColor = CoForeBouton
                    ElseIf TypeOf c Is ListBox Then
                        c.BackColor = CoBackListe
                        c.ForeColor = CoForeListe       ' voir si ça marche pour le texte
                    ElseIf TypeOf c Is Label Then
                        c.BackColor = CoBackLabel
                        c.ForeColor = CoForeLabel

                    End If
                Next
                TbFiltre.BackColor = CoBackTb
            Else
                'Me.BackColor = 
                For Each c As Control In Me.Controls
                    If TypeOf c Is TextBox Then
                        'c.BackColor = Color.Red
                        c.ForeColor = SystemColors.GrayText 'ControlDark
                    ElseIf TypeOf c Is Button Then
                        c.BackColor = SystemColors.Control     ' à noter que les boutons & labels prennent automatiquement le ForeColor du parent (ListBoxCustomActeurs), mais soit
                        c.ForeColor = SystemColors.GrayText
                    ElseIf TypeOf c Is ListBox Then
                        c.BackColor = SystemColors.Control
                        c.ForeColor = SystemColors.ControlDarkDark
                    ElseIf TypeOf c Is Label Then
                        'c.BackColor = 
                        c.ForeColor = SystemColors.GrayText
                    End If
                Next
            End If
            _aspectActif = value
        End Set
    End Property
    Private Sub PrendreEchantillonsCouleurs()
        CoBack = Me.BackColor
        CoFore = Me.CoFore
        CoBackListe = LbListe.BackColor
        CoForeListe = LbListe.ForeColor
        CoBackTb = TbFiltre.BackColor
        CoForeTb = TbFiltre.ForeColor
        CoBackBoutons = BtNouveau.BackColor
        CoForeBoutons = BtNouveau.ForeColor
        CoForeLabel = LabNom.ForeColor
        CoBackLabel = LabNom.BackColor
    End Sub
#End Region

    Public Sub New()
        InitializeComponent()
        ' note les couleurs originales des composants
        'PrendreEchantillonsCouleurs()
        'LbListe.FonctionFiltre = AddressOf FiltrerElem
    End Sub


    Public Sub Me_Load() Handles Me.Load
        ' vérification en attendant de savoir pourquoi l'évènement Load s'exécute 3 fois pour les contrôles qui sont sur le premier onglet
        Static initialisationfaite As Boolean
        If Not initialisationfaite Then
            UpdateListeActeurs()
            LbListe.ClearSelected()    ' le premier élément est sélectionné par défaut, ce qu'on ne veut pas (pour éviter les distractions dans certains forms)
            ' (pas optimal : on retire une sélection qui vient d'être faite, avec requête bdd)

            ' si le form est susceptible d'émettre des évènements BddChanged, on s'"abonne" pour mettre la liste à jour quand ça arrive
            Dim formparent As Form = Me.FindForm
            If TypeOf formparent Is QuiModifieBdd Then
                AddHandler CType(formparent, QuiModifieBdd).BddChanged, AddressOf OnBddChanged
            End If
            initialisationfaite = True
        End If

    End Sub




    Public Event BddChanged()   ' À FAIRE y réagir dans form

    Sub UpdateListeActeurs()
        Try         ' le designer a une erreur d'accès à la bdd et Me.DesignMode n'a pas l'air de fonctionner

            LbListe.DataSource = New SortableBindingList(Of IEntity.Condense)(liste)
        Catch e As Exception
        End Try
    End Sub

    ''Public Sub BindListe(lst As List(Of Acteur.Condense))
    ''    Dim ancienidselect As Integer? = LbListe.SelectedValue
    ''    Dim ancienfiltre As String = If(LbListe.DataSource IsNot Nothing, LbListe.DataSource.Filter, "")
    ''    LbListe.DataSource = New SortableBindingList(Of Acteur.Condense)(lst) With {.FilterFunc = AddressOf FiltrerElem}
    ''    LbListe.DataSource.filter = ancienfiltre ' doit être fait après binding comme datasource
    ''    If ancienidselect IsNot Nothing AndAlso LbListe.DataSource.Find("Id", ancienidselect) <> -1 Then   ' l'ancien id peut ne plus être dans la liste (à la suite d'une suppression par exemple)
    ''        LbListe.SelectedValue = ancienidselect
    ''        ' (en cas de suppression, sélectionner l'item adjacent serait pas mal)
    ''    Else
    ''        LbListe.ClearSelected()      ' le premier élément est sélectionné par défaut, ce qu'on ne veut pas pour éviter les distractions
    ''        ' (pas optimal : on retire une sélection qui vient d'être faite, avec requête bdd)
    ''    End If
    ''End Sub

    'Sub FiltrerListe(sender As Object, e As EventArgs) Handles TbFiltre.TextChanged
    '    ' quand des items sont supprimés/ajoutés, le SelectedIndex ne change pas et risque se retrouver sur un item différent ;
    '    ' en plus, même si SelectedValue prend la valeur du nouvel item sélectionné, l'evt SelectedValueChanged n'est pas déclenché
    '    ' (sauf quand le SelectedIndex est remonté parce que devenu hors liste, mais ce n'est pas mieux)
    '    ' --> donc, refait la sélection manuellement
    '    RemoveHandler LbListe.SelectedValueChanged, AddressOf LbListe_SelectedValueChanged

    '    LbListe.DataSource.Filter = TbFiltre.Text
    '    If ActeurSelectionne IsNot Nothing AndAlso LbListe.DataSource.Find("Id", ActeurSelectionne.Id) <> -1 Then
    '        LbListe.SelectedValue = ActeurSelectionne.Id
    '    Else
    '        LbListe.ClearSelected()
    '    End If

    '    AddHandler LbListe.SelectedValueChanged, AddressOf LbListe_SelectedValueChanged
    'End Sub

    Sub FiltrerListe(sender As Object, e As EventArgs) Handles TbFiltre.TextChanged
        LbListe.Filtre = TbFiltre.Text
    End Sub


    ' affichage des infos de la personne sélectionnée   
    '' peut-être faire un evt ActeurChanged pour être sûr que ceci se fasse après que les nouvelles infos de l'acteur sélect aient été mises à jour
    '' dans la ListBoxActeurs
    'Private Sub LbListe_SelectedValueChanged(sender As Object, e As EventArgs)
    Private Sub LbListe_ActeurChanged() Handles LbListe.ActeurChanged
        If LbListe.SelectedValue Is Nothing Then            ' désactive les boutons modif/détails (à faire : bouton suppr si il y en a un)
            BtModifier.Enabled = False
            BtDetails.Enabled = False
            _acteurSelectionne = Nothing
            ' vide les indications sur la personne
            LabNom.Text = ""
            LabAdresse.Text = ""
            LabTel.Text = ""
            LabDateNaiss.Text = ""
            LabNoNational.Text = ""
        Else
            ' active les boutons modif/détails (à faire : btn suppr, si il y en a un)
            BtModifier.Enabled = True
            BtDetails.Enabled = True

            LabNom.Text = _acteurSelectionne.NomComplet
            LabAdresse.Text = _acteurSelectionne.AdresseComplete
            LabTel.Text = _acteurSelectionne.Tel
            LabNoNational.Text = If(_acteurSelectionne.NoRegistre, "")
            LabDateNaiss.Text = If(_acteurSelectionne.DateNaiss.HasValue, _acteurSelectionne.DateNaiss.Value.ToString("dd/MM/yyyy"), "")
        End If
        ' dispose() ancien acteurselectionne ?
        RaiseEvent ActeurChanged()
    End Sub

    Private Sub BtNouveau_Click(sender As Object, e As EventArgs) Handles BtNouveau.Click
        Dim formajout As New FormEditActeur
        If formajout.ShowDialog() = DialogResult.OK Then       ' si le nouveau est ajouté
            If formajout.IdActeur IsNot Nothing Then
                ''UpdateListeActeurs()                 ' recharge les données depuis la bdd
                'LbListe.UpdateListe() ' à remettre qd lb est lbact
                'TbFiltre.Text = ""    ' le nouvel élément ne doit pas être masqué par le filtre
                RaiseEvent BddChanged()
                LbListe.SelectedValue = formajout.IdActeur
            End If
        End If
        ' dispose formajout ?
    End Sub

    Public Sub OnBddChanged()
        TbFiltre.Text = ""    ' un nouvel élément ne doit pas être masqué par le filtre
        Me.UpdateListeActeurs()
    End Sub
    Private Sub BtModifier_Click(sender As Object, e As EventArgs) Handles BtModifier.Click

        Dim formmodif As New FormEditActeur(_acteurSelectionne.Id)
        If _acteurSelectionne IsNot Nothing AndAlso _acteurSelectionne.Id <> Nothing Then    ' normalement le bouton "Modifier" est désactivé si pas de sélection mais sait-on jamais
            If formmodif.ShowDialog = DialogResult.OK Then
                'UpdateListeActeurs()    ' à rem qd lb est lbact
                'TbFiltre.Text = ""     ' si le nom a changé (rare, mais soit), l'item risquerait de ne plus être affiché à cause du filtre
                'LbListe.DataSource.Filter = ""
                'LbListe.SelectedValue = formmodif.IdActeur
                RaiseEvent BddChanged()
            End If
        End If
    End Sub

    '    Function FiltrerElem(elem As Object, filtre As String) As Boolean
    ''Return elem.Nom.contains(filtre)
    'Return UzineAGaz.ReduireString(elem.Texte).Contains(UzineAGaz.ReduireString(filtre))
    'End Function

    Private Sub BtClearFiltr_Click(sender As Object, e As EventArgs) Handles BtClearFiltr.Click
        TbFiltre.Text = ""
    End Sub


    ' Event bddchanged pour déclencher màj autre(s) liste(s)

End Class
