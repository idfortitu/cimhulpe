Public Class FormEditEmplacement
    Public IdEmplacement As Integer?
    Private LEmplacement As Emplacement

    Public Sub New(Optional IdEmpl As Integer? = Nothing)
        ' This call is required by the designer.
        InitializeComponent()
        IdEmplacement = IdEmpl
    End Sub

    Private Sub FormEditEmplacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' édit ou nouveau ?

    End Sub

    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs) Handles BtEnregistrer.Click

    End Sub

    ' pas de DialogResult automatique sinon il se déclenche quand on appuie sur entrée pour passer une ligne dans le commentaire
    Private Sub DgvConcessions_KeyDown(sender As Object, e As KeyEventArgs) Handles TbNbPlaces.KeyDown, TbReference.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtEnregistrer_Click(BtEnregistrer, Nothing)
        End If
    End Sub



End Class