Imports System
Imports System.Net
Imports System.IO
Module tests_http
    Sub testrequete(Optional url As String = "http://phpcimetiere")
        Dim req As HttpWebRequest = HttpWebRequest.Create(url)
        req.Method = "GET"
        'req.ContentLength = byteArray.Length
        'Stream strLeStream = req.GetRequestStream()
        'strLeStream.Write(bytearray,0,bytearray.length)
        'strLeStream.Close()
        Dim rep As WebResponse = req.GetResponse()

        Dim donnees As Stream = rep.GetResponseStream

        Dim lectstream As New StreamReader(donnees)

        Dim reptexte As String = lectstream.ReadToEnd()


        MessageBox.Show(reptexte)

        rep.Close()
    End Sub

    Sub testrequetesecu(Optional url As String = "https://phpcimetiere")
        testrequete(url)
    End Sub

End Module
