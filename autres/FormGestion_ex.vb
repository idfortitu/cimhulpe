' Ancienne version liste défunts avec ListView triable 


Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports PopupControl


Public Class FormGestion
    Dim DefuntsColonneTri As Integer = -1
    Dim DefuntAffiche As Defunt

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.SuspendLayout()
        Dim ListeDefunts = Bdd.GetListeDefunts()
        Dim items(ListeDefunts.Count - 1) As ListViewItem
				For i = 0 To items.Count - 1
            items(i) = New ListViewItem({ListeDefunts(i).Nom,
                                         ListeDefunts(i).Prenom,
                                         ListeDefunts(i).Emplacement,
                                         ListeDefunts(i).NumeroLh,
                                         CType(ListeDefunts(i).DateDeces, Date).ToString("dd/MM/yyyy")
                                        }) With {.Tag = ListeDefunts(i).id}
        Next
        LvListeDefunts.Items.AddRange(items)
        LvListeDefunts.Sorting = SortOrder.None
        ''Me.ResumeLayout(False)
    End Sub

    ' trie en fonction d'une colonne
    Private Sub LvListeDefunts_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles LvListeDefunts.ColumnClick
        ' retire la flèche de l'ancienne colonne
        If DefuntsColonneTri <> -1 Then
            LvListeDefunts.Columns(DefuntsColonneTri).Text = Replace(Replace(LvListeDefunts.Columns(DefuntsColonneTri).Text, " ↓", ""), " ↑", "")
        End If
        ' change la colonne / l'ordre de tri
        If DefuntsColonneTri <> e.Column Then
            DefuntsColonneTri = e.Column
            LvListeDefunts.Sorting = SortOrder.Ascending
        Else
            If LvListeDefunts.Sorting = SortOrder.Ascending Then
                LvListeDefunts.Sorting = SortOrder.Descending
            Else
                LvListeDefunts.Sorting = SortOrder.Ascending
            End If
        End If
        ' met une la "flèche" au bon endroit
        If LvListeDefunts.Sorting = SortOrder.Ascending Then
            LvListeDefunts.Columns(e.Column).Text += " ↑"
        Else
            LvListeDefunts.Columns(e.Column).Text += " ↓"
        End If

        LvListeDefunts.ListViewItemSorter = New ComparateurListeDefunts(e.Column, LvListeDefunts.Columns(e.Column).Tag, LvListeDefunts.Sorting)
        'LvListeDefunts.Sort()  ' a l'air de marcher sans
    End Sub

    Private Class ComparateurListeDefunts
        Implements IComparer
        Private col As Integer
        Private coltag As String
        Private ordre As SortOrder
        Public Sub New(col As Integer, coltag As String, ordre As SortOrder)
            Me.col = col
            Me.coltag = coltag
            Me.ordre = ordre
        End Sub

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Dim res As Integer = 0 ' égal par défaut
            Select Case coltag
                Case "code"
                    'ordre numérique
                    Dim nx, ny As Integer
                    If Not Int32.TryParse(CType(x, ListViewItem).SubItems(col).Text, nx) Then
                        res = 1     ' les valeurs incorrectes sont renvoyées à la fin ("plus grand")
                    ElseIf Not Int32.TryParse(CType(y, ListViewItem).SubItems(col).Text, ny) Then
                        res = -1
                    Else
                        If nx < ny Then
                            res = -1
                        ElseIf nx > ny Then
                            res = 1
                        End If
                    End If
                Case "datedeces"
                    'ordre de date
                    Dim dx, dy As Date
                    If Not DateTime.TryParseExact(CType(x, ListViewItem).SubItems(col).Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dx) Then
                        res = 1
                    ElseIf Not DateTime.TryParseExact(CType(y, ListViewItem).SubItems(col).Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dy) Then
                        res = -1
                    Else
                        res = Date.Compare(dx, dy)
                    End If
                Case Else
                    ' ordre alphabétique
                    res = [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
            End Select
            Return If(ordre = SortOrder.Ascending, res, -res)
        End Function

    End Class

    ' ItemActivate serait peut-être mieux, pour ne pas charger des infos sans arrêt si par exemple on navigue dans la liste au clavier
    Private Sub LvListeDefunts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvListeDefunts.SelectedIndexChanged
        If LvListeDefunts.SelectedItems.Count > 0 Then
            DefuntAffiche = Bdd.ChargerDefunt(CType(LvListeDefunts.SelectedItems(0).Tag, Int32))
            With DefuntAffiche
                TxtDefNom.Text = .Prenom & " " & .Nom
                TxtDefEmplacement.Text = If(.SejourActif IsNot Nothing, .SejourActif.Emplacement.Reference, "(non spécifié)")
                TxtDefDateDeces.Text = If(.DateDeces IsNot Nothing, .DateDeces.Value.ToString("dd/MM/yyyy"), "")
                TxtDefCode.Text = If(.NumeroLh, "")
                TxtDefEtatCiv.Text = Defunt.EtatCivilToString(.EtatCivil) & If(.EtatCivil <> "celibataire", "de " & .EtatCivilDe, "")
                TxtDefDomicile.Text = If(.Adresse IsNot Nothing, .Adresse & ",", "") &
                    If(.Cp IsNot Nothing, .Cp & " ", "") & If(.Ville IsNot Nothing, .Ville, "") & If(String.Compare(.Pays, "belgique", True) <> 0, ", " & .Pays, "")
            End With
        End If
    End Sub
End Class
