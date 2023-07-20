Imports System.Data.SqlClient
Public Class Login
    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        iniciosesion()
        If datauser.RowCount > 1 Then
            Dim id As String = datauser.SelectedCells.Item(0).Value
            Dim form2 As New MainMenu(id)
            form2.Show()
            Dispose()
        Else
            MessageBox.Show("Verifique su usuario y contraseña", "Control de acceso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub


    Sub iniciosesion()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("validar_usuario", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@usuario", tbUsuario.Text)
            da.SelectCommand.Parameters.AddWithValue("@passworduser", tbcontrasena.Text)
            da.Fill(dt)
            datauser.DataSource = dt
            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datauser.Visible = False

    End Sub

    Private Sub btRegistro_Click(sender As Object, e As EventArgs) Handles btRegistro.Click
        Dispose()
        Registro.ShowDialog()
    End Sub
End Class