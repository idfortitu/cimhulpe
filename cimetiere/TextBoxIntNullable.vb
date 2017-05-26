Public Class TextBoxIntNullable
    Inherits TextBoxInt

    ' textbox qui accepte seulement les chiffres

    Public Overloads Property Value As Integer?
        Get
            'Return If(Me.Text Is Nothing, Nothing, Int32.Parse(Me.Text))
            If Me.Text.Trim = "" Then
                Return Nothing
            Else
                Return Int32.Parse(Me.Text)
            End If
        End Get
        Set(value As Integer?)
            Me.Text = If(value, "")
        End Set
    End Property

End Class
