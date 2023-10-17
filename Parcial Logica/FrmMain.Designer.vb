<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnCalculadora = New System.Windows.Forms.Button()
        Me.BtnCasa = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCalculadora
        '
        Me.BtnCalculadora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCalculadora.Location = New System.Drawing.Point(147, 102)
        Me.BtnCalculadora.Name = "BtnCalculadora"
        Me.BtnCalculadora.Size = New System.Drawing.Size(106, 57)
        Me.BtnCalculadora.TabIndex = 0
        Me.BtnCalculadora.Text = "Calculadora de superficie de lotes"
        Me.BtnCalculadora.UseVisualStyleBackColor = True
        '
        'BtnCasa
        '
        Me.BtnCasa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCasa.Location = New System.Drawing.Point(433, 102)
        Me.BtnCasa.Name = "BtnCasa"
        Me.BtnCasa.Size = New System.Drawing.Size(100, 57)
        Me.BtnCasa.TabIndex = 1
        Me.BtnCasa.Text = "Casa de cambio"
        Me.BtnCasa.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCerrar.Location = New System.Drawing.Point(315, 213)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 2
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 321)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnCasa)
        Me.Controls.Add(Me.BtnCalculadora)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents BtnCalculadora As Button
    Friend WithEvents BtnCasa As Button
    Friend WithEvents BtnCerrar As Button
End Class
