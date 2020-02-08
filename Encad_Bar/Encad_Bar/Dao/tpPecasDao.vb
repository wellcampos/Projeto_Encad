Imports MySql.Data.MySqlClient

Public Class tpPecasDao
    Dim conexaoMySql As MySqlConnection
    Dim comandoMySQl As MySqlCommand
    Dim leitorDataReader As MySqlDataReader
    Dim conexao As String = "Server=localhost;Database=encad_bar;Uid=root;Pwd=root"
    Dim list As List(Of TipoPecas)
    Public Function Pecas() As List(Of TipoPecas)
        Dim consultaSql As String = "select tp.ID, p.BAR_NUMBER, tp.Nome from tppeca tp
  INNER JOIN pecas p on p.TIPOPC = tp.ID"
        Dim getConexao As New Conexao
        Try
            conexaoMySql = New MySqlConnection(conexao)
            comandoMySQl = New MySqlCommand(consultaSql, conexaoMySql)
            conexaoMySql.Open()
            list = New List(Of TipoPecas)

            leitorDataReader = comandoMySQl.ExecuteReader()
            While (leitorDataReader.Read())
                Dim pc As New TipoPecas
                pc.ID = leitorDataReader.GetInt32("ID")
                pc.BarNumber = leitorDataReader.GetString("BAR_NUMBER")
                pc.Nome = leitorDataReader.Item("Nome")
                list.Add(pc)
            End While
        Catch ex As Exception
            MessageBox.Show("Erro  :" + ex.Message)
        Finally
            leitorDataReader.Close()
            conexaoMySql.Close()
        End Try
        Return list
    End Function
    Public Function PecasGetById(barNumber As String) As Pecas
        Dim consultaSql As String = "Select * from pecas where BAR_NUMBER='" + Trim(barNumber) + "'"
        Dim getConexao As New Conexao
        Dim pc As New Pecas
        Try
            conexaoMySql = New MySqlConnection(conexao)
            comandoMySQl = New MySqlCommand(consultaSql, conexaoMySql)
            conexaoMySql.Open()

            leitorDataReader = comandoMySQl.ExecuteReader()
            While (leitorDataReader.Read())
                pc.ID = leitorDataReader.GetInt32("ID")
                pc.Obra = leitorDataReader.GetInt32("OBRA")
                pc.TipoPC = leitorDataReader.GetInt32("TIPOPC")
                pc.NumEtiqueta = leitorDataReader.GetInt32("NUM_ETIQ")
            End While
        Catch ex As Exception
            MessageBox.Show("Erro  :" + ex.Message)
        Finally
            leitorDataReader.Close()
            conexaoMySql.Close()
        End Try
        Return pc
    End Function
End Class
