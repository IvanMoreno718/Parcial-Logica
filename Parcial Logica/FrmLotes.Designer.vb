<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLotes
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
        Me.Largo = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Superficie = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Ancho = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCalcular.Location = New System.Drawing.Point(363, 264)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcular.TabIndex = 0
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'Largo
        '
        Me.Largo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Largo.Location = New System.Drawing.Point(393, 164)
        Me.Largo.Name = "Largo"
        Me.Largo.Size = New System.Drawing.Size(100, 23)
        Me.Largo.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(254, 171)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(133, 16)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Ingrese el largo del lote:"
        '
        'Superficie
        '
        Me.Superficie.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Superficie.Location = New System.Drawing.Point(393, 222)
        Me.Superficie.Name = "Superficie"
        Me.Superficie.ReadOnly = True
        Me.Superficie.Size = New System.Drawing.Size(100, 23)
        Me.Superficie.TabIndex = 9
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Location = New System.Drawing.Point(254, 225)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(133, 16)
        Me.TextBox8.TabIndex = 10
        Me.TextBox8.Text = "La superficie del lote es:"
        '
        'Ancho
        '
        Me.Ancho.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Ancho.Location = New System.Drawing.Point(393, 193)
        Me.Ancho.Name = "Ancho"
        Me.Ancho.Size = New System.Drawing.Size(100, 23)
        Me.Ancho.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(254, 196)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(133, 16)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Text = "Ingrese el ancho del lote:"
        '
        'FrmLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Ancho)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Superficie)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Largo)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Name = "FrmLotes"
        Me.Text = "FrmLotes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCalcular As Button
    Friend WithEvents Largo As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Superficie As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Ancho As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
