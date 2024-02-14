Imports MySql.Data.MySqlClient

Public Class Factura

    Dim server = "localhost"
    Dim user = "root"
    Dim pwd = "12345"
    Dim database = "pizzeria"
    Dim cadenaConexion = "server=" & server & ";user=" & user & ";pwd=" & pwd & ";database=" & database & ";SslMode=none;"
    Dim myCom = New MySqlConnection(cadenaConexion)
    Dim cantidad As Integer
    Dim pizzas As New Dictionary(Of String, Double) From {{"Margarita", 25}, {"Napolitana", 30}, {"Hawai", 35}}
    Dim bebidas As New Dictionary(Of String, Double) From {{"Agua", 2}, {"CocaCola", 3}, {"Pepsi", 2.5}}

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxPizza.Items.AddRange(New String() {"Margarita", "Napolitana", "Hawai"})
        TextBoxNroPedido.Text = 0
        ComboBoxBebida.Items.AddRange(New String() {"Agua", "CocaCola", "Pepsi"})
    End Sub
    Private Sub LimpiarFormulario()
        TextBoxDescripcion.Text = ""
        TextBoxCant.Text = ""
        TextBoxSubTotal.Text = ""
        TextBoxTotal.Text = ""
        TextBoxIVA.Text = ""
        TextBoxNEtoaCancelar.Text = ""
        TextBoxCliente.Text = ""
        TextBoxTLF.Text = ""
        TextBoxDireccion.Text = ""
        RadioButtondebito.Checked = False
        RadioButtonCredito.Checked = False
        RadioButtonEfectivo.Checked = False
    End Sub

    Private Sub CalcularTotales()
        Dim total As Double = 0
        Dim numer = TextBoxSubTotal.Text
        Dim subTotales As String() = numer.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        For Each item As String In subTotales
            total += Double.Parse(item)
        Next
        Dim iva As Double = total * 0.12
        Dim netoACancelar As Double = total + iva
        If RadioButtondebito.Checked Then
            netoACancelar *= 0.9
        End If
        TextBoxTotal.Text = total.ToString("F2")
        TextBoxIVA.Text = iva.ToString("F2")
        TextBoxNEtoaCancelar.Text = netoACancelar.ToString("F2")
    End Sub



    'Labelres.Text = "conexion exitosa"
    Private Sub ButtonNuevoPedido_Click(sender As Object, e As EventArgs) Handles ButtonNuevoPedido.Click
        Dim metodoDePago As String
        If RadioButtonEfectivo.Checked Then
            metodoDePago = RadioButtonEfectivo.Text
        ElseIf RadioButtondebito.Checked Then
            metodoDePago = RadioButtondebito.Text
        Else
            metodoDePago = RadioButtonCredito.Text
        End If

        Try
            myCom.Open()
            Labelres.Text = "conexion exitosa"
            Dim query = "INSERT into factura" & "(Pedido, Cliente, Telefono, Direccion, MetodoDePago, Descripcion, Cantidad, Subtotal, Total, Iva, Neto_a_Cancelar) VALUES" & " ('" & TextBoxNroPedido.Text & "','" & TextBoxCliente.Text & "','" & TextBoxTLF.Text & "','" & TextBoxDireccion.Text & "','" & metodoDePago & "','" & TextBoxDescripcion.Text & "','" & TextBoxCant.Text & "','" & TextBoxSubTotal.Text & "','" & TextBoxTotal.Text & "','" & TextBoxIVA.Text & "','" & TextBoxNEtoaCancelar.Text & "')"
            Dim comando = New MySqlCommand(query, myCom)
            Dim reader = comando.ExecuteReader()
            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myCom.Close()
        End Try


        TextBoxNroPedido.Text = CInt(TextBoxNroPedido.Text) + 1

        LimpiarFormulario()

    End Sub


    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Dim frm As New Form1
        frm.Show()

    End Sub

    Private Sub ButtonAgregarAlPedido_Click(sender As Object, e As EventArgs) Handles ButtonAgregarAlPedido.Click
        Dim pizzaSeleccionada As String = ComboBoxPizza.SelectedItem.ToString()
        Dim inputPizza As String = InputBox("¿Cuántas pizzas " & pizzaSeleccionada & " quieres?", "Pedido de pizza")
        If String.IsNullOrEmpty(inputPizza) Then Return
        Dim cantidadPizza As Integer = Integer.Parse(inputPizza)
        TextBoxDescripcion.Text += pizzaSeleccionada & Environment.NewLine
        TextBoxCant.Text += cantidadPizza.ToString() & Environment.NewLine
        Dim subtotalPizza As Double = cantidadPizza * pizzas(pizzaSeleccionada)
        TextBoxSubTotal.Text += subtotalPizza.ToString() & Environment.NewLine

        Dim bebidaSeleccionada As String = ComboBoxBebida.SelectedItem.ToString()
        Dim inputBebida As String = InputBox("¿Cuántas " & bebidaSeleccionada & " quieres?", "Pedido de bebida")
        If String.IsNullOrEmpty(inputBebida) Then Return
        Dim cantidadBebida As Integer = Integer.Parse(inputBebida)
        TextBoxDescripcion.Text += bebidaSeleccionada & Environment.NewLine
        TextBoxCant.Text += cantidadBebida.ToString() & Environment.NewLine
        Dim subtotalBebida As Double = cantidadBebida * bebidas(bebidaSeleccionada)
        TextBoxSubTotal.Text += subtotalBebida.ToString() & Environment.NewLine

        CalcularTotales()
    End Sub

End Class