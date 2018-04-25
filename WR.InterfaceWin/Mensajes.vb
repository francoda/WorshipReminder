Imports WR.Models

Public Class Mensajes

    Public Property PermitirEditar() As Boolean
        Get
            Return Not txtTitulo.ReadOnly
        End Get
        Set(ByVal Editar As Boolean)
            txtTitulo.ReadOnly = Not Editar
            txtTitulo.BackColor = IIf(Editar, SystemColors.Window, Color.FromArgb(242, 242, 242))
            If MensajeBindingSource.Current IsNot Nothing AndAlso Not DirectCast(MensajeBindingSource.Current, Mensaje).TieneDescripcion Then
                txtMensaje.Clear()
            End If
            txtMensaje.ReadOnly = Not Editar
            txtMensaje.BackColor = IIf(Editar, SystemColors.Window, Color.FromArgb(242, 242, 242))
            panelDetalle.BackColor = IIf(Editar, SystemColors.Window, Color.FromArgb(242, 242, 242))
            tags.Editable = Editar
            btnMas.Visible = Not Editar
            btnEditar.Visible = Not Editar And dgvMensajes.RowCount > 0
            btnBorrar.Visible = Editar
            btnGuardar.Visible = Editar
            panelArchivos.Visible = Editar
            btnAgregarArchivo.Visible = Editar
            btnBorrarArchivo.Visible = Editar And dgvArchivos.CurrentRow IsNot Nothing
            dgvMensajes.Enabled = Not Editar
        End Set
    End Property

    Sub New()
        InitializeComponent()
        splitLista.Panel2Collapsed = True
        MensajeBindingSource.DataSource = New Lista(Of Mensaje)
        MensajeBindingSource.Sort = "Titulo"
        cbTipo.Text = "Titulo"
        PermitirEditar = MensajeBindingSource.Count > 0
    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        MensajeBindingSource.AddNew()
        PermitirEditar = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        PermitirEditar = True
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If MsgBox("¿Desea eliminar el mensaje " &
            dgvMensajes.CurrentRow.Cells(TituloDataGridViewTextBoxColumn.Index).Value & "?",
            MsgBoxStyle.YesNo,
            dgvMensajes.CurrentRow.Cells(TituloDataGridViewTextBoxColumn.Index).Value) = MsgBoxResult.Yes Then
            MensajeBindingSource.RemoveCurrent()
            MensajeBindingSource.DataSource.Guardar()
        End If
        PermitirEditar = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        PermitirEditar = False
        MensajeBindingSource.DataSource.Guardar()
    End Sub

    Private Sub dgvArchivos_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvArchivos.DataBindingComplete
        panelArchivos.Visible = PermitirEditar And dgvArchivos.RowCount > 0
        dgvArchivos.Visible = dgvArchivos.RowCount > 0
        dgvArchivos.Height = (If(dgvArchivos.ColumnHeadersVisible, dgvArchivos.ColumnHeadersHeight, 0)) + dgvArchivos.Rows.OfType(Of DataGridViewRow)().Where(Function(r) r.Visible).Sum(Function(r) r.Height) + 10
    End Sub

    Private Sub dgvArchivos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvArchivos.SelectionChanged
        btnBorrarArchivo.Visible = PermitirEditar And dgvArchivos.CurrentRow IsNot Nothing
    End Sub

    Private Sub btnAgregarArchivo_Click(sender As Object, e As EventArgs) Handles btnAgregarArchivo.Click
        Using filesDialog As New OpenFileDialog
            filesDialog.Multiselect = True
            filesDialog.Title = "Seleccione los archivos que desea agregar a este mensaje"
            If filesDialog.ShowDialog() = DialogResult.OK Then
                For Each file As String In filesDialog.FileNames
                    ArchivosBindingSource.Add(New Archivo(file))
                Next
            End If
        End Using
        MensajeBindingSource.DataSource.Guardar()
    End Sub

    Private Sub btnBorrarArchivo_Click(sender As Object, e As EventArgs) Handles btnBorrarArchivo.Click
        If dgvArchivos.CurrentRow IsNot Nothing AndAlso MsgBox("¿Desea eliminar el archivo " &
                                                               dgvArchivos.CurrentRow.Cells(NombreDataGridViewTextBoxColumn.Index).Value & "?",
                                                               MsgBoxStyle.YesNo,
                                                               dgvArchivos.CurrentRow.Cells(NombreDataGridViewTextBoxColumn.Index).Value) = MsgBoxResult.Yes Then
            ArchivosBindingSource.RemoveCurrent()
            MensajeBindingSource.DataSource.Guardar()
        End If
    End Sub

    Private Sub dgvArchivos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchivos.CellDoubleClick
        If dgvArchivos.CurrentRow IsNot Nothing Then
            Try
                Process.Start(dgvArchivos.CurrentRow.Cells(PathDataGridViewTextBoxColumn.Index).Value)
            Catch
                MsgBox("Error al abrir el archivo" & dgvArchivos.CurrentRow.Cells(NombreDataGridViewTextBoxColumn.Index).Value,
                   MsgBoxStyle.Exclamation, dgvArchivos.CurrentRow.Cells(NombreDataGridViewTextBoxColumn.Index).Value)
            End Try
        End If
    End Sub

    Private Sub txtTitulo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTitulo.Validating
        If MensajeBindingSource.List.Cast(Of Mensaje).Any(Function(x) x.Titulo.Trim.ToLower = txtTitulo.Text.Trim.ToLower And x IsNot MensajeBindingSource.Current) Then
            e.Cancel = True
            MsgBox("Ya existe un mensaje con este Titulo.", MsgBoxStyle.Critical, "Cuidado")
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click, txtBuscar.Validating
        MensajeBindingSource.Find(cbTipo.Text, txtBuscar.Text)
    End Sub

    Private Sub MensajeBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles MensajeBindingSource.CurrentChanged
        splitLista.Panel2Collapsed = MensajeBindingSource.Current Is Nothing
    End Sub
End Class
