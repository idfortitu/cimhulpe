Imports System.ComponentModel

Public Class SimpleQuestion
    ' contrôle qui affiche un texte (question) et des radiobuttons (choix possibles)
    ' une Action peut être associée à un choix pour être déclenchée avec un appel à FaireActions

    Private Actions As New Dictionary(Of RadioButton, Action)

    <Category("Appearance"), Description("Le texte associé au contrôle.")>
    Public Overrides Property text As String
        Get
            Return Me.LeLabel.Text
        End Get
        Set(value As String)
            Me.LeLabel.Text = value
        End Set
    End Property

    ' prend la largeur du parent
    Public Sub DimFlpChoix() Handles Me.Load
        Me.MaximumSize = New Size(Me.Parent.Width, 0)
        Me.MinimumSize = New Size(Me.Parent.Width, 0)
        Me.FlowPanelOptions.MaximumSize = New Size(Me.Width - Me.FlowPanelOptions.Location.X, 0)
    End Sub

    Function AddChoix(texte As String, Optional LAction As Action = Nothing, Optional checked As Boolean = False) As RadioButton
        'Dim btn As New RadioButton() With {.Text = texte}
        Dim btn As New WrappingRadioButton() With {.Text = texte}
        If checked Then btn.Checked = True
        'btn.AutoSize = False
        'btn.AutoSize = True
        'btn.Size = New Size(150, 30)

        btn.CheckAlign = ContentAlignment.TopLeft

        'btn.MinimumSize = New Size(150, 60) ' mettre larg ctnr
        'btn.MaximumSize = New Size(150, 400)
        'btn.AutoEllipsis = True ''
        'btn.Width = Me.FlowPanelOptions.Width

        'btn.MinimumSize

        'btn.Width = 200
        'btn.AutoSize = True

        Actions.Add(btn, LAction)
        'Me.FlowPanelOptions.Controls.Add(New Label With {.Text = "osefsef"})
        Me.FlowPanelOptions.Controls.Add(btn)
        Return btn
    End Function

    Sub FaireActions()
        For Each action As KeyValuePair(Of RadioButton, Action) In Actions
            If action.Key.Checked Then
                If action.Value IsNot Nothing Then Invoke(action.Value)
                Exit For      '   radiobutton, donc un seul choix
            End If
        Next
    End Sub



    ' https://blogs.msdn.microsoft.com/jfoscoding/2005/10/07/how-can-i-create-a-wrapping-radio-button-checkbox/
    Friend Class WrappingRadioButton
        Inherits System.Windows.Forms.RadioButton

        Dim cachedSizeOfOneLineOfText As System.Drawing.Size = System.Drawing.Size.Empty
        Dim preferredSizeHash As New Dictionary(Of Size, Size)(3)  ' testing this out – typically we’ve got three different constraints.

        Friend Sub New()
            MyBase.New()
            Me.AutoSize = True
        End Sub

        Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)

            MyBase.OnTextChanged(e)
            CacheTextSize()
        End Sub

        Protected Overrides Sub OnFontChanged(ByVal e As System.EventArgs)
            MyBase.OnFontChanged(e)
            CacheTextSize()
        End Sub

        Private Sub CacheTextSize()
            'When the text has changed, the preferredSizeHash is invalid…
            preferredSizeHash.Clear()

            If String.IsNullOrEmpty(Me.Text) Then
                cachedSizeOfOneLineOfText = System.Drawing.Size.Empty
            Else
                cachedSizeOfOneLineOfText = TextRenderer.MeasureText(Me.Text, Me.Font, New Size(Int32.MaxValue, Int32.MaxValue), TextFormatFlags.WordBreak)
            End If
        End Sub

        Public Overrides Function getpreferredsize(ByVal proposedsize As System.Drawing.Size) As System.Drawing.Size

            Dim prefSize As Size = MyBase.GetPreferredSize(proposedsize)
            If (proposedsize.Width > 1) AndAlso (prefSize.Width > proposedsize.Width) AndAlso (Not String.IsNullOrEmpty(Me.Text) AndAlso Not proposedsize.Width.Equals(Int32.MaxValue) OrElse Not proposedsize.Height.Equals(Int32.MaxValue)) Then
                ' NOTE: WinForm pass (1,0) to ask the default size of the control, when it hasn’t got prefered Width. We should prefer to arrange everything in one line, but not break to multilines.
                ' we have the possiblility of wrapping… back out the single line of text
                Dim bordersAndPadding As Size = prefSize - cachedSizeOfOneLineOfText
                ' add back in the text size, subtract baseprefsize.width and 3 from proposed size width so they wrap properly
                Dim newConstraints As Size = proposedsize - bordersAndPadding - New Size(3, 0)

                If newConstraints.Width < 0 Then
                    newConstraints.Width = 0
                End If
                If newConstraints.Height < 0 Then
                    newConstraints.Height = 0
                End If

                If (Not preferredSizeHash.ContainsKey(newConstraints)) Then
                    prefSize = bordersAndPadding + TextRenderer.MeasureText(Me.Text, Me.Font, newConstraints, TextFormatFlags.WordBreak)
                    preferredSizeHash(newConstraints) = prefSize

                Else
                    prefSize = preferredSizeHash(newConstraints)
                End If
            End If
            Return prefSize
        End Function
    End Class

    Private Sub DimFlpChoix(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
