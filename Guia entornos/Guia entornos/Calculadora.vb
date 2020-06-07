Public Class Calculadora

    Dim Operaciones As String
    Dim Resultado As Nullable(Of Double) = Nothing
    Dim Valor As Nullable(Of Double) = Nothing
    Dim operador As Boolean
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        restricciones()
        txtResultado.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        restricciones()
        txtResultado.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        restricciones()
        txtResultado.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        restricciones()
        txtResultado.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        restricciones()
        txtResultado.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        restricciones()
        txtResultado.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        restricciones()
        txtResultado.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        restricciones()
        txtResultado.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        restricciones()
        txtResultado.Text &= "9"
    End Sub

    Private Sub btnCero_Click(sender As Object, e As EventArgs) Handles btnCero.Click
        restricciones()
        txtResultado.Text &= "0"
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        restricciones()
        If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
            txtResultado.Text &= "."
        End If
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Evaluar()
        Operaciones = "+"
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Evaluar()
        Operaciones = "-"
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Evaluar()
        Operaciones = "x"
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Evaluar()
        Operaciones = "/"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtResultado.Text = "0"
        Valor = Nothing
        Resultado = Nothing
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        Evaluar()
        Validacion_division()
        Operaciones = ""
        If txtResultado.Text = "SYNTAX ERROR" Then
            ltHistorial.Text = ""
        Else
            ltHistorial.Items.Add(txtResultado.Text)
        End If
    End Sub
    Public Sub Evaluar()
        operador = True
        Valor = Val(txtResultado.Text)
        If Resultado IsNot Nothing Then
            Select Case Operaciones
                Case "+"
                    Resultado = Resultado + Valor
                Case "-"
                    Resultado -= Valor
                Case "x"
                    Resultado *= Valor
                Case "/"
                    Resultado /= Valor
            End Select
            txtResultado.Text = Resultado
        Else
            Resultado = Valor
        End If
    End Sub
    Public Sub restricciones()
        If operador = True Then
            txtResultado.Clear()
            operador = False
        ElseIf txtResultado.Text = "0" Then
            txtResultado.Text = ""
        End If
    End Sub
    Public Sub Validacion_division()
        If Resultado = Resultado / 0 Then
            txtResultado.Text = "SYNTAX ERROR"
        Else
            Resultado /= Valor
        End If
    End Sub
End Class