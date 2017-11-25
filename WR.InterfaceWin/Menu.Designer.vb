<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim toolMenu As System.Windows.Forms.ToolStrip
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.btnMensajes = New System.Windows.Forms.ToolStripButton()
        Me.btnConfiguracion = New System.Windows.Forms.ToolStripButton()
        Me.btnContactos = New System.Windows.Forms.ToolStripButton()
        Me.MenuMensajes = New WR.InterfaceWin.Mensajes()
        Me.MenuContactos = New WR.InterfaceWin.Contactos()
        toolMenu = New System.Windows.Forms.ToolStrip()
        toolMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolMenu
        '
        toolMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(153, Byte), Integer))
        toolMenu.Dock = System.Windows.Forms.DockStyle.Left
        toolMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        toolMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMensajes, Me.btnConfiguracion, Me.btnContactos})
        toolMenu.Location = New System.Drawing.Point(0, 0)
        toolMenu.Name = "toolMenu"
        toolMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        toolMenu.Size = New System.Drawing.Size(51, 468)
        toolMenu.TabIndex = 1
        '
        'btnMensajes
        '
        Me.btnMensajes.AutoSize = False
        Me.btnMensajes.BackgroundImage = CType(resources.GetObject("btnMensajes.BackgroundImage"), System.Drawing.Image)
        Me.btnMensajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMensajes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.btnMensajes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMensajes.ForeColor = System.Drawing.Color.White
        Me.btnMensajes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMensajes.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMensajes.Name = "btnMensajes"
        Me.btnMensajes.Size = New System.Drawing.Size(50, 50)
        Me.btnMensajes.Text = "Mensajes"
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnConfiguracion.AutoSize = False
        Me.btnConfiguracion.BackgroundImage = Global.WR.InterfaceWin.My.Resources.Resources.Configuracion
        Me.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnConfiguracion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnConfiguracion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguracion.ForeColor = System.Drawing.Color.White
        Me.btnConfiguracion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConfiguracion.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(50, 50)
        Me.btnConfiguracion.Text = "Contactos"
        Me.btnConfiguracion.Visible = False
        '
        'btnContactos
        '
        Me.btnContactos.AutoSize = False
        Me.btnContactos.BackgroundImage = CType(resources.GetObject("btnContactos.BackgroundImage"), System.Drawing.Image)
        Me.btnContactos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnContactos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnContactos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContactos.ForeColor = System.Drawing.Color.White
        Me.btnContactos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnContactos.Margin = New System.Windows.Forms.Padding(0)
        Me.btnContactos.Name = "btnContactos"
        Me.btnContactos.Size = New System.Drawing.Size(50, 50)
        Me.btnContactos.Text = "Contactos"
        '
        'MenuMensajes
        '
        Me.MenuMensajes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuMensajes.Location = New System.Drawing.Point(51, 0)
        Me.MenuMensajes.Name = "MenuMensajes"
        Me.MenuMensajes.PermitirEditar = False
        Me.MenuMensajes.Size = New System.Drawing.Size(672, 468)
        Me.MenuMensajes.TabIndex = 2
        Me.MenuMensajes.Visible = False
        '
        'MenuContactos
        '
        Me.MenuContactos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuContactos.Location = New System.Drawing.Point(51, 0)
        Me.MenuContactos.Name = "MenuContactos"
        Me.MenuContactos.PermitirEditar = False
        Me.MenuContactos.Size = New System.Drawing.Size(672, 468)
        Me.MenuContactos.TabIndex = 3
        Me.MenuContactos.Visible = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 468)
        Me.Controls.Add(Me.MenuMensajes)
        Me.Controls.Add(Me.MenuContactos)
        Me.Controls.Add(toolMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu"
        Me.Text = "WorshipReminder"
        toolMenu.ResumeLayout(False)
        toolMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnMensajes As ToolStripButton
    Friend WithEvents MenuMensajes As Mensajes
    Private WithEvents btnContactos As ToolStripButton
    Private WithEvents btnConfiguracion As ToolStripButton
    Friend WithEvents MenuContactos As Contactos
End Class
