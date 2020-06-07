Public Class Numeros

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim par, impar, positivo, negativo, cantidad, suma, ingresados As Integer
        cantidad = Val(txtCantidad.Text)
        For i = 1 To cantidad Step 1
            ingresados = InputBox("Ingrese el número " & i, "Ingresar")
            suma += ingresados
            If ingresados > 0 Then
                positivo += 1
            Else
                negativo = negativo + 1
            End If
            If (ingresados Mod 2) = 0 Then
                par += 1
            Else
                impar += 1
            End If
            cmbIngresados.Items.Add(ingresados)
        Next
        txtSuma.Text = suma
        txtPositivo.Text = positivo
        txtNegativo.Text = negativo
        txtPares.Text = par
        txtImpar.Text = impar
        txtTotal.Text = cantidad

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cmbIngresados.Items.Remove(cmbIngresados)
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class