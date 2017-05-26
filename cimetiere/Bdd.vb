Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports Newtonsoft.Json
Imports System
Imports System.Net
Imports System.IO
Imports System.Text



' Fonctions : - plus forcément à jour
' GetTable(table as String) As DataTable        ' ex : GetTable("demandeurs")
' GetTableWithId(table as String, NomPk As String, Id As Integer) As DataTable      ' ex : GetTableWithId("emplacements","empl_id",4)

' Function GetFormInhumation(id As Integer) As DemandeInhumation
' Function GetFormNvConcession(id As Integer) As DemandeNvConcession
' Function GetFormNvConBenefs(IdForm) As Beneficiaire()
' PutFormInhumation(LeForm As DemandeInhumation) As Integer      ' ajoute un nouveau form en bdd (table forms inhum + éventuellement form nv con & fnvcon bénéficiaires
'                                                                     renvoie l'id inséré
' Function PutFormNvCon(LeForm As DemandeNvConcession) As Integer
' 


Module Bdd

    Dim conn As New MySqlConnection


    Function GetDataTable(commande As String) As DataTable
        Dim objConn As New MySql.Data.MySqlClient.MySqlConnection
        Dim objCmd As New MySql.Data.MySqlClient.MySqlCommand
        Dim dtAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim ds As New DataSet()
        Dim strConnString As String
        strConnString = "Server=" & ConfigLocale.BddHost & ";User Id=" & ConfigLocale.BddUser & "; Password=" & ConfigLocale.BddPass & "; Database=" & ConfigLocale.BddNom & "; Pooling=false"

        objConn.ConnectionString = strConnString
        With objCmd
            .Connection = objConn
            .CommandText = commande
            .CommandType = CommandType.Text
        End With
        dtAdapter.SelectCommand = objCmd
        dtAdapter.Fill(ds)
        dtAdapter = Nothing
        objConn.Close()
        objConn = Nothing
        Return ds.Tables(0)   '*** Return DataTable ***' 


    End Function


    Function GetValeurSql(commande As String, colonne As String) As String
        conn.ConnectionString = "Server=" & ConfigLocale.BddHost & ";User Id=" & ConfigLocale.BddUser & "; Password=" & ConfigLocale.BddPass & "; Database=" & ConfigLocale.BddNom & "; Pooling=false"
        conn.Open()
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As MySqlDataReader
        Dim SQL As String
        Dim objConn As New MySql.Data.MySqlClient.MySqlConnection
        myCommand.Connection = conn
        ' La requête
        SQL = commande
        myCommand.CommandText = SQL
        myAdapter.SelectCommand = myCommand
        myData = myCommand.ExecuteReader()
        myData.Read()
        Dim str = myData.GetString(colonne)
        myData.Close()
        conn.Close()
        Return str

    End Function

    'Public Function InsertPers() As Boolean

    '    Dim conn As MySqlConnection = Connecter()
    '    Dim sqlCommand As New MySqlCommand
    '    Dim str_carSql As String

    '    Try
    '        str_carSql = "insert into personne (id, nom, prenom, naissance, mort, sepulture, enterement, expiration) values ('','heu','peutetre','25','34','65','98','20')"
    '        MsgBox(str_carSql)
    '        sqlCommand.Connection = conn
    '        sqlCommand.CommandText = str_carSql
    '        sqlCommand.ExecuteNonQuery()
    '        Return True

    '    Catch ex As Exception
    '        Return False
    '        MsgBox("Error occured: Could not insert record")
    '    End Try

    '    conn.Close()
    'End Function


    ' Pour service PHP
    ' Renvoie du JSON (actuellement) 
    ' à continuer


End Module
