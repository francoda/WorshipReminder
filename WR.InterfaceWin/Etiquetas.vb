Imports System.ComponentModel

Public Class Etiquetas

    <AttributeProvider(GetType(IListSource))>
    Public Property DataSource() As Object
        Get
            Return tagsBindingSource.DataSource
        End Get
        Set(ByVal value As Object)
            tagsBindingSource.DataSource = value
        End Set
    End Property

    Public Property Editable() As Boolean
        Get
            Return panelNewTag.Visible
        End Get
        Set(ByVal value As Boolean)
            txtNewTag.Visible = value
            panelNewTag.Visible = value
            btnAgregar.Visible = value
            For Each tagCtl As Etiqueta In flpTags.Controls.Cast(Of Control).OfType(Of Etiqueta)
                tagCtl.Editable = value
            Next
        End Set
    End Property

    Private Sub tagsBindingSource_ListChanged(sender As Object, e As ListChangedEventArgs) Handles tagsBindingSource.ListChanged
        flpTags.Controls.Clear()
        flpTags.Controls.Add(txtNewTag)
        flpTags.Controls.Add(btnAgregar)
        For Each tag As String In tagsBindingSource.List
            Dim tagCtl As New Etiqueta(tag)
            flpTags.Controls.Add(tagCtl)
            AddHandler tagCtl.Borrar, AddressOf tags_Borrar
        Next
    End Sub

    Private Sub tags_Borrar(ByRef sender As Object, ByVal e As EventArgs)
        tagsBindingSource.Remove(DirectCast(sender, Etiqueta).Titulo)
        flpTags.Controls.Remove(sender)
    End Sub

    Private Sub txtNewTag_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNewTag.KeyDown
        If e.KeyCode = Keys.Enter Then
            Agregar(txtNewTag.Text)
            txtNewTag.Clear()
        End If
        txtNewTag.Select()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Agregar(txtNewTag.Text)
    End Sub

    Private Sub Agregar(tag As String)
        If tag.Length > 0 And Not tagsBindingSource.List.Cast(Of String).Any(Function(x) x = tag) Then
            tagsBindingSource.Add(tag)
        End If
    End Sub


End Class
