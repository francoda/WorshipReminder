<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Etiqueta
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNombre.Location = New System.Drawing.Point(0, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.lblNombre.Size = New System.Drawing.Size(81, 17)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre de Tag"
        '
        'btnBorrar
        '
        Me.btnBorrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(81, 0)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(17, 17)
        Me.btnBorrar.TabIndex = 1
        Me.btnBorrar.Text = "X"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'Etiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnBorrar)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "Etiqueta"
        Me.Size = New System.Drawing.Size(98, 17)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents btnBorrar As Button
End Class
