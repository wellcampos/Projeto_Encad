<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelPecas
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
        Me.LbObra = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridPeca = New System.Windows.Forms.DataGridView()
        CType(Me.GridPeca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbObra
        '
        Me.LbObra.AutoSize = True
        Me.LbObra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbObra.Location = New System.Drawing.Point(12, 9)
        Me.LbObra.Name = "LbObra"
        Me.LbObra.Size = New System.Drawing.Size(34, 13)
        Me.LbObra.TabIndex = 0
        Me.LbObra.Text = "Obra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Relação de Peças, dois cliques para ver a dimensão"
        '
        'GridPeca
        '
        Me.GridPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPeca.Location = New System.Drawing.Point(12, 69)
        Me.GridPeca.Name = "GridPeca"
        Me.GridPeca.Size = New System.Drawing.Size(441, 235)
        Me.GridPeca.TabIndex = 2
        '
        'RelPecas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 426)
        Me.Controls.Add(Me.GridPeca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbObra)
        Me.Name = "RelPecas"
        Me.Text = "RelPecas"
        CType(Me.GridPeca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbObra As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GridPeca As DataGridView
End Class
