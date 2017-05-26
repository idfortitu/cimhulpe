Public Class ElemListeBenefBdd
    Private _benef As Acteur        ' dispose ?
    Public Property Benef As Acteur
        Get
            Return _benef
        End Get
        Set(value As Acteur)
            _benef = value
            With _benef
                LabAdresse.Text = If(.AdresseComplete <> "", .AdresseComplete, "(Adresse non précisée)")
                LabDateNaiss.Text = If(.DateNaiss IsNot Nothing, .DateNaiss.Value.ToString("dd/MM/yyyy"), "(Date de naissance absente)")
                LabNom.Text = .Nom
                LabPrenom.Text = .Prenom
                'TbLienParente.Text = CtrlBenef.TbLienParente.Text
            End With

        End Set
    End Property

    Delegate Sub RetirerBeneficiaireEventHandler(sender As ElemListeBeneficiairesNvCon, e As EventArgs)
    'Public Event Retirer As RetirerBeneficiaireEventHandler
    Public Event Retirer(elem As ElemListeBenefBdd)
    Private Sub btRetirerBeneficiaire_Click(sender As Object, e As EventArgs) Handles BtRetirerBeneficiaire.Click
        RaiseEvent Retirer(Me)
    End Sub

End Class
