Imports WR.Models

Public Class Contactos

    Public Property PermitirEditar() As Boolean
        Get
            Return Not txtTitulo.ReadOnly
        End Get
        Set(ByVal Editar As Boolean)
            txtTitulo.ReadOnly = Not Editar
            txtTitulo.BackColor = IIf(Editar, SystemColors.Window, Color.FromArgb(242, 242, 242))
            txtDireccion.ReadOnly = Not Editar
            txtDireccion.BackColor = IIf(Editar, SystemColors.Window, Color.FromArgb(242, 242, 242))
            txtLocalidad.ReadOnly = Not Editar
            txtLocalidad.BackColor = IIf(Editar, SystemColors.Window, Color.FromArgb(242, 242, 242))
            btnMas.Visible = Not Editar
            btnEditar.Visible = Not Editar And dgvIglesias.RowCount > 0
            btnEditarContacto.Visible = Editar And dgvContactos.RowCount > 0
            btnBorrar.Visible = Editar
            btnGuardar.Visible = Editar
            panelContactos.Visible = Editar Or ContactosBindingSource.Count > 0
            btnAgregarContacto.Visible = Editar
            btnBorrarContacto.Visible = Editar And dgvContactos.CurrentRow IsNot Nothing
            dgvIglesias.Enabled = Not Editar
            dgvContactos.ReadOnly = Not Editar
            spliterMensajes.Panel2Collapsed = Not Editar
            MensajeBindingSource.DataSource = New Lista(Of Mensaje)().Where(Function(x) IglesiaBindingSource.Current Is Nothing OrElse Not DirectCast(IglesiaBindingSource.Current, Iglesia).Mensajes.Any(Function(y) y.Equals(x))).ToList
        End Set
    End Property

    Sub New()
        InitializeComponent()
        splitLista.Panel2Collapsed = True
        IglesiaBindingSource.DataSource = New Lista(Of Iglesia)
        IglesiaBindingSource.Sort = "Nombre"
        cbTipo.Text = "Nombre"
        PermitirEditar = IglesiaBindingSource.Count > 0
    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        IglesiaBindingSource.AddNew()
        PermitirEditar = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        PermitirEditar = True
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If MsgBox("¿Desea eliminar el mensaje " &
            dgvIglesias.CurrentRow.Cells(NombreDataGridViewTextBoxColumn.Index).Value & "?",
            MsgBoxStyle.YesNo,
            dgvIglesias.CurrentRow.Cells(NombreDataGridViewTextBoxColumn.Index).Value) = MsgBoxResult.Yes Then
            IglesiaBindingSource.RemoveCurrent()
            IglesiaBindingSource.DataSource.Guardar()
        End If
        PermitirEditar = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        PermitirEditar = False
        IglesiaBindingSource.DataSource.Guardar()
    End Sub

    Private Sub dgvContactos_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvContactos.DataBindingComplete
        panelContactos.Visible = PermitirEditar And dgvContactos.RowCount > 0
        dgvContactos.Visible = dgvContactos.RowCount > 0
        dgvContactos.Height = (If(dgvContactos.ColumnHeadersVisible, dgvContactos.ColumnHeadersHeight, 0)) + dgvContactos.Rows.OfType(Of DataGridViewRow)().Where(Function(r) r.Visible).Sum(Function(r) r.Height) + 10
    End Sub

    Private Sub dgvContactos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvContactos.SelectionChanged
        btnBorrarContacto.Visible = PermitirEditar And dgvContactos.CurrentRow IsNot Nothing
    End Sub

    Private Sub btnAgregarArchivo_Click(sender As Object, e As EventArgs) Handles btnAgregarContacto.Click
        ContactosBindingSource.AddNew()
    End Sub

    Private Sub btnBorrarArchivo_Click(sender As Object, e As EventArgs) Handles btnBorrarContacto.Click
        ContactosBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnAgregarMensajes_Click(sender As Object, e As EventArgs) Handles btnAgregarMensajes.Click
        For Each dr As DataGridViewRow In dgvMensajes.SelectedRows
            MensajesCargadosBindingSource.Add(dr.DataBoundItem)
            MensajeBindingSource.Remove(dr.DataBoundItem)
        Next
    End Sub

    Private Sub btnBorrarMensajes_Click(sender As Object, e As EventArgs) Handles btnBorrarMensajes.Click
        For Each dr As DataGridViewRow In dgvMensajesCargados.SelectedRows
            MensajeBindingSource.Add(dr.DataBoundItem)
            MensajesCargadosBindingSource.Remove(dr.DataBoundItem)
        Next
    End Sub

    Private Sub btnEditarContacto_Click(sender As Object, e As EventArgs) Handles btnEditarContacto.Click
        If dgvContactos.CurrentRow IsNot Nothing Then
            dgvContactos.BeginEdit(False)
        End If
    End Sub

    Private Sub txtTitulo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTitulo.Validating
        If IglesiaBindingSource.List.Cast(Of Iglesia).Any(Function(x) x.Nombre.Trim.ToLower = txtTitulo.Text.Trim.ToLower) Then
            e.Cancel = True
            MsgBox("Ya existe una Iglesia con este nombre.", MsgBoxStyle.Critical, "Cuidado")
        End If
    End Sub

    Private Sub IglesiaBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles IglesiaBindingSource.CurrentChanged
        splitLista.Panel2Collapsed = IglesiaBindingSource.Current Is Nothing
    End Sub

    Private Sub ContactosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ContactosBindingSource.CurrentChanged
        panelContactos.Visible = PermitirEditar Or ContactosBindingSource.Count > 0
    End Sub
End Class
