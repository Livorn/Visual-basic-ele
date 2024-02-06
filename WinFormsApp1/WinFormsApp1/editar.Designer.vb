<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editar
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
        Precio = New TextBox()
        Label8 = New Label()
        regresar = New Button()
        Label7 = New Label()
        Cantidad = New TextBox()
        Label6 = New Label()
        Color = New TextBox()
        Label5 = New Label()
        Tipo = New TextBox()
        Label4 = New Label()
        Ubicacion = New TextBox()
        Label3 = New Label()
        Categoria = New TextBox()
        Label2 = New Label()
        Nombre = New TextBox()
        Borrar = New Button()
        AplicarCambio = New Button()
        Label1 = New Label()
        ListBox1 = New ListBox()
        Eliminar = New Button()
        SuspendLayout()
        ' 
        ' Precio
        ' 
        Precio.Location = New Point(12, 368)
        Precio.Name = "Precio"
        Precio.Size = New Size(379, 23)
        Precio.TabIndex = 89
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(14, 350)
        Label8.Name = "Label8"
        Label8.Size = New Size(43, 15)
        Label8.TabIndex = 88
        Label8.Text = "Precio:"
        ' 
        ' regresar
        ' 
        regresar.Location = New Point(300, 406)
        regresar.Name = "regresar"
        regresar.Size = New Size(90, 40)
        regresar.TabIndex = 87
        regresar.Text = "regresar"
        regresar.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(108, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(202, 37)
        Label7.TabIndex = 86
        Label7.Text = "Editar producto"
        ' 
        ' Cantidad
        ' 
        Cantidad.Location = New Point(12, 322)
        Cantidad.Name = "Cantidad"
        Cantidad.Size = New Size(379, 23)
        Cantidad.TabIndex = 85
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 304)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 15)
        Label6.TabIndex = 84
        Label6.Text = "Cantidad:"
        ' 
        ' Color
        ' 
        Color.Location = New Point(12, 278)
        Color.Name = "Color"
        Color.Size = New Size(379, 23)
        Color.TabIndex = 83
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 260)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 82
        Label5.Text = "Color:"
        ' 
        ' Tipo
        ' 
        Tipo.Location = New Point(12, 234)
        Tipo.Name = "Tipo"
        Tipo.Size = New Size(379, 23)
        Tipo.TabIndex = 81
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 216)
        Label4.Name = "Label4"
        Label4.Size = New Size(33, 15)
        Label4.TabIndex = 80
        Label4.Text = "Tipo:"
        ' 
        ' Ubicacion
        ' 
        Ubicacion.Location = New Point(12, 190)
        Ubicacion.Name = "Ubicacion"
        Ubicacion.Size = New Size(379, 23)
        Ubicacion.TabIndex = 79
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 78
        Label3.Text = "Ubicacion:"
        ' 
        ' Categoria
        ' 
        Categoria.Location = New Point(12, 146)
        Categoria.Name = "Categoria"
        Categoria.Size = New Size(379, 23)
        Categoria.TabIndex = 77
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 76
        Label2.Text = "Categoria:"
        ' 
        ' Nombre
        ' 
        Nombre.Location = New Point(12, 102)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(379, 23)
        Nombre.TabIndex = 75
        ' 
        ' Borrar
        ' 
        Borrar.Location = New Point(12, 406)
        Borrar.Name = "Borrar"
        Borrar.Size = New Size(90, 40)
        Borrar.TabIndex = 74
        Borrar.Text = "Borrar"
        Borrar.UseVisualStyleBackColor = True
        ' 
        ' AplicarCambio
        ' 
        AplicarCambio.Location = New Point(108, 406)
        AplicarCambio.Name = "AplicarCambio"
        AplicarCambio.Size = New Size(90, 40)
        AplicarCambio.TabIndex = 73
        AplicarCambio.Text = "Aplicar cambio"
        AplicarCambio.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 72
        Label1.Text = "Nombre:"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(14, 62)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(376, 19)
        ListBox1.TabIndex = 90
        ' 
        ' Eliminar
        ' 
        Eliminar.Location = New Point(204, 406)
        Eliminar.Name = "Eliminar"
        Eliminar.Size = New Size(90, 40)
        Eliminar.TabIndex = 91
        Eliminar.Text = "Eliminar"
        Eliminar.UseVisualStyleBackColor = True
        ' 
        ' editar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(406, 453)
        Controls.Add(Eliminar)
        Controls.Add(ListBox1)
        Controls.Add(Precio)
        Controls.Add(Label8)
        Controls.Add(regresar)
        Controls.Add(Label7)
        Controls.Add(Cantidad)
        Controls.Add(Label6)
        Controls.Add(Color)
        Controls.Add(Label5)
        Controls.Add(Tipo)
        Controls.Add(Label4)
        Controls.Add(Ubicacion)
        Controls.Add(Label3)
        Controls.Add(Categoria)
        Controls.Add(Label2)
        Controls.Add(Nombre)
        Controls.Add(Borrar)
        Controls.Add(AplicarCambio)
        Controls.Add(Label1)
        Name = "editar"
        Text = "editar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Precio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents regresar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Cantidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Color As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Tipo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Ubicacion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Categoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Borrar As Button
    Friend WithEvents AplicarCambio As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Eliminar As Button
End Class
