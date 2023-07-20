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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtcontrasena = New System.Windows.Forms.MaskedTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SeaGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(114, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(46, 92)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(207, 24)
        Me.txtUsuario.TabIndex = 1
        '
        'txtcontrasena
        '
        Me.txtcontrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontrasena.Location = New System.Drawing.Point(46, 151)
        Me.txtcontrasena.Name = "txtcontrasena"
        Me.txtcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontrasena.Size = New System.Drawing.Size(207, 24)
        Me.txtcontrasena.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.SeaGreen
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(43, 126)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(103, 22)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Contraseña"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(184, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.label2)
        Me.Panel1.Controls.Add(Me.txtcontrasena)
        Me.Panel1.Location = New System.Drawing.Point(71, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 305)
        Me.Panel1.TabIndex = 5
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(439, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtcontrasena As MaskedTextBox
    Friend WithEvents label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
