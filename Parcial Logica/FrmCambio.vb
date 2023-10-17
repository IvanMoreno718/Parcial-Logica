Public Class FrmCambio
    Dim numero1, numero2 As Single
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim division As Decimal
        Dim rutaArchivo As String = "..\..\..\Historial.txt"
        numero1 = Val(Valor1.Text)
        numero2 = Val(Valor2.Text)

        division = numero1 / numero2

        dolar.Text = division
        My.Computer.FileSystem.WriteAllText(rutaArchivo, dolar.Text & vbCrLf, True)
    End Sub

End Class