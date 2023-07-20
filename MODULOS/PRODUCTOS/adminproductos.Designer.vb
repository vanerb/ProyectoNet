<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminproductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminproductos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.tbbuscar = New System.Windows.Forms.TextBox()
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.bteliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.PanelUserInfo = New System.Windows.Forms.Panel()
        Me.lbiduser = New System.Windows.Forms.Label()
        Me.btsaveas = New System.Windows.Forms.Button()
        Me.btsave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUserInfo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btSearch)
        Me.Panel2.Controls.Add(Me.tbbuscar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 66)
        Me.Panel2.TabIndex = 5
        '
        'btSearch
        '
        Me.btSearch.BackColor = System.Drawing.Color.Transparent
        Me.btSearch.FlatAppearance.BorderSize = 0
        Me.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSearch.Image = CType(resources.GetObject("btSearch.Image"), System.Drawing.Image)
        Me.btSearch.Location = New System.Drawing.Point(13, 13)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(46, 33)
        Me.btSearch.TabIndex = 2
        Me.btSearch.UseVisualStyleBackColor = False
        '
        'tbbuscar
        '
        Me.tbbuscar.Location = New System.Drawing.Point(65, 20)
        Me.tbbuscar.Name = "tbbuscar"
        Me.tbbuscar.Size = New System.Drawing.Size(685, 20)
        Me.tbbuscar.TabIndex = 1
        '
        'datagrid
        '
        Me.datagrid.AllowUserToAddRows = False
        Me.datagrid.AllowUserToDeleteRows = False
        Me.datagrid.AllowUserToResizeColumns = False
        Me.datagrid.AllowUserToResizeRows = False
        Me.datagrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bteliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.datagrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.datagrid.Location = New System.Drawing.Point(0, 111)
        Me.datagrid.Name = "datagrid"
        Me.datagrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid.RowHeadersVisible = False
        Me.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid.Size = New System.Drawing.Size(800, 339)
        Me.datagrid.TabIndex = 6
        '
        'bteliminar
        '
        Me.bteliminar.HeaderText = "Eliminar"
        Me.bteliminar.Image = CType(resources.GetObject("bteliminar.Image"), System.Drawing.Image)
        Me.bteliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.bteliminar.Name = "bteliminar"
        Me.bteliminar.ReadOnly = True
        '
        'btAdd
        '
        Me.btAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAdd.AutoSize = True
        Me.btAdd.BackColor = System.Drawing.Color.Transparent
        Me.btAdd.FlatAppearance.BorderSize = 0
        Me.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.Location = New System.Drawing.Point(712, 365)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btAdd.Size = New System.Drawing.Size(76, 73)
        Me.btAdd.TabIndex = 7
        Me.btAdd.UseVisualStyleBackColor = False
        '
        'PanelUserInfo
        '
        Me.PanelUserInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.PanelUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelUserInfo.Controls.Add(Me.lbiduser)
        Me.PanelUserInfo.Controls.Add(Me.btsaveas)
        Me.PanelUserInfo.Controls.Add(Me.btsave)
        Me.PanelUserInfo.Controls.Add(Me.btClose)
        Me.PanelUserInfo.Controls.Add(Me.tbPass)
        Me.PanelUserInfo.Controls.Add(Me.tbUser)
        Me.PanelUserInfo.Controls.Add(Me.tbName)
        Me.PanelUserInfo.Controls.Add(Me.Label4)
        Me.PanelUserInfo.Controls.Add(Me.Label3)
        Me.PanelUserInfo.Controls.Add(Me.Label2)
        Me.PanelUserInfo.Controls.Add(Me.DataGridView1)
        Me.PanelUserInfo.Location = New System.Drawing.Point(169, 138)
        Me.PanelUserInfo.Name = "PanelUserInfo"
        Me.PanelUserInfo.Size = New System.Drawing.Size(511, 242)
        Me.PanelUserInfo.TabIndex = 8
        '
        'lbiduser
        '
        Me.lbiduser.AutoSize = True
        Me.lbiduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbiduser.ForeColor = System.Drawing.Color.White
        Me.lbiduser.Location = New System.Drawing.Point(230, 23)
        Me.lbiduser.Name = "lbiduser"
        Me.lbiduser.Size = New System.Drawing.Size(98, 22)
        Me.lbiduser.TabIndex = 9
        Me.lbiduser.Text = "Id usuario"
        '
        'btsaveas
        '
        Me.btsaveas.Location = New System.Drawing.Point(195, 177)
        Me.btsaveas.Name = "btsaveas"
        Me.btsaveas.Size = New System.Drawing.Size(118, 34)
        Me.btsaveas.TabIndex = 8
        Me.btsaveas.Text = "Guardar cambios"
        Me.btsaveas.UseVisualStyleBackColor = True
        '
        'btsave
        '
        Me.btsave.Location = New System.Drawing.Point(217, 177)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(75, 34)
        Me.btsave.TabIndex = 7
        Me.btsave.Text = "Guardar"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.BackColor = System.Drawing.Color.Transparent
        Me.btClose.FlatAppearance.BorderSize = 0
        Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btClose.Image = CType(resources.GetObject("btClose.Image"), System.Drawing.Image)
        Me.btClose.Location = New System.Drawing.Point(469, 3)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(38, 33)
        Me.btClose.TabIndex = 6
        Me.btClose.UseVisualStyleBackColor = False
        '
        'tbPass
        '
        Me.tbPass.Location = New System.Drawing.Point(173, 135)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPass.Size = New System.Drawing.Size(240, 20)
        Me.tbPass.TabIndex = 5
        '
        'tbUser
        '
        Me.tbUser.Location = New System.Drawing.Point(173, 101)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(240, 20)
        Me.tbUser.TabIndex = 4
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(173, 68)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(240, 20)
        Me.tbName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label4.Location = New System.Drawing.Point(71, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Contraseña"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label3.Location = New System.Drawing.Point(71, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label2.Location = New System.Drawing.Point(71, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-79, -59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(73, 336)
        Me.DataGridView1.TabIndex = 3
        '
        'adminproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelUserInfo)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.datagrid)
        Me.Name = "adminproductos"
        Me.Text = "adminproductos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUserInfo.ResumeLayout(False)
        Me.PanelUserInfo.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btSearch As Button
    Friend WithEvents tbbuscar As TextBox
    Friend WithEvents datagrid As DataGridView
    Friend WithEvents bteliminar As DataGridViewImageColumn
    Friend WithEvents btAdd As Button
    Friend WithEvents PanelUserInfo As Panel
    Friend WithEvents lbiduser As Label
    Friend WithEvents btsaveas As Button
    Friend WithEvents btsave As Button
    Friend WithEvents btClose As Button
    Friend WithEvents tbPass As TextBox
    Friend WithEvents tbUser As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
