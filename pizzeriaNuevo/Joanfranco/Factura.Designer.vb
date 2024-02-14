<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBoxSubTotal = New TextBox()
        TextBoxCant = New TextBox()
        TextBoxDescripcion = New TextBox()
        ButtonAgregarAlPedido = New Button()
        ListBoxDescripcion = New ListBox()
        ListBoxSubTotal = New ListBox()
        ListBoxCant = New ListBox()
        Label16 = New Label()
        Label15 = New Label()
        Panel2 = New Panel()
        ComboBoxBebida = New ComboBox()
        Label12 = New Label()
        Label13 = New Label()
        TextBoxprecioB = New TextBox()
        Label14 = New Label()
        GroupBox1 = New GroupBox()
        RadioButtonEfectivo = New RadioButton()
        RadioButtonCredito = New RadioButton()
        RadioButtondebito = New RadioButton()
        Panel1 = New Panel()
        ComboBoxPizza = New ComboBox()
        Label11 = New Label()
        Label10 = New Label()
        TextBoxprecio = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TextBoxNEtoaCancelar = New TextBox()
        TextBoxIVA = New TextBox()
        TextBoxTotal = New TextBox()
        TextBoxDireccion = New TextBox()
        TextBoxTLF = New TextBox()
        TextBoxCliente = New TextBox()
        TextBoxNroPedido = New TextBox()
        ButtonSalir = New Button()
        ButtonNuevoPedido = New Button()
        Label1 = New Label()
        TextBoxPizza = New TextBox()
        Panel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBoxSubTotal
        ' 
        TextBoxSubTotal.Enabled = False
        TextBoxSubTotal.Location = New Point(220, 207)
        TextBoxSubTotal.Multiline = True
        TextBoxSubTotal.Name = "TextBoxSubTotal"
        TextBoxSubTotal.Size = New Size(84, 124)
        TextBoxSubTotal.TabIndex = 70
        ' 
        ' TextBoxCant
        ' 
        TextBoxCant.Enabled = False
        TextBoxCant.Location = New Point(175, 207)
        TextBoxCant.Multiline = True
        TextBoxCant.Name = "TextBoxCant"
        TextBoxCant.Size = New Size(39, 124)
        TextBoxCant.TabIndex = 69
        ' 
        ' TextBoxDescripcion
        ' 
        TextBoxDescripcion.Enabled = False
        TextBoxDescripcion.Location = New Point(22, 207)
        TextBoxDescripcion.Multiline = True
        TextBoxDescripcion.Name = "TextBoxDescripcion"
        TextBoxDescripcion.Size = New Size(147, 124)
        TextBoxDescripcion.TabIndex = 68
        ' 
        ' ButtonAgregarAlPedido
        ' 
        ButtonAgregarAlPedido.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonAgregarAlPedido.Location = New Point(250, 146)
        ButtonAgregarAlPedido.Name = "ButtonAgregarAlPedido"
        ButtonAgregarAlPedido.Size = New Size(127, 28)
        ButtonAgregarAlPedido.TabIndex = 66
        ButtonAgregarAlPedido.Text = "Agregar pedido"
        ButtonAgregarAlPedido.UseVisualStyleBackColor = True
        ' 
        ' ListBoxDescripcion
        ' 
        ListBoxDescripcion.FormattingEnabled = True
        ListBoxDescripcion.ItemHeight = 15
        ListBoxDescripcion.Location = New Point(22, 207)
        ListBoxDescripcion.Name = "ListBoxDescripcion"
        ListBoxDescripcion.Size = New Size(147, 124)
        ListBoxDescripcion.TabIndex = 65
        ' 
        ' ListBoxSubTotal
        ' 
        ListBoxSubTotal.FormattingEnabled = True
        ListBoxSubTotal.ItemHeight = 15
        ListBoxSubTotal.Location = New Point(220, 207)
        ListBoxSubTotal.Name = "ListBoxSubTotal"
        ListBoxSubTotal.Size = New Size(84, 124)
        ListBoxSubTotal.TabIndex = 64
        ' 
        ' ListBoxCant
        ' 
        ListBoxCant.FormattingEnabled = True
        ListBoxCant.ItemHeight = 15
        ListBoxCant.Location = New Point(175, 207)
        ListBoxCant.Name = "ListBoxCant"
        ListBoxCant.Size = New Size(39, 124)
        ListBoxCant.TabIndex = 63
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(220, 183)
        Label16.Name = "Label16"
        Label16.Size = New Size(68, 21)
        Label16.TabIndex = 62
        Label16.Text = "Subtotal"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(175, 183)
        Label15.Name = "Label15"
        Label15.Size = New Size(45, 21)
        Label15.TabIndex = 61
        Label15.Text = "Cant."
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(ComboBoxBebida)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(TextBoxprecioB)
        Panel2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Panel2.Location = New Point(365, 39)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(241, 101)
        Panel2.TabIndex = 60
        ' 
        ' ComboBoxBebida
        ' 
        ComboBoxBebida.FormattingEnabled = True
        ComboBoxBebida.Location = New Point(3, 30)
        ComboBoxBebida.Name = "ComboBoxBebida"
        ComboBoxBebida.Size = New Size(131, 25)
        ComboBoxBebida.TabIndex = 35
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(168, 12)
        Label12.Name = "Label12"
        Label12.Size = New Size(44, 17)
        Label12.TabIndex = 29
        Label12.Text = "Precio"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(3, 12)
        Label13.Name = "Label13"
        Label13.Size = New Size(48, 17)
        Label13.TabIndex = 28
        Label13.Text = "Bebida"
        ' 
        ' TextBoxprecioB
        ' 
        TextBoxprecioB.Enabled = False
        TextBoxprecioB.Location = New Point(156, 30)
        TextBoxprecioB.Multiline = True
        TextBoxprecioB.Name = "TextBoxprecioB"
        TextBoxprecioB.Size = New Size(64, 66)
        TextBoxprecioB.TabIndex = 27
        TextBoxprecioB.Text = "2" & vbCrLf & "3" & vbCrLf & "2,5" & vbCrLf & vbCrLf
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(365, 12)
        Label14.Name = "Label14"
        Label14.Size = New Size(61, 25)
        Label14.TabIndex = 59
        Label14.Text = "Menu"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButtonEfectivo)
        GroupBox1.Controls.Add(RadioButtonCredito)
        GroupBox1.Controls.Add(RadioButtondebito)
        GroupBox1.Cursor = Cursors.Hand
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(310, 327)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(143, 98)
        GroupBox1.TabIndex = 57
        GroupBox1.TabStop = False
        GroupBox1.Text = "Metodo de Pago"
        ' 
        ' RadioButtonEfectivo
        ' 
        RadioButtonEfectivo.AutoSize = True
        RadioButtonEfectivo.Location = New Point(18, 71)
        RadioButtonEfectivo.Name = "RadioButtonEfectivo"
        RadioButtonEfectivo.Size = New Size(82, 25)
        RadioButtonEfectivo.TabIndex = 5
        RadioButtonEfectivo.TabStop = True
        RadioButtonEfectivo.Text = "Efectivo"
        RadioButtonEfectivo.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonCredito
        ' 
        RadioButtonCredito.AutoSize = True
        RadioButtonCredito.Location = New Point(18, 46)
        RadioButtonCredito.Name = "RadioButtonCredito"
        RadioButtonCredito.Size = New Size(79, 25)
        RadioButtonCredito.TabIndex = 4
        RadioButtonCredito.TabStop = True
        RadioButtonCredito.Text = "Credito"
        RadioButtonCredito.UseVisualStyleBackColor = True
        ' 
        ' RadioButtondebito
        ' 
        RadioButtondebito.AutoSize = True
        RadioButtondebito.Location = New Point(18, 22)
        RadioButtondebito.Name = "RadioButtondebito"
        RadioButtondebito.Size = New Size(74, 25)
        RadioButtondebito.TabIndex = 3
        RadioButtondebito.TabStop = True
        RadioButtondebito.Text = "Debito"
        RadioButtondebito.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(ComboBoxPizza)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(TextBoxprecio)
        Panel1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Panel1.Location = New Point(25, 39)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(241, 101)
        Panel1.TabIndex = 56
        ' 
        ' ComboBoxPizza
        ' 
        ComboBoxPizza.FormattingEnabled = True
        ComboBoxPizza.Location = New Point(3, 30)
        ComboBoxPizza.Name = "ComboBoxPizza"
        ComboBoxPizza.Size = New Size(131, 25)
        ComboBoxPizza.TabIndex = 34
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(168, 12)
        Label11.Name = "Label11"
        Label11.Size = New Size(44, 17)
        Label11.TabIndex = 29
        Label11.Text = "Precio"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(3, 12)
        Label10.Name = "Label10"
        Label10.Size = New Size(37, 17)
        Label10.TabIndex = 28
        Label10.Text = "Pizza"
        ' 
        ' TextBoxprecio
        ' 
        TextBoxprecio.Enabled = False
        TextBoxprecio.Location = New Point(156, 30)
        TextBoxprecio.Multiline = True
        TextBoxprecio.Name = "TextBoxprecio"
        TextBoxprecio.Size = New Size(64, 66)
        TextBoxprecio.TabIndex = 27
        TextBoxprecio.Text = "25" & vbCrLf & "30" & vbCrLf & "35"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(22, 183)
        Label9.Name = "Label9"
        Label9.Size = New Size(91, 21)
        Label9.TabIndex = 55
        Label9.Text = "Descripción"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(328, 288)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 21)
        Label8.TabIndex = 54
        Label8.Text = "Dirección:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(328, 259)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 21)
        Label7.TabIndex = 53
        Label7.Text = "Teléfono:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(328, 230)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 21)
        Label6.TabIndex = 52
        Label6.Text = "Cliente:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(328, 201)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 21)
        Label5.TabIndex = 51
        Label5.Text = "Nro. Pedido:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 410)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 15)
        Label4.TabIndex = 50
        Label4.Text = "Neto a Cancelar:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(49, 382)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 49
        Label3.Text = "I.V.A. (12%):"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(84, 352)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 48
        Label2.Text = "Total:"
        ' 
        ' TextBoxNEtoaCancelar
        ' 
        TextBoxNEtoaCancelar.Enabled = False
        TextBoxNEtoaCancelar.Location = New Point(125, 407)
        TextBoxNEtoaCancelar.Name = "TextBoxNEtoaCancelar"
        TextBoxNEtoaCancelar.Size = New Size(104, 23)
        TextBoxNEtoaCancelar.TabIndex = 47
        ' 
        ' TextBoxIVA
        ' 
        TextBoxIVA.Enabled = False
        TextBoxIVA.Location = New Point(125, 378)
        TextBoxIVA.Name = "TextBoxIVA"
        TextBoxIVA.Size = New Size(104, 23)
        TextBoxIVA.TabIndex = 46
        ' 
        ' TextBoxTotal
        ' 
        TextBoxTotal.Enabled = False
        TextBoxTotal.Location = New Point(125, 349)
        TextBoxTotal.Name = "TextBoxTotal"
        TextBoxTotal.Size = New Size(104, 23)
        TextBoxTotal.TabIndex = 45
        ' 
        ' TextBoxDireccion
        ' 
        TextBoxDireccion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxDireccion.Location = New Point(406, 288)
        TextBoxDireccion.Name = "TextBoxDireccion"
        TextBoxDireccion.Size = New Size(200, 29)
        TextBoxDireccion.TabIndex = 44
        ' 
        ' TextBoxTLF
        ' 
        TextBoxTLF.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxTLF.Location = New Point(401, 259)
        TextBoxTLF.Name = "TextBoxTLF"
        TextBoxTLF.Size = New Size(173, 29)
        TextBoxTLF.TabIndex = 43
        ' 
        ' TextBoxCliente
        ' 
        TextBoxCliente.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxCliente.Location = New Point(393, 230)
        TextBoxCliente.Name = "TextBoxCliente"
        TextBoxCliente.Size = New Size(213, 29)
        TextBoxCliente.TabIndex = 42
        ' 
        ' TextBoxNroPedido
        ' 
        TextBoxNroPedido.Enabled = False
        TextBoxNroPedido.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxNroPedido.Location = New Point(428, 201)
        TextBoxNroPedido.Name = "TextBoxNroPedido"
        TextBoxNroPedido.Size = New Size(142, 29)
        TextBoxNroPedido.TabIndex = 41
        ' 
        ' ButtonSalir
        ' 
        ButtonSalir.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonSalir.Location = New Point(459, 378)
        ButtonSalir.Name = "ButtonSalir"
        ButtonSalir.Size = New Size(148, 28)
        ButtonSalir.TabIndex = 40
        ButtonSalir.Text = "Salir"
        ButtonSalir.UseVisualStyleBackColor = True
        ' 
        ' ButtonNuevoPedido
        ' 
        ButtonNuevoPedido.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonNuevoPedido.Location = New Point(459, 344)
        ButtonNuevoPedido.Name = "ButtonNuevoPedido"
        ButtonNuevoPedido.Size = New Size(148, 28)
        ButtonNuevoPedido.TabIndex = 39
        ButtonNuevoPedido.Text = "Nuevo Pedido"
        ButtonNuevoPedido.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(25, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 21)
        Label1.TabIndex = 38
        Label1.Text = "Menu"
        ' 
        ' TextBoxPizza
        ' 
        TextBoxPizza.Location = New Point(25, 216)
        TextBoxPizza.Multiline = True
        TextBoxPizza.Name = "TextBoxPizza"
        TextBoxPizza.Size = New Size(131, 66)
        TextBoxPizza.TabIndex = 58
        TextBoxPizza.Text = "Margarita" & vbCrLf & "Napolitana" & vbCrLf & "Hawai"
        ' 
        ' Factura
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(634, 450)
        Controls.Add(TextBoxSubTotal)
        Controls.Add(TextBoxCant)
        Controls.Add(TextBoxDescripcion)
        Controls.Add(ButtonAgregarAlPedido)
        Controls.Add(ListBoxDescripcion)
        Controls.Add(ListBoxSubTotal)
        Controls.Add(ListBoxCant)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Panel2)
        Controls.Add(Label14)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBoxNEtoaCancelar)
        Controls.Add(TextBoxIVA)
        Controls.Add(TextBoxTotal)
        Controls.Add(TextBoxDireccion)
        Controls.Add(TextBoxTLF)
        Controls.Add(TextBoxCliente)
        Controls.Add(TextBoxNroPedido)
        Controls.Add(ButtonSalir)
        Controls.Add(ButtonNuevoPedido)
        Controls.Add(Label1)
        Controls.Add(TextBoxPizza)
        Name = "Factura"
        Text = "Factura"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxSubTotal As TextBox
    Friend WithEvents TextBoxCant As TextBox
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents ButtonAgregarAlPedido As Button
    Friend WithEvents ListBoxDescripcion As ListBox
    Friend WithEvents ListBoxSubTotal As ListBox
    Friend WithEvents ListBoxCant As ListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBoxBebida As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxprecioB As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonEfectivo As RadioButton
    Friend WithEvents RadioButtonCredito As RadioButton
    Friend WithEvents RadioButtondebito As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxPizza As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxprecio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNEtoaCancelar As TextBox
    Friend WithEvents TextBoxIVA As TextBox
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents TextBoxTLF As TextBox
    Friend WithEvents TextBoxCliente As TextBox
    Friend WithEvents TextBoxNroPedido As TextBox
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ButtonNuevoPedido As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxPizza As TextBox
End Class
