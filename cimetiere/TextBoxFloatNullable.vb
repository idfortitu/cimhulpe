Public Class TextBoxFloatNullable
    Inherits TextBoxFloat
    Public Overloads Property Value As Single?
        Get
            If Me.Text.Trim = "" Then
                Return Nothing
            Else
                Dim res As Single
                Single.TryParse(Me.Text.Replace(",", "."), Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, res)
                Return res
            End If
        End Get
        Set(value As Single?)
            Me.Text = If(value, "")
        End Set
    End Property



End Class
