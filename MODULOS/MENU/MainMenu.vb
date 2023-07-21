Imports System.Data.SqlClient
Public Class MainMenu

    Private id As String
    Public Sub New(ByVal valor As String)
        InitializeComponent()
        id = valor ' Guarda el valor recibido en una variable local del formulario.
    End Sub
    Private Sub btestudiantes_Click(sender As Object, e As EventArgs) Handles btusuarios.Click
        Dispose()
        Dim usurios As New VerUsuarios(id)
        usurios.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
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
                            .nombre = reader("usuario").ToString(),
                            .tipo = reader("tipo").ToString()
                        }
            End If
        End Using

        cerrar()



        lbUsuarioName.Text = usuario.usuarioname
        lbusername.Text = usuario.nombre
        lbTipo.Text = usuario.tipo

        If lbTipo.Text.Equals("admin") = 0 Then
            btusuarios.Visible = True
        Else
            btusuarios.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()
        Login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
        Dim tienda As New Tienda(id)
        tienda.Show()
    End Sub
End Class

