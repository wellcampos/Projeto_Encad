Imports System.IO

Public Class FrmDB
    Public databaseOk As Boolean
    Public DBip As String = ""

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        databaseOk = True
        Dim path As String = Application.StartupPath
        writeFile(path)

    End Sub

    Sub writeFile(path As String)
        If Not String.IsNullOrEmpty(txtIP.Text) Then
            Using writer As New StreamWriter(path + "\Encad.ini", False)
                writer.WriteLine("DBIP = " + txtIP.Text)
                DBip = txtIP.Text
                Me.DialogResult = DialogResult.OK
            End Using

        Else
            MsgBox("Informe o IP para continuar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        If Not String.IsNullOrWhiteSpace(line) Then
            Dim valores As String() = line.Trim().Split("=")
            If valores.Length > 1 Then
                DBip = valores(1)
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub
End Class