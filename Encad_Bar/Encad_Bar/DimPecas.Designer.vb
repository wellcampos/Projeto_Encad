<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DimPecas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbEtiqueta = New System.Windows.Forms.Label()
        Me.picImagem = New System.Windows.Forms.PictureBox()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Qr Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Etiqueta:"
        '
        'lbEtiqueta
        '
        Me.lbEtiqueta.AutoSize = True
        Me.lbEtiqueta.Location = New System.Drawing.Point(84, 63)
        Me.lbEtiqueta.Name = "lbEtiqueta"
        Me.lbEtiqueta.Size = New System.Drawing.Size(39, 13)
        Me.lbEtiqueta.TabIndex = 2
        Me.lbEtiqueta.Text = "Label3"
        '
        'picImagem
        '
        Me.picImagem.Location = New System.Drawing.Point(71, 12)
        Me.picImagem.Name = "picImagem"
        Me.picImagem.Size = New System.Drawing.Size(52, 39)
        Me.picImagem.TabIndex = 3
        Me.picImagem.TabStop = False
        '
        'DimPecas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.picImagem)
        Me.Controls.Add(Me.lbEtiqueta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DimPecas"
        Me.Text = "DimPecas"
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbEtiqueta As Label
    Friend WithEvents picImagem As PictureBox
End Class
