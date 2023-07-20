Public Class MainMenu

    Private id As String
    Public Sub New(ByVal valor As String)
        InitializeComponent()
        id = valor ' Guarda el valor recibido en una variable local del formulario.
    End Sub
    Private Sub btestudiantes_Click(sender As Object, e As EventArgs) Handles btestudiantes.Click
        VerUsuarios.ShowDialog()
    End Sub
End Class