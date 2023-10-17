Public Class FrmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCalculadora.Click
        FrmLotes.Show()
    End Sub

    Private Sub BtnCasa_Click_1(sender As Object, e As EventArgs) Handles BtnCasa.Click
        FrmCambio.show()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class