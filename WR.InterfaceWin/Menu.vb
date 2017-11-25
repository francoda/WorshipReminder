Imports WR.Models

Public Class Menu

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Mostrar(ByVal controlShow As UserControl)
        For Each control As Control In Controls
            If TypeOf control Is UserControl Then
                control.Visible = control Is controlShow
            End If
        Next
    End Sub

    Private Sub btnMensajes_Click(sender As Object, e As EventArgs) Handles btnMensajes.Click
        Mostrar(MenuMensajes)
    End Sub

    Private Sub btnContactos_Click(sender As Object, e As EventArgs) Handles btnContactos.Click
        Mostrar(MenuContactos)
    End Sub
End Class
