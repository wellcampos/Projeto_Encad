Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim stringConexao As String = ConfigurationManager.ConnectionStrings(“ConexaoMySql”).ConnectionString()
    Dim conexaoMySql As MySqlConnection
    Dim comandoMySQl As MySqlCommand
    Dim leitorDataReader As MySqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consultaSql As String = "SELECT * FROM USERS"
        Try
            conexaoMySql = New MySqlConnection(stringConexao)
            comandoMySQl = New MySqlCommand(consultaSql, conexaoMySql)
            conexaoMySql.Open()
            leitorDataReader = comandoMySQl.ExecuteReader()
            While (leitorDataReader.Read())
                ListBox1.Items.Add(leitorDataReader.Item("UserName"))
            End While
        Catch ex As Exception
            MessageBox.Show("Erro  :" + ex.Message)
        Finally
            leitorDataReader.Close()
            conexaoMySql.Close()
        End Try

    End Sub
End Class
