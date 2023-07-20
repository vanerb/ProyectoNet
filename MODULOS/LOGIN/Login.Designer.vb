<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbcontrasena = New System.Windows.Forms.MaskedTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btlogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.datauser = New System.Windows.Forms.DataGridView()
        Me.btRegistro = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datauser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'tbUsuario
        '
        Me.tbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.Location = New System.Drawing.Point(50, 160)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(207, 24)
        Me.tbUsuario.TabIndex = 1
        '
        'tbcontrasena
        '
        Me.tbcontrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcontrasena.Location = New System.Drawing.Point(50, 219)
        Me.tbcontrasena.Name = "tbcontrasena"
        Me.tbcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbcontrasena.Size = New System.Drawing.Size(207, 24)
        Me.tbcontrasena.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(47, 194)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(103, 22)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Contraseña"
        '
        'btlogin
        '
        Me.btlogin.Location = New System.Drawing.Point(57, 274)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(75, 36)
        Me.btlogin.TabIndex = 4
        Me.btlogin.Text = "Login"
        Me.btlogin.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btRegistro)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.tbUsuario)
        Me.Panel1.Controls.Add(Me.btlogin)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.label2)
        Me.Panel1.Controls.Add(Me.tbcontrasena)
        Me.Panel1.Location = New System.Drawing.Point(68, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 327)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'datauser
        '
        Me.datauser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datauser.Location = New System.Drawing.Point(12, 3)
        Me.datauser.Name = "datauser"
        Me.datauser.Size = New System.Drawing.Size(415, 60)
        Me.datauser.TabIndex = 6
        '
        'btRegistro
        '
        Me.btRegistro.Location = New System.Drawing.Point(171, 274)
        Me.btRegistro.Name = "btRegistro"
        Me.btRegistro.Size = New System.Drawing.Size(75, 36)
        Me.btRegistro.TabIndex = 6
        Me.btRegistro.Text = "Registrarse"
        Me.btRegistro.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(439, 450)
        Me.Controls.Add(Me.datauser)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datauser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents tbcontrasena As MaskedTextBox
    Friend WithEvents label2 As Label
    Friend WithEvents btlogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents datauser As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btRegistro As Button
End Class
