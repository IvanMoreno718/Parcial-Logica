Public Class FrmLogin
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txtpsw.TextChanged

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnaceptar_Click(sender As Object, e As EventArgs) Handles Btnaceptar.Click
        If Me.Txtpsw.Text = "izo" Then
            FrmMain.Show()
            Me.Close()
        Else
            MsgBox("Contraseña incorrecta")
        End If
    End Sub
End Class