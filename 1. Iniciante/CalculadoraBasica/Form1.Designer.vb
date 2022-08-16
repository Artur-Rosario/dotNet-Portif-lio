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
        Me.components = New System.ComponentModel.Container()
        Me.BtnMais = New System.Windows.Forms.Button()
        Me.BtnMenos = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnDivisao = New System.Windows.Forms.Button()
        Me.Valor1 = New System.Windows.Forms.NumericUpDown()
        Me.Valor2 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnReset = New System.Windows.Forms.Button()
        CType(Me.Valor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Valor2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMais
        '
        Me.BtnMais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMais.Location = New System.Drawing.Point(163, 20)
        Me.BtnMais.Name = "BtnMais"
        Me.BtnMais.Size = New System.Drawing.Size(22, 24)
        Me.BtnMais.TabIndex = 0
        Me.BtnMais.Text = "+"
        Me.BtnMais.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnMais.UseVisualStyleBackColor = True
        '
        'BtnMenos
        '
        Me.BtnMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenos.Location = New System.Drawing.Point(163, 50)
        Me.BtnMenos.Name = "BtnMenos"
        Me.BtnMenos.Size = New System.Drawing.Size(22, 24)
        Me.BtnMenos.TabIndex = 1
        Me.BtnMenos.Text = "-"
        Me.BtnMenos.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnMenos.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(163, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(22, 24)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnDivisao
        '
        Me.BtnDivisao.Location = New System.Drawing.Point(163, 111)
        Me.BtnDivisao.Name = "BtnDivisao"
        Me.BtnDivisao.Size = New System.Drawing.Size(22, 24)
        Me.BtnDivisao.TabIndex = 3
        Me.BtnDivisao.Text = "/"
        Me.BtnDivisao.UseVisualStyleBackColor = True
        '
        'Valor1
        '
        Me.Valor1.Location = New System.Drawing.Point(34, 46)
        Me.Valor1.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.Valor1.Name = "Valor1"
        Me.Valor1.Size = New System.Drawing.Size(110, 20)
        Me.Valor1.TabIndex = 4
        '
        'Valor2
        '
        Me.Valor2.Location = New System.Drawing.Point(207, 46)
        Me.Valor2.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.Valor2.Name = "Valor2"
        Me.Valor2.Size = New System.Drawing.Size(110, 20)
        Me.Valor2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(344, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.ForeColor = System.Drawing.Color.White
        Me.BtnCalcular.Location = New System.Drawing.Point(369, 111)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcular.TabIndex = 7
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Valor 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Operação"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Valor 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(322, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(341, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Resultado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(51, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(312, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Defina o Tipo De Operação!!"
        Me.Label6.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.DarkRed
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.White
        Me.BtnReset.Location = New System.Drawing.Point(288, 111)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 14
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(457, 147)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Valor2)
        Me.Controls.Add(Me.Valor1)
        Me.Controls.Add(Me.BtnDivisao)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnMenos)
        Me.Controls.Add(Me.BtnMais)
        Me.Name = "Form1"
        Me.Text = "MDIStart"
        CType(Me.Valor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Valor2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMais As Button
    Friend WithEvents BtnMenos As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnDivisao As Button
    Friend WithEvents Valor1 As NumericUpDown
    Friend WithEvents Valor2 As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnReset As Button
End Class
