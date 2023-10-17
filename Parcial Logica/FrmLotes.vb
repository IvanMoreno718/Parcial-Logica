Public Class FrmLotes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim num, num2, resultado
        num = Val(Largo.Text)
        num2 = Val(Ancho.Text)
        resultado = num * num2
        Superficie.Text = resultado

    End Sub

    Private Sub FrmLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class