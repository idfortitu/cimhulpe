Public Class ListboxEntites
    Inherits ListBox
    Public IdSelectionne As Integer? = Nothing      ' ne correspond pas forcément à Me.SelectedValue car la sélection peut ne pas faire partie de la liste si celle-ci est filtrée
    Public FonctionFiltre As Func(Of Object, String, Boolean) = AddressOf FiltrerElem
    Private _filtre As String = ""
    Public Property Filtre As String
        Get
            Return _filtre
        End Get
        Set(value As String)
            _filtre = value
            If Me.DataSource IsNot Nothing Then FiltrerListe()
        End Set
    End Property

    Public Event ActeurChanged()

    Public Sub New()
        'Me.DisplayMember = "Texte"        ' passer à ToString() pour les entités/condensés qui n'auraient pas de .Texte ?
        Me.ValueMember = "Id"
        AddHandler Me.SelectedValueChanged, AddressOf Me_SelectedValueChanged
    End Sub

    Public Overloads Property DataSource As SortableBindingList(Of IEntity.Condense)
        Get
            Return MyBase.DataSource
        End Get
        Set(value As SortableBindingList(Of IEntity.Condense))
            If value Is Nothing Then
                MyBase.DataSource = value
                Exit Property
            End If
            Dim ancienidselect As Integer? = Me.SelectedValue
            MyBase.DataSource = New SortableBindingList(Of IEntity.Condense)(value)
            With MyBase.DataSource
                .FilterFunc = FonctionFiltre
                .Filter = _filtre           ' doit être fait après le binding comme datasource
                If ancienidselect IsNot Nothing AndAlso .Find("Id", ancienidselect) <> -1 Then
                    Me.SelectedValue = ancienidselect
                Else
                    ' (en cas de suppression, sélectionner l'item adjacent serait pas mal)
                End If
            End With
        End Set
    End Property


    Private Sub Me_SelectedValueChanged(sender As Object, e As EventArgs)
        Me.IdSelectionne = Me.SelectedValue
        RaiseEvent ActeurChanged()
    End Sub

    Public Function FiltrerElem(elem As Object, filtre As String) As Boolean
        'Return elem.Texte.contains(filtre)
        Return UzineAGaz.ReduireString(elem.ToString).Contains(UzineAGaz.ReduireString(filtre))
    End Function

    Private Sub FiltrerListe()
        ' quand des items sont supprimés/ajoutés, le SelectedIndex ne change pas et risque se retrouver sur un item différent;
        ' en plus, même si SelectedValue prend la valeur du nouvel item sélectionné, l'evt SelectedValueChanged n'est pas déclenché
        ' (sauf si le SelectedIndex est remonté parce que devenu hors liste, mais ce n'est pas mieux)
        ' --> donc, refait la sélection manuellement
        RemoveHandler Me.SelectedValueChanged, AddressOf Me_SelectedValueChanged

        Me.DataSource.Filter = _filtre
        If IdSelectionne IsNot Nothing AndAlso Me.DataSource.Find("Id", IdSelectionne) <> -1 Then
            Me.SelectedValue = IdSelectionne
        Else
            Me.ClearSelected()
        End If

        AddHandler Me.SelectedValueChanged, AddressOf Me_SelectedValueChanged
    End Sub

End Class
