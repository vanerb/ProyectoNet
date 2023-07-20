Imports System.Data.SqlClient
Public Class Registro
    Private Sub btRegistro_Click(sender As Object, e As EventArgs) Handles btRegistro.Click
        Try
            Dim cmd As New SqlCommand

            abrir()
            cmd = New SqlCommand("insertar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@nombre", tbName.Text)
            cmd.Parameters.AddWithValue("@usuario", tbUsuario.Text)
            cmd.Parameters.AddWithValue("@password", tbcontrasena.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            Dispose()
            Login.ShowDialog()

        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub
End Class