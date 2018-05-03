Imports System.IO
Imports WR.Models
Imports Microsoft.Office.Interop.Word

Public Class Mensajes

    Public Property PermitirEditar() As Boolean
        Get
            Return Not txtTitulo.ReadOnly
        End Get
        Set(ByVal Editar As Boolean)
            txtTitulo.ReadOnly = Not Editar
            txtTitulo.BackColor = IIf(Editar, SystemColors.Window, Color.FromArgb(242, 242, 242))
            splitMesajePreview.Panel1Collapsed = Not Editar
            splitMesajePreview.Panel2Collapsed = Editar Or (MensajeBindingSource.Current IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(DirectCast(MensajeBindingSource.Current, Mensaje).Descripcion))
            txtMensaje.ReadOnly = Not Editar
            txtMensaje.BackColor = IIf(Editar, SystemColors.Window, Color.FromArgb(242, 242, 242))
            panelDetalle.BackColor = IIf(Editar, SystemColors.Window, Color.FromArgb(242, 242, 242))
            tags.Editable = Editar
            btnMas.Visible = Not Editar
            btnEditar.Visible = Not Editar And dgvMensajes.RowCount > 0
            btnBorrar.Visible = Editar
            btnGuardar.Visible = Editar
            panelArchivos.Visible = Editar Or ArchivosBindingSource.Count > 0
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

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click, NuevoToolStripMenuItem.Click
        MensajeBindingSource.AddNew()
        PermitirEditar = True
    End Sub

    Private Sub ImportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarToolStripMenuItem.Click
        Using filesDialog As New OpenFileDialog
            filesDialog.Multiselect = True
            filesDialog.Title = "Seleccione los archivos que desea agregar a este mensaje"
            If filesDialog.ShowDialog() = DialogResult.OK Then
                MensajeBindingSource.AddNew()
                PermitirEditar = True
                For Each file As String In filesDialog.FileNames
                    If file.Contains(".doc") Or filesDialog.FileNames.Count = 0 Then
                        txtTitulo.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Path.GetFileNameWithoutExtension(file).ToLower)
                    End If
                    If file.ToLower.Contains("tema") Then
                        tags.Agregar(Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Path.GetDirectoryName(file).Split("\").Last().ToLower))
                    End If
                    ArchivosBindingSource.Add(New Archivo(file))
                Next
            End If
        End Using
    End Sub

    Private Sub ImportarVariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarVariosToolStripMenuItem.Click
        Using filesDialog As New OpenFileDialog
            filesDialog.Multiselect = True
            filesDialog.Title = "Seleccione los archivos que desea agregar a este mensaje"
            If filesDialog.ShowDialog() = DialogResult.OK Then
                For Each file As String In filesDialog.FileNames
                    MensajeBindingSource.AddNew()
                    PermitirEditar = True
                    txtTitulo.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Path.GetFileNameWithoutExtension(file).ToLower)
                    If file.ToLower.Contains("tema") Then
                        tags.Agregar(Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Path.GetDirectoryName(file).Split("\").Last().ToLower))
                    End If
                    ArchivosBindingSource.Add(New Archivo(file))
                    PermitirEditar = False
                    MensajeBindingSource.DataSource.Guardar()
                Next
            End If
        End Using
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        MensajeBindingSource.Find(cbTipo.Text, txtBuscar.Text)
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            MensajeBindingSource.Find(cbTipo.Text, txtBuscar.Text)
        End If
    End Sub

    Private Sub MensajeBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles MensajeBindingSource.CurrentChanged
        splitLista.Panel2Collapsed = MensajeBindingSource.Current Is Nothing
        If MensajeBindingSource.Current IsNot Nothing AndAlso String.IsNullOrWhiteSpace(DirectCast(MensajeBindingSource.Current, Mensaje).Descripcion) AndAlso DirectCast(MensajeBindingSource.Current, Mensaje).Archivos.Any(Function(x) Path.GetExtension(x.Nombre).Remove(0, 1).ToLower().Contains("doc")) Then
            Dim descripcionWord As String = String.Empty
            Dim objNull = Reflection.Missing.Value
            Dim Doc As Document = New Application().Documents.Open(DirectCast(MensajeBindingSource.Current, Mensaje).Archivos.First(Function(x) Path.GetExtension(x.Nombre).Remove(0, 1).ToLower().Contains("doc")).Ruta, objNull, True, objNull, objNull, objNull, objNull, objNull, objNull, objNull, objNull, objNull, objNull, objNull, objNull)
            Doc.ActiveWindow.Selection.WholeStory()
            Doc.ActiveWindow.Selection.Copy()
            txtPreviewWord.Text = Clipboard.GetDataObject().GetData(DataFormats.Text).ToString()
            Doc.Close()
        Else
            txtPreviewWord.Text = String.Empty
        End If
    End Sub

    Private Sub MensajeBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles MensajeBindingSource.CurrentItemChanged
        tags.AutoCompleteCustomSource.Clear()
        tags.AutoCompleteCustomSource.AddRange(MensajeBindingSource.Cast(Of Mensaje).SelectMany(Function(x) x.Tags).ToArray)
    End Sub

    Private Sub ArchivosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ArchivosBindingSource.CurrentChanged
        panelArchivos.Visible = PermitirEditar Or ArchivosBindingSource.Count > 0
    End Sub
End Class
