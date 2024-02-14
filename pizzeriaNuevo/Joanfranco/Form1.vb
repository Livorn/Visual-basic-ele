Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles Factura.Click
        Dim frm As New Factura
        frm.Show()

    End Sub

    Private Sub Almacen_Click(sender As Object, e As EventArgs) Handles Almacen.Click
        Dim frm As New Almacen
        frm.Show()
    End Sub

    Private Sub Administrador_Click(sender As Object, e As EventArgs) Handles Administrador.Click
        Dim frm As New Administrador
        frm.Show()

    End Sub
End Class
