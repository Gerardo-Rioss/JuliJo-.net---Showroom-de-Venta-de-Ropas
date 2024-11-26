<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConsultaMovimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaMovimientos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtgMovimientos1 = New System.Windows.Forms.DataGridView()
        Me.btnBorrarBusqueda = New System.Windows.Forms.Button()
        Me.btnBuscarMovimiento = New System.Windows.Forms.Button()
        Me.chkBuscarFecha = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMovimiento1 = New System.Windows.Forms.TextBox()
        Me.dtgMovimientos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNegativo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCalcularTotales = New System.Windows.Forms.Button()
        Me.txtPositivo = New System.Windows.Forms.TextBox()
        Me.txtMovimiento2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtFechaMovimiento = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscarMov = New System.Windows.Forms.Button()
        Me.dtgMovimientos2 = New System.Windows.Forms.DataGridView()
        Me.btnCrearMovimiento = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        CType(Me.dtgMovimientos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgMovimientos2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(527, 100)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(33, 33)
        Me.btnBuscar.TabIndex = 66
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtgMovimientos1
        '
        Me.dtgMovimientos1.AllowUserToAddRows = False
        Me.dtgMovimientos1.AllowUserToDeleteRows = False
        Me.dtgMovimientos1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgMovimientos1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgMovimientos1.BackgroundColor = System.Drawing.Color.White
        Me.dtgMovimientos1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgMovimientos1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgMovimientos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMovimientos1.Location = New System.Drawing.Point(9, 51)
        Me.dtgMovimientos1.Name = "dtgMovimientos1"
        Me.dtgMovimientos1.ReadOnly = True
        Me.dtgMovimientos1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgMovimientos1.RowHeadersVisible = False
        Me.dtgMovimientos1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgMovimientos1.Size = New System.Drawing.Size(225, 117)
        Me.dtgMovimientos1.TabIndex = 65
        '
        'btnBorrarBusqueda
        '
        Me.btnBorrarBusqueda.FlatAppearance.BorderSize = 0
        Me.btnBorrarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarBusqueda.Image = CType(resources.GetObject("btnBorrarBusqueda.Image"), System.Drawing.Image)
        Me.btnBorrarBusqueda.Location = New System.Drawing.Point(279, 12)
        Me.btnBorrarBusqueda.Name = "btnBorrarBusqueda"
        Me.btnBorrarBusqueda.Size = New System.Drawing.Size(33, 33)
        Me.btnBorrarBusqueda.TabIndex = 64
        Me.btnBorrarBusqueda.UseVisualStyleBackColor = True
        '
        'btnBuscarMovimiento
        '
        Me.btnBuscarMovimiento.FlatAppearance.BorderSize = 0
        Me.btnBuscarMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarMovimiento.Image = CType(resources.GetObject("btnBuscarMovimiento.Image"), System.Drawing.Image)
        Me.btnBuscarMovimiento.Location = New System.Drawing.Point(240, 12)
        Me.btnBuscarMovimiento.Name = "btnBuscarMovimiento"
        Me.btnBuscarMovimiento.Size = New System.Drawing.Size(33, 33)
        Me.btnBuscarMovimiento.TabIndex = 63
        Me.btnBuscarMovimiento.UseVisualStyleBackColor = True
        '
        'chkBuscarFecha
        '
        Me.chkBuscarFecha.AutoSize = True
        Me.chkBuscarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBuscarFecha.ForeColor = System.Drawing.Color.White
        Me.chkBuscarFecha.Location = New System.Drawing.Point(411, 51)
        Me.chkBuscarFecha.Name = "chkBuscarFecha"
        Me.chkBuscarFecha.Size = New System.Drawing.Size(126, 17)
        Me.chkBuscarFecha.TabIndex = 62
        Me.chkBuscarFecha.Text = "Buscar por Fecha"
        Me.chkBuscarFecha.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(408, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Fecha Fin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(408, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Fecha Inicio"
        '
        'dtFecha2
        '
        Me.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha2.Location = New System.Drawing.Point(411, 126)
        Me.dtFecha2.Name = "dtFecha2"
        Me.dtFecha2.Size = New System.Drawing.Size(97, 20)
        Me.dtFecha2.TabIndex = 59
        '
        'dtFecha1
        '
        Me.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha1.Location = New System.Drawing.Point(411, 87)
        Me.dtFecha1.Name = "dtFecha1"
        Me.dtFecha1.Size = New System.Drawing.Size(97, 20)
        Me.dtFecha1.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Movimiento"
        '
        'txtMovimiento1
        '
        Me.txtMovimiento1.Location = New System.Drawing.Point(9, 25)
        Me.txtMovimiento1.Name = "txtMovimiento1"
        Me.txtMovimiento1.Size = New System.Drawing.Size(225, 20)
        Me.txtMovimiento1.TabIndex = 56
        '
        'dtgMovimientos
        '
        Me.dtgMovimientos.AllowUserToAddRows = False
        Me.dtgMovimientos.AllowUserToDeleteRows = False
        Me.dtgMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgMovimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgMovimientos.BackgroundColor = System.Drawing.Color.White
        Me.dtgMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgMovimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMovimientos.Location = New System.Drawing.Point(9, 51)
        Me.dtgMovimientos.Name = "dtgMovimientos"
        Me.dtgMovimientos.ReadOnly = True
        Me.dtgMovimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgMovimientos.RowHeadersVisible = False
        Me.dtgMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgMovimientos.Size = New System.Drawing.Size(396, 354)
        Me.dtgMovimientos.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 18)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "-- $"
        '
        'txtNegativo
        '
        Me.txtNegativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNegativo.Location = New System.Drawing.Point(95, 412)
        Me.txtNegativo.Name = "txtNegativo"
        Me.txtNegativo.Size = New System.Drawing.Size(96, 20)
        Me.txtNegativo.TabIndex = 71
        Me.txtNegativo.Tag = ""
        Me.txtNegativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(197, 411)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 18)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "++ $"
        '
        'btnCalcularTotales
        '
        Me.btnCalcularTotales.FlatAppearance.BorderSize = 0
        Me.btnCalcularTotales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularTotales.Image = CType(resources.GetObject("btnCalcularTotales.Image"), System.Drawing.Image)
        Me.btnCalcularTotales.Location = New System.Drawing.Point(355, 405)
        Me.btnCalcularTotales.Name = "btnCalcularTotales"
        Me.btnCalcularTotales.Size = New System.Drawing.Size(33, 33)
        Me.btnCalcularTotales.TabIndex = 69
        Me.btnCalcularTotales.UseVisualStyleBackColor = True
        '
        'txtPositivo
        '
        Me.txtPositivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPositivo.Location = New System.Drawing.Point(245, 411)
        Me.txtPositivo.Name = "txtPositivo"
        Me.txtPositivo.Size = New System.Drawing.Size(96, 20)
        Me.txtPositivo.TabIndex = 68
        Me.txtPositivo.Tag = ""
        Me.txtPositivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMovimiento2
        '
        Me.txtMovimiento2.Location = New System.Drawing.Point(411, 236)
        Me.txtMovimiento2.Name = "txtMovimiento2"
        Me.txtMovimiento2.Size = New System.Drawing.Size(179, 20)
        Me.txtMovimiento2.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(411, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Movimiento"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(414, 275)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(97, 20)
        Me.txtMonto.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(411, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Monto $"
        '
        'dtFechaMovimiento
        '
        Me.dtFechaMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaMovimiento.Location = New System.Drawing.Point(414, 301)
        Me.dtFechaMovimiento.Name = "dtFechaMovimiento"
        Me.dtFechaMovimiento.Size = New System.Drawing.Size(97, 20)
        Me.dtFechaMovimiento.TabIndex = 77
        '
        'btnBuscarMov
        '
        Me.btnBuscarMov.FlatAppearance.BorderSize = 0
        Me.btnBuscarMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarMov.Image = CType(resources.GetObject("btnBuscarMov.Image"), System.Drawing.Image)
        Me.btnBuscarMov.Location = New System.Drawing.Point(596, 229)
        Me.btnBuscarMov.Name = "btnBuscarMov"
        Me.btnBuscarMov.Size = New System.Drawing.Size(33, 33)
        Me.btnBuscarMov.TabIndex = 80
        Me.btnBuscarMov.UseVisualStyleBackColor = True
        '
        'dtgMovimientos2
        '
        Me.dtgMovimientos2.AllowUserToAddRows = False
        Me.dtgMovimientos2.AllowUserToDeleteRows = False
        Me.dtgMovimientos2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgMovimientos2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgMovimientos2.BackgroundColor = System.Drawing.Color.White
        Me.dtgMovimientos2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgMovimientos2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgMovimientos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMovimientos2.Location = New System.Drawing.Point(411, 259)
        Me.dtgMovimientos2.Name = "dtgMovimientos2"
        Me.dtgMovimientos2.ReadOnly = True
        Me.dtgMovimientos2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgMovimientos2.RowHeadersVisible = False
        Me.dtgMovimientos2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgMovimientos2.Size = New System.Drawing.Size(179, 117)
        Me.dtgMovimientos2.TabIndex = 82
        '
        'btnCrearMovimiento
        '
        Me.btnCrearMovimiento.FlatAppearance.BorderSize = 0
        Me.btnCrearMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearMovimiento.Image = CType(resources.GetObject("btnCrearMovimiento.Image"), System.Drawing.Image)
        Me.btnCrearMovimiento.Location = New System.Drawing.Point(517, 288)
        Me.btnCrearMovimiento.Name = "btnCrearMovimiento"
        Me.btnCrearMovimiento.Size = New System.Drawing.Size(33, 33)
        Me.btnCrearMovimiento.TabIndex = 83
        Me.btnCrearMovimiento.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.FlatAppearance.BorderSize = 0
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(411, 169)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(33, 33)
        Me.btnExcel.TabIndex = 84
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'FormConsultaMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(640, 443)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.dtgMovimientos2)
        Me.Controls.Add(Me.btnBuscarMov)
        Me.Controls.Add(Me.dtFechaMovimiento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMovimiento2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNegativo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCalcularTotales)
        Me.Controls.Add(Me.txtPositivo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dtgMovimientos1)
        Me.Controls.Add(Me.btnBorrarBusqueda)
        Me.Controls.Add(Me.btnBuscarMovimiento)
        Me.Controls.Add(Me.chkBuscarFecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtFecha2)
        Me.Controls.Add(Me.dtFecha1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMovimiento1)
        Me.Controls.Add(Me.dtgMovimientos)
        Me.Controls.Add(Me.btnCrearMovimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormConsultaMovimientos"
        Me.Text = "Movimientos"
        CType(Me.dtgMovimientos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgMovimientos2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dtgMovimientos1 As DataGridView
    Friend WithEvents btnBorrarBusqueda As Button
    Friend WithEvents btnBuscarMovimiento As Button
    Friend WithEvents chkBuscarFecha As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtFecha2 As DateTimePicker
    Friend WithEvents dtFecha1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMovimiento1 As TextBox
    Friend WithEvents dtgMovimientos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNegativo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCalcularTotales As Button
    Friend WithEvents txtPositivo As TextBox
    Friend WithEvents txtMovimiento2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtFechaMovimiento As DateTimePicker
    Friend WithEvents btnBuscarMov As Button
    Friend WithEvents dtgMovimientos2 As DataGridView
    Friend WithEvents btnCrearMovimiento As Button
    Friend WithEvents btnExcel As Button
End Class
