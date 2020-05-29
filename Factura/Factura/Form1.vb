Public Class Form1
    Dim Descuento As Double
    Dim ISV As Double
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click


        If txtPrecio.Text = "" Then
            MsgBox("Casilla Vacía", vbInformation)
            chkdescuento.Checked = False
            chkISV.Checked = False
        ElseIf Not IsNumeric(txtPrecio.Text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtPrecio.Text = ""
            chkdescuento.Checked = False
            chkISV.Checked = False
        ElseIf IsNumeric(Val(txtPrecio.Text)) Then
            If txtPrecio.Text <= 0 Then
                MsgBox("Ingrese datos que se puedan calcular")
                txtPrecio.Text = ""
                chkdescuento.Checked = False
                chkISV.Checked = False
            End If
        End If

        If txtCantidad.Text = "" Then
            MsgBox("Casilla Vacía", vbInformation)
            chkdescuento.Checked = False
            chkISV.Checked = False
        ElseIf Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Ingrese un valor númerico", vbInformation)
            txtCantidad.Text = ""
            chkdescuento.Checked = False
            chkISV.Checked = False
        ElseIf IsNumeric(Val(txtCantidad.text)) Then
            If txtCantidad.Text <= 0 Then
                MsgBox("Ingrese datos que se puedan calcular")
                txtCantidad.Text = ""
                chkdescuento.Checked = False
                chkISV.Checked = False
            End If
        End If

        If txtPrecio.Text = "" Then

        ElseIf txtCantidad.Text = "" Then

        Else
            txtSubT.Text = txtPrecio.Text * txtCantidad.Text

            If chkdescuento.Checked = True Then
                txtDescuento.Text = txtSubT.Text * Descuento
                txtTotal.Text = txtSubT.Text - (txtSubT.Text * Descuento)
                txtISV.Text = ""
            ElseIf chkISV.Checked = True Then
                txtISV.Text = txtSubT.Text * ISV
                txtTotal.Text = (txtSubT.Text) + (txtSubT.Text * ISV)
                txtDescuento.Text = ""
            End If
            btnNew.Enabled = True
        End If

    End Sub

    Private Sub chkdescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkdescuento.CheckedChanged
        If chkdescuento.Checked = True Then
            CmbDesc.Enabled = True
            chkISV.Enabled = False
        ElseIf chkdescuento.Checked = False Then
            CmbDesc.Enabled = False
            chkISV.Enabled = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbDesc.Enabled = False
        cmbISV.Enabled = False
        btnNew.Enabled = False
    End Sub

    Private Sub CmbDesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDesc.SelectedIndexChanged

        If CmbDesc.Text = "Estudiantil" Then
            Descuento = 0.1
        ElseIf CmbDesc.Text = "Tercera Edad" Then
            Descuento = 0.15
        ElseIf CmbDesc.Text = "Mayorista" Then
            Descuento = 0.3
        ElseIf CmbDesc.Text = "Empleados" Then
            Descuento = 0.2
        ElseIf CmbDesc.Text = "Pronto Pago" Then
            Descuento = 0.08
        ElseIf CmbDesc.Text = "Comercial" Then
            Descuento = 0.05
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtPrecio.Clear()
        txtCantidad.Clear()
        chkISV.Checked = False
        chkdescuento.Checked = False
        txtSubT.Clear()
        txtTotal.Clear()
        txtISV.Clear()
        txtDescuento.Clear()
        btnNew.Enabled = False

    End Sub

    Private Sub chkISV_CheckedChanged(sender As Object, e As EventArgs) Handles chkISV.CheckedChanged
        If chkISV.Checked = True Then
            cmbISV.Enabled = True
            chkdescuento.Enabled = False
        ElseIf chkISV.Checked = False Then
            cmbISV.Enabled = False
            chkdescuento.Enabled = True
        End If
    End Sub

    Private Sub cmbISV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbISV.SelectedIndexChanged
        If cmbISV.Text = "15%" Then
            ISV = 0.15
        ElseIf cmbISV.Text = "17%" Then
            ISV = 0.17
        End If
    End Sub
End Class
