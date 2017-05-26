Partial Public Class DemandeNvConcession
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

    Public Sub IntegrerInfosCsnr(csnr As Acteur)
        With csnr
            CsnrNom = .Nom
            CsnrPrenom = .Prenom
            CsnrDateNaiss = .DateNaiss
            CsnrNoNational = .NoRegistre
            CsnrAdresse = .Adresse
            CsnrVille = .Ville
            CsnrCp = .Cp
            CsnrPays = .Pays
            CsnrTel = .Tel
        End With
    End Sub
    Public Sub IntegrerInfosPmand(pmand As Acteur)
        With pmand
            PmandNom = .Nom
            PmandPrenom = .Prenom
            PmandDateNaiss = .DateNaiss
            PmandTel = .Tel
            PmandAdresse = .Adresse
            PmandVille = .Ville
            PmandCp = .Cp
            PmandPays = .Pays
        End With
    End Sub
    Public Sub AjouterBeneficiaire(ben As Acteur, Optional lienParente As String = "")
        Dim nvbenfnvcon As New FnvConBenef With {
            .Adresse = ben.Adresse,
            .Cp = ben.Cp,
            .DateNaiss = ben.DateNaiss,
            .Nom = ben.Nom,
            .Pays = ben.Pays,
            .Prenom = ben.Prenom,
            .Ville = ben.Ville,
            .LienParente = lienParente
        }

        Me.Beneficiaires.Add(nvbenfnvcon)
    End Sub
    ' en option, prend une liste de string de même taille que la liste de bénefs, pour leurs liens de parenté respectifs
    Public Sub AjouterBeneficiaires(bens As List(Of Acteur), Optional liensParente As List(Of String) = Nothing)
        If liensParente Is Nothing Then
            For Each ben In bens
                Me.AjouterBeneficiaire(ben)
            Next
            End
        Else
            For n = 0 To bens.Count - 1
                Me.AjouterBeneficiaire(bens(n), liensParente(n))
            Next
        End If
    End Sub

    Public Shared Function TypeConToString(tcon As String)
        Dim res As String = ""
        Select Case tcon
            Case "pl_ordinaire_cercueil"
                res = "Inhumation ordinaire en pleine terre (cercueil)"
            Case "pl_ordinaire_urne"
                res = "Inhumation ordinaire en pleine terre (urne)"
            Case "pl_1pers_15ans_cercueil"
                res = "Inhumation en pleine terre (1 personne) - concession de 15 ans (cercueil)"
            Case "pl_1pers_15ans_urne"
                res = "Inhumation en pleine terre (1 personne) - concession de 15 ans (urne)"
            Case "pl_2pers_15ans_cercueil"
                res = "Inhumation en pleine terre (2 personnes) - concession de 15 ans (cercueil)"
            Case "pl_2pers_15ans_urne"
                res = "Inhumation en pleine terre (2 personnes) - concession de 15 ans (urne)"
            Case "caveau_30ans_cercueil"
                res = "Placement d'un caveau - concession de 30 ans - (cercueil)"
            Case "caveau_30ans_cercueil_cavcom"
                res = "Placement d'un caveau - concession de 30 ans - (cercueil) - Emplacement pourvu d'un caveau communal"
            Case "caveau_30ans_urne"
                res = "Placement d'un caveau - concession de 30 ans - (urne)"
            Case "caveau_30ans_urne_cavcom"
                res = "Placement d'un caveau - concession de 30 ans - (urne) - Emplacement pourvu d'un caveau communal"
            Case "ouverture_caveau"
                res = "Ouverture de caveau uniquement si travail du fossoyeur (ouverture par chemin)"
            Case "urne_colomb_ordinaire"
                res = "Une urne mise en colombarium - place ordinaire (cell. 1 place prioritairement)"
            Case "urne_colomb_15ans"
                res = "Une urne mise en colombarium - concession de 15 ans"
            Case "urne_colomb_30ans"
                res = "Une urne mise en colombarium - concession de 30 ans"
            Case "cavurne_communal"
                res = "Placement d'un cavurne communal - concession de 30 ans (max. 5 urnes)"
            Case "dispersion_cendres"
                res = "Dispersion des cendres"
        End Select
        Return res
    End Function

    Public Function TypeConToString()
        Return Emplacement.TypeToString(Me.TypeCon)
    End Function
End Class
