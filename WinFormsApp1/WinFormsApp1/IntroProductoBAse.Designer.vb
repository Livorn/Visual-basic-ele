<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntroProductoBAse
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
        Button2 = New Button()
        Subir = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Precio
        ' 
        Precio.Location = New Point(10, 339)
        Precio.Name = "Precio"
        Precio.Size = New Size(354, 23)
        Precio.TabIndex = 71
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 321)
        Label8.Name = "Label8"
        Label8.Size = New Size(43, 15)
        Label8.TabIndex = 70
        Label8.Text = "Precio:"
        ' 
        ' regresar
        ' 
        regresar.Location = New Point(252, 377)
        regresar.Name = "regresar"
        regresar.Size = New Size(114, 40)
        regresar.TabIndex = 69
        regresar.Text = "regresar"
        regresar.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(25, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(319, 37)
        Label7.TabIndex = 68
        Label7.Text = "Datos de nuevo producto"
        ' 
        ' Cantidad
        ' 
        Cantidad.Location = New Point(10, 293)
        Cantidad.Name = "Cantidad"
        Cantidad.Size = New Size(354, 23)
        Cantidad.TabIndex = 67
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(10, 275)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 15)
        Label6.TabIndex = 66
        Label6.Text = "Cantidad:"
        ' 
        ' Color
        ' 
        Color.Location = New Point(10, 249)
        Color.Name = "Color"
        Color.Size = New Size(354, 23)
        Color.TabIndex = 65
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 231)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 64
        Label5.Text = "Color:"
        ' 
        ' Tipo
        ' 
        Tipo.Location = New Point(10, 205)
        Tipo.Name = "Tipo"
        Tipo.Size = New Size(354, 23)
        Tipo.TabIndex = 63
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(10, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(33, 15)
        Label4.TabIndex = 62
        Label4.Text = "Tipo:"
        ' 
        ' Ubicacion
        ' 
        Ubicacion.Location = New Point(10, 161)
        Ubicacion.Name = "Ubicacion"
        Ubicacion.Size = New Size(354, 23)
        Ubicacion.TabIndex = 61
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 60
        Label3.Text = "Ubicacion:"
        ' 
        ' Categoria
        ' 
        Categoria.Location = New Point(10, 117)
        Categoria.Name = "Categoria"
        Categoria.Size = New Size(354, 23)
        Categoria.TabIndex = 59
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 58
        Label2.Text = "Categoria:"
        ' 
        ' Nombre
        ' 
        Nombre.Location = New Point(10, 73)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(354, 23)
        Nombre.TabIndex = 57
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(10, 377)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 40)
        Button2.TabIndex = 56
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Subir
        ' 
        Subir.Location = New Point(132, 377)
        Subir.Name = "Subir"
        Subir.Size = New Size(114, 40)
        Subir.TabIndex = 55
        Subir.Text = "Subir"
        Subir.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 54
        Label1.Text = "Nombre:"
        ' 
        ' IntroProductoBAse
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(377, 426)
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
        Controls.Add(Button2)
        Controls.Add(Subir)
        Controls.Add(Label1)
        Name = "IntroProductoBAse"
        Text = "IntroProductoBAse"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Subir As Button
    Friend WithEvents Label1 As Label
End Class
