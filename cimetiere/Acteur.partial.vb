Partial Public Class Acteur
    Inherits IEntity
    Implements IEntityInterface
    ' peut pas mettre Implements dans la classe générée automatiquement
    ' http://stackoverflow.com/a/26824272
    ' http://stackoverflow.com/a/473284
    Private Property InternId As Integer Implements IEntityInterface.Id
        Get
            Return Me.Id
        End Get
        Set(value As Integer)
            Me.Id = value
        End Set
    End Property

    ' Renvoie une seule string du style "13 avenue de la rue, 1415 Trouperdu (France)"
    Public ReadOnly Property AdresseComplete(Optional ForcerPays As Boolean = False) As String
        Get
            Return StaticAdresseComplete(Me.Adresse, Me.Cp, Me.Ville, Me.Pays, ForcerPays)
        End Get
    End Property

    ' Renvoie une seule string du style "13 avenue de la rue, 1415 Trouperdu (France)"
    Public Shared Function StaticAdresseComplete(adr As String, cp As Integer?, ville As String, pays As String, Optional ForcerPays As Boolean = False)
        Dim texte As String = ""
        If adr <> Nothing Then
            texte = adr
        End If

        Dim cpville As String = ""
        If cp.HasValue Then
            cpville = cp.Value
            If ville IsNot Nothing Then cpville &= " "
        End If
        cpville &= ville

        If cpville IsNot Nothing Then
            'If texte IsNot Nothing Then texte &= ", "
            If texte <> Nothing Then texte &= ", "
            texte &= cpville
        End If

        If pays IsNot Nothing AndAlso (ForcerPays = True Or pays <> "Belgique") Then
            If texte <> "" Then
                texte &= " (" & pays & ")"
            Else
                texte &= pays
            End If
        End If
        Return texte

    End Function

    Public ReadOnly Property NomComplet(Optional SignalerAbsence As Boolean = False) As String
        Get
            'If Nom <> Nothing And Prenom <> Nothing Then
            '    Return Nom & ", " & Prenom
            'ElseIf Nom <> Nothing And Prenom = Nothing Then
            '    Return If(SignalerAbsence, Nom & ", (prénom non précisé)", Nom)
            'ElseIf nom = Nothing And prenom <> Nothing Then
            '    Return If(SignalerAbsence, Prenom & " (nom de famille non précisé)", Prenom)
            'Else
            '    Return If(SignalerAbsence, "(nom absent)", Nothing)
            'End If
            Return StaticNomComplet(Me.Prenom, Me.Nom, SignalerAbsence)
        End Get
    End Property

    Public Shared Function StaticNomComplet(act As Acteur, Optional SignalerAbsence As Boolean = False) As String
        Return StaticNomComplet(act.Prenom, act.Nom, SignalerAbsence)
    End Function

    Public Shared Function StaticNomComplet(prenom As String, nom As String, Optional SignalerAbsence As Boolean = False) As String
        If nom <> Nothing And prenom <> Nothing Then
            'Return nom & ", " & prenom
            Return nom.ToUpper & " " & prenom
        ElseIf nom <> Nothing And prenom = Nothing Then
            'Return If(SignalerAbsence, nom & ", (prénom non précisé)", nom)
            Return If(SignalerAbsence, nom.ToUpper & " (prénom non précisé)", nom.ToUpper)
        ElseIf nom = Nothing And prenom <> Nothing Then
            Return If(SignalerAbsence, prenom & " (nom de famille non précisé)", prenom)
        Else
            Return If(SignalerAbsence, "(nom absent)", Nothing)
        End If
    End Function

    Class InfosPourListe
        Public Property Id As Integer?
        Public Property Nom As String
    End Class


End Class
