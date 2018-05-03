<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mensajes
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Dim lblTags As System.Windows.Forms.Label
        Dim lblArchivos As System.Windows.Forms.Label
        Dim FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
        Dim panelTop As System.Windows.Forms.Panel
        Dim flpControles As System.Windows.Forms.FlowLayoutPanel
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBorrarArchivo = New System.Windows.Forms.Button()
        Me.btnAgregarArchivo = New System.Windows.Forms.Button()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.MensajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.splitLista = New System.Windows.Forms.SplitContainer()
        Me.dgvMensajes = New System.Windows.Forms.DataGridView()
        Me.TituloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelBusqueda = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.cmsAgregar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarVariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelDetalle = New System.Windows.Forms.Panel()
        Me.splitMesajePreview = New System.Windows.Forms.SplitContainer()
        Me.txtMensaje = New System.Windows.Forms.RichTextBox()
        Me.txtPreviewWord = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelArchivos = New System.Windows.Forms.Panel()
        Me.dgvArchivos = New System.Windows.Forms.DataGridView()
        Me.ImagenDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TamanoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArchivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tags = New WR.InterfaceWin.Etiquetas()
        Me.TagsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        lblTags = New System.Windows.Forms.Label()
        lblArchivos = New System.Windows.Forms.Label()
        FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        panelTop = New System.Windows.Forms.Panel()
        flpControles = New System.Windows.Forms.FlowLayoutPanel()
        FlowLayoutPanel1.SuspendLayout()
        panelTop.SuspendLayout()
        CType(Me.MensajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        flpControles.SuspendLayout()
        CType(Me.splitLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitLista.Panel1.SuspendLayout()
        Me.splitLista.Panel2.SuspendLayout()
        Me.splitLista.SuspendLayout()
        CType(Me.dgvMensajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBusqueda.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.cmsAgregar.SuspendLayout()
        Me.panelDetalle.SuspendLayout()
        CType(Me.splitMesajePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitMesajePreview.Panel1.SuspendLayout()
        Me.splitMesajePreview.Panel2.SuspendLayout()
        Me.splitMesajePreview.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelArchivos.SuspendLayout()
        CType(Me.dgvArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TagsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTags
        '
        lblTags.AutoSize = True
        lblTags.Dock = System.Windows.Forms.DockStyle.Left
        lblTags.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTags.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(153, Byte), Integer))
        lblTags.Location = New System.Drawing.Point(10, 3)
        lblTags.Name = "lblTags"
        lblTags.Size = New System.Drawing.Size(44, 16)
        lblTags.TabIndex = 9
        lblTags.Text = "Tags"
        '
        'lblArchivos
        '
        lblArchivos.AutoSize = True
        lblArchivos.Dock = System.Windows.Forms.DockStyle.Fill
        lblArchivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblArchivos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(153, Byte), Integer))
        lblArchivos.Location = New System.Drawing.Point(10, 3)
        lblArchivos.Name = "lblArchivos"
        lblArchivos.Size = New System.Drawing.Size(68, 16)
        lblArchivos.TabIndex = 8
        lblArchivos.Text = "Archivos"
        '
        'FlowLayoutPanel1
        '
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.Controls.Add(Me.btnBorrarArchivo)
        FlowLayoutPanel1.Controls.Add(Me.btnAgregarArchivo)
        FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        FlowLayoutPanel1.Location = New System.Drawing.Point(486, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New System.Drawing.Size(35, 16)
        FlowLayoutPanel1.TabIndex = 7
        '
        'btnBorrarArchivo
        '
        Me.btnBorrarArchivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrarArchivo.BackgroundImage = Global.WR.InterfaceWin.My.Resources.Resources.Borrar
        Me.btnBorrarArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBorrarArchivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarArchivo.FlatAppearance.BorderSize = 0
        Me.btnBorrarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarArchivo.Location = New System.Drawing.Point(0, 0)
        Me.btnBorrarArchivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBorrarArchivo.Name = "btnBorrarArchivo"
        Me.btnBorrarArchivo.Size = New System.Drawing.Size(15, 15)
        Me.btnBorrarArchivo.TabIndex = 7
        Me.btnBorrarArchivo.UseVisualStyleBackColor = True
        Me.btnBorrarArchivo.Visible = False
        '
        'btnAgregarArchivo
        '
        Me.btnAgregarArchivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarArchivo.BackgroundImage = Global.WR.InterfaceWin.My.Resources.Resources.Mas
        Me.btnAgregarArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarArchivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarArchivo.FlatAppearance.BorderSize = 0
        Me.btnAgregarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarArchivo.Location = New System.Drawing.Point(20, 0)
        Me.btnAgregarArchivo.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAgregarArchivo.Name = "btnAgregarArchivo"
        Me.btnAgregarArchivo.Size = New System.Drawing.Size(15, 15)
        Me.btnAgregarArchivo.TabIndex = 8
        Me.btnAgregarArchivo.UseVisualStyleBackColor = True
        Me.btnAgregarArchivo.Visible = False
        '
        'panelTop
        '
        panelTop.Controls.Add(Me.txtTitulo)
        panelTop.Controls.Add(flpControles)
        panelTop.Dock = System.Windows.Forms.DockStyle.Top
        panelTop.Location = New System.Drawing.Point(0, 0)
        panelTop.Name = "panelTop"
        panelTop.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        panelTop.Size = New System.Drawing.Size(531, 30)
        panelTop.TabIndex = 9
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MensajeBindingSource, "Titulo", True))
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTitulo.Location = New System.Drawing.Point(10, 5)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.ShortcutsEnabled = False
        Me.txtTitulo.Size = New System.Drawing.Size(431, 15)
        Me.txtTitulo.TabIndex = 4
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MensajeBindingSource
        '
        Me.MensajeBindingSource.DataSource = GetType(WR.Models.Mensaje)
        '
        'flpControles
        '
        flpControles.AutoSize = True
        flpControles.Controls.Add(Me.btnBorrar)
        flpControles.Controls.Add(Me.btnGuardar)
        flpControles.Controls.Add(Me.btnEditar)
        flpControles.Dock = System.Windows.Forms.DockStyle.Right
        flpControles.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        flpControles.Location = New System.Drawing.Point(441, 5)
        flpControles.Name = "flpControles"
        flpControles.Size = New System.Drawing.Size(80, 20)
        flpControles.TabIndex = 7
        '
        'btnBorrar
        '
        Me.btnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar.BackgroundImage = Global.WR.InterfaceWin.My.Resources.Resources.Borrar
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Location = New System.Drawing.Point(10, 0)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(20, 20)
        Me.btnBorrar.TabIndex = 7
        Me.btnBorrar.UseVisualStyleBackColor = True
        Me.btnBorrar.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackgroundImage = Global.WR.InterfaceWin.My.Resources.Resources.Guardar
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(35, 0)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(20, 20)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.UseVisualStyleBackColor = True
        Me.btnGuardar.Visible = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackgroundImage = Global.WR.InterfaceWin.My.Resources.Resources.Editar
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(60, 0)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(20, 20)
        Me.btnEditar.TabIndex = 5
        Me.btnEditar.UseVisualStyleBackColor = True
        Me.btnEditar.Visible = False
        '
        'splitLista
        '
        Me.splitLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitLista.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitLista.Location = New System.Drawing.Point(0, 0)
        Me.splitLista.Name = "splitLista"
        '
        'splitLista.Panel1
        '
        Me.splitLista.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.splitLista.Panel1.Controls.Add(Me.dgvMensajes)
        Me.splitLista.Panel1.Controls.Add(Me.panelBusqueda)
        Me.splitLista.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 10)
        '
        'splitLista.Panel2
        '
        Me.splitLista.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.splitLista.Panel2.Controls.Add(Me.panelDetalle)
        Me.splitLista.Panel2.Controls.Add(Me.Panel1)
        Me.splitLista.Panel2.Controls.Add(Me.panelArchivos)
        Me.splitLista.Panel2.Controls.Add(Me.dgvArchivos)
        Me.splitLista.Panel2.Controls.Add(panelTop)
        Me.splitLista.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.splitLista.Size = New System.Drawing.Size(808, 495)
        Me.splitLista.SplitterDistance = 270
        Me.splitLista.SplitterWidth = 7
        Me.splitLista.TabIndex = 1
        '
        'dgvMensajes
        '
        Me.dgvMensajes.AllowUserToAddRows = False
        Me.dgvMensajes.AllowUserToDeleteRows = False
        Me.dgvMensajes.AutoGenerateColumns = False
        Me.dgvMensajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvMensajes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvMensajes.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvMensajes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMensajes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvMensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMensajes.ColumnHeadersVisible = False
        Me.dgvMensajes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TituloDataGridViewTextBoxColumn})
        Me.dgvMensajes.DataSource = Me.MensajeBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMensajes.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMensajes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMensajes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMensajes.Location = New System.Drawing.Point(0, 35)
        Me.dgvMensajes.MultiSelect = False
        Me.dgvMensajes.Name = "dgvMensajes"
        Me.dgvMensajes.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(135, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMensajes.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMensajes.RowHeadersVisible = False
        Me.dgvMensajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMensajes.Size = New System.Drawing.Size(270, 450)
        Me.dgvMensajes.TabIndex = 1
        '
        'TituloDataGridViewTextBoxColumn
        '
        Me.TituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo"
        Me.TituloDataGridViewTextBoxColumn.HeaderText = "Titulo"
        Me.TituloDataGridViewTextBoxColumn.Name = "TituloDataGridViewTextBoxColumn"
        Me.TituloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'panelBusqueda
        '
        Me.panelBusqueda.Controls.Add(Me.Panel2)
        Me.panelBusqueda.Controls.Add(Me.cbTipo)
        Me.panelBusqueda.Controls.Add(Me.btnBuscar)
        Me.panelBusqueda.Controls.Add(Me.btnMas)
        Me.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBusqueda.Location = New System.Drawing.Point(0, 5)
        Me.panelBusqueda.Name = "panelBusqueda"
        Me.panelBusqueda.Padding = New System.Windows.Forms.Padding(3)
        Me.panelBusqueda.Size = New System.Drawing.Size(270, 30)
        Me.panelBusqueda.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtBuscar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(100, 3)
        Me.Panel2.MaximumSize = New System.Drawing.Size(0, 24)
        Me.Panel2.MinimumSize = New System.Drawing.Size(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(0, 24)
        Me.Panel2.TabIndex = 9
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.SystemColors.Window
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(0, 5)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(127, 15)
        Me.txtBuscar.TabIndex = 0
        '
        'cbTipo
        '
        Me.cbTipo.Dock = System.Windows.Forms.DockStyle.Left
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Titulo", "Descripcion", "Archivos", "Tags"})
        Me.cbTipo.Location = New System.Drawing.Point(3, 3)
        Me.cbTipo.Margin = New System.Windows.Forms.Padding(0)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(97, 24)
        Me.cbTipo.TabIndex = 8
        '
        'btnBuscar
        '
        Me.btnBuscar.AutoSize = True
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Window
        Me.btnBuscar.BackgroundImage = Global.WR.InterfaceWin.My.Resources.Resources.Buscar
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(227, 3)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(20, 24)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnMas
        '
        Me.btnMas.BackColor = System.Drawing.Color.White
        Me.btnMas.BackgroundImage = Global.WR.InterfaceWin.My.Resources.Resources.Mas
        Me.btnMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMas.ContextMenuStrip = Me.cmsAgregar
        Me.btnMas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMas.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMas.FlatAppearance.BorderSize = 0
        Me.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMas.Location = New System.Drawing.Point(247, 3)
        Me.btnMas.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(20, 24)
        Me.btnMas.TabIndex = 8
        Me.btnMas.UseVisualStyleBackColor = False
        '
        'cmsAgregar
        '
        Me.cmsAgregar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ImportarToolStripMenuItem, Me.ImportarVariosToolStripMenuItem})
        Me.cmsAgregar.Name = "cmsAgregar"
        Me.cmsAgregar.Size = New System.Drawing.Size(155, 70)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ImportarToolStripMenuItem
        '
        Me.ImportarToolStripMenuItem.Name = "ImportarToolStripMenuItem"
        Me.ImportarToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ImportarToolStripMenuItem.Text = "Importar"
        '
        'ImportarVariosToolStripMenuItem
        '
        Me.ImportarVariosToolStripMenuItem.Name = "ImportarVariosToolStripMenuItem"
        Me.ImportarVariosToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ImportarVariosToolStripMenuItem.Text = "Importar Varios"
        '
        'panelDetalle
        '
        Me.panelDetalle.Controls.Add(Me.splitMesajePreview)
        Me.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDetalle.Location = New System.Drawing.Point(0, 30)
        Me.panelDetalle.Name = "panelDetalle"
        Me.panelDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.panelDetalle.Size = New System.Drawing.Size(531, 338)
        Me.panelDetalle.TabIndex = 12
        '
        'splitMesajePreview
        '
        Me.splitMesajePreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitMesajePreview.Location = New System.Drawing.Point(3, 3)
        Me.splitMesajePreview.Name = "splitMesajePreview"
        '
        'splitMesajePreview.Panel1
        '
        Me.splitMesajePreview.Panel1.Controls.Add(Me.txtMensaje)
        '
        'splitMesajePreview.Panel2
        '
        Me.splitMesajePreview.Panel2.Controls.Add(Me.txtPreviewWord)
        Me.splitMesajePreview.Panel2Collapsed = True
        Me.splitMesajePreview.Size = New System.Drawing.Size(525, 332)
        Me.splitMesajePreview.SplitterDistance = 175
        Me.splitMesajePreview.TabIndex = 9
        '
        'txtMensaje
        '
        Me.txtMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MensajeBindingSource, "Descripcion", True))
        Me.txtMensaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMensaje.Location = New System.Drawing.Point(0, 0)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ReadOnly = True
        Me.txtMensaje.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtMensaje.Size = New System.Drawing.Size(525, 332)
        Me.txtMensaje.TabIndex = 8
        Me.txtMensaje.Text = ""
        '
        'txtPreviewWord
        '
        Me.txtPreviewWord.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtPreviewWord.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPreviewWord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPreviewWord.Location = New System.Drawing.Point(0, 0)
        Me.txtPreviewWord.Name = "txtPreviewWord"
        Me.txtPreviewWord.ReadOnly = True
        Me.txtPreviewWord.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtPreviewWord.Size = New System.Drawing.Size(96, 100)
        Me.txtPreviewWord.TabIndex = 9
        Me.txtPreviewWord.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tags)
        Me.Panel1.Controls.Add(lblTags)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 368)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Panel1.Size = New System.Drawing.Size(531, 22)
        Me.Panel1.TabIndex = 11
        '
        'panelArchivos
        '
        Me.panelArchivos.AutoSize = True
        Me.panelArchivos.Controls.Add(lblArchivos)
        Me.panelArchivos.Controls.Add(FlowLayoutPanel1)
        Me.panelArchivos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelArchivos.Location = New System.Drawing.Point(0, 390)
        Me.panelArchivos.Name = "panelArchivos"
        Me.panelArchivos.Padding = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.panelArchivos.Size = New System.Drawing.Size(531, 22)
        Me.panelArchivos.TabIndex = 10
        Me.panelArchivos.Visible = False
        '
        'dgvArchivos
        '
        Me.dgvArchivos.AllowUserToAddRows = False
        Me.dgvArchivos.AllowUserToDeleteRows = False
        Me.dgvArchivos.AutoGenerateColumns = False
        Me.dgvArchivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvArchivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvArchivos.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvArchivos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvArchivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArchivos.ColumnHeadersVisible = False
        Me.dgvArchivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ImagenDataGridViewImageColumn, Me.NombreDataGridViewTextBoxColumn, Me.TamanoDataGridViewTextBoxColumn})
        Me.dgvArchivos.DataSource = Me.ArchivosBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvArchivos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvArchivos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvArchivos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvArchivos.Location = New System.Drawing.Point(0, 412)
        Me.dgvArchivos.MultiSelect = False
        Me.dgvArchivos.Name = "dgvArchivos"
        Me.dgvArchivos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(135, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvArchivos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvArchivos.RowHeadersVisible = False
        Me.dgvArchivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArchivos.Size = New System.Drawing.Size(531, 73)
        Me.dgvArchivos.TabIndex = 10
        '
        'ImagenDataGridViewImageColumn
        '
        Me.ImagenDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ImagenDataGridViewImageColumn.DataPropertyName = "Imagen"
        Me.ImagenDataGridViewImageColumn.HeaderText = "Imagen"
        Me.ImagenDataGridViewImageColumn.Name = "ImagenDataGridViewImageColumn"
        Me.ImagenDataGridViewImageColumn.ReadOnly = True
        Me.ImagenDataGridViewImageColumn.Width = 5
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TamanoDataGridViewTextBoxColumn
        '
        Me.TamanoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TamanoDataGridViewTextBoxColumn.DataPropertyName = "Tamano"
        Me.TamanoDataGridViewTextBoxColumn.HeaderText = "Tamano"
        Me.TamanoDataGridViewTextBoxColumn.Name = "TamanoDataGridViewTextBoxColumn"
        Me.TamanoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TamanoDataGridViewTextBoxColumn.Width = 5
        '
        'ArchivosBindingSource
        '
        Me.ArchivosBindingSource.DataMember = "Archivos"
        Me.ArchivosBindingSource.DataSource = Me.MensajeBindingSource
        '
        'tags
        '
        Me.tags.AutoSize = True
        Me.tags.DataSource = Me.TagsBindingSource
        Me.tags.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tags.Editable = True
        Me.tags.Location = New System.Drawing.Point(54, 3)
        Me.tags.Name = "tags"
        Me.tags.Size = New System.Drawing.Size(467, 16)
        Me.tags.TabIndex = 10
        '
        'TagsBindingSource
        '
        Me.TagsBindingSource.DataMember = "Tags"
        Me.TagsBindingSource.DataSource = Me.MensajeBindingSource
        '
        'Mensajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.splitLista)
        Me.Name = "Mensajes"
        Me.Size = New System.Drawing.Size(808, 495)
        FlowLayoutPanel1.ResumeLayout(False)
        panelTop.ResumeLayout(False)
        panelTop.PerformLayout()
        CType(Me.MensajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        flpControles.ResumeLayout(False)
        Me.splitLista.Panel1.ResumeLayout(False)
        Me.splitLista.Panel2.ResumeLayout(False)
        Me.splitLista.Panel2.PerformLayout()
        CType(Me.splitLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitLista.ResumeLayout(False)
        CType(Me.dgvMensajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBusqueda.ResumeLayout(False)
        Me.panelBusqueda.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.cmsAgregar.ResumeLayout(False)
        Me.panelDetalle.ResumeLayout(False)
        Me.splitMesajePreview.Panel1.ResumeLayout(False)
        Me.splitMesajePreview.Panel2.ResumeLayout(False)
        CType(Me.splitMesajePreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitMesajePreview.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelArchivos.ResumeLayout(False)
        Me.panelArchivos.PerformLayout()
        CType(Me.dgvArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TagsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents txtBuscar As TextBox
    Private WithEvents txtMensaje As RichTextBox
    Private WithEvents btnBorrar As Button
    Private WithEvents btnGuardar As Button
    Private WithEvents btnEditar As Button
    Private WithEvents txtTitulo As TextBox
    Friend WithEvents panelBusqueda As Panel
    Private WithEvents btnBuscar As Button
    Friend WithEvents dgvMensajes As DataGridView
    Private WithEvents btnMas As Button
    Friend WithEvents dgvArchivos As DataGridView
    Private WithEvents btnBorrarArchivo As Button
    Private WithEvents btnAgregarArchivo As Button
    Friend WithEvents PathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImageDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents panelArchivos As Panel
    Friend WithEvents tags As Etiquetas
    Friend WithEvents panelDetalle As Panel
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents MensajeBindingSource As BindingSource
    Friend WithEvents ArchivosBindingSource As BindingSource
    Friend WithEvents TituloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImagenDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TamanoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents splitLista As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents splitMesajePreview As SplitContainer
    Private WithEvents txtPreviewWord As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmsAgregar As ContextMenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportarVariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TagsBindingSource As BindingSource
End Class
