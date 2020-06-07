Public Class Formula
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim CAC, BC, DA, raiz, x1, x2, a, b As Double
        CAC = 4 * Val(txtA.Text) * Val(txtC.Text)
        BC = Math.Pow(Val(txtB.Text), 2)
        DA = 2 * Val(txtA.Text)
        raiz = Math.Sqrt(BC - CAC)
        a = -Val(txtB.Text) + raiz
        b = -Val(txtB.Text) - raiz
        x1 = a / DA
        x2 = b / DA
        Try
            If Me.ValidateChildren And IsNumeric(txtA.Text) And IsNumeric(txtB.Text) And IsNumeric(txtC.Text) Then
                If BC - CAC < 0 Then
                    MsgBox("No se puede evaluar numeros negativos en una raiz")
                    txtA.Clear()
                    txtB.Clear()
                    txtC.Clear()
                    txtX.Clear()
                    txtX2.Clear()
                Else
                    txtX.Text = x1
                    txtX2.Text = x2
                    MessageBox.Show("Calculo exitoso", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtA.Clear()
                txtB.Clear()
                txtC.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        txtX.Clear()
        txtX2.Clear()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class