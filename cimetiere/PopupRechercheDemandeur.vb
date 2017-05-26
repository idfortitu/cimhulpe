Public Class PopupRechercheDemandeur
    Inherits PopupRecherche

    Protected Overrides Property ListeValueMember As String = "Id"
    Protected Overrides Property ListeDisplayMember As String = "Nom"

    Public Sub New(Optional ActionSuite As Action(Of Object) = Nothing, Optional RechInit As String = "")
        MyBase.New(ActionSuite, RechInit)
    End Sub

    Protected Overrides Sub UpdateListe(texte As String)

    End Sub
End Class
