Public Class editar
    Private Sub regresar_Click_1(sender As Object, e As EventArgs) Handles regresar.Click
        Dim pasar As New Form1
        pasar.Show()
        Hide()
    End Sub

    Private Sub Limpiar()
        Nombre.Text = ""
        Precio.Text = ""
        Tipo.Text = ""
        Categoria.Text = ""
        Ubicacion.Text = ""
        Color.Text = ""
        Cantidad.Text = ""

    End Sub
    Private Sub regresar_Click(sender As Object, e As EventArgs)
        Dim pasar As New Form1
        pasar.Show()
        Hide()
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        Limpiar()
    End Sub
End Class