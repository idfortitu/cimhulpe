Partial Public Class FnvConBenef
    Inherits IEntity
    Implements IEntityInterface
    Private Property InternId As Integer Implements IEntityInterface.Id
        Get
            Return Me.Id
        End Get
        Set(value As Integer)
            Me.Id = value
        End Set
    End Property

    'Shared Function FromBeneficiaire(b As Beneficiaire) As FnvConBenef
    Shared Function FromBeneficiaire(b As Acteur) As FnvConBenef
        Return New FnvConBenef With {
            .Nom = b.Nom,
            .Prenom = b.Prenom,
            .DateNaiss = b.DateNaiss,
            .Adresse = b.Adresse,
            .Ville = b.Ville,
            .Cp = b.Cp,
            .Pays = b.Pays} ',
        '.LienParente = b.LienParente,   ' n'est plus un membre de Beneficiaire
    End Function
End Class
