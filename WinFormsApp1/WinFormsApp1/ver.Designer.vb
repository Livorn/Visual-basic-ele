<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ver
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
        regresar = New Button()
        Label7 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' regresar
        ' 
        regresar.Location = New Point(252, 376)
        regresar.Name = "regresar"
        regresar.Size = New Size(114, 40)
        regresar.TabIndex = 51
        regresar.Text = "regresar"
        regresar.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(92, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(192, 37)
        Label7.TabIndex = 50
        Label7.Text = "Almacen datos"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(10, 376)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 40)
        Button2.TabIndex = 38
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(132, 376)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 40)
        Button1.TabIndex = 37
        Button1.Text = "Subir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(12, 82)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(78, 19)
        ListBox1.TabIndex = 52
        ' 
        ' ver
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(377, 426)
        Controls.Add(ListBox1)
        Controls.Add(regresar)
        Controls.Add(Label7)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "ver"
        Text = "ver"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents regresar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
End Class
