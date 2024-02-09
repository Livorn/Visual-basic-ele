<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        ButtonNuevoPedido = New Button()
        ButtonSalir = New Button()
        RadioButtondebito = New RadioButton()
        RadioButtonCredito = New RadioButton()
        TextBoxNroPedido = New TextBox()
        TextBoxCliente = New TextBox()
        TextBoxTLF = New TextBox()
        TextBoxDireccion = New TextBox()
        TextBoxTotal = New TextBox()
        TextBoxIVA = New TextBox()
        TextBoxNEtoaCancelar = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Panel1 = New Panel()
        ComboBoxPizza = New ComboBox()
        Label11 = New Label()
        Label10 = New Label()
        TextBoxprecio = New TextBox()
        ComboBoxBebida = New ComboBox()
        TextBoxPizza = New TextBox()
        GroupBox1 = New GroupBox()
        RadioButton3 = New RadioButton()
        Panel2 = New Panel()
        Label12 = New Label()
        Label13 = New Label()
        TextBoxprecioB = New TextBox()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        ListBoxCant = New ListBox()
        ListBoxSubTotal = New ListBox()
        ListBoxDescripcion = New ListBox()
        ButtonAgregarAlPedido = New Button()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 0
        Label1.Text = "Menu"
        ' 
        ' ButtonNuevoPedido
        ' 
        ButtonNuevoPedido.Location = New Point(461, 342)
        ButtonNuevoPedido.Name = "ButtonNuevoPedido"
        ButtonNuevoPedido.Size = New Size(127, 28)
        ButtonNuevoPedido.TabIndex = 1
        ButtonNuevoPedido.Text = "Nuevo Pedido"
        ButtonNuevoPedido.UseVisualStyleBackColor = True
        ' 
        ' ButtonSalir
        ' 
        ButtonSalir.Location = New Point(461, 376)
        ButtonSalir.Name = "ButtonSalir"
        ButtonSalir.Size = New Size(127, 28)
        ButtonSalir.TabIndex = 2
        ButtonSalir.Text = "Salir"
        ButtonSalir.UseVisualStyleBackColor = True
        ' 
        ' RadioButtondebito
        ' 
        RadioButtondebito.AutoSize = True
        RadioButtondebito.Location = New Point(18, 22)
        RadioButtondebito.Name = "RadioButtondebito"
        RadioButtondebito.Size = New Size(60, 19)
        RadioButtondebito.TabIndex = 3
        RadioButtondebito.TabStop = True
        RadioButtondebito.Text = "Debito"
        RadioButtondebito.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonCredito
        ' 
        RadioButtonCredito.AutoSize = True
        RadioButtonCredito.Location = New Point(18, 48)
        RadioButtonCredito.Name = "RadioButtonCredito"
        RadioButtonCredito.Size = New Size(64, 19)
        RadioButtonCredito.TabIndex = 4
        RadioButtonCredito.TabStop = True
        RadioButtonCredito.Text = "Credito"
        RadioButtonCredito.UseVisualStyleBackColor = True
        ' 
        ' TextBoxNroPedido
        ' 
        TextBoxNroPedido.Enabled = False
        TextBoxNroPedido.Location = New Point(421, 199)
        TextBoxNroPedido.Name = "TextBoxNroPedido"
        TextBoxNroPedido.Size = New Size(121, 23)
        TextBoxNroPedido.TabIndex = 6
        ' 
        ' TextBoxCliente
        ' 
        TextBoxCliente.Location = New Point(395, 228)
        TextBoxCliente.Name = "TextBoxCliente"
        TextBoxCliente.Size = New Size(192, 23)
        TextBoxCliente.TabIndex = 7
        ' 
        ' TextBoxTLF
        ' 
        TextBoxTLF.Location = New Point(403, 257)
        TextBoxTLF.Name = "TextBoxTLF"
        TextBoxTLF.Size = New Size(152, 23)
        TextBoxTLF.TabIndex = 8
        ' 
        ' TextBoxDireccion
        ' 
        TextBoxDireccion.Location = New Point(408, 286)
        TextBoxDireccion.Name = "TextBoxDireccion"
        TextBoxDireccion.Size = New Size(179, 23)
        TextBoxDireccion.TabIndex = 9
        ' 
        ' TextBoxTotal
        ' 
        TextBoxTotal.Enabled = False
        TextBoxTotal.Location = New Point(127, 347)
        TextBoxTotal.Name = "TextBoxTotal"
        TextBoxTotal.Size = New Size(104, 23)
        TextBoxTotal.TabIndex = 10
        ' 
        ' TextBoxIVA
        ' 
        TextBoxIVA.Enabled = False
        TextBoxIVA.Location = New Point(127, 376)
        TextBoxIVA.Name = "TextBoxIVA"
        TextBoxIVA.Size = New Size(104, 23)
        TextBoxIVA.TabIndex = 11
        ' 
        ' TextBoxNEtoaCancelar
        ' 
        TextBoxNEtoaCancelar.Enabled = False
        TextBoxNEtoaCancelar.Location = New Point(127, 405)
        TextBoxNEtoaCancelar.Name = "TextBoxNEtoaCancelar"
        TextBoxNEtoaCancelar.Size = New Size(104, 23)
        TextBoxNEtoaCancelar.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(86, 350)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 13
        Label2.Text = "Total:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(51, 380)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 14
        Label3.Text = "I.V.A. (12%):"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 408)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 15)
        Label4.TabIndex = 15
        Label4.Text = "Neto a Cancelar:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(342, 202)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 15)
        Label5.TabIndex = 16
        Label5.Text = "Nro. Pedido:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(342, 231)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 15)
        Label6.TabIndex = 17
        Label6.Text = "Cliente:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(342, 260)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 15)
        Label7.TabIndex = 18
        Label7.Text = "Teléfono:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(342, 289)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 15)
        Label8.TabIndex = 19
        Label8.Text = "Dirección:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(24, 187)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 15)
        Label9.TabIndex = 20
        Label9.Text = "Descripción"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(ComboBoxPizza)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(TextBoxprecio)
        Panel1.Location = New Point(27, 37)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(241, 101)
        Panel1.TabIndex = 21
        ' 
        ' ComboBoxPizza
        ' 
        ComboBoxPizza.FormattingEnabled = True
        ComboBoxPizza.Location = New Point(3, 30)
        ComboBoxPizza.Name = "ComboBoxPizza"
        ComboBoxPizza.Size = New Size(131, 23)
        ComboBoxPizza.TabIndex = 34
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(168, 12)
        Label11.Name = "Label11"
        Label11.Size = New Size(40, 15)
        Label11.TabIndex = 29
        Label11.Text = "Precio"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(3, 12)
        Label10.Name = "Label10"
        Label10.Size = New Size(33, 15)
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
        ' ComboBoxBebida
        ' 
        ComboBoxBebida.FormattingEnabled = True
        ComboBoxBebida.Location = New Point(3, 30)
        ComboBoxBebida.Name = "ComboBoxBebida"
        ComboBoxBebida.Size = New Size(131, 23)
        ComboBoxBebida.TabIndex = 35
        ' 
        ' TextBoxPizza
        ' 
        TextBoxPizza.Location = New Point(27, 214)
        TextBoxPizza.Multiline = True
        TextBoxPizza.Name = "TextBoxPizza"
        TextBoxPizza.Size = New Size(131, 66)
        TextBoxPizza.TabIndex = 26
        TextBoxPizza.Text = "Margarita" & vbCrLf & "Napolitana" & vbCrLf & "Hawai"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButtonCredito)
        GroupBox1.Controls.Add(RadioButtondebito)
        GroupBox1.Cursor = Cursors.Hand
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(310, 330)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(130, 98)
        GroupBox1.TabIndex = 22
        GroupBox1.TabStop = False
        GroupBox1.Text = "Metodo de Pago"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(18, 71)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(67, 19)
        RadioButton3.TabIndex = 5
        RadioButton3.TabStop = True
        RadioButton3.Text = "Efectivo"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(ComboBoxBebida)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(TextBoxprecioB)
        Panel2.Location = New Point(367, 37)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(241, 101)
        Panel2.TabIndex = 27
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(168, 12)
        Label12.Name = "Label12"
        Label12.Size = New Size(40, 15)
        Label12.TabIndex = 29
        Label12.Text = "Precio"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(3, 12)
        Label13.Name = "Label13"
        Label13.Size = New Size(43, 15)
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
        Label14.Location = New Point(367, 19)
        Label14.Name = "Label14"
        Label14.Size = New Size(38, 15)
        Label14.TabIndex = 26
        Label14.Text = "Menu"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(177, 187)
        Label15.Name = "Label15"
        Label15.Size = New Size(35, 15)
        Label15.TabIndex = 28
        Label15.Text = "Cant."
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(222, 187)
        Label16.Name = "Label16"
        Label16.Size = New Size(51, 15)
        Label16.TabIndex = 29
        Label16.Text = "Subtotal"
        ' 
        ' ListBoxCant
        ' 
        ListBoxCant.FormattingEnabled = True
        ListBoxCant.ItemHeight = 15
        ListBoxCant.Location = New Point(177, 205)
        ListBoxCant.Name = "ListBoxCant"
        ListBoxCant.Size = New Size(39, 124)
        ListBoxCant.TabIndex = 30
        ' 
        ' ListBoxSubTotal
        ' 
        ListBoxSubTotal.FormattingEnabled = True
        ListBoxSubTotal.ItemHeight = 15
        ListBoxSubTotal.Location = New Point(222, 205)
        ListBoxSubTotal.Name = "ListBoxSubTotal"
        ListBoxSubTotal.Size = New Size(84, 124)
        ListBoxSubTotal.TabIndex = 31
        ' 
        ' ListBoxDescripcion
        ' 
        ListBoxDescripcion.FormattingEnabled = True
        ListBoxDescripcion.ItemHeight = 15
        ListBoxDescripcion.Location = New Point(24, 205)
        ListBoxDescripcion.Name = "ListBoxDescripcion"
        ListBoxDescripcion.Size = New Size(147, 124)
        ListBoxDescripcion.TabIndex = 32
        ' 
        ' ButtonAgregarAlPedido
        ' 
        ButtonAgregarAlPedido.Location = New Point(252, 144)
        ButtonAgregarAlPedido.Name = "ButtonAgregarAlPedido"
        ButtonAgregarAlPedido.Size = New Size(127, 28)
        ButtonAgregarAlPedido.TabIndex = 33
        ButtonAgregarAlPedido.Text = "Agregar pedido"
        ButtonAgregarAlPedido.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(634, 450)
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
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonNuevoPedido As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents RadioButtondebito As RadioButton
    Friend WithEvents RadioButtonCredito As RadioButton
    Friend WithEvents TextBoxNroPedido As TextBox
    Friend WithEvents TextBoxCliente As TextBox
    Friend WithEvents TextBoxTLF As TextBox
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents TextBoxIVA As TextBox
    Friend WithEvents TextBoxNEtoaCancelar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxprecio As TextBox
    Friend WithEvents TextBoxPizza As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxprecioB As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents ListBoxCant As ListBox
    Friend WithEvents ListBoxSubTotal As ListBox
    Friend WithEvents ListBoxDescripcion As ListBox
    Friend WithEvents ComboBoxPizza As ComboBox
    Friend WithEvents ButtonAgregarAlPedido As Button
    Friend WithEvents ComboBoxBebida As ComboBox
End Class
