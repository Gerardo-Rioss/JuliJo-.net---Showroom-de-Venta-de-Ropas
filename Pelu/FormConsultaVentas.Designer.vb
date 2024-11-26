<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConsultaVentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaVentas))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgVentas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtTotalEfectivo = New System.Windows.Forms.TextBox()
        Me.btnCalcularTotales = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalCredito = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalDebito = New System.Windows.Forms.TextBox()
        Me.btnLimpiarBusqueda = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalAnuladas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtgDetalleVenta = New System.Windows.Forms.DataGridView()
        Me.btnAnularVenta = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        CType(Me.dtgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgVentas
        '
        Me.dtgVentas.AllowUserToAddRows = False
        Me.dtgVentas.AllowUserToDeleteRows = False
        Me.dtgVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgVentas.BackgroundColor = System.Drawing.Color.White
        Me.dtgVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgVentas.Location = New System.Drawing.Point(14, 69)
        Me.dtgVentas.Name = "dtgVentas"
        Me.dtgVentas.ReadOnly = True
        Me.dtgVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgVentas.RowHeadersVisible = False
        Me.dtgVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgVentas.Size = New System.Drawing.Size(648, 284)
        Me.dtgVentas.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Ventas"
        '
        'dtFecha1
        '
        Me.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha1.Location = New System.Drawing.Point(219, 41)
        Me.dtFecha1.Name = "dtFecha1"
        Me.dtFecha1.Size = New System.Drawing.Size(97, 20)
        Me.dtFecha1.TabIndex = 36
        '
        'dtFecha2
        '
        Me.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha2.Location = New System.Drawing.Point(322, 41)
        Me.dtFecha2.Name = "dtFecha2"
        Me.dtFecha2.Size = New System.Drawing.Size(97, 20)
        Me.dtFecha2.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(216, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Fecha Inicio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(319, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Fecha Fin"
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(425, 30)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(33, 33)
        Me.btnBuscar.TabIndex = 44
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtTotalEfectivo
        '
        Me.txtTotalEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalEfectivo.Location = New System.Drawing.Point(670, 250)
        Me.txtTotalEfectivo.Name = "txtTotalEfectivo"
        Me.txtTotalEfectivo.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalEfectivo.TabIndex = 45
        Me.txtTotalEfectivo.Tag = ""
        Me.txtTotalEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalcularTotales
        '
        Me.btnCalcularTotales.FlatAppearance.BorderSize = 0
        Me.btnCalcularTotales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularTotales.Image = CType(resources.GetObject("btnCalcularTotales.Image"), System.Drawing.Image)
        Me.btnCalcularTotales.Location = New System.Drawing.Point(670, 105)
        Me.btnCalcularTotales.Name = "btnCalcularTotales"
        Me.btnCalcularTotales.Size = New System.Drawing.Size(33, 33)
        Me.btnCalcularTotales.TabIndex = 47
        Me.btnCalcularTotales.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(667, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 18)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Efectivo $"
        '
        'txtTotalCredito
        '
        Me.txtTotalCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCredito.Location = New System.Drawing.Point(670, 206)
        Me.txtTotalCredito.Name = "txtTotalCredito"
        Me.txtTotalCredito.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalCredito.TabIndex = 50
        Me.txtTotalCredito.Tag = ""
        Me.txtTotalCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(667, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Crédito $"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(667, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Débito $"
        '
        'txtTotalDebito
        '
        Me.txtTotalDebito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDebito.Location = New System.Drawing.Point(670, 162)
        Me.txtTotalDebito.Name = "txtTotalDebito"
        Me.txtTotalDebito.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalDebito.TabIndex = 54
        Me.txtTotalDebito.Tag = ""
        Me.txtTotalDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLimpiarBusqueda
        '
        Me.btnLimpiarBusqueda.FlatAppearance.BorderSize = 0
        Me.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarBusqueda.Image = CType(resources.GetObject("btnLimpiarBusqueda.Image"), System.Drawing.Image)
        Me.btnLimpiarBusqueda.Location = New System.Drawing.Point(464, 28)
        Me.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda"
        Me.btnLimpiarBusqueda.Size = New System.Drawing.Size(33, 33)
        Me.btnLimpiarBusqueda.TabIndex = 56
        Me.btnLimpiarBusqueda.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(667, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 18)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Anuladas $"
        '
        'txtTotalAnuladas
        '
        Me.txtTotalAnuladas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAnuladas.Location = New System.Drawing.Point(670, 294)
        Me.txtTotalAnuladas.Name = "txtTotalAnuladas"
        Me.txtTotalAnuladas.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalAnuladas.TabIndex = 57
        Me.txtTotalAnuladas.Tag = ""
        Me.txtTotalAnuladas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Detalles"
        '
        'dtgDetalleVenta
        '
        Me.dtgDetalleVenta.AllowUserToAddRows = False
        Me.dtgDetalleVenta.AllowUserToDeleteRows = False
        Me.dtgDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgDetalleVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgDetalleVenta.BackgroundColor = System.Drawing.Color.White
        Me.dtgDetalleVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDetalleVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDetalleVenta.Location = New System.Drawing.Point(14, 372)
        Me.dtgDetalleVenta.Name = "dtgDetalleVenta"
        Me.dtgDetalleVenta.ReadOnly = True
        Me.dtgDetalleVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgDetalleVenta.RowHeadersVisible = False
        Me.dtgDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDetalleVenta.Size = New System.Drawing.Size(648, 115)
        Me.dtgDetalleVenta.TabIndex = 31
        '
        'btnAnularVenta
        '
        Me.btnAnularVenta.FlatAppearance.BorderSize = 0
        Me.btnAnularVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnularVenta.Image = CType(resources.GetObject("btnAnularVenta.Image"), System.Drawing.Image)
        Me.btnAnularVenta.Location = New System.Drawing.Point(629, 30)
        Me.btnAnularVenta.Name = "btnAnularVenta"
        Me.btnAnularVenta.Size = New System.Drawing.Size(33, 33)
        Me.btnAnularVenta.TabIndex = 59
        Me.btnAnularVenta.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.FlatAppearance.BorderSize = 0
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(668, 320)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(33, 33)
        Me.btnExcel.TabIndex = 60
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'FormConsultaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(778, 502)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnAnularVenta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTotalAnuladas)
        Me.Controls.Add(Me.btnLimpiarBusqueda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalDebito)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalCredito)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCalcularTotales)
        Me.Controls.Add(Me.txtTotalEfectivo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtFecha2)
        Me.Controls.Add(Me.dtFecha1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtgDetalleVenta)
        Me.Controls.Add(Me.dtgVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormConsultaVentas"
        Me.Text = "CONSULTA VENTAS"
        CType(Me.dtgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgVentas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dtFecha1 As DateTimePicker
    Friend WithEvents dtFecha2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtTotalEfectivo As TextBox
    Friend WithEvents btnCalcularTotales As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalCredito As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalDebito As TextBox
    Friend WithEvents btnLimpiarBusqueda As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotalAnuladas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtgDetalleVenta As DataGridView
    Friend WithEvents btnAnularVenta As Button
    Friend WithEvents btnExcel As Button
End Class
