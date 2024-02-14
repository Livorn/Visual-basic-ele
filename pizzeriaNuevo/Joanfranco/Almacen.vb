Imports MySql.Data.MySqlClient

Public Class Almacen
    Dim server = "localhost"
    Dim user = "root"
    Dim pwd = "12345"
    Dim database = "pizzeria"
    Dim cadenaConexion = "server=" & server & ";user=" & user & ";pwd=" & pwd & ";database=" & database & ";SslMode=none;"
    Dim myCom = New MySqlConnection(cadenaConexion)
    Private Sub buttonSubir_Click(sender As Object, e As EventArgs) Handles buttonSubir.Click


        Try
            myCom.Open()

            Dim query = "INSERT into almacen" & "(Id, Nombre, Categoria, Cantidad, Precio, FechaDeCompra, FechaDeExp) VALUES" & " ('" & TxtID.Text & "','" & TxtBoxNombre.Text & "','" & TxtBoxDescripcion.Text & "','" & TxtBoxCategoria.Text & "','" & TxtBoxPrecio.Text & "','" & fechadcompra.Text & "','" & expdata.Text & "')"
            Dim comando = New MySqlCommand(query, myCom)
            Dim reader = comando.ExecuteReader()
            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myCom.Close()
        End Try
        LimpiarFormulario()
    End Sub

    Private Sub LimpiarFormulario()
        TxtID.Text = ""
        TxtBoxNombre.Text = ""
        TxtBoxDescripcion.Text = ""
        TxtBoxCategoria.Text = ""
        TxtBoxPrecio.Text = ""
        fechadcompra.Text = ""
        expdata.Text = ""

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New Form1
        frm.Show()
        Dim ocultar As New Almacen
        ocultar.Hide()
    End Sub
End Class