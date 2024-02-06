Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class IntroProductoBAse

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
    Private Sub IntroProductoBAse_Load(sender As Object, e As EventArgs)

    End Sub


    Private Sub regresar_Click(sender As Object, e As EventArgs)
        Dim pasar As New Form1
        pasar.Show()
        Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar()
    End Sub

    Private Sub IntroProductoBAse_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class