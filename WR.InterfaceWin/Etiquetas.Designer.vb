<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Etiquetas
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
        Me.components = New System.ComponentModel.Container()
        Me.txtNewTag = New System.Windows.Forms.TextBox()
        Me.flpTags = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tagsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.panelNewTag = New System.Windows.Forms.Panel()
        Me.flpTags.SuspendLayout()
        CType(Me.tagsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNewTag.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNewTag
        '
        Me.txtNewTag.BackColor = System.Drawing.Color.White
        Me.txtNewTag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewTag.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNewTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewTag.Location = New System.Drawing.Point(1, 1)
        Me.txtNewTag.Margin = New System.Windows.Forms.Padding(0)
        Me.txtNewTag.MinimumSize = New System.Drawing.Size(0, 15)
        Me.txtNewTag.Name = "txtNewTag"
        Me.txtNewTag.Size = New System.Drawing.Size(185, 15)
        Me.txtNewTag.TabIndex = 0
        '
        'flpTags
        '
        Me.flpTags.AutoSize = True
        Me.flpTags.Controls.Add(Me.panelNewTag)
        Me.flpTags.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpTags.Location = New System.Drawing.Point(0, 0)
        Me.flpTags.Name = "flpTags"
        Me.flpTags.Size = New System.Drawing.Size(517, 27)
        Me.flpTags.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImage = Global.WR.InterfaceWin.My.Resources.Resources.Mas
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(186, 1)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(13, 13)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.UseVisualStyleBackColor = True
        Me.btnAgregar.Visible = False
        '
        'tagsBindingSource
        '
        Me.tagsBindingSource.DataMember = "Tags"
        Me.tagsBindingSource.DataSource = GetType(WR.Models.Mensaje)
        '
        'panelNewTag
        '
        Me.panelNewTag.AutoSize = True
        Me.panelNewTag.BackColor = System.Drawing.Color.White
        Me.panelNewTag.Controls.Add(Me.txtNewTag)
        Me.panelNewTag.Controls.Add(Me.btnAgregar)
        Me.panelNewTag.Location = New System.Drawing.Point(3, 1)
        Me.panelNewTag.Margin = New System.Windows.Forms.Padding(3, 1, 0, 0)
        Me.panelNewTag.MinimumSize = New System.Drawing.Size(200, 15)
        Me.panelNewTag.Name = "panelNewTag"
        Me.panelNewTag.Padding = New System.Windows.Forms.Padding(1)
        Me.panelNewTag.Size = New System.Drawing.Size(200, 15)
        Me.panelNewTag.TabIndex = 10
        '
        'Etiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.flpTags)
        Me.Name = "Etiquetas"
        Me.Size = New System.Drawing.Size(517, 27)
        Me.flpTags.ResumeLayout(False)
        Me.flpTags.PerformLayout()
        CType(Me.tagsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNewTag.ResumeLayout(False)
        Me.panelNewTag.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewTag As TextBox
    Friend WithEvents flpTags As FlowLayoutPanel
    Friend WithEvents tagsBindingSource As BindingSource
    Private WithEvents btnAgregar As Button
    Friend WithEvents panelNewTag As Panel
End Class
