Public Class PanelInfosCsnr
    Public Function GetConcessionnaire() As Acteur
        Dim csnr = New Acteur With {
            .Nom = TbCsnrNom.Value,
            .Prenom = TbCsnrPrenom.Value,
            .NoRegistre = tbCsnrNoNational.Value,
            .Tel = TbCsnrTel.Value,
            .Adresse = TbCsnrAdresse.Value,
            .Cp = tbCsnrCp.Value,
            .Ville = TbCsnrVille.Value,
            .Pays = TbCsnrPays.Value
        }
        If dtpCsnrDateNaiss.Checked Then
            csnr.DateNaiss = dtpCsnrDateNaiss.Value
        Else
            csnr.DateNaiss = Nothing
        End If
        Return csnr
    End Function

End Class
