Imports System.Windows

Public Class Form1
    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Dim pasar As New IntroProductoBAse
        pasar.Show()
        Hide()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Dim pasar As New ver
        pasar.Show()
        Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pasar As New editar
        pasar.Show()
        Hide()
    End Sub
End Class
