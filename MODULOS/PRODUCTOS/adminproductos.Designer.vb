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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminproductos))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.tbbuscar = New System.Windows.Forms.TextBox()
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.bteliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.PanelProdInfo = New System.Windows.Forms.Panel()
        Me.btsubir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pbprod = New System.Windows.Forms.PictureBox()
        Me.btmenos = New System.Windows.Forms.Button()
        Me.btmas = New System.Windows.Forms.Button()
        Me.tbStock = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbidprod = New System.Windows.Forms.Label()
        Me.btsaveas = New System.Windows.Forms.Button()
        Me.btsave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.tbSerial = New System.Windows.Forms.TextBox()
        Me.tbDescr = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pbVisualizer = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbTipo = New System.Windows.Forms.Label()
        Me.lbusername = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbUsuarioName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProdInfo.SuspendLayout()
        CType(Me.pbprod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVisualizer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btSearch)
        Me.Panel2.Controls.Add(Me.tbbuscar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(977, 66)
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
        Me.tbbuscar.Size = New System.Drawing.Size(646, 20)
        Me.tbbuscar.TabIndex = 1
        '
        'datagrid
        '
        Me.datagrid.AllowUserToAddRows = False
        Me.datagrid.AllowUserToDeleteRows = False
        Me.datagrid.AllowUserToResizeColumns = False
        Me.datagrid.AllowUserToResizeRows = False
        Me.datagrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.datagrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.datagrid.Location = New System.Drawing.Point(0, 65)
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
        Me.datagrid.RowTemplate.Height = 30
        Me.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid.Size = New System.Drawing.Size(851, 406)
        Me.datagrid.TabIndex = 6
        '
        'bteliminar
        '
        Me.bteliminar.Frozen = True
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
        Me.btAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btAdd.FlatAppearance.BorderSize = 0
        Me.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.Location = New System.Drawing.Point(35, 317)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btAdd.Size = New System.Drawing.Size(76, 73)
        Me.btAdd.TabIndex = 7
        Me.btAdd.UseVisualStyleBackColor = False
        '
        'PanelProdInfo
        '
        Me.PanelProdInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.PanelProdInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelProdInfo.Controls.Add(Me.btsubir)
        Me.PanelProdInfo.Controls.Add(Me.Label5)
        Me.PanelProdInfo.Controls.Add(Me.pbprod)
        Me.PanelProdInfo.Controls.Add(Me.btmenos)
        Me.PanelProdInfo.Controls.Add(Me.btmas)
        Me.PanelProdInfo.Controls.Add(Me.tbStock)
        Me.PanelProdInfo.Controls.Add(Me.Label1)
        Me.PanelProdInfo.Controls.Add(Me.lbidprod)
        Me.PanelProdInfo.Controls.Add(Me.btsaveas)
        Me.PanelProdInfo.Controls.Add(Me.btsave)
        Me.PanelProdInfo.Controls.Add(Me.btClose)
        Me.PanelProdInfo.Controls.Add(Me.tbSerial)
        Me.PanelProdInfo.Controls.Add(Me.tbDescr)
        Me.PanelProdInfo.Controls.Add(Me.tbName)
        Me.PanelProdInfo.Controls.Add(Me.Label4)
        Me.PanelProdInfo.Controls.Add(Me.Label3)
        Me.PanelProdInfo.Controls.Add(Me.Label2)
        Me.PanelProdInfo.Controls.Add(Me.DataGridView1)
        Me.PanelProdInfo.Location = New System.Drawing.Point(233, 20)
        Me.PanelProdInfo.Name = "PanelProdInfo"
        Me.PanelProdInfo.Size = New System.Drawing.Size(511, 408)
        Me.PanelProdInfo.TabIndex = 8
        '
        'btsubir
        '
        Me.btsubir.Location = New System.Drawing.Point(281, 308)
        Me.btsubir.Name = "btsubir"
        Me.btsubir.Size = New System.Drawing.Size(75, 23)
        Me.btsubir.TabIndex = 16
        Me.btsubir.Text = "Subir"
        Me.btsubir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label5.Location = New System.Drawing.Point(71, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Imagen"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pbprod
        '
        Me.pbprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbprod.Location = New System.Drawing.Point(173, 243)
        Me.pbprod.Name = "pbprod"
        Me.pbprod.Size = New System.Drawing.Size(101, 89)
        Me.pbprod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbprod.TabIndex = 14
        Me.pbprod.TabStop = False
        '
        'btmenos
        '
        Me.btmenos.Location = New System.Drawing.Point(385, 217)
        Me.btmenos.Name = "btmenos"
        Me.btmenos.Size = New System.Drawing.Size(28, 20)
        Me.btmenos.TabIndex = 13
        Me.btmenos.Text = "-"
        Me.btmenos.UseVisualStyleBackColor = True
        '
        'btmas
        '
        Me.btmas.Location = New System.Drawing.Point(352, 217)
        Me.btmas.Name = "btmas"
        Me.btmas.Size = New System.Drawing.Size(28, 20)
        Me.btmas.TabIndex = 12
        Me.btmas.Text = "+"
        Me.btmas.UseVisualStyleBackColor = True
        '
        'tbStock
        '
        Me.tbStock.Location = New System.Drawing.Point(173, 217)
        Me.tbStock.Name = "tbStock"
        Me.tbStock.Size = New System.Drawing.Size(164, 20)
        Me.tbStock.TabIndex = 11
        Me.tbStock.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.Location = New System.Drawing.Point(71, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Stock"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbidprod
        '
        Me.lbidprod.AutoSize = True
        Me.lbidprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbidprod.ForeColor = System.Drawing.Color.White
        Me.lbidprod.Location = New System.Drawing.Point(230, 23)
        Me.lbidprod.Name = "lbidprod"
        Me.lbidprod.Size = New System.Drawing.Size(110, 22)
        Me.lbidprod.TabIndex = 9
        Me.lbidprod.Text = "Id producto"
        '
        'btsaveas
        '
        Me.btsaveas.Location = New System.Drawing.Point(198, 339)
        Me.btsaveas.Name = "btsaveas"
        Me.btsaveas.Size = New System.Drawing.Size(118, 35)
        Me.btsaveas.TabIndex = 8
        Me.btsaveas.Text = "Guardar cambios"
        Me.btsaveas.UseVisualStyleBackColor = True
        '
        'btsave
        '
        Me.btsave.Location = New System.Drawing.Point(217, 340)
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
        'tbSerial
        '
        Me.tbSerial.Location = New System.Drawing.Point(173, 191)
        Me.tbSerial.Name = "tbSerial"
        Me.tbSerial.Size = New System.Drawing.Size(240, 20)
        Me.tbSerial.TabIndex = 5
        '
        'tbDescr
        '
        Me.tbDescr.Location = New System.Drawing.Point(173, 101)
        Me.tbDescr.Multiline = True
        Me.tbDescr.Name = "tbDescr"
        Me.tbDescr.Size = New System.Drawing.Size(240, 84)
        Me.tbDescr.TabIndex = 4
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
        Me.Label4.Location = New System.Drawing.Point(71, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Serial"
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
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripcion"
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
        'pbVisualizer
        '
        Me.pbVisualizer.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbVisualizer.Location = New System.Drawing.Point(13, 16)
        Me.pbVisualizer.Name = "pbVisualizer"
        Me.pbVisualizer.Size = New System.Drawing.Size(101, 88)
        Me.pbVisualizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbVisualizer.TabIndex = 9
        Me.pbVisualizer.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pbVisualizer)
        Me.Panel1.Controls.Add(Me.btAdd)
        Me.Panel1.Location = New System.Drawing.Point(851, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(126, 406)
        Me.Panel1.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbTipo)
        Me.Panel3.Controls.Add(Me.lbusername)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.lbUsuarioName)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(746, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(231, 66)
        Me.Panel3.TabIndex = 6
        '
        'lbTipo
        '
        Me.lbTipo.AutoSize = True
        Me.lbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipo.ForeColor = System.Drawing.Color.White
        Me.lbTipo.Location = New System.Drawing.Point(67, 49)
        Me.lbTipo.Name = "lbTipo"
        Me.lbTipo.Size = New System.Drawing.Size(45, 13)
        Me.lbTipo.TabIndex = 5
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Id_Usuario"
        Me.Label6.Visible = False
        '
        'adminproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 471)
        Me.Controls.Add(Me.PanelProdInfo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.datagrid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "adminproductos"
        Me.Text = "adminproductos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProdInfo.ResumeLayout(False)
        Me.PanelProdInfo.PerformLayout()
        CType(Me.pbprod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVisualizer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btSearch As Button
    Friend WithEvents tbbuscar As TextBox
    Friend WithEvents datagrid As DataGridView
    Friend WithEvents btAdd As Button
    Friend WithEvents PanelProdInfo As Panel
    Friend WithEvents lbidprod As Label
    Friend WithEvents btsaveas As Button
    Friend WithEvents btsave As Button
    Friend WithEvents btClose As Button
    Friend WithEvents tbSerial As TextBox
    Friend WithEvents tbDescr As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btsubir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents pbprod As PictureBox
    Friend WithEvents btmenos As Button
    Friend WithEvents btmas As Button
    Friend WithEvents tbStock As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bteliminar As DataGridViewImageColumn
    Friend WithEvents pbVisualizer As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbTipo As Label
    Friend WithEvents lbusername As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbUsuarioName As Label
    Friend WithEvents Label6 As Label
End Class
