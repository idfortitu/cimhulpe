Public Class FormHome
    Private formprincipal As FormGestion
    Private disposition As Integer
    Dim Notif_affiche = 1
    Private Sub FAccBdeclaredeces_Click_1(sender As Object, e As EventArgs)
        Dim FormAjout As New FormNouvelleInhumation()
        FormAjout.ShowDialog()
    End Sub

    Private Sub FAccTBNewConcession_Click_1(sender As Object, e As EventArgs) Handles FAccTBNewConcession.Click
        Dim FormAjout As New FormNouvelleConcession()
        FormAjout.ShowDialog()
    End Sub

    Private Sub FAccTBProlongation_Click_1(sender As Object, e As EventArgs) Handles FAccTBProlongation.Click
        Dim FormProlong As New FormProlongation
        FormProlong.ShowDialog()
    End Sub

    Private Sub FAccTBReserv_Click_1(sender As Object, e As EventArgs) Handles FAccTBReserv.Click
        Dim leform = New FormEmplacements
        leform.ShowDialog()
    End Sub

    Private Sub FAccTBConsulter_Click_1(sender As Object, e As EventArgs) Handles FAccTBConsulter.Click
        Dim formprincipal = New FormGestion
        formprincipal.ShowDialog()
    End Sub

    Private Sub FormHomeBMasque_Click(sender As Object, e As EventArgs) Handles FormHomeBMasque.Click
        If Notif_affiche = 1 Then
            FormHomePanNotif.Location = New Point(-7, 465)
            FormHomeBMasque.Text = "Afficher"
            Notif_affiche = 0
        Else
            FormHomePanNotif.Location = New Point(-7, 400)
            FormHomeBMasque.Text = "Masquer"
            Notif_affiche = 1
        End If

    End Sub

    Private Sub BtDebug_Click(sender As Object, e As EventArgs) Handles BtDebug.Click
        Dim FaddD As New debug_tests
        FaddD.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim leform = New FormEmplacements
        leform.ShowDialog()
    End Sub
End Class