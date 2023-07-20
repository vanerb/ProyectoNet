Imports System.Data.SqlClient
Public Class MainMenu

    Private id As String
    Public Sub New(ByVal valor As String)
        InitializeComponent()
        id = valor ' Guarda el valor recibido en una variable local del formulario.
    End Sub
    Private Sub btestudiantes_Click(sender As Object, e As EventArgs) Handles btestudiantes.Click

        Dim usurios As New VerUsuarios(id)
        usurios.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim productos As New adminproductos(id)
        productos.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        lbUsuario.Text = id
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuario As Usuario = Nothing
        abrir()
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("buscar_usuario_por_id", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@idusuario", id)

        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                usuario = New Usuario() With {
                            .usuarioname = reader("nombre").ToString(),
                            .nombre = reader("usuario").ToString()
                        }
            End If
        End Using

        cerrar()

        lbUsuarioName.Text = usuario.usuarioname
        lbusername.Text = usuario.nombre
    End Sub
End Class

Public Class Usuario
    Public Property usuarioname As String
    Public Property nombre As String
End Class