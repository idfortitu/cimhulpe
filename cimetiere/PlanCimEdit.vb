Public Class PlanCimEdit


    Public coords_empl_actuel As List(Of Point) = New List(Of Point)

    Private Sub PlanCimEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim empl As New Emplacement
        Dim nbr As Integer
        With empl
            .Reference = tbref.Text
            .Type = lbtype.SelectedItem.ToString        ' erreur si pas d'élément sélectionné
            .Commentaire = tbcom.Text
            .MonumClasse = cbclasse.Checked
            .NbPlaces = If(Int32.TryParse(tbplaces.Text, nbr), nbr, Nothing)
        End With

        coords_empl_actuel.Add(coords_empl_actuel(0))
        Dim coords((coords_empl_actuel.Count * 4) - 1) As Byte
        Dim i As Integer = 0
        For Each pt As Point In coords_empl_actuel
            coords(i) = pt.X And &HFF
            i += 1
            coords(i) = pt.X >> 8
            i += 1
            coords(i) = pt.Y And &HFF
            i += 1
            coords(i) = pt.Y >> 8
            i += 1
        Next
        empl.Coords = coords

        Using ctx As New CimBddContext
            ctx.Emplacements.Add(empl)
            ctx.SaveChanges()
        End Using

        tbref.Text = ""
        tbplaces.Text = ""
        tbcom.Text = ""
        cbclasse.Checked = False
        Me.coords_empl_actuel.Clear()



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        Dim propx As Single = 2000 / PictureBox1.Size.Width
        Dim propy As Single = 2000 / PictureBox1.Size.Height
        coords_empl_actuel.Add(New Point(CInt(e.Location.X * propx), CInt(e.Location.Y * propy)))

    End Sub
End Class
