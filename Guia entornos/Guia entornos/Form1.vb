Public Class Form1
    Private Sub Pcalculadora_Click(sender As Object, e As EventArgs) Handles Pcalculadora.Click
        Calculadora.Show()
        Me.Hide()
    End Sub
    Private Sub Pcalculadora_MouseHover(sender As Object, e As EventArgs) Handles Pcalculadora.MouseHover
        ToolTip1.SetToolTip(Pcalculadora, "Clic si desea hacer operaciones")
        ToolTip1.ToolTipTitle = "Calculadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Pformula_Click(sender As Object, e As EventArgs) Handles Pformula.Click
        Formula.Show()
        Me.Hide()
    End Sub

    Private Sub Pformula_MouseHover(sender As Object, e As EventArgs) Handles Pformula.MouseHover
        ToolTip2.SetToolTip(Pformula, "Fórmula Cuadrática")
        ToolTip2.ToolTipTitle = "Fórmula"
        ToolTip2.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Palmacen_Click(sender As Object, e As EventArgs) Handles Palmacen.Click
        Almacen.Show()
        Me.Hide()
    End Sub

    Private Sub Palmacen_MouseHover(sender As Object, e As EventArgs) Handles Palmacen.MouseHover
        ToolTip3.SetToolTip(Palmacen, "Ventas mensuales")
        ToolTip3.ToolTipTitle = "Almacén"
        ToolTip3.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub PNumero_Click(sender As Object, e As EventArgs) Handles PNumero.Click
        Numeros.Show()
        Me.Hide()
    End Sub

    Private Sub PNumero_MouseHover(sender As Object, e As EventArgs) Handles PNumero.MouseHover
        ToolTip4.SetToolTip(PNumero, "Ordenamiento de números")
        ToolTip4.ToolTipTitle = "Números"
        ToolTip4.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Pdeduccion_Click(sender As Object, e As EventArgs) Handles Pdeduccion.Click
        Deduccion.Show()
        Me.Hide()
    End Sub

    Private Sub Pdeduccion_MouseHover(sender As Object, e As EventArgs) Handles Pdeduccion.MouseHover
        ToolTip5.SetToolTip(Pdeduccion, "Deducción de empleados")
        ToolTip5.ToolTipTitle = "Deducciones"
        ToolTip5.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
