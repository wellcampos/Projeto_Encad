<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.picImagem = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(340, 186)
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(57, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Pesquisa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'picImagem
        '
        Me.picImagem.Location = New System.Drawing.Point(396, 12)
        Me.picImagem.Name = "picImagem"
        Me.picImagem.Size = New System.Drawing.Size(230, 186)
        Me.picImagem.TabIndex = 2
        Me.picImagem.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(396, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Gerar QrCode"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(261, 236)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 330)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.picImagem)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents picImagem As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
