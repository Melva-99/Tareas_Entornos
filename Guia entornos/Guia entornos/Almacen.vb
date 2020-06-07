Public Class Almacen
    Dim almacen1, almacen2, almacen3, almacen4, almacen5, almacen6, almacen7, almacen9, almacen8, almacen10, media As Double


    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cmbAlmacen.Text = ""
        txtVM.Clear()
        txtM.Clear()
        ltSmedia.Items.Clear()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        ltSmedia.Items.Clear()
        txtM.Text = media
        If txtM.Text < almacen1 Then
            ltSmedia.Items.Add("Almacén Pájaro Azul")
        End If
        If txtM.Text < almacen2 Then
            ltSmedia.Items.Add("Ferretería Javier")
        End If
        If txtM.Text < almacen3 Then
            ltSmedia.Items.Add("Almacén La Chela")
        End If
        If txtM.Text < almacen4 Then
            ltSmedia.Items.Add("Dinant")
        End If
        If txtM.Text < almacen5 Then
            ltSmedia.Items.Add("Pulpería El flaco")
        End If
        If txtM.Text < almacen6 Then
            ltSmedia.Items.Add("Tienda La Confianza")
        End If
        If txtM.Text < almacen7 Then
            ltSmedia.Items.Add("Confitería")
        End If
        If txtM.Text < almacen8 Then
            ltSmedia.Items.Add("Comercial Lainez")
        End If
        If txtM.Text < almacen9 Then
            ltSmedia.Items.Add("Variedades Los dos hermanos")
        End If
        If txtM.Text < almacen10 Then
            ltSmedia.Items.Add("Mangy´s Store")
        End If

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If Me.ValidateChildren And IsNumeric(txtVM.Text) And Val(txtVM.Text) >= 0 Then
                If cmbAlmacen.SelectedItem = "" Then
                    MsgBox("Debe seleccionar el almacén")
                ElseIf cmbAlmacen.Text = "Almacén Pájaro Azul" Then
                    almacen1 = Val(txtVM.Text)
                    txtVM.Text = ""
                ElseIf cmbAlmacen.Text = "Ferretería Javier" Then
                    almacen2 = Val(txtVM.Text)
                    txtVM.Text = ""
                ElseIf cmbAlmacen.Text = "Almacén La Chela" Then
                    almacen3 = Val(txtVM.Text)
                    txtVM.Clear()
                ElseIf cmbAlmacen.Text = "Dinant" Then
                    almacen4 = Val(txtVM.Text)
                    txtVM.Clear()
                ElseIf cmbAlmacen.Text = "Pulpería El flaco" Then
                    almacen5 = Val(txtVM.Text)
                    txtVM.Clear()
                ElseIf cmbAlmacen.Text = "Tienda La Confianza" Then
                    almacen6 = Val(txtVM.Text)
                    txtVM.Clear()
                ElseIf cmbAlmacen.Text = "Confitería" Then
                    almacen7 = Val(txtVM.Text)
                    txtVM.Clear()
                ElseIf cmbAlmacen.Text = "Comercial Lainez" Then
                    almacen8 = Val(txtVM.Text)
                    txtVM.Clear()
                ElseIf cmbAlmacen.Text = "Variedades Los dos hermanos" Then
                    almacen9 = Val(txtVM.Text)
                    txtVM.Clear()
                ElseIf cmbAlmacen.Text = "Mangy´s Store" Then
                    almacen10 = Val(txtVM.Text)
                    txtVM.Clear()
                End If
                media = (almacen1 + almacen2 + almacen3 + almacen4 + almacen5 + almacen6 + almacen7 + almacen9 + almacen8 + almacen10) / 10
            Else
                MessageBox.Show("Ingrese datos numéricos y números positivos")
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class