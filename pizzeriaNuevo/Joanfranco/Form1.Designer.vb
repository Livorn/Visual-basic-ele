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
        Almacen = New Button()
        Factura = New Button()
        Administrador = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Almacen
        ' 
        Almacen.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Almacen.Location = New Point(184, 202)
        Almacen.Name = "Almacen"
        Almacen.Size = New Size(291, 94)
        Almacen.TabIndex = 1
        Almacen.Text = "Almacen"
        Almacen.UseVisualStyleBackColor = True
        ' 
        ' Factura
        ' 
        Factura.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Factura.Location = New Point(184, 102)
        Factura.Name = "Factura"
        Factura.Size = New Size(291, 94)
        Factura.TabIndex = 2
        Factura.Text = "Factura"
        Factura.UseVisualStyleBackColor = True
        ' 
        ' Administrador
        ' 
        Administrador.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Administrador.Location = New Point(184, 302)
        Administrador.Name = "Administrador"
        Administrador.Size = New Size(291, 94)
        Administrador.TabIndex = 3
        Administrador.Text = "Administrador"
        Administrador.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(100, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(451, 60)
        Label1.TabIndex = 4
        Label1.Text = "PIZZERIA EL PEPE"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(634, 450)
        Controls.Add(Label1)
        Controls.Add(Administrador)
        Controls.Add(Factura)
        Controls.Add(Almacen)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Almacen As Button
    Friend WithEvents Factura As Button
    Friend WithEvents Administrador As Button
    Friend WithEvents Label1 As Label
End Class
