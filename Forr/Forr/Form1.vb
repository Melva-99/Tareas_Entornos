Public Class Form1
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

        Dim b As Integer
        Dim asterisco As String

        txtmostrar.Text = Len(txtNombre.Text)

        For b = 0 To txtmostrar.Text Step 1
            asterisco = ("*")
            Continue For

            txtmostrar.Text = (txtNombre.Text)
        Next

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
