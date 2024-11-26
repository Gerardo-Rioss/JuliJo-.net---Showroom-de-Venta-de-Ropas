<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnVentasTarjeta = New System.Windows.Forms.Button()
        Me.btnConsultaMovimientos = New System.Windows.Forms.Button()
        Me.btnConsultaVentas = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnVentasTarjeta)
        Me.GroupBox2.Controls.Add(Me.btnConsultaMovimientos)
        Me.GroupBox2.Controls.Add(Me.btnConsultaVentas)
        Me.GroupBox2.Controls.Add(Me.btnVentas)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(482, 115)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'btnVentasTarjeta
        '
        Me.btnVentasTarjeta.BackColor = System.Drawing.Color.Black
        Me.btnVentasTarjeta.FlatAppearance.BorderSize = 0
        Me.btnVentasTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentasTarjeta.ForeColor = System.Drawing.Color.White
        Me.btnVentasTarjeta.Location = New System.Drawing.Point(360, 21)
        Me.btnVentasTarjeta.Name = "btnVentasTarjeta"
        Me.btnVentasTarjeta.Size = New System.Drawing.Size(112, 81)
        Me.btnVentasTarjeta.TabIndex = 10
        Me.btnVentasTarjeta.Text = "Ventas Tarjetas"
        Me.btnVentasTarjeta.UseVisualStyleBackColor = False
        '
        'btnConsultaMovimientos
        '
        Me.btnConsultaMovimientos.BackColor = System.Drawing.Color.Black
        Me.btnConsultaMovimientos.FlatAppearance.BorderSize = 0
        Me.btnConsultaMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultaMovimientos.ForeColor = System.Drawing.Color.White
        Me.btnConsultaMovimientos.Location = New System.Drawing.Point(242, 21)
        Me.btnConsultaMovimientos.Name = "btnConsultaMovimientos"
        Me.btnConsultaMovimientos.Size = New System.Drawing.Size(112, 81)
        Me.btnConsultaMovimientos.TabIndex = 9
        Me.btnConsultaMovimientos.Text = "Movimientos"
        Me.btnConsultaMovimientos.UseVisualStyleBackColor = False
        '
        'btnConsultaVentas
        '
        Me.btnConsultaVentas.BackColor = System.Drawing.Color.Black
        Me.btnConsultaVentas.FlatAppearance.BorderSize = 0
        Me.btnConsultaVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultaVentas.ForeColor = System.Drawing.Color.White
        Me.btnConsultaVentas.Location = New System.Drawing.Point(124, 21)
        Me.btnConsultaVentas.Name = "btnConsultaVentas"
        Me.btnConsultaVentas.Size = New System.Drawing.Size(112, 81)
        Me.btnConsultaVentas.TabIndex = 5
        Me.btnConsultaVentas.Text = "Consulta Ventas"
        Me.btnConsultaVentas.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.Black
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.ForeColor = System.Drawing.Color.White
        Me.btnVentas.Location = New System.Drawing.Point(6, 21)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(112, 81)
        Me.btnVentas.TabIndex = 4
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(78, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(362, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(502, 297)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormPrincipal"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnVentas As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnConsultaVentas As Button
    Friend WithEvents btnConsultaMovimientos As Button
    Friend WithEvents btnVentasTarjeta As Button
End Class
