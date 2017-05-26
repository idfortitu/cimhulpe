Public Class MaskedTextBoxDate
    Inherits MaskedTextBox
    Public Sub New()
        MyBase.New
        Me.Mask = "00/00/0000"
        Me.TextAlign = HorizontalAlignment.Right
    End Sub

    ' liste d'Integer? (le designer a du mal à initaliser correctement les tableaux, en tout cas of nullable)
    ' contenant dans cet ordre le jour, le mois et l'annnée
    Public Property IntArrayValue As List(Of Integer?)
        Get
            Dim strDate() As String = Split(Me.Text, "/")
            Dim intJour, intMois, intAnnee As Integer?
            If IsNumeric(strDate(0)) AndAlso strDate(0) <> 0 Then
                intJour = strDate(0)
            Else
                intJour = Nothing
            End If
            If IsNumeric(strDate(1)) AndAlso strDate(1) <> 0 Then
                intMois = strDate(1)
            Else
                intMois = Nothing
            End If
            If IsNumeric(strDate(2)) AndAlso strDate(2) <> 0 Then
                intAnnee = strDate(2)
            Else
                intAnnee = Nothing
            End If
            'Return New List(Of Integer?)({intJour, intMois, intAnnee})
            Return New List(Of Integer?)({intJour, intMois, intAnnee})
        End Get
        ' essayer Set(value() As Integer?) si le designer déconne ?
        Set(value As List(Of Integer?))
            Me.Text = Format(value(0), "00") & "/" & Format(value(1), "00") & "/" & Format(value(2), "0000")
        End Set
    End Property

    Public Property DateValue As Date?
        ' attend Me.Text au format j/m/a
        ' si un "champ" est 0 (mois, jour), le met à 1
        Get
            Dim txtsansespaces As String = Replace(Me.Text, " ", "")
            If Replace(txtsansespaces, "/", "").Equals(String.Empty) Then
                Return Nothing
            Else
                Dim strs() As String = Split(txtsansespaces, "/")
                ' string = reference type
                ' gaffe aux espaces
                For n = 0 To 1
                    If strs(n).Count = 0 Then strs(n) = "1"
                    strs(n) = Format(CType(strs(n), Integer), "00")
                Next
                If strs(2).Count = 0 Then strs(2) = "0"
                strs(2) = Format(CType(strs(2), Integer), "0000")
                Return Date.ParseExact(strs(0) & "/" & strs(1) & "/" & strs(2), "dd/MM/yyyy", Globalization.CultureInfo.InvariantCulture)
            End If
        End Get
        Set(value As Date?)
            If value Is Nothing Then
                Me.Text = "__/__/____"
            Else
                Me.Text = Format(value.Value.Day, "00") & "/" & Format(value.Value.Month, "00") & "/" & Format(value.Value.Year, "0000")
            End If

        End Set
    End Property

End Class
