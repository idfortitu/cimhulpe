Public Class TextBoxInt
    Inherits TextBoxCBanner
    'Inherits TextBox
    Public Overridable Property Value As Integer
        Get
            Dim res As Integer
            Int32.TryParse(Me.Text, res)
            Return res
        End Get
        Set(value As Integer)
            Me.Text = value
        End Set
    End Property

    ' empêche d'entrer du texte au clavier
    Public Sub nombreskeydown(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' filtre aussi le copier-coller
    Protected Overrides Sub WndProc(ByRef m As Message)

        If m.Msg <> 770 Then         ' WM_PASTE
            MyBase.WndProc(m)
            Return
        End If

        Dim s As String = ""
        Dim ex_s As String = Clipboard.GetText
        For Each c In ex_s
            If Char.IsNumber(c) Then s += c
        Next
        If s <> "" Then
            Clipboard.SetText(s)
            MyBase.WndProc(m)
            Clipboard.SetText(ex_s)
        End If
    End Sub

End Class
