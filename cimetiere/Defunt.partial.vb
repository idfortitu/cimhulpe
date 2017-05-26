Partial Public Class Defunt
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

    ' le nom est moche mais EtatCivilToString est déjà réservé pour la propriété
    Shared Function StaticEtatCivilToString(etat As String, Optional de As String = "") As String
        Dim res As String = ""
        Select Case etat
            Case "celibataire"
                res = "célibataire"
            Case "epoux"
                res = "époux(se)"
                If de <> "" Then res &= " de " & de
            Case "veuf"
                res = "veuf"
                If de <> "" Then res &= " de " & de
            Case "divorce"
                res = "divorcé"
                If de <> "" Then res &= " de " & de
            Case "enfant"
                res = "fils/fille"
                If de <> "" Then res &= " de " & de
        End Select
        Return res
    End Function

    Public ReadOnly Property EtatCivilToString As String
        Get
            Return StaticEtatCivilToString(Me.EtatCivil, Me.EtatCivilDe)
        End Get
    End Property

    ' C/C de la même dans Acteur, mais flemme de faire encore une classe
    ' Renvoie une seule string du style "13 avenue de la rue, 1415 Trouperdu (France)"
    Public ReadOnly Property AdresseComplete(Optional ForcerPays As Boolean = False) As String
        Get
            ' Renvoie une seule string du style "13 avenue de la rue, 1415 Trouperdu (France)"
            Dim texte As String = ""
            If Adresse <> Nothing Then
                texte = Me.Adresse
            End If

            Dim cpville As String = ""
            If Cp.HasValue Then
                cpville = Cp.Value
                If Ville IsNot Nothing Then cpville &= " "
            End If
            cpville &= Ville

            If cpville IsNot Nothing Then
                'If texte IsNot Nothing Then texte &= ", "
                If texte <> Nothing Then texte &= ", "
                texte &= cpville
            End If

            If Pays IsNot Nothing AndAlso (ForcerPays = True Or Pays <> "Belgique") Then
                If texte <> "" Then
                    texte &= " (" & Pays & ")"
                Else
                    texte &= Pays
                End If
            End If
            Return texte
        End Get
    End Property


    ' C/C de la même dans Acteur, flemme de faire encore une classe
    Public ReadOnly Property NomComplet(Optional SignalerAbsence As Boolean = False) As String
        Get
            If Nom <> Nothing And Prenom <> Nothing Then
                'Return Nom & ", " & Prenom
                Return Nom.ToUpper & " " & Prenom
            ElseIf Nom <> Nothing And Prenom = Nothing Then
                'Return If(SignalerAbsence, Nom & ", (prénom non précisé)", Nom)
                Return If(SignalerAbsence, Nom.ToUpper & " (prénom non précisé)", Nom.ToUpper)
            ElseIf Nom = Nothing And Prenom <> Nothing Then
                Return If(SignalerAbsence, Prenom & " (nom de famille non précisé)", Prenom)
            Else
                Return If(SignalerAbsence, "(nom absent)", Nothing)
            End If
        End Get
    End Property




    Public Class InfosPourListe
        Public Property Id As Integer?
        Public Property Nom As String
        Public Property NumeroLh As Integer?
        Public Property RefEmplacement As String
        Public Property DateDeces As Date?

    End Class

End Class
