' trucs pour l'api web abandonnée

' Doivent évidemment correspondre aux formats attendus et renvoyés par la partie serveur
Public Class BddErreur
    Public code As Integer
    Public message As String
    Sub New(code As Integer, msg As String)
        Me.code = code
        Me.message = msg
    End Sub
End Class

Public Class BddDataIdentifiants
    Public login As String
    Public mdp As String
    Public Sub New(login, mdp)
        Me.login = login
        Me.mdp = mdp
    End Sub
End Class

Public Class BddReponseIdentification
    Public UserType As Integer
End Class

'Public MustInherit Class BddEnvoi
'    MustOverride Property action As String
'End Class

'classe générique pour les 'data' passées avec les commandes
Public Class BddDataObj

End Class
