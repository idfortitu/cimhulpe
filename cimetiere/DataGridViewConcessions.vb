' met des couleurs différentes pour les concessions expirées ou proches de la date d'exp
Public Class DataGridViewConcessions
    Inherits DataGridView
    Private Sub ColorLignes(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Me.CellFormatting
        Dim larow As DataGridViewRow = Me.Rows(e.RowIndex)
        Dim datefin As Date? = CType(larow.DataBoundItem, Concession.InfosPourListe).DateFin
        Dim expire As Boolean = datefin.HasValue AndAlso datefin < Today
        Dim impair As Boolean = e.RowIndex Mod 2 <> 0
        If expire Then
            If impair Then
                larow.DefaultCellStyle.BackColor = Color.FromArgb(212, 212, 212)
                larow.DefaultCellStyle.ForeColor = SystemColors.GrayText
            Else
                larow.DefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222)
                larow.DefaultCellStyle.ForeColor = SystemColors.GrayText
            End If
        End If
    End Sub

End Class
