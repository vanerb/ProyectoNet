Imports System.Data.SqlClient
Public Class Tienda
    Private cart As New List(Of String)
    Dim isActive As Boolean

    Private id As String
    Public Sub New(ByVal valor As String)
        InitializeComponent()
        id = valor ' Guarda el valor recibido en una variable local del formulario.
    End Sub

    Private Sub LoadProducts()
        ' Limpiar el ListBox antes de cargar los productos
        'lstCart.Items.Clear()
        cart.Clear()

        abrir()
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("mostrar_producto", conexion)
        cmd.CommandType = 4
        Try

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim productId As String = reader("idproducto").ToString()
                Dim productName As String = reader("nombre").ToString()
                Dim productDescr As String = reader("descripcion").ToString()
                Dim productImg As String = reader("imagen").ToString()
                Dim productStock As String = reader("stock").ToString()
                ' Crear un nuevo botón para el producto

                Dim miniPanel As New Panel()
                miniPanel.BorderStyle = BorderStyle.FixedSingle
                miniPanel.Width = 150
                miniPanel.Height = 200

                ' Crear el PictureBox con la imagen
                Dim pictureBox As New PictureBox()
                pictureBox.Width = 100
                pictureBox.Height = 100
                pictureBox.Image = Image.FromFile(productImg)
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom
                pictureBox.Location = New Point((miniPanel.Width - pictureBox.Width) \ 2, 10)

                ' Crear el botón
                Dim button As New Button()
                button.Text = productName
                button.Tag = productId & "-" & productName
                button.Width = 130
                button.Height = 30
                button.Location = New Point((miniPanel.Width - button.Width) \ 2, 150)
                button.ForeColor = Color.White
                button.TextAlign = ContentAlignment.MiddleCenter

                ' Agregar el PictureBox y el botón al panel
                miniPanel.Controls.Add(pictureBox)
                miniPanel.Controls.Add(button)

                ' Agregar un controlador de eventos para el clic en el botón
                AddHandler button.Click, AddressOf btnProduct_Click

                ' Agregar el botón al panel que contendrá los productos
                pnlProducts.Controls.Add(miniPanel)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos desde la base de datos: " & ex.Message, "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cerrar()

    End Sub

    Private Sub Tienda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        lbUsuarioName.Text = usuario.usuarioname
        lbusername.Text = usuario.nombre
        lbTipo.Text = usuario.tipo
        cerrar()

        isActive = True
        LoadProducts()



    End Sub


    Private Function CheckStock(productId As String) As Boolean


        Dim producto As Producto = Nothing
        abrir()
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("buscar_producto_id", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@idprod", productId)

        Try
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    producto = New Producto() With {
                            .stock = reader("Stock").ToString()
                        }
                End If
            End Using
            Return Integer.Parse(producto.stock) > 0

        Catch ex As Exception
            MessageBox.Show("Error al verificar el stock del producto: " & ex.Message, "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cerrar()

        Return False
    End Function

    Private Function UpdateStock(productId As String) As Boolean
        abrir()
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("restar_stock", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@idproducto", productId)
        cmd.ExecuteNonQuery()
        cerrar()

        Return True


    End Function

    Private Sub btnProduct_Click(sender As Object, e As EventArgs)
        Dim selectedProduct As String = DirectCast(sender, Button).Tag.ToString()
        Dim Productos As String() = selectedProduct.Split("-")

        If CheckStock(Productos(0)) Then
            ' Restar el stock en la base de datos
            If UpdateStock(Productos(0)) Then
                cart.Add(Productos(1))
                carrito.Items.Add(Productos(1))
                lbCount.Text = cart.Count
                MessageBox.Show("Producto agregado al carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al actualizar el stock del producto.", "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("El producto no tiene stock suficiente.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If



    End Sub


    Private Sub btCart_Click(sender As Object, e As EventArgs) Handles btCart.Click


        If isActive = False Then
            carrito.Visible = True
            isActive = True
        Else
            carrito.Visible = False
            isActive = False
        End If



    End Sub

    Private Sub Tienda_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim menu As New MainMenu(id)
        menu.Show()
    End Sub
End Class