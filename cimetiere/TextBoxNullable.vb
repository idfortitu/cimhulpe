Public Class TextBoxNullable
    Inherits TextBoxCBanner
    'Inherits TextBox
    ' renvoie Nothing si la chaîne est vide

    Public Property Value As String
        Get
            If Me.Text.Trim <> "" Then
                Return Me.Text
            Else
                Return Nothing
            End If
        End Get
        Set(value As String)
            Me.Text = If(value, "")
        End Set
    End Property
End Class
