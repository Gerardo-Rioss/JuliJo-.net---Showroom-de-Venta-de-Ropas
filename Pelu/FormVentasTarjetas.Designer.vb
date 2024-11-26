<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentasTarjetas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVentasTarjetas))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnLimpiarBusqueda = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalDebito = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalCredito = New System.Windows.Forms.TextBox()
        Me.btnCalcularTotales = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtgDetallesVenta = New System.Windows.Forms.DataGridView()
        Me.dtgVentas = New System.Windows.Forms.DataGridView()
        Me.chkSinTransferir = New System.Windows.Forms.CheckBox()
        Me.btnMarcar = New System.Windows.Forms.Button()
        Me.dtFechaTransferencia = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnExcel = New System.Windows.Forms.Button()
        CType(Me.dtgDetallesVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLimpiarBusqueda
        '
        Me.btnLimpiarBusqueda.FlatAppearance.BorderSize = 0
        Me.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarBusqueda.Image = CType(resources.GetObject("btnLimpiarBusqueda.Image"), System.Drawing.Image)
        Me.btnLimpiarBusqueda.Location = New System.Drawing.Point(392, 14)
        Me.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda"
        Me.btnLimpiarBusqueda.Size = New System.Drawing.Size(33, 33)
        Me.btnLimpiarBusqueda.TabIndex = 78
        Me.btnLimpiarBusqueda.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(663, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Débito $"
        '
        'txtTotalDebito
        '
        Me.txtTotalDebito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDebito.Location = New System.Drawing.Point(666, 273)
        Me.txtTotalDebito.Name = "txtTotalDebito"
        Me.txtTotalDebito.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalDebito.TabIndex = 76
        Me.txtTotalDebito.Tag = ""
        Me.txtTotalDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(663, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Crédito $"
        '
        'txtTotalCredito
        '
        Me.txtTotalCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCredito.Location = New System.Drawing.Point(666, 317)
        Me.txtTotalCredito.Name = "txtTotalCredito"
        Me.txtTotalCredito.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalCredito.TabIndex = 73
        Me.txtTotalCredito.Tag = ""
        Me.txtTotalCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalcularTotales
        '
        Me.btnCalcularTotales.FlatAppearance.BorderSize = 0
        Me.btnCalcularTotales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularTotales.Image = CType(resources.GetObject("btnCalcularTotales.Image"), System.Drawing.Image)
        Me.btnCalcularTotales.Location = New System.Drawing.Point(666, 216)
        Me.btnCalcularTotales.Name = "btnCalcularTotales"
        Me.btnCalcularTotales.Size = New System.Drawing.Size(33, 33)
        Me.btnCalcularTotales.TabIndex = 70
        Me.btnCalcularTotales.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(353, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(33, 33)
        Me.btnBuscar.TabIndex = 67
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(247, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Fecha Fin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(144, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Fecha Inicio"
        '
        'dtFecha2
        '
        Me.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha2.Location = New System.Drawing.Point(250, 27)
        Me.dtFecha2.Name = "dtFecha2"
        Me.dtFecha2.Size = New System.Drawing.Size(97, 20)
        Me.dtFecha2.TabIndex = 64
        '
        'dtFecha1
        '
        Me.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha1.Location = New System.Drawing.Point(147, 27)
        Me.dtFecha1.Name = "dtFecha1"
        Me.dtFecha1.Size = New System.Drawing.Size(97, 20)
        Me.dtFecha1.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Detalles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Ventas"
        '
        'dtgDetallesVenta
        '
        Me.dtgDetallesVenta.AllowUserToAddRows = False
        Me.dtgDetallesVenta.AllowUserToDeleteRows = False
        Me.dtgDetallesVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgDetallesVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgDetallesVenta.BackgroundColor = System.Drawing.Color.White
        Me.dtgDetallesVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDetallesVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgDetallesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDetallesVenta.Location = New System.Drawing.Point(12, 356)
        Me.dtgDetallesVenta.Name = "dtgDetallesVenta"
        Me.dtgDetallesVenta.ReadOnly = True
        Me.dtgDetallesVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgDetallesVenta.RowHeadersVisible = False
        Me.dtgDetallesVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDetallesVenta.Size = New System.Drawing.Size(648, 115)
        Me.dtgDetallesVenta.TabIndex = 60
        '
        'dtgVentas
        '
        Me.dtgVentas.AllowUserToAddRows = False
        Me.dtgVentas.AllowUserToDeleteRows = False
        Me.dtgVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgVentas.BackgroundColor = System.Drawing.Color.White
        Me.dtgVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgVentas.Location = New System.Drawing.Point(12, 53)
        Me.dtgVentas.Name = "dtgVentas"
        Me.dtgVentas.ReadOnly = True
        Me.dtgVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgVentas.RowHeadersVisible = False
        Me.dtgVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgVentas.Size = New System.Drawing.Size(648, 284)
        Me.dtgVentas.TabIndex = 59
        '
        'chkSinTransferir
        '
        Me.chkSinTransferir.AutoSize = True
        Me.chkSinTransferir.ForeColor = System.Drawing.Color.White
        Me.chkSinTransferir.Location = New System.Drawing.Point(465, 34)
        Me.chkSinTransferir.Name = "chkSinTransferir"
        Me.chkSinTransferir.Size = New System.Drawing.Size(110, 17)
        Me.chkSinTransferir.TabIndex = 79
        Me.chkSinTransferir.Text = "Solo sin Transferir"
        Me.chkSinTransferir.UseVisualStyleBackColor = True
        '
        'btnMarcar
        '
        Me.btnMarcar.FlatAppearance.BorderSize = 0
        Me.btnMarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarcar.Image = CType(resources.GetObject("btnMarcar.Image"), System.Drawing.Image)
        Me.btnMarcar.Location = New System.Drawing.Point(667, 95)
        Me.btnMarcar.Name = "btnMarcar"
        Me.btnMarcar.Size = New System.Drawing.Size(33, 33)
        Me.btnMarcar.TabIndex = 80
        Me.btnMarcar.UseVisualStyleBackColor = True
        '
        'dtFechaTransferencia
        '
        Me.dtFechaTransferencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaTransferencia.Location = New System.Drawing.Point(666, 69)
        Me.dtFechaTransferencia.Name = "dtFechaTransferencia"
        Me.dtFechaTransferencia.Size = New System.Drawing.Size(97, 20)
        Me.dtFechaTransferencia.TabIndex = 81
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(663, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Transferido"
        '
        'btnExcel
        '
        Me.btnExcel.FlatAppearance.BorderSize = 0
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(666, 153)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(33, 33)
        Me.btnExcel.TabIndex = 83
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'FormVentasTarjetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(776, 485)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtFechaTransferencia)
        Me.Controls.Add(Me.btnMarcar)
        Me.Controls.Add(Me.chkSinTransferir)
        Me.Controls.Add(Me.btnLimpiarBusqueda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalDebito)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalCredito)
        Me.Controls.Add(Me.btnCalcularTotales)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtFecha2)
        Me.Controls.Add(Me.dtFecha1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtgDetallesVenta)
        Me.Controls.Add(Me.dtgVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormVentasTarjetas"
        Me.Text = "Ventas Tarjetas"
        CType(Me.dtgDetallesVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiarBusqueda As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalDebito As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalCredito As TextBox
    Friend WithEvents btnCalcularTotales As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtFecha2 As DateTimePicker
    Friend WithEvents dtFecha1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtgDetallesVenta As DataGridView
    Friend WithEvents dtgVentas As DataGridView
    Friend WithEvents chkSinTransferir As CheckBox
    Friend WithEvents btnMarcar As Button
    Friend WithEvents dtFechaTransferencia As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents btnExcel As Button
End Class
