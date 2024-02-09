Public Class Form1

    Dim cantidad As Integer
    Dim pizzas As New Dictionary(Of String, Double) From {{"Margarita", 25}, {"Napolitana", 30}, {"Hawai", 35}}
    Dim bebidas As New Dictionary(Of String, Double) From {{"Agua", 2}, {"CocaCola", 3}, {"Pepsi", 2.5}}

    Private Sub LimpiarFormulario()
        ListBoxDescripcion.Items.Clear()
        ListBoxCant.Items.Clear()
        ListBoxSubTotal.Items.Clear()
        TextBoxTotal.Text = ""
        TextBoxIVA.Text = ""
        TextBoxNEtoaCancelar.Text = ""
        TextBoxCliente.Text = ""
        TextBoxTLF.Text = ""
        TextBoxDireccion.Text = ""
        RadioButtondebito.Checked = False
        RadioButtonCredito.Checked = False
    End Sub

    Private Sub CalcularTotales()
        Dim total As Double = 0
        For Each item As Double In ListBoxSubTotal.Items
            total += item
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxPizza.Items.AddRange(New String() {"Margarita", "Napolitana", "Hawai"})
        TextBoxNroPedido.Text = 0
        ComboBoxBebida.Items.AddRange(New String() {"Agua", "CocaCola", "Pepsi"})
    End Sub

    Private Sub ButtonNuevoPedido_Click(sender As Object, e As EventArgs) Handles ButtonNuevoPedido.Click

        TextBoxNroPedido.Text = CInt(TextBoxNroPedido.Text) + 1

        LimpiarFormulario()

    End Sub


    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Application.Exit()
    End Sub

    Private Sub ButtonAgregarAlPedido_Click(sender As Object, e As EventArgs) Handles ButtonAgregarAlPedido.Click
        Dim pizzaSeleccionada As String = ComboBoxPizza.SelectedItem.ToString()
        Dim inputPizza As String = InputBox("¿Cuántas pizzas " & pizzaSeleccionada & " quieres?", "Pedido de pizza")
        If String.IsNullOrEmpty(inputPizza) Then Return
        Dim cantidadPizza As Integer = Integer.Parse(inputPizza)
        ListBoxDescripcion.Items.Add(pizzaSeleccionada)
        ListBoxCant.Items.Add(cantidadPizza)
        Dim subtotalPizza As Double = cantidadPizza * pizzas(pizzaSeleccionada)
        ListBoxSubTotal.Items.Add(subtotalPizza)

        Dim bebidaSeleccionada As String = ComboBoxBebida.SelectedItem.ToString()
        Dim inputBebida As String = InputBox("¿Cuántas " & bebidaSeleccionada & " quieres?", "Pedido de bebida")
        If String.IsNullOrEmpty(inputBebida) Then Return
        Dim cantidadBebida As Integer = Integer.Parse(inputBebida)
        ListBoxDescripcion.Items.Add(bebidaSeleccionada)
        ListBoxCant.Items.Add(cantidadBebida)
        Dim subtotalBebida As Double = cantidadBebida * bebidas(bebidaSeleccionada)
        ListBoxSubTotal.Items.Add(subtotalBebida)

        CalcularTotales()
    End Sub
End Class
