Public Class TextBoxFloat
    Inherits TextBoxCBanner
    Public Overridable Property Value As Single
        Get
            If Me.Text.Trim = "" Then
                Return 0
            Else
                Dim res As Single
                Single.TryParse(Me.Text.Replace(",", "."), Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, res)
                Return res
            End If
        End Get
        Set(value As Single)
            Me.Text = value
        End Set
    End Property

    ' empêche d'entrer du texte au clavier
    Public Sub nombreskeydown(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Not Char.IsControl(e.KeyChar) Then
            If e.KeyChar = "," Then
                ''''' mettre la virgule à la position du curseur
                Dim poscur As Integer = Me.SelectionStart
                Dim nouvtext = VirerVirgules(Me.Text, poscur)
                nouvtext = nouvtext.Insert(poscur, ",")
                Me.Text = nouvtext
                Me.SelectionStart = poscur + 1
                e.Handled = True
            ElseIf Not Char.IsNumber(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    ' filtre aussi le copier-coller
    Protected Overrides Sub WndProc(ByRef m As Message)

        If m.Msg <> 770 Then         ' WM_PASTE
            MyBase.WndProc(m)
            Return
        End If

        ' filtre les caractères non-autorisés
        Dim s As String = ""
        Dim ex_s As String = Clipboard.GetText
        For Each c In ex_s
            If Char.IsNumber(c) Or c = "," Then s += c
        Next

        If s <> "" Then
            Dim poscur As Integer = Me.SelectionStart
            Dim nouveautexte = Me.Text
            ' supprime la sélection actuelle pour la remplacer
            nouveautexte = nouveautexte.Remove(poscur, Me.SelectionLength)
            ' insère le texte collé
            nouveautexte = nouveautexte.Insert(Me.SelectionStart, s)
            poscur = poscur + s.Count
            ' retire les virgules en trop, ne laisse que la dernière :
            Dim i As Integer = nouveautexte.Count - 1
            ' localise la dernière virgule
            While i >= 0 AndAlso nouveautexte(i) <> ","
                i -= 1
            End While
            ' et enlève les virgules précédentes
            i -= 1
            While i >= 0
                If nouveautexte(i) = "," Then
                    nouveautexte = nouveautexte.Remove(i, 1)
                    If poscur > i Then poscur -= 1
                End If
                i -= 1
            End While

            Me.Text = nouveautexte
            Me.SelectionStart = poscur
        End If
    End Sub

    ' enlève les virgules, en option adapte la position du curseur
    Private Function VirerVirgules(s As String, Optional ByRef poscur As Integer = 0) As String
        Dim res As String = ""
        Dim i As Integer = 0
        While i < poscur
            If s(i) <> "," Then
                res += s(i)
            Else
                poscur -= 1
            End If
            i += 1
        End While
        While i < s.Count
            If s(i) <> "," Then res += s(i)
            i += 1
        End While
        Return res
    End Function

End Class

