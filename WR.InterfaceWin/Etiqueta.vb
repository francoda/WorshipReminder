Public Class Etiqueta

    Public Event Borrar(ByRef sender As Object, ByVal e As EventArgs)

    Public Property Titulo() As String
        Get
            Return lblNombre.Text
        End Get
        Set(ByVal value As String)
            lblNombre.Text = value
        End Set
    End Property

    Public Property Editable() As Boolean
        Get
            Return btnBorrar.Visible
        End Get
        Set(ByVal value As Boolean)
            btnBorrar.Visible = value
        End Set
    End Property

    Public Sub New(tag As String)
        InitializeComponent()
        Titulo = tag
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        RaiseEvent Borrar(Me, e)
    End Sub
End Class
