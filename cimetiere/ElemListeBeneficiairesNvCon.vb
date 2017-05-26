Public Class ElemListeBeneficiairesNvCon

    ' pas fini, abandonné
    'Private Property _aspectActif As Boolean = True
    'Public Property AspectActif As Boolean
    '    Get
    '        Return _aspectActif
    '    End Get
    '    Set(value As Boolean)
    '        If Not value Then
    '            Me.BackColor = SystemColors.ControlLightLight
    '            Me.ForeColor = SystemColors.GrayText
    '            ' à faire : bouton
    '        Else
    '            Me.BackColor = SystemColors.Window
    '            Me.ForeColor = SystemColors.ControlText
    '            ' à faire : bouton
    '        End If
    '    End Set
    'End Property

    Delegate Sub RetirerBeneficiaireEventHandler(sender As ElemListeBeneficiairesNvCon, e As EventArgs)
    'Public Event Retirer As RetirerBeneficiaireEventHandler
    Public Event Retirer(elem As ElemListeBeneficiairesNvCon)
    Private Sub btRetirerBeneficiaire_Click(sender As Object, e As EventArgs) Handles btRetirerBeneficiaire.Click
        RaiseEvent Retirer(Me)
    End Sub
End Class
