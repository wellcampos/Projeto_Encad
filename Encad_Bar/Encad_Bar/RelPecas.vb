Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data
Imports System.IO
Public Class RelPecas
    Dim stringConexao As String = "" 'ConfigurationManager.ConnectionStrings(“ConexaoMySql”).ConnectionString()
    Dim conexaoMySql As MySqlConnection
    Dim comandoMySQl As MySqlCommand
    Dim leitorDataReader As MySqlDataReader
    Dim DBIp As String = ""
    Private Sub RelPecas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim getPecas As New tpPecasDao
        Dim lstPecas As New List(Of TipoPecas)
        lstPecas = getPecas.Pecas
        GridPeca.DataSource = lstPecas
    End Sub

    Private Sub GridPeca_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GridPeca.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = GridPeca.Rows(e.RowIndex)
            Dim barNumber = row.Cells(2).Value
            Dim nome = row.Cells(1).Value
            Dim frmDimPecas As New DimPecas
            frmDimPecas.Proc(barNumber, nome)
            frmDimPecas.Show()
        End If
    End Sub
End Class