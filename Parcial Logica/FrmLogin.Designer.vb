<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.Txtpsw = New System.Windows.Forms.TextBox()
        Me.Btnaceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txtpsw
        '
        Me.Txtpsw.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtpsw.Location = New System.Drawing.Point(254, 70)
        Me.Txtpsw.Name = "Txtpsw"
        Me.Txtpsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpsw.Size = New System.Drawing.Size(100, 23)
        Me.Txtpsw.TabIndex = 0
        '
        'Btnaceptar
        '
        Me.Btnaceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnaceptar.Location = New System.Drawing.Point(266, 118)
        Me.Btnaceptar.Name = "Btnaceptar"
        Me.Btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.Btnaceptar.TabIndex = 1
        Me.Btnaceptar.Text = "Aceptar"
        Me.Btnaceptar.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 182)
        Me.Controls.Add(Me.Btnaceptar)
        Me.Controls.Add(Me.Txtpsw)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtpsw As TextBox
    Friend WithEvents Btnaceptar As Button
End Class
