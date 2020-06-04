Imports System.ComponentModel

Public Class Form1
    Dim Precio, total As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Try
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And (txtHora.Text) <> String.Empty And (txtCod.Text) <> String.Empty Then
                txtTotal.Text = Val(txtTotal.Text) + (txtbebida.Text)
                MessageBox.Show("Factura exitosa", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al facturar", "Ingrese los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkHam_CheckedChanged(sender As Object, e As EventArgs) Handles chkHam.CheckedChanged
        Precio = 55.0
        If chkHam.Checked = True Then
            txtTotal.Text = Precio
            total += Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkHam.Text)
            chkArroz.Enabled = False
            chkBaleadas.Enabled = False
            chkChuleta.Enabled = False
            chkPastel.Enabled = False
            chkPollo.Enabled = False
            chkPupusas.Enabled = False
            chkSopa.Enabled = False
            chkTacos.Enabled = False
        ElseIf chkHam.Checked = False Then
            total = total - 55.0
            txtTotal.Text = total
            list1.Items.RemoveAt(chkHam.Checked)
            chkArroz.Enabled = True
            chkBaleadas.Enabled = True
            chkChuleta.Enabled = True
            chkPastel.Enabled = True
            chkPollo.Enabled = True
            chkPupusas.Enabled = True
            chkSopa.Enabled = True
            chkTacos.Enabled = True
            chkHam.Enabled = True
        End If
    End Sub

    Private Sub chkPollo_CheckedChanged(sender As Object, e As EventArgs) Handles chkPollo.CheckedChanged
        Precio = 80.0
        If chkPollo.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkPollo.Text)
            chkArroz.Enabled = False
            chkBaleadas.Enabled = False
            chkChuleta.Enabled = False
            chkPastel.Enabled = False
            chkHam.Enabled = False
            chkPupusas.Enabled = False
            chkSopa.Enabled = False
            chkTacos.Enabled = False
        ElseIf chkPollo.Checked = False Then
            total = total - 80.0
            txtTotal.Text = total
            list1.Items.RemoveAt(chkPollo.Checked)
            chkArroz.Enabled = True
            chkBaleadas.Enabled = True
            chkChuleta.Enabled = True
            chkPastel.Enabled = True
            chkPollo.Enabled = True
            chkPupusas.Enabled = True
            chkSopa.Enabled = True
            chkTacos.Enabled = True
            chkHam.Enabled = True
        End If
    End Sub

    Private Sub chkChuleta_CheckedChanged(sender As Object, e As EventArgs) Handles chkChuleta.CheckedChanged
        Precio = 120.0
        If chkChuleta.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkChuleta.Text)
            btnPagar.Enabled = True
            chkArroz.Enabled = False
            chkBaleadas.Enabled = False
            chkHam.Enabled = False
            chkPastel.Enabled = False
            chkPollo.Enabled = False
            chkPupusas.Enabled = False
            chkSopa.Enabled = False
            chkTacos.Enabled = False
        ElseIf chkChuleta.Checked = False Then
            total = total - 120.0
            txtTotal.Text = total
            list1.Items.RemoveAt(chkChuleta.Checked)
            chkArroz.Enabled = True
            chkBaleadas.Enabled = True
            chkChuleta.Enabled = True
            chkPastel.Enabled = True
            chkPollo.Enabled = True
            chkPupusas.Enabled = True
            chkSopa.Enabled = True
            chkTacos.Enabled = True
            chkHam.Enabled = True

        End If
    End Sub

    Private Sub chkSopa_CheckedChanged(sender As Object, e As EventArgs) Handles chkSopa.CheckedChanged
        Precio = 110.0
        If chkSopa.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkSopa.Text)
            btnPagar.Enabled = True
            chkArroz.Enabled = False
            chkBaleadas.Enabled = False
            chkChuleta.Enabled = False
            chkPastel.Enabled = False
            chkPollo.Enabled = False
            chkPupusas.Enabled = False
            chkHam.Enabled = False
            chkTacos.Enabled = False
        ElseIf chkSopa.Checked = False Then
            total = total - 110.0
            txtTotal.Text = total
            list1.Items.RemoveAt(chkSopa.Checked)
            chkArroz.Enabled = True
            chkBaleadas.Enabled = True
            chkChuleta.Enabled = True
            chkPastel.Enabled = True
            chkPollo.Enabled = True
            chkPupusas.Enabled = True
            chkSopa.Enabled = True
            chkTacos.Enabled = True
            chkHam.Enabled = True
        End If
    End Sub

    Private Sub chkArroz_CheckedChanged(sender As Object, e As EventArgs) Handles chkArroz.CheckedChanged
        Precio = 120.0
        If chkArroz.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkArroz.Text)
            btnPagar.Enabled = True
            chkHam.Enabled = False
            chkBaleadas.Enabled = False
            chkChuleta.Enabled = False
            chkPastel.Enabled = False
            chkPollo.Enabled = False
            chkPupusas.Enabled = False
            chkSopa.Enabled = False
            chkTacos.Enabled = False
        ElseIf chkArroz.Checked = False Then
            total = total - 120.0
            txtTotal.Text = total
            list1.Items.RemoveAt(chkArroz.Checked)
            chkArroz.Enabled = True
            chkBaleadas.Enabled = True
            chkChuleta.Enabled = True
            chkPastel.Enabled = True
            chkPollo.Enabled = True
            chkPupusas.Enabled = True
            chkSopa.Enabled = True
            chkTacos.Enabled = True
            chkHam.Enabled = True
        End If
    End Sub

    Private Sub chkTacos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTacos.CheckedChanged
        Precio = 65.0
        If chkTacos.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkTacos.Text)
            btnPagar.Enabled = True
            chkArroz.Enabled = False
            chkBaleadas.Enabled = False
            chkChuleta.Enabled = False
            chkPastel.Enabled = False
            chkPollo.Enabled = False
            chkPupusas.Enabled = False
            chkSopa.Enabled = False
            chkHam.Enabled = False
        ElseIf chkTacos.Checked = False Then
            total = total - 65.0
            txtTotal.Text = total
            list1.Items.RemoveAt(chkTacos.Checked)
            chkArroz.Enabled = True
            chkBaleadas.Enabled = True
            chkChuleta.Enabled = True
            chkPastel.Enabled = True
            chkPollo.Enabled = True
            chkPupusas.Enabled = True
            chkSopa.Enabled = True
            chkTacos.Enabled = True
            chkHam.Enabled = True
        End If
    End Sub

    Private Sub chkBaleadas_CheckedChanged(sender As Object, e As EventArgs) Handles chkBaleadas.CheckedChanged
        Precio = 12.0
        If chkBaleadas.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkBaleadas.Text)
            btnPagar.Enabled = True
            chkArroz.Enabled = False
            chkHam.Enabled = False
            chkChuleta.Enabled = False
            chkPastel.Enabled = False
            chkPollo.Enabled = False
            chkPupusas.Enabled = False
            chkSopa.Enabled = False
            chkTacos.Enabled = False
        ElseIf chkBaleadas.Checked = False Then
            total = total - 12.0
            txtTotal.Text = total
            list1.Items.RemoveAt(chkBaleadas.Checked)
            chkArroz.Enabled = True
            chkBaleadas.Enabled = True
            chkChuleta.Enabled = True
            chkPastel.Enabled = True
            chkPollo.Enabled = True
            chkPupusas.Enabled = True
            chkSopa.Enabled = True
            chkTacos.Enabled = True
            chkHam.Enabled = True
        End If
    End Sub

    Private Sub chkPastel_CheckedChanged(sender As Object, e As EventArgs) Handles chkPastel.CheckedChanged
        Precio = 10.0
        If chkPastel.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkPastel.Text)
            chkArroz.Enabled = False
            chkBaleadas.Enabled = False
            chkChuleta.Enabled = False
            chkHam.Enabled = False
            chkPollo.Enabled = False
            chkPupusas.Enabled = False
            chkSopa.Enabled = False
            chkTacos.Enabled = False
        ElseIf chkPastel.Checked = False Then
            total = total - 10.0
            txtTotal.Text = total
            list1.Items.RemoveAt(chkPastel.Checked)
            chkArroz.Enabled = True
            chkBaleadas.Enabled = True
            chkChuleta.Enabled = True
            chkPastel.Enabled = True
            chkPollo.Enabled = True
            chkPupusas.Enabled = True
            chkSopa.Enabled = True
            chkTacos.Enabled = True
            chkHam.Enabled = True
        End If
    End Sub

    Private Sub chkPupusas_CheckedChanged(sender As Object, e As EventArgs) Handles chkPupusas.CheckedChanged
        Precio = 15.0
        If chkPupusas.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkPupusas.Text)
            chkArroz.Enabled = False
            chkBaleadas.Enabled = False
            chkChuleta.Enabled = False
            chkPastel.Enabled = False
            chkPollo.Enabled = False
            chkHam.Enabled = False
            chkSopa.Enabled = False
            chkTacos.Enabled = False
        ElseIf chkPupusas.Checked = False Then
            total = total - 15.0
            txtTotal.Text = total
            list1.Items.RemoveAt(chkPastel.Checked)
            chkArroz.Enabled = True
            chkBaleadas.Enabled = True
            chkChuleta.Enabled = True
            chkPastel.Enabled = True
            chkPollo.Enabled = True
            chkPupusas.Enabled = True
            chkSopa.Enabled = True
            chkTacos.Enabled = True
            chkHam.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        chkArroz.Checked = False
        chkBaleadas.Checked = False
        chkChuleta.Checked = False
        chkPastel.Checked = False
        chkPollo.Checked = False
        chkHam.Checked = False
        chkSopa.Checked = False
        chkTacos.Checked = False
        chkPupusas.Checked = False

        chkArroz.Enabled = True
        chkHam.Enabled = True
        chkBaleadas.Enabled = True
        chkChuleta.Enabled = True
        chkPastel.Enabled = True
        chkPollo.Enabled = True
        chkPupusas.Enabled = True
        chkSopa.Enabled = True
        chkTacos.Enabled = True

        chkPapas.Checked = False
        chkHuevo.Checked = False
        chkCarne.Checked = False
        chkTortillas.Checked = False
        chkTajadas.Checked = False
        chkAguacate.Checked = False
        chkChapsui.Checked = False
        chkEnsalada.Checked = False

        list1.Clear()
        txtTotal.Clear()
        txtCantidad.Clear()
        txtbebida.Clear()
    End Sub

    Private Sub chkPapas_CheckedChanged(sender As Object, e As EventArgs) Handles chkPapas.CheckedChanged
        Precio = 25.0
        If chkPapas.Checked = True Then
            list1.Items.Add(chkPapas.Text)
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
        ElseIf (chkPapas.Checked = False) Then
            list1.Items.RemoveAt(chkPapas.Checked)
            total = total - 25.0
            txtTotal.Text = total
        End If
    End Sub

    Private Sub chkHuevo_CheckedChanged(sender As Object, e As EventArgs) Handles chkHuevo.CheckedChanged
        Precio = 4.0
        If chkHuevo.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkHuevo.Text)
        ElseIf chkHuevo.Checked = False Then
            list1.Items.RemoveAt(chkHuevo.Checked)
            total = total - 4.0
            txtTotal.Text = total
        End If
    End Sub

    Private Sub chkCarne_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarne.CheckedChanged
        Precio = 10.0
        If chkCarne.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkCarne.Text)
        ElseIf chkCarne.Checked = False Then
            list1.Items.RemoveAt(chkCarne.Checked)
            total = total - 10.0
            txtTotal.Text = total
        End If
    End Sub

    Private Sub chkAguacate_CheckedChanged(sender As Object, e As EventArgs) Handles chkAguacate.CheckedChanged
        Precio = 7.0
        If chkAguacate.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkAguacate.Text)
        ElseIf chkAguacate.Checked = False Then
            list1.Items.RemoveAt(chkAguacate.Checked)
            total = total - 7.0
            txtTotal.Text = total
        End If
    End Sub

    Private Sub chkChapsui_CheckedChanged(sender As Object, e As EventArgs) Handles chkChapsui.CheckedChanged
        Precio = 55.0
        If chkChapsui.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkChapsui.Text)
        ElseIf chkChapsui.Checked = False Then
            list1.Items.RemoveAt(chkChapsui.Checked)
            total = total - 55.0
            txtTotal.Text = total
        End If
    End Sub

    Private Sub chkTortillas_CheckedChanged(sender As Object, e As EventArgs) Handles chkTortillas.CheckedChanged
        Precio = 1.0
        If chkTortillas.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkTortillas.Text)
        ElseIf chkTortillas.Checked = False Then
            list1.Items.RemoveAt(chkTortillas.Checked)
            total = total - 1.0
            txtTotal.Text = total
        End If
    End Sub

    Private Sub chkTajadas_CheckedChanged(sender As Object, e As EventArgs) Handles chkTajadas.CheckedChanged
        Precio = 10.0
        If chkTajadas.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkTajadas.Text)
        ElseIf chkTajadas.Checked = False Then
            list1.Items.RemoveAt(chkTajadas.Checked)
            total = total - 10.0
            txtTotal.Text = total
        End If
    End Sub

    Private Sub chkEnsalada_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnsalada.CheckedChanged
        Precio = 25.0
        If chkEnsalada.Checked = True Then
            txtTotal.Text = Precio
            total = total + Val(txtTotal.Text)
            txtTotal.Text = total
            list1.Items.Add(chkEnsalada.Text)
        ElseIf chkEnsalada.Checked = False Then
            list1.Items.RemoveAt(chkEnsalada.Checked)
            total = total - 25.0
            txtTotal.Text = total
        End If
    End Sub

    Private Sub txtCod_Validating(sender As Object, e As CancelEventArgs) Handles txtCod.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorFactura.SetError(sender, "")
        Else
            Me.ErrorFactura.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip1.SetToolTip(txtNombre, "Ingrese el nombre")
        ToolTip1.ToolTipTitle = "Nombre"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtHora_MouseHover(sender As Object, e As EventArgs) Handles txtHora.MouseHover
        ToolTip1.SetToolTip(txtHora, "Ingrese la hora del pedido")
        ToolTip1.ToolTipTitle = "Hora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        chkArroz.Checked = False
        chkBaleadas.Checked = False
        chkChuleta.Checked = False
        chkPastel.Checked = False
        chkPollo.Checked = False
        chkHam.Checked = False
        chkSopa.Checked = False
        chkTacos.Checked = False
        chkPupusas.Checked = False
        chkArroz.Enabled = True
        chkHam.Enabled = True
        chkBaleadas.Enabled = True
        chkChuleta.Enabled = True
        chkPastel.Enabled = True
        chkPollo.Enabled = True
        chkPupusas.Enabled = True
        chkSopa.Enabled = True
        chkTacos.Enabled = True
        chkPapas.Checked = False
        chkHuevo.Checked = False
        chkCarne.Checked = False
        chkTortillas.Checked = False
        chkTajadas.Checked = False
        chkAguacate.Checked = False
        chkChapsui.Checked = False
        chkEnsalada.Checked = False
        txtTotal.Clear()
        txtCod.Clear()
        txtHora.Clear()
        txtNombre.Clear()
        txtbebida.Clear()
        txtCantidad.Clear()
        list1.Clear()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Fresco, totalPagar, totalB, precio As Integer

            Fresco = txtCantidad.Text
            For i = 1 To Fresco Step 1
                Precio = InputBox("Ingrese el precio de las bebidas: " & i, "Bebidas")
                totalPagar += Precio
            Next
            totalB = Fresco * precio
            txtbebida.Text = totalB
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCod_MouseHover(sender As Object, e As EventArgs) Handles txtCod.MouseHover
        ToolTip1.SetToolTip(txtCod, "Ingrese el codigo de factura")
        ToolTip1.ToolTipTitle = "Código"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
