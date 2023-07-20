Imports System.Data.SqlClient
Imports System.IO
Public Class adminproductos

    Dim rutaImagen As String
    Private id As String
    Public Sub New(ByVal valor As String)
        InitializeComponent()
        id = valor ' Guarda el valor recibido en una variable local del formulario.
    End Sub
    Private Sub btsubir_Click(sender As Object, e As EventArgs) Handles btsubir.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos (*.*)|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Obtener la ruta completa del archivo seleccionado
            rutaImagen = openFileDialog.FileName

            ' Mostrar la imagen en el PictureBox
            pbprod.Image = Image.FromFile(rutaImagen)
        End If
    End Sub

    Private Sub btmas_Click(sender As Object, e As EventArgs) Handles btmas.Click
        Dim n As Integer
        n = tbStock.Text
        n += 1
        tbStock.Text = n
    End Sub

    Private Sub btmenos_Click(sender As Object, e As EventArgs) Handles btmenos.Click
        Dim n As Integer
        n = tbStock.Text

        If n > 0 Then
            n -= 1
            tbStock.Text = n
        End If
    End Sub

    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click
        Try
            Dim cmd As New SqlCommand
            Dim bytesImagen() As Byte = File.ReadAllBytes(rutaImagen)

            abrir()
            cmd = New SqlCommand("insertar_producto", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@nombre", tbName.Text)
            cmd.Parameters.AddWithValue("@descripcion", tbDescr.Text)
            cmd.Parameters.AddWithValue("@serial", tbSerial.Text)
            cmd.Parameters.AddWithValue("@stock", tbStock.Text)
            cmd.Parameters.AddWithValue("@imagen", rutaImagen)
            cmd.Parameters.AddWithValue("@id_usuario", lbUsuario.Text)

            cmd.ExecuteNonQuery()
            cerrar()

            Mostrar()
            PanelProdInfo.Visible = False

        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub

    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_producto", conexion)
            da.Fill(dt)
            datagrid.DataSource = dt
            cerrar()
            Multilinea(datagrid)

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub adminproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Mostrar()
        MostrarImagen()


        lbUsuario.Text = id
        PanelProdInfo.Visible = False
        btsave.Visible = False
        btsaveas.Visible = False
        lbUsuario.Visible = False
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        PanelProdInfo.Visible = True

        btsave.Visible = True
        btsaveas.Visible = False
    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        PanelProdInfo.Visible = False
    End Sub



    Private Sub datagrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid.CellClick
        MostrarImagen()

        If e.ColumnIndex = Me.datagrid.Columns.Item("bteliminar").Index Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Realmente estás seguro de que quieres eliminar este elemento?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("eliminar_producto", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idproducto", datagrid.SelectedCells.Item(2).Value)
                    cmd.ExecuteNonQuery()
                    cerrar()
                    Mostrar()
                Catch ex As Exception

                End Try

            End If

        End If
    End Sub

    Private Sub datagrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid.CellDoubleClick
        Try
            btsave.Visible = False
            btsaveas.Visible = True
            PanelProdInfo.Visible = True
            lbidprod.Text = datagrid.SelectedCells.Item(2).Value
            tbName.Text = datagrid.SelectedCells.Item(3).Value
            tbDescr.Text = datagrid.SelectedCells.Item(4).Value
            tbSerial.Text = datagrid.SelectedCells.Item(5).Value
            tbStock.Text = datagrid.SelectedCells.Item(6).Value
            Dim imageData As Byte() = File.ReadAllBytes(datagrid.SelectedCells.Item(7).Value)
            Using memoryStream As New MemoryStream(imageData)
                pbprod.Image = Image.FromStream(memoryStream)
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btsaveas_Click(sender As Object, e As EventArgs) Handles btsaveas.Click
        Try


            Dim cmd As New SqlCommand
            Dim bytesImagen() As Byte = File.ReadAllBytes(rutaImagen)
            abrir()
            cmd = New SqlCommand("editar_producto", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idproducto", lbidprod.Text)
            cmd.Parameters.AddWithValue("@nombre", tbName.Text)
            cmd.Parameters.AddWithValue("@descripcion", tbDescr.Text)
            cmd.Parameters.AddWithValue("@serial", tbSerial.Text)
            cmd.Parameters.AddWithValue("@stock", tbStock.Text)
            cmd.Parameters.AddWithValue("@imagen", rutaImagen)
            cmd.ExecuteNonQuery()
            cerrar()
            Mostrar()
            PanelProdInfo.Visible = False

        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub tbbuscar_TextChanged(sender As Object, e As EventArgs) Handles tbbuscar.TextChanged
        buscar()
    End Sub

    Sub MostrarImagen()
        Dim imageData As Byte() = File.ReadAllBytes(datagrid.SelectedCells.Item(7).Value)
        Using memoryStream As New MemoryStream(imageData)
            imgvisualizer.Image = Image.FromStream(memoryStream)
        End Using
    End Sub


    Sub buscar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Try
            abrir()
            da = New SqlDataAdapter("buscar_producto", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", tbbuscar.Text)

            da.Fill(dt)
            datagrid.DataSource = dt
            cerrar()
            Multilinea(datagrid)
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class