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
        Nuevo = New Button()
        Label7 = New Label()
        Editar = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' Nuevo
        ' 
        Nuevo.Location = New Point(30, 79)
        Nuevo.Name = "Nuevo"
        Nuevo.Size = New Size(319, 60)
        Nuevo.TabIndex = 1
        Nuevo.Text = "Nuevo producto"
        Nuevo.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(51, 22)
        Label7.Name = "Label7"
        Label7.Size = New Size(276, 37)
        Label7.TabIndex = 14
        Label7.Text = "Base de dato almacen"
        ' 
        ' Editar
        ' 
        Editar.Location = New Point(30, 163)
        Editar.Name = "Editar"
        Editar.Size = New Size(319, 60)
        Editar.TabIndex = 16
        Editar.Text = "Ver"
        Editar.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(30, 249)
        Button5.Name = "Button5"
        Button5.Size = New Size(319, 60)
        Button5.TabIndex = 17
        Button5.Text = "Editar"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(377, 339)
        Controls.Add(Button5)
        Controls.Add(Editar)
        Controls.Add(Label7)
        Controls.Add(Nuevo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Nuevo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Editar As Button
    Friend WithEvents Button5 As Button
End Class
