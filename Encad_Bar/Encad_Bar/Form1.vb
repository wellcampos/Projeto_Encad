Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data
Public Class Form1
    Dim stringConexao As String = ConfigurationManager.ConnectionStrings(“ConexaoMySql”).ConnectionString()
    Dim conexaoMySql As MySqlConnection
    Dim comandoMySQl As MySqlCommand
    Dim leitorDataReader As MySqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consultaSql As String = "select * from encad_bar.tppeca"
        Try
            conexaoMySql = New MySqlConnection(stringConexao)
            comandoMySQl = New MySqlCommand(consultaSql, conexaoMySql)
            conexaoMySql.Open()
            leitorDataReader = comandoMySQl.ExecuteReader()
            While (leitorDataReader.Read())
                ListBox1.Items.Add(leitorDataReader.Item("Nome"))
            End While
        Catch ex As Exception
            MessageBox.Show("Erro  :" + ex.Message)
        Finally
            leitorDataReader.Close()
            conexaoMySql.Close()
        End Try

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub tamanhoNormaldoForm()
        Me.Width = 499
        Me.Height = 352
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Not String.IsNullOrWhiteSpace(ListBox1.SelectedItem) Then
            Try
                tamanhoNormaldoForm()
                Dim url As String = ListBox1.SelectedItem
                Dim qrencod As New QRCodeEncoder()
                Dim qrcode As Bitmap = qrencod.Encode(url)
                picImagem.Image = TryCast(qrcode, Image)
            Catch ex As Exception
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Informe uma texto para gerar o QRCode", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
