<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVentas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCantidad = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtgTalles = New System.Windows.Forms.DataGridView()
        Me.dtgProveedores = New System.Windows.Forms.DataGridView()
        Me.dtgTipoPrenda = New System.Windows.Forms.DataGridView()
        Me.dtgMarcas = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.btnBuscarMarca = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.btnBuscarTalle = New System.Windows.Forms.Button()
        Me.txtTalle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscarTipoPrenda = New System.Windows.Forms.Button()
        Me.txtTipoPrenda = New System.Windows.Forms.TextBox()
        Me.dtgTarjetas = New System.Windows.Forms.DataGridView()
        Me.txtTarjetas = New System.Windows.Forms.TextBox()
        Me.dtgDetalles = New System.Windows.Forms.DataGridView()
        Me.btnRegistrarVenta = New System.Windows.Forms.Button()
        Me.optTarjeta = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnBorrarVuelto = New System.Windows.Forms.Button()
        Me.txtVuelto = New System.Windows.Forms.TextBox()
        Me.btnCalcularVuelto = New System.Windows.Forms.Button()
        Me.txtMontoEntrega = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.optEfectivo = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnEliminarLinea = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Talle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtgTalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgTipoPrenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgTarjetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(190, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(87, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Fecha"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(192, 30)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(264, 20)
        Me.txtCliente.TabIndex = 17
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(197, 32)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(351, 20)
        Me.txtDescripcion.TabIndex = 18
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConfirmar
        '
        Me.btnConfirmar.FlatAppearance.BorderSize = 0
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.Location = New System.Drawing.Point(568, 63)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(33, 33)
        Me.btnConfirmar.TabIndex = 26
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(504, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Cantidad"
        '
        'cmbCantidad
        '
        Me.cmbCantidad.FormattingEnabled = True
        Me.cmbCantidad.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbCantidad.Location = New System.Drawing.Point(507, 75)
        Me.cmbCantidad.Name = "cmbCantidad"
        Me.cmbCantidad.Size = New System.Drawing.Size(52, 21)
        Me.cmbCantidad.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(396, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Precio"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(399, 75)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(99, 20)
        Me.txtPrecio.TabIndex = 22
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtgTalles)
        Me.GroupBox3.Controls.Add(Me.dtgProveedores)
        Me.GroupBox3.Controls.Add(Me.dtgTipoPrenda)
        Me.GroupBox3.Controls.Add(Me.dtgMarcas)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.btnBuscarProveedor)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtProveedor)
        Me.GroupBox3.Controls.Add(Me.btnBuscarMarca)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtMarca)
        Me.GroupBox3.Controls.Add(Me.btnBuscarTalle)
        Me.GroupBox3.Controls.Add(Me.txtTalle)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnBuscarTipoPrenda)
        Me.GroupBox3.Controls.Add(Me.txtTipoPrenda)
        Me.GroupBox3.Controls.Add(Me.dtgTarjetas)
        Me.GroupBox3.Controls.Add(Me.txtTarjetas)
        Me.GroupBox3.Controls.Add(Me.txtDescripcion)
        Me.GroupBox3.Controls.Add(Me.dtgDetalles)
        Me.GroupBox3.Controls.Add(Me.btnRegistrarVenta)
        Me.GroupBox3.Controls.Add(Me.optTarjeta)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.btnConfirmar)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtPrecio)
        Me.GroupBox3.Controls.Add(Me.optEfectivo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cmbCantidad)
        Me.GroupBox3.Controls.Add(Me.btnEliminarLinea)
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(13, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(893, 340)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'dtgTalles
        '
        Me.dtgTalles.AllowUserToAddRows = False
        Me.dtgTalles.AllowUserToDeleteRows = False
        Me.dtgTalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgTalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgTalles.BackgroundColor = System.Drawing.Color.White
        Me.dtgTalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgTalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgTalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTalles.ColumnHeadersVisible = False
        Me.dtgTalles.Location = New System.Drawing.Point(554, 58)
        Me.dtgTalles.Name = "dtgTalles"
        Me.dtgTalles.ReadOnly = True
        Me.dtgTalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgTalles.RowHeadersVisible = False
        Me.dtgTalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgTalles.Size = New System.Drawing.Size(141, 125)
        Me.dtgTalles.TabIndex = 50
        '
        'dtgProveedores
        '
        Me.dtgProveedores.AllowUserToAddRows = False
        Me.dtgProveedores.AllowUserToDeleteRows = False
        Me.dtgProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgProveedores.BackgroundColor = System.Drawing.Color.White
        Me.dtgProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProveedores.ColumnHeadersVisible = False
        Me.dtgProveedores.Location = New System.Drawing.Point(197, 101)
        Me.dtgProveedores.Name = "dtgProveedores"
        Me.dtgProveedores.ReadOnly = True
        Me.dtgProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgProveedores.RowHeadersVisible = False
        Me.dtgProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgProveedores.Size = New System.Drawing.Size(157, 125)
        Me.dtgProveedores.TabIndex = 49
        '
        'dtgTipoPrenda
        '
        Me.dtgTipoPrenda.AllowUserToAddRows = False
        Me.dtgTipoPrenda.AllowUserToDeleteRows = False
        Me.dtgTipoPrenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgTipoPrenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgTipoPrenda.BackgroundColor = System.Drawing.Color.White
        Me.dtgTipoPrenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgTipoPrenda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgTipoPrenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTipoPrenda.ColumnHeadersVisible = False
        Me.dtgTipoPrenda.Location = New System.Drawing.Point(11, 57)
        Me.dtgTipoPrenda.Name = "dtgTipoPrenda"
        Me.dtgTipoPrenda.ReadOnly = True
        Me.dtgTipoPrenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgTipoPrenda.RowHeadersVisible = False
        Me.dtgTipoPrenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgTipoPrenda.Size = New System.Drawing.Size(141, 125)
        Me.dtgTipoPrenda.TabIndex = 48
        '
        'dtgMarcas
        '
        Me.dtgMarcas.AllowUserToAddRows = False
        Me.dtgMarcas.AllowUserToDeleteRows = False
        Me.dtgMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgMarcas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgMarcas.BackgroundColor = System.Drawing.Color.White
        Me.dtgMarcas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgMarcas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMarcas.ColumnHeadersVisible = False
        Me.dtgMarcas.Location = New System.Drawing.Point(10, 101)
        Me.dtgMarcas.Name = "dtgMarcas"
        Me.dtgMarcas.ReadOnly = True
        Me.dtgMarcas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgMarcas.RowHeadersVisible = False
        Me.dtgMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgMarcas.Size = New System.Drawing.Size(141, 125)
        Me.dtgMarcas.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(551, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Talle"
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.FlatAppearance.BorderSize = 0
        Me.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProveedor.Image = CType(resources.GetObject("btnBuscarProveedor.Image"), System.Drawing.Image)
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(360, 62)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(33, 33)
        Me.btnBuscarProveedor.TabIndex = 45
        Me.btnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(197, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Proveedor"
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(197, 75)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(157, 20)
        Me.txtProveedor.TabIndex = 43
        Me.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarMarca
        '
        Me.btnBuscarMarca.FlatAppearance.BorderSize = 0
        Me.btnBuscarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarMarca.Image = CType(resources.GetObject("btnBuscarMarca.Image"), System.Drawing.Image)
        Me.btnBuscarMarca.Location = New System.Drawing.Point(158, 62)
        Me.btnBuscarMarca.Name = "btnBuscarMarca"
        Me.btnBuscarMarca.Size = New System.Drawing.Size(33, 33)
        Me.btnBuscarMarca.TabIndex = 42
        Me.btnBuscarMarca.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(8, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Marca"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(11, 75)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(141, 20)
        Me.txtMarca.TabIndex = 40
        Me.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarTalle
        '
        Me.btnBuscarTalle.FlatAppearance.BorderSize = 0
        Me.btnBuscarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarTalle.Image = CType(resources.GetObject("btnBuscarTalle.Image"), System.Drawing.Image)
        Me.btnBuscarTalle.Location = New System.Drawing.Point(701, 19)
        Me.btnBuscarTalle.Name = "btnBuscarTalle"
        Me.btnBuscarTalle.Size = New System.Drawing.Size(33, 33)
        Me.btnBuscarTalle.TabIndex = 39
        Me.btnBuscarTalle.UseVisualStyleBackColor = True
        '
        'txtTalle
        '
        Me.txtTalle.Location = New System.Drawing.Point(554, 32)
        Me.txtTalle.Name = "txtTalle"
        Me.txtTalle.Size = New System.Drawing.Size(141, 20)
        Me.txtTalle.TabIndex = 38
        Me.txtTalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Tipo de Prenda"
        '
        'btnBuscarTipoPrenda
        '
        Me.btnBuscarTipoPrenda.FlatAppearance.BorderSize = 0
        Me.btnBuscarTipoPrenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarTipoPrenda.Image = CType(resources.GetObject("btnBuscarTipoPrenda.Image"), System.Drawing.Image)
        Me.btnBuscarTipoPrenda.Location = New System.Drawing.Point(158, 19)
        Me.btnBuscarTipoPrenda.Name = "btnBuscarTipoPrenda"
        Me.btnBuscarTipoPrenda.Size = New System.Drawing.Size(33, 33)
        Me.btnBuscarTipoPrenda.TabIndex = 36
        Me.btnBuscarTipoPrenda.UseVisualStyleBackColor = True
        '
        'txtTipoPrenda
        '
        Me.txtTipoPrenda.Location = New System.Drawing.Point(11, 32)
        Me.txtTipoPrenda.Name = "txtTipoPrenda"
        Me.txtTipoPrenda.Size = New System.Drawing.Size(141, 20)
        Me.txtTipoPrenda.TabIndex = 35
        Me.txtTipoPrenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtgTarjetas
        '
        Me.dtgTarjetas.AllowUserToAddRows = False
        Me.dtgTarjetas.AllowUserToDeleteRows = False
        Me.dtgTarjetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgTarjetas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgTarjetas.BackgroundColor = System.Drawing.Color.White
        Me.dtgTarjetas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgTarjetas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTarjetas.ColumnHeadersVisible = False
        Me.dtgTarjetas.Location = New System.Drawing.Point(721, 102)
        Me.dtgTarjetas.Name = "dtgTarjetas"
        Me.dtgTarjetas.ReadOnly = True
        Me.dtgTarjetas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgTarjetas.RowHeadersVisible = False
        Me.dtgTarjetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgTarjetas.Size = New System.Drawing.Size(155, 188)
        Me.dtgTarjetas.TabIndex = 29
        '
        'txtTarjetas
        '
        Me.txtTarjetas.Location = New System.Drawing.Point(721, 76)
        Me.txtTarjetas.Name = "txtTarjetas"
        Me.txtTarjetas.Size = New System.Drawing.Size(155, 20)
        Me.txtTarjetas.TabIndex = 30
        Me.txtTarjetas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtgDetalles
        '
        Me.dtgDetalles.AllowUserToAddRows = False
        Me.dtgDetalles.AllowUserToDeleteRows = False
        Me.dtgDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgDetalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgDetalles.BackgroundColor = System.Drawing.Color.White
        Me.dtgDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDetalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.idTipo, Me.Tipo, Me.Descripcion, Me.idTalle, Me.Talle, Me.idMarca, Me.Marca, Me.idProv, Me.Proveedor, Me.Precio, Me.Subtotal})
        Me.dtgDetalles.Location = New System.Drawing.Point(10, 102)
        Me.dtgDetalles.Name = "dtgDetalles"
        Me.dtgDetalles.ReadOnly = True
        Me.dtgDetalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgDetalles.RowHeadersVisible = False
        Me.dtgDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDetalles.Size = New System.Drawing.Size(866, 165)
        Me.dtgDetalles.TabIndex = 25
        '
        'btnRegistrarVenta
        '
        Me.btnRegistrarVenta.FlatAppearance.BorderSize = 0
        Me.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarVenta.Image = CType(resources.GetObject("btnRegistrarVenta.Image"), System.Drawing.Image)
        Me.btnRegistrarVenta.Location = New System.Drawing.Point(461, 274)
        Me.btnRegistrarVenta.Name = "btnRegistrarVenta"
        Me.btnRegistrarVenta.Size = New System.Drawing.Size(54, 50)
        Me.btnRegistrarVenta.TabIndex = 25
        Me.btnRegistrarVenta.UseVisualStyleBackColor = True
        '
        'optTarjeta
        '
        Me.optTarjeta.AutoSize = True
        Me.optTarjeta.ForeColor = System.Drawing.Color.White
        Me.optTarjeta.Location = New System.Drawing.Point(809, 52)
        Me.optTarjeta.Name = "optTarjeta"
        Me.optTarjeta.Size = New System.Drawing.Size(58, 17)
        Me.optTarjeta.TabIndex = 1
        Me.optTarjeta.TabStop = True
        Me.optTarjeta.Text = "Tarjeta"
        Me.optTarjeta.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnBorrarVuelto)
        Me.GroupBox5.Controls.Add(Me.txtVuelto)
        Me.GroupBox5.Controls.Add(Me.btnCalcularVuelto)
        Me.GroupBox5.Controls.Add(Me.txtMontoEntrega)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(12, 273)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(301, 49)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Calcular Vuelto"
        '
        'btnBorrarVuelto
        '
        Me.btnBorrarVuelto.FlatAppearance.BorderSize = 0
        Me.btnBorrarVuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarVuelto.Image = CType(resources.GetObject("btnBorrarVuelto.Image"), System.Drawing.Image)
        Me.btnBorrarVuelto.Location = New System.Drawing.Point(259, 10)
        Me.btnBorrarVuelto.Name = "btnBorrarVuelto"
        Me.btnBorrarVuelto.Size = New System.Drawing.Size(33, 33)
        Me.btnBorrarVuelto.TabIndex = 32
        Me.btnBorrarVuelto.UseVisualStyleBackColor = True
        '
        'txtVuelto
        '
        Me.txtVuelto.Location = New System.Drawing.Point(156, 19)
        Me.txtVuelto.Name = "txtVuelto"
        Me.txtVuelto.Size = New System.Drawing.Size(99, 20)
        Me.txtVuelto.TabIndex = 25
        Me.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalcularVuelto
        '
        Me.btnCalcularVuelto.FlatAppearance.BorderSize = 0
        Me.btnCalcularVuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularVuelto.Image = CType(resources.GetObject("btnCalcularVuelto.Image"), System.Drawing.Image)
        Me.btnCalcularVuelto.Location = New System.Drawing.Point(117, 8)
        Me.btnCalcularVuelto.Name = "btnCalcularVuelto"
        Me.btnCalcularVuelto.Size = New System.Drawing.Size(33, 33)
        Me.btnCalcularVuelto.TabIndex = 24
        Me.btnCalcularVuelto.UseVisualStyleBackColor = True
        '
        'txtMontoEntrega
        '
        Me.txtMontoEntrega.Location = New System.Drawing.Point(6, 18)
        Me.txtMontoEntrega.Name = "txtMontoEntrega"
        Me.txtMontoEntrega.Size = New System.Drawing.Size(99, 20)
        Me.txtMontoEntrega.TabIndex = 23
        Me.txtMontoEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(692, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "TOTAL $"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(777, 273)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(99, 26)
        Me.txtTotal.TabIndex = 23
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(740, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 15)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Formas de Pago"
        '
        'optEfectivo
        '
        Me.optEfectivo.AutoSize = True
        Me.optEfectivo.ForeColor = System.Drawing.Color.White
        Me.optEfectivo.Location = New System.Drawing.Point(739, 52)
        Me.optEfectivo.Name = "optEfectivo"
        Me.optEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.optEfectivo.TabIndex = 0
        Me.optEfectivo.TabStop = True
        Me.optEfectivo.Text = "Efectivo"
        Me.optEfectivo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(197, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Descripción de Articulo"
        '
        'btnEliminarLinea
        '
        Me.btnEliminarLinea.FlatAppearance.BorderSize = 0
        Me.btnEliminarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarLinea.Image = CType(resources.GetObject("btnEliminarLinea.Image"), System.Drawing.Image)
        Me.btnEliminarLinea.Location = New System.Drawing.Point(646, 62)
        Me.btnEliminarLinea.Name = "btnEliminarLinea"
        Me.btnEliminarLinea.Size = New System.Drawing.Size(33, 33)
        Me.btnEliminarLinea.TabIndex = 32
        Me.btnEliminarLinea.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.Location = New System.Drawing.Point(607, 62)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(33, 33)
        Me.btnLimpiar.TabIndex = 33
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtFecha)
        Me.GroupBox4.Controls.Add(Me.txtCliente)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(180, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(560, 69)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(90, 30)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtFecha.TabIndex = 22
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cant"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 58
        '
        'idTipo
        '
        Me.idTipo.HeaderText = "ID"
        Me.idTipo.Name = "idTipo"
        Me.idTipo.ReadOnly = True
        Me.idTipo.Width = 45
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 57
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 99
        '
        'idTalle
        '
        Me.idTalle.HeaderText = "ID"
        Me.idTalle.Name = "idTalle"
        Me.idTalle.ReadOnly = True
        Me.idTalle.Width = 45
        '
        'Talle
        '
        Me.Talle.HeaderText = "Talle"
        Me.Talle.Name = "Talle"
        Me.Talle.ReadOnly = True
        Me.Talle.Width = 60
        '
        'idMarca
        '
        Me.idMarca.HeaderText = "ID"
        Me.idMarca.Name = "idMarca"
        Me.idMarca.ReadOnly = True
        Me.idMarca.Width = 45
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Width = 67
        '
        'idProv
        '
        Me.idProv.HeaderText = "ID"
        Me.idProv.Name = "idProv"
        Me.idProv.ReadOnly = True
        Me.idProv.Width = 45
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.Width = 90
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 68
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 79
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(920, 441)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormVentas"
        Me.Text = "VENTAS"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dtgTalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgTipoPrenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgTarjetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbCantidad As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents optTarjeta As RadioButton
    Friend WithEvents optEfectivo As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtVuelto As TextBox
    Friend WithEvents btnCalcularVuelto As Button
    Friend WithEvents txtMontoEntrega As TextBox
    Friend WithEvents btnRegistrarVenta As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtgDetalles As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTarjetas As TextBox
    Friend WithEvents dtgTarjetas As DataGridView
    Friend WithEvents btnBorrarVuelto As Button
    Friend WithEvents btnEliminarLinea As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscarTipoPrenda As Button
    Friend WithEvents txtTipoPrenda As TextBox
    Friend WithEvents btnBuscarTalle As Button
    Friend WithEvents txtTalle As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnBuscarProveedor As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents btnBuscarMarca As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents dtgTalles As DataGridView
    Friend WithEvents dtgProveedores As DataGridView
    Friend WithEvents dtgTipoPrenda As DataGridView
    Friend WithEvents dtgMarcas As DataGridView
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents idTipo As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents idTalle As DataGridViewTextBoxColumn
    Friend WithEvents Talle As DataGridViewTextBoxColumn
    Friend WithEvents idMarca As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents idProv As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
End Class
