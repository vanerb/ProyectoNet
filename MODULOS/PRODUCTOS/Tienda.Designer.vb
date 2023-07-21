<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tienda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tienda))
        Me.carrito = New System.Windows.Forms.ListBox()
        Me.pnlProducts = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbCount = New System.Windows.Forms.Label()
        Me.btCart = New System.Windows.Forms.Button()
        Me.TopMenu = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbTipo = New System.Windows.Forms.Label()
        Me.lbusername = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbUsuarioName = New System.Windows.Forms.Label()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.TopMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'carrito
        '
        Me.carrito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.carrito.BackColor = System.Drawing.Color.Black
        Me.carrito.ForeColor = System.Drawing.Color.White
        Me.carrito.FormattingEnabled = True
        Me.carrito.Location = New System.Drawing.Point(20, 42)
        Me.carrito.Name = "carrito"
        Me.carrito.ScrollAlwaysVisible = True
        Me.carrito.Size = New System.Drawing.Size(180, 238)
        Me.carrito.TabIndex = 2
        '
        'pnlProducts
        '
        Me.pnlProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlProducts.AutoSize = True
        Me.pnlProducts.Location = New System.Drawing.Point(0, 0)
        Me.pnlProducts.Name = "pnlProducts"
        Me.pnlProducts.Size = New System.Drawing.Size(581, 548)
        Me.pnlProducts.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lbCount)
        Me.Panel1.Controls.Add(Me.btCart)
        Me.Panel1.Controls.Add(Me.carrito)
        Me.Panel1.Location = New System.Drawing.Point(581, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 542)
        Me.Panel1.TabIndex = 4
        '
        'lbCount
        '
        Me.lbCount.AutoSize = True
        Me.lbCount.BackColor = System.Drawing.Color.Transparent
        Me.lbCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCount.ForeColor = System.Drawing.Color.Maroon
        Me.lbCount.Location = New System.Drawing.Point(183, 3)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(17, 18)
        Me.lbCount.TabIndex = 4
        Me.lbCount.Text = "0"
        '
        'btCart
        '
        Me.btCart.BackgroundImage = CType(resources.GetObject("btCart.BackgroundImage"), System.Drawing.Image)
        Me.btCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btCart.FlatAppearance.BorderSize = 0
        Me.btCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCart.Location = New System.Drawing.Point(144, 3)
        Me.btCart.Name = "btCart"
        Me.btCart.Size = New System.Drawing.Size(43, 33)
        Me.btCart.TabIndex = 3
        Me.btCart.UseVisualStyleBackColor = True
        '
        'TopMenu
        '
        Me.TopMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.TopMenu.Controls.Add(Me.Panel2)
        Me.TopMenu.Controls.Add(Me.PictureBox1)
        Me.TopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopMenu.Location = New System.Drawing.Point(0, 0)
        Me.TopMenu.Name = "TopMenu"
        Me.TopMenu.Size = New System.Drawing.Size(800, 75)
        Me.TopMenu.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbTipo)
        Me.Panel2.Controls.Add(Me.lbusername)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.lbUsuarioName)
        Me.Panel2.Controls.Add(Me.lbUsuario)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(569, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(231, 75)
        Me.Panel2.TabIndex = 4
        '
        'lbTipo
        '
        Me.lbTipo.AutoSize = True
        Me.lbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipo.ForeColor = System.Drawing.Color.White
        Me.lbTipo.Location = New System.Drawing.Point(67, 49)
        Me.lbTipo.Name = "lbTipo"
        Me.lbTipo.Size = New System.Drawing.Size(45, 13)
        Me.lbTipo.TabIndex = 6
        Me.lbTipo.Text = "Label5"
        '
        'lbusername
        '
        Me.lbusername.AutoSize = True
        Me.lbusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbusername.ForeColor = System.Drawing.Color.White
        Me.lbusername.Location = New System.Drawing.Point(62, 28)
        Me.lbusername.Name = "lbusername"
        Me.lbusername.Size = New System.Drawing.Size(67, 18)
        Me.lbusername.TabIndex = 4
        Me.lbusername.Text = "Usuario"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(18, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'lbUsuarioName
        '
        Me.lbUsuarioName.AutoSize = True
        Me.lbUsuarioName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuarioName.ForeColor = System.Drawing.Color.White
        Me.lbUsuarioName.Location = New System.Drawing.Point(62, 9)
        Me.lbUsuarioName.Name = "lbUsuarioName"
        Me.lbUsuarioName.Size = New System.Drawing.Size(67, 18)
        Me.lbUsuarioName.TabIndex = 3
        Me.lbUsuarioName.Text = "Usuario"
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.ForeColor = System.Drawing.Color.White
        Me.lbUsuario.Location = New System.Drawing.Point(3, 49)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(58, 13)
        Me.lbUsuario.TabIndex = 1
        Me.lbUsuario.Text = "Id_Usuario"
        Me.lbUsuario.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.pnlProducts)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 75)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(581, 548)
        Me.Panel3.TabIndex = 6
        '
        'Tienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 623)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TopMenu)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Tienda"
        Me.Text = "Tienda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TopMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents carrito As ListBox
    Friend WithEvents pnlProducts As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbCount As Label
    Friend WithEvents btCart As Button
    Friend WithEvents TopMenu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbTipo As Label
    Friend WithEvents lbusername As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbUsuarioName As Label
    Friend WithEvents lbUsuario As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
End Class
