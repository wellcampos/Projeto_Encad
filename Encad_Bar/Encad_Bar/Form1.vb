Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data
Imports System.IO

Public Class Form1
    Dim stringConexao As String = "" 'ConfigurationManager.ConnectionStrings(“ConexaoMySql”).ConnectionString()
    Dim conexaoMySql As MySqlConnection
    Dim comandoMySQl As MySqlCommand
    Dim leitorDataReader As MySqlDataReader
    Dim DBIp As String = ""

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        readFile(Application.StartupPath)
        If String.IsNullOrEmpty(DBIp) Then
            Dim frmDb As New FrmDB()
            frmDb.ShowDialog(Me)
            If frmDb.DialogResult = DialogResult.Cancel Then
                If MessageBox.Show("Informe o IP para continuar", "Aviso",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    Me.Close()
                End If
            Else
                DBIp = frmDb.DBip
            End If
        End If
        stringConexao = "Server=" + DBIp + ";Database=encad_bar;Uid=root;Pwd=root;"
    End Sub

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
                'tamanhoNormaldoForm()
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

    Sub readFile(path As String)
        Dim line As String = ""
        'Dim DBip As String = ""
        If File.Exists(path + "\Encad.ini") Then
            Using reader As New StreamReader(path + "\Encad.ini", True)
                line = reader.ReadLine()
            End Using
        End If
        If Not String.IsNullOrWhiteSpace(line) And line.Contains("DBIP") Then
            Dim valores As String() = line.Trim().Split("=")
            If valores.Length > 1 Then
                DBIp = valores(1)
            End If
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Rect As New Rectangle(20, 20, picImagem.Width, picImagem.Height)
        e.Graphics.DrawImage(picImagem.Image, Rect)
    End Sub

    Private Sub btnImprimir_Click_1(sender As Object, e As EventArgs) Handles btnImprimir.Click
        picImagem.Width = picImagem.Image.Width + 2

        picImagem.Height = picImagem.Image.Height + 2

        ' imprime a imagem

        PrintDocument1.Print()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frmPecas As New RelPecas
        frmPecas.Show()

    End Sub
End Class
