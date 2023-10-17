<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.Valor1 = New System.Windows.Forms.TextBox()
        Me.Valor2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.dolar = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCalcular.Location = New System.Drawing.Point(358, 255)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcular.TabIndex = 0
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'Valor1
        '
        Me.Valor1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Valor1.Location = New System.Drawing.Point(343, 106)
        Me.Valor1.Name = "Valor1"
        Me.Valor1.Size = New System.Drawing.Size(100, 23)
        Me.Valor1.TabIndex = 1
        '
        'Valor2
        '
        Me.Valor2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Valor2.Location = New System.Drawing.Point(343, 153)
        Me.Valor2.Name = "Valor2"
        Me.Valor2.Size = New System.Drawing.Size(100, 23)
        Me.Valor2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(186, 109)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(151, 16)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Ingrese la cantidad de pesos:"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(171, 156)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(166, 16)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "Ingrese la cotizacion del dolar:"
        '
        'dolar
        '
        Me.dolar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dolar.Location = New System.Drawing.Point(343, 201)
        Me.dolar.Name = "dolar"
        Me.dolar.ReadOnly = True
        Me.dolar.Size = New System.Drawing.Size(100, 23)
        Me.dolar.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(186, 204)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(151, 16)
        Me.TextBox4.TabIndex = 6
        Me.TextBox4.Text = "La cantidad de dolares son:"
        '
        'FrmCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.dolar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Valor2)
        Me.Controls.Add(Me.Valor1)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Name = "FrmCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCambio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCalcular As Button
    Friend WithEvents Valor1 As TextBox
    Friend WithEvents Valor2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents dolar As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
End Class
