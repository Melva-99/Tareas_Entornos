Public Class Login
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If txtusuario.Text = "0201199900964" And txtcontra.Text = "Melva99" Then
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Datos Incorrectos")
            txtusuario.Clear()
            txtcontra.Clear()
        End If
    End Sub
End Class