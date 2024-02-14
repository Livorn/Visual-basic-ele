<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Almacen
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
        Button1 = New Button()
        Label1 = New Label()
        TxtBoxNombre = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TxtBoxDescripcion = New TextBox()
        Label4 = New Label()
        TxtBoxPrecio = New TextBox()
        TxtBoxCategoria = New TextBox()
        Label5 = New Label()
        Button2 = New Button()
        ListBox1 = New ListBox()
        buttonSubir = New Button()
        Label6 = New Label()
        TxtID = New TextBox()
        Button4 = New Button()
        Label8 = New Label()
        Label9 = New Label()
        fechadcompra = New DateTimePicker()
        expdata = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(310, 400)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 38)
        Button1.TabIndex = 1
        Button1.Text = "Eliminar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(149, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 45)
        Label1.TabIndex = 2
        Label1.Text = "Almacen"
        ' 
        ' TxtBoxNombre
        ' 
        TxtBoxNombre.Location = New Point(12, 148)
        TxtBoxNombre.Name = "TxtBoxNombre"
        TxtBoxNombre.Size = New Size(263, 23)
        TxtBoxNombre.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 4
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 5
        Label3.Text = "Cantidad"
        ' 
        ' TxtBoxDescripcion
        ' 
        TxtBoxDescripcion.Location = New Point(12, 192)
        TxtBoxDescripcion.Name = "TxtBoxDescripcion"
        TxtBoxDescripcion.Size = New Size(433, 23)
        TxtBoxDescripcion.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 262)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 15)
        Label4.TabIndex = 7
        Label4.Text = "Precio"
        ' 
        ' TxtBoxPrecio
        ' 
        TxtBoxPrecio.Location = New Point(12, 280)
        TxtBoxPrecio.Name = "TxtBoxPrecio"
        TxtBoxPrecio.Size = New Size(122, 23)
        TxtBoxPrecio.TabIndex = 8
        ' 
        ' TxtBoxCategoria
        ' 
        TxtBoxCategoria.Location = New Point(12, 236)
        TxtBoxCategoria.Name = "TxtBoxCategoria"
        TxtBoxCategoria.Size = New Size(219, 23)
        TxtBoxCategoria.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 10
        Label5.Text = "Categoria"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 400)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 38)
        Button2.TabIndex = 11
        Button2.Text = "Editar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(12, 61)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(403, 19)
        ListBox1.TabIndex = 12
        ' 
        ' buttonSubir
        ' 
        buttonSubir.Location = New Point(161, 400)
        buttonSubir.Name = "buttonSubir"
        buttonSubir.Size = New Size(143, 38)
        buttonSubir.TabIndex = 13
        buttonSubir.Text = "Subir"
        buttonSubir.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 83)
        Label6.Name = "Label6"
        Label6.Size = New Size(18, 15)
        Label6.TabIndex = 15
        Label6.Text = "ID"
        ' 
        ' TxtID
        ' 
        TxtID.Location = New Point(12, 101)
        TxtID.Name = "TxtID"
        TxtID.Size = New Size(219, 23)
        TxtID.TabIndex = 14
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveBorder
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(360, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(93, 38)
        Button4.TabIndex = 16
        Button4.Text = "<-"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 307)
        Label8.Name = "Label8"
        Label8.Size = New Size(101, 15)
        Label8.TabIndex = 18
        Label8.Text = "Fecha De Compra"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 351)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 15)
        Label9.TabIndex = 20
        Label9.Text = "Fecha De Exp"
        ' 
        ' fechadcompra
        ' 
        fechadcompra.Location = New Point(12, 325)
        fechadcompra.Name = "fechadcompra"
        fechadcompra.Size = New Size(232, 23)
        fechadcompra.TabIndex = 22
        ' 
        ' expdata
        ' 
        expdata.Location = New Point(12, 369)
        expdata.Name = "expdata"
        expdata.Size = New Size(232, 23)
        expdata.TabIndex = 23
        ' 
        ' Almacen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(460, 450)
        Controls.Add(expdata)
        Controls.Add(fechadcompra)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Button4)
        Controls.Add(Label6)
        Controls.Add(TxtID)
        Controls.Add(buttonSubir)
        Controls.Add(ListBox1)
        Controls.Add(Button2)
        Controls.Add(Label5)
        Controls.Add(TxtBoxCategoria)
        Controls.Add(TxtBoxPrecio)
        Controls.Add(Label4)
        Controls.Add(TxtBoxDescripcion)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TxtBoxNombre)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Almacen"
        Text = "Almacen"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBoxDescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBoxPrecio As TextBox
    Friend WithEvents TxtBoxCategoria As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents buttonSubir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents fechadcompra As DateTimePicker
    Friend WithEvents expdata As DateTimePicker
End Class
