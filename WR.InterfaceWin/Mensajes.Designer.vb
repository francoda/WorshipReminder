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
        Dim splitLista As System.Windows.Forms.SplitContainer
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim panelTop As System.Windows.Forms.Panel
        Dim flpControles As System.Windows.Forms.FlowLayoutPanel
        Me.dgvMensajes = New System.Windows.Forms.DataGridView()
        Me.TituloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MensajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.panelBusqueda = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtMensaje = New System.Windows.Forms.RichTextBox()
        Me.txtTags = New System.Windows.Forms.TextBox()
        Me.panelArchivos = New System.Windows.Forms.Panel()
        Me.lblArchivos = New System.Windows.Forms.Label()
        Me.btnBorrarArchivo = New System.Windows.Forms.Button()
        Me.btnAgregarArchivo = New System.Windows.Forms.Button()
        Me.dgvArchivos = New System.Windows.Forms.DataGridView()
        Me.ImagenDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TamanoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RutaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaArchivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnMas = New System.Windows.Forms.Button()
        splitLista = New System.Windows.Forms.SplitContainer()
        FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        panelTop = New System.Windows.Forms.Panel()
        flpControles = New System.Windows.Forms.FlowLayoutPanel()
        CType(splitLista, System.ComponentModel.ISupportInitialize).BeginInit()
        splitLista.Panel1.SuspendLayout()
        splitLista.Panel2.SuspendLayout()
        splitLista.SuspendLayout()
        CType(Me.dgvMensajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MensajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBusqueda.SuspendLayout()
        Me.panelArchivos.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        CType(Me.dgvArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaArchivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        panelTop.SuspendLayout()
        flpControles.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitLista
        '
        splitLista.Dock = System.Windows.Forms.DockStyle.Fill
        splitLista.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        splitLista.Location = New System.Drawing.Point(0, 0)
        splitLista.Name = "splitLista"
        '
        'splitLista.Panel1
        '
        splitLista.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        splitLista.Panel1.Controls.Add(Me.dgvMensajes)
        splitLista.Panel1.Controls.Add(Me.panelBusqueda)
        splitLista.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 10)
        '
        'splitLista.Panel2
        '
        splitLista.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        splitLista.Panel2.Controls.Add(Me.txtMensaje)
        splitLista.Panel2.Controls.Add(Me.txtTags)
        splitLista.Panel2.Controls.Add(Me.panelArchivos)
        splitLista.Panel2.Controls.Add(Me.dgvArchivos)
        splitLista.Panel2.Controls.Add(panelTop)
        splitLista.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        splitLista.Size = New System.Drawing.Size(808, 495)
        splitLista.SplitterDistance = 214
        splitLista.SplitterWidth = 7
        splitLista.TabIndex = 1
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
        Me.dgvMensajes.Location = New System.Drawing.Point(0, 30)
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
        Me.dgvMensajes.Size = New System.Drawing.Size(214, 455)
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
        'MensajeBindingSource
        '
        Me.MensajeBindingSource.DataSource = GetType(WR.Models.Mensaje)
        '
        'panelBusqueda
        '
        Me.panelBusqueda.Controls.Add(Me.btnBuscar)
        Me.panelBusqueda.Controls.Add(Me.txtBuscar)
        Me.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBusqueda.Location = New System.Drawing.Point(0, 5)
        Me.panelBusqueda.Name = "panelBusqueda"
        Me.panelBusqueda.Padding = New System.Windows.Forms.Padding(3, 5, 0, 5)
        Me.panelBusqueda.Size = New System.Drawing.Size(214, 25)
        Me.panelBusqueda.TabIndex = 0
        Me.panelBusqueda.Visible = False
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
        Me.btnBuscar.Location = New System.Drawing.Point(199, 5)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(15, 15)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.SystemColors.Window
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(3, 5)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(211, 15)
        Me.txtBuscar.TabIndex = 0
        '
        'txtMensaje
        '
        Me.txtMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MensajeBindingSource, "Contenido", True))
        Me.txtMensaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMensaje.Location = New System.Drawing.Point(0, 30)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ReadOnly = True
        Me.txtMensaje.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtMensaje.Size = New System.Drawing.Size(587, 347)
        Me.txtMensaje.TabIndex = 8
        Me.txtMensaje.Text = ""
        '
        'txtTags
        '
        Me.txtTags.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtTags.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTags.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MensajeBindingSource, "Tags", True))
        Me.txtTags.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtTags.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTags.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTags.Location = New System.Drawing.Point(0, 377)
        Me.txtTags.Name = "txtTags"
        Me.txtTags.ReadOnly = True
        Me.txtTags.ShortcutsEnabled = False
        Me.txtTags.Size = New System.Drawing.Size(587, 13)
        Me.txtTags.TabIndex = 8
        '
        'panelArchivos
        '
        Me.panelArchivos.AutoSize = True
        Me.panelArchivos.Controls.Add(Me.lblArchivos)
        Me.panelArchivos.Controls.Add(FlowLayoutPanel1)
        Me.panelArchivos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelArchivos.Location = New System.Drawing.Point(0, 390)
        Me.panelArchivos.Name = "panelArchivos"
        Me.panelArchivos.Padding = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.panelArchivos.Size = New System.Drawing.Size(587, 22)
        Me.panelArchivos.TabIndex = 10
        Me.panelArchivos.Visible = False
        '
        'lblArchivos
        '
        Me.lblArchivos.AutoSize = True
        Me.lblArchivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblArchivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArchivos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblArchivos.Location = New System.Drawing.Point(10, 3)
        Me.lblArchivos.Name = "lblArchivos"
        Me.lblArchivos.Size = New System.Drawing.Size(69, 16)
        Me.lblArchivos.TabIndex = 8
        Me.lblArchivos.Text = "Archivos"
        '
        'FlowLayoutPanel1
        '
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.Controls.Add(Me.btnBorrarArchivo)
        FlowLayoutPanel1.Controls.Add(Me.btnAgregarArchivo)
        FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        FlowLayoutPanel1.Location = New System.Drawing.Point(542, 3)
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
        Me.dgvArchivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ImagenDataGridViewImageColumn, Me.NombreDataGridViewTextBoxColumn, Me.TamanoDataGridViewTextBoxColumn, Me.RutaDataGridViewTextBoxColumn})
        Me.dgvArchivos.DataSource = Me.ListaArchivosBindingSource
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
        Me.dgvArchivos.Size = New System.Drawing.Size(587, 73)
        Me.dgvArchivos.TabIndex = 10
        '
        'ImagenDataGridViewImageColumn
        '
        Me.ImagenDataGridViewImageColumn.DataPropertyName = "Imagen"
        Me.ImagenDataGridViewImageColumn.HeaderText = "Imagen"
        Me.ImagenDataGridViewImageColumn.MinimumWidth = 30
        Me.ImagenDataGridViewImageColumn.Name = "ImagenDataGridViewImageColumn"
        Me.ImagenDataGridViewImageColumn.ReadOnly = True
        Me.ImagenDataGridViewImageColumn.Width = 30
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
        'RutaDataGridViewTextBoxColumn
        '
        Me.RutaDataGridViewTextBoxColumn.DataPropertyName = "Ruta"
        Me.RutaDataGridViewTextBoxColumn.HeaderText = "Ruta"
        Me.RutaDataGridViewTextBoxColumn.Name = "RutaDataGridViewTextBoxColumn"
        Me.RutaDataGridViewTextBoxColumn.ReadOnly = True
        Me.RutaDataGridViewTextBoxColumn.Visible = False
        Me.RutaDataGridViewTextBoxColumn.Width = 5
        '
        'ListaArchivosBindingSource
        '
        Me.ListaArchivosBindingSource.DataMember = "ListaArchivos"
        Me.ListaArchivosBindingSource.DataSource = Me.MensajeBindingSource
        '
        'panelTop
        '
        panelTop.Controls.Add(Me.txtTitulo)
        panelTop.Controls.Add(flpControles)
        panelTop.Dock = System.Windows.Forms.DockStyle.Top
        panelTop.Location = New System.Drawing.Point(0, 0)
        panelTop.Name = "panelTop"
        panelTop.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        panelTop.Size = New System.Drawing.Size(587, 30)
        panelTop.TabIndex = 9
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MensajeBindingSource, "Titulo", True))
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtTitulo.Location = New System.Drawing.Point(10, 5)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.ShortcutsEnabled = False
        Me.txtTitulo.Size = New System.Drawing.Size(462, 15)
        Me.txtTitulo.TabIndex = 4
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'flpControles
        '
        flpControles.AutoSize = True
        flpControles.Controls.Add(Me.btnBorrar)
        flpControles.Controls.Add(Me.btnGuardar)
        flpControles.Controls.Add(Me.btnEditar)
        flpControles.Controls.Add(Me.btnMas)
        flpControles.Dock = System.Windows.Forms.DockStyle.Right
        flpControles.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        flpControles.Location = New System.Drawing.Point(472, 5)
        flpControles.Name = "flpControles"
        flpControles.Size = New System.Drawing.Size(105, 20)
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
        'btnMas
        '
        Me.btnMas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMas.BackgroundImage = Global.WR.InterfaceWin.My.Resources.Resources.Mas
        Me.btnMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMas.FlatAppearance.BorderSize = 0
        Me.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMas.Location = New System.Drawing.Point(85, 0)
        Me.btnMas.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(20, 20)
        Me.btnMas.TabIndex = 8
        Me.btnMas.UseVisualStyleBackColor = True
        '
        'Mensajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(splitLista)
        Me.Name = "Mensajes"
        Me.Size = New System.Drawing.Size(808, 495)
        splitLista.Panel1.ResumeLayout(False)
        splitLista.Panel2.ResumeLayout(False)
        splitLista.Panel2.PerformLayout()
        CType(splitLista, System.ComponentModel.ISupportInitialize).EndInit()
        splitLista.ResumeLayout(False)
        CType(Me.dgvMensajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MensajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBusqueda.ResumeLayout(False)
        Me.panelBusqueda.PerformLayout()
        Me.panelArchivos.ResumeLayout(False)
        Me.panelArchivos.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaArchivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        panelTop.ResumeLayout(False)
        panelTop.PerformLayout()
        flpControles.ResumeLayout(False)
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
    Private WithEvents txtTags As TextBox
    Friend WithEvents dgvArchivos As DataGridView
    Friend WithEvents MensajeBindingSource As BindingSource
    Friend WithEvents TituloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblArchivos As Label
    Private WithEvents btnBorrarArchivo As Button
    Private WithEvents btnAgregarArchivo As Button
    Friend WithEvents PathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImageDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents ListaArchivosBindingSource As BindingSource
    Friend WithEvents panelArchivos As Panel
    Friend WithEvents ImagenDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TamanoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RutaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
