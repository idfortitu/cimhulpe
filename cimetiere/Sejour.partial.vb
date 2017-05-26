Partial Public Class Sejour
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

    Public Property EstActuel As Boolean
            Get

                Return Me.Defunt.SejourActif Is Me
            End Get
            Set(value As Boolean)
                ' il faut qu'il y ait un défunt
                If Me.Defunt IsNot Nothing Then
                    Me.Defunt.SejourActif = Me
                Else
                    Throw New Exception("Un séjour doit être associé à un défunt avant d'être marqué comme actif.")
                End If
            End Set
        End Property
    End Class
