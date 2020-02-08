Imports MessagingToolkit.QRCode.Codec

Public Class DimPecas
    Sub Proc(BarNumber As String, nomePeca As String)
        Dim _tppc As New tpPecasDao
        Dim peca As New Pecas
        peca = _tppc.PecasGetById(BarNumber)
        lbEtiqueta.Text = peca.NumEtiqueta.ToString
        Dim strUrl = peca.ID.ToString + "#" + nomePeca
        gerarQrCode(strUrl)

        '        Dim DimPeca As ADODB.Recordset
        '        Dim DimObra As ADODB.Recordset
        '        Dim DimTpPc As ADODB.Recordset

        ''BarNumber = Principal.Text1.Text
        'Set DimPeca = New ADODB.Recordset
        'Set DimObra = New ADODB.Recordset
        'Set DimTpPc = New ADODB.Recordset

        ''Me.Show

        'DimPeca.Open "Select * from pecas where BAR_NUMBER='" + Trim(BarNumber) + "'", Principal.MyConn
        'DimObra.Open "Select * from obras where ID=" + Trim(Str(DimPeca("OBRA"))), Principal.MyConn
        'DimTpPc.Open "Select * from tppeca where ID=" + Trim(Str(DimPeca("TIPOPC"))), Principal.MyConn
        'GridDim.Clear
        '        GridDim.ColWidth(0) = 3050
        '        GridDim.ColWidth(1) = 2000
        '        LblEtiq = DimPeca("NUM_ETIQ")
        '        LblNumPc = separa_bar(BarNumber)
        '        If DimPeca("OBRA") = -1 Then
        '            LblObra = "Estoque"
        '        Else
        '            LblObra = DimObra("NOME_OBRA")
        '        End If
        '        LblTp = DimTpPc("NOME")
        '        On Error Resume Next
        '        For i = 0 To 8 Step 2
        '            GridDim.Row = i
        '            GridDim.Col = 0
        '            GridDim.Text = DimTpPc(5 + i)
        '            GridDim.Col = 1
        '            GridDim.Text = Str(DimPeca(9 + i))
        '        Next
        '        For i = 1 To 9 Step 2
        '            GridDim.Row = i
        '            GridDim.Col = 0
        '            GridDim.CellBackColor = &HC0C0C0
        '            GridDim.Text = DimTpPc(5 + i)
        '            GridDim.Col = 1
        '            GridDim.CellBackColor = &HC0C0C0
        '            GridDim.Text = Str(DimPeca(9 + i))
        '        Next
        '        On Error GoTo 0
    End Sub

    Public Function gerarQrCode(code As String)
        If Not String.IsNullOrWhiteSpace(code) Then
            Try
                'tamanhoNormaldoForm()
                Dim url As String = code
                Dim qrencod As New QRCodeEncoder()
                Dim qrcode As Bitmap = qrencod.Encode(url)
                picImagem.Image = TryCast(qrcode, Image)
            Catch ex As Exception
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Informe uma texto para gerar o QRCode", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function
End Class