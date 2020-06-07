Imports System.ComponentModel

Public Class Deduccion

    Private Sub txtSueldo_Validating(sender As Object, e As CancelEventArgs) Handles txtSueldo.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                Me.ErrorVacio.SetError(sender, "")
            Else
                Me.ErrorVacio.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        txtSueldo.Clear()
        txtNeto.Clear()
        txtDoE.Clear()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            If Me.ValidateChildren And IsNumeric(txtSueldo.Text) And Val(txtSueldo.Text) >= 0 Then
                If Val(txtSueldo.Text) < 16582.92 Then
                    txtDoE.Text = "Excento"
                    txtNeto.Text = txtSueldo.Text
                ElseIf (txtSueldo.Text > 16582.93 And txtSueldo.Text < 23536.61) Then
                    txtDoE.Text = "Deducción"
                    txtNeto.Text = Val(txtSueldo.Text) - (Val(txtSueldo.Text) * 0.15)
                ElseIf (txtSueldo.Text > 23536.62 And txtSueldo.Text < 50317.69) Then
                    txtDoE.Text = "Deducción"
                    txtNeto.Text = Val(txtSueldo.Text) - (Val(txtSueldo.Text) * 0.2)
                ElseIf txtSueldo.Text > 50317.69 Then
                    txtDoE.Text = "Deducción"
                    txtNeto.Text = Val(txtSueldo.Text) - (Val(txtSueldo.Text) * 0.25)
                End If
            ElseIf txtSueldo.Text = "" Then
                If DirectCast(sender, TextBox).Text.Length > 0 Then
                    Me.ErrorVacio.SetError(sender, "")
                Else
                    Me.ErrorVacio.SetError(sender, "Es un campo obligatorio")
                End If
            Else
                MessageBox.Show("Ingrese datos numéricos y números positivos")
            End If
        Catch ex As Exception
        End Try

    End Sub
End Class