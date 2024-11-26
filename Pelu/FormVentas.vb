Imports System.Data.SqlClient



Public Class FormVentas
    Dim idTarjetaSeleccionada As Integer
    Dim idMarcaSeleccionada As Integer
    Dim idProveedorSeleccionado As Integer
    Dim idTipoPrendaSeleccionada As Integer
    Dim idTalleSeleccionado As Integer
    Dim idVentaGenerada As Integer
    Dim total As Integer
    Dim existe As Boolean

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idTalleSeleccionado = 0
        idMarcaSeleccionada = 0
        idProveedorSeleccionado = 0
        idTipoPrendaSeleccionada = 0
        idTalleSeleccionado = 0
        dtgTipoPrenda.Visible = False
        txtTipoPrenda.ReadOnly = True
        dtgMarcas.Visible = False
        txtMarca.ReadOnly = True
        dtgProveedores.Visible = False
        dtgTalles.Visible = False
        dtgTarjetas.Visible = False
        existe = False
        txtVuelto.ReadOnly = True
        txtCliente.Text = "CONSUMIDOR FINAL"
        dtFecha.Text = Date.Today
        optEfectivo.Checked = True
        txtTarjetas.ReadOnly = True
        txtTalle.ReadOnly = True
        txtProveedor.ReadOnly = True
        cmbCantidad.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCantidad.SelectedItem = "1"
        total = 0
        txtTotal.ReadOnly = True
        MostrarTipoPrenda()
        MostrarMarcas()
        MostrarProveedores()
        MostrarTalles()
        MostrarTarjetas()
        txtDescripcion.CharacterCasing = CharacterCasing.Upper
        txtCliente.CharacterCasing = CharacterCasing.Upper
        dtgDetalles.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dtgDetalles.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
    Sub MostrarTipoPrenda()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("MostrarTipoPrenda", conexion)
            da.Fill(dt)
            dtgTipoPrenda.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub MostrarMarcas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("MostrarMarcas", conexion)
            da.Fill(dt)
            dtgMarcas.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub MostrarProveedores()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("MostrarProveedores", conexion)
            da.Fill(dt)
            dtgProveedores.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub MostrarTalles()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("MostrarTalles", conexion)
            da.Fill(dt)
            dtgTalles.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub MostrarTarjetas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("MostrarTarjetas", conexion)
            da.Fill(dt)
            dtgTarjetas.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub optTarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles optTarjeta.CheckedChanged
        If optTarjeta.Checked = True Then
            txtTarjetas.ReadOnly = False
            dtgTarjetas.Visible = True
        End If

    End Sub

    Private Sub optEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles optEfectivo.CheckedChanged
        If optEfectivo.Checked = True Then
            txtTarjetas.ReadOnly = True
            txtTarjetas.Text = ""
            dtgTarjetas.Visible = False
        End If
    End Sub

    Private Sub btnCalcularVuelto_Click(sender As Object, e As EventArgs) Handles btnCalcularVuelto.Click
        If txtTotal.Text = "" Or txtTotal.Text = 0 Then
            MessageBox.Show("No tiene ingresado Producto ni Servicios para el calculo", "Vuelto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            txtVuelto.Text = txtMontoEntrega.Text - txtTotal.Text
        End If

    End Sub



    Private Sub txtMontoEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontoEntrega.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Solo se puede ingresar Números", "Calcular Vuelto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMontoEntrega.Focus()
        End If
    End Sub

    Private Sub btnBorrarVuelto_Click(sender As Object, e As EventArgs) Handles btnBorrarVuelto.Click
        txtMontoEntrega.Text = ""
        txtVuelto.Text = ""
    End Sub

    Private Sub btnBuscarTipoPrenda_Click(sender As Object, e As EventArgs) Handles btnBuscarTipoPrenda.Click
        dtgTipoPrenda.Visible = True
        dtgMarcas.Visible = False
        dtgProveedores.Visible = False
        dtgTalles.Visible = False
    End Sub

    Private Sub dtgTipoPrenda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgTipoPrenda.CellClick
        txtTipoPrenda.Text = dtgTipoPrenda.CurrentRow.Cells(1).Value
        idTipoPrendaSeleccionada = dtgTipoPrenda.CurrentRow.Cells(0).Value
        dtgTipoPrenda.Visible = False

    End Sub

    Private Sub btnBuscarMarca_Click(sender As Object, e As EventArgs) Handles btnBuscarMarca.Click
        dtgMarcas.Visible = True
        dtgTipoPrenda.Visible = False
        dtgProveedores.Visible = False
        dtgTalles.Visible = False
    End Sub

    Private Sub dtgMarcas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgMarcas.CellClick
        txtMarca.Text = dtgMarcas.CurrentRow.Cells(1).Value
        idMarcaSeleccionada = dtgMarcas.CurrentRow.Cells(0).Value
        dtgMarcas.Visible = False
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        dtgProveedores.Visible = True
        dtgTipoPrenda.Visible = False
        dtgMarcas.Visible = False
        dtgTalles.Visible = False
    End Sub

    Private Sub dtgProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgProveedores.CellClick
        txtProveedor.Text = dtgProveedores.CurrentRow.Cells(1).Value
        idProveedorSeleccionado = dtgProveedores.CurrentRow.Cells(0).Value
        dtgProveedores.Visible = False
    End Sub

    Private Sub btnBuscarTalle_Click(sender As Object, e As EventArgs) Handles btnBuscarTalle.Click
        dtgTalles.Visible = True
        dtgTipoPrenda.Visible = False
        dtgMarcas.Visible = False
        dtgProveedores.Visible = False

    End Sub

    Private Sub dtgTalles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgTalles.CellClick
        txtTalle.Text = dtgTalles.CurrentRow.Cells(1).Value
        idTalleSeleccionado = dtgTalles.CurrentRow.Cells(0).Value
        dtgTalles.Visible = False
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtTipoPrenda.Text = ""
        txtMarca.Text = ""
        txtDescripcion.Text = ""
        txtProveedor.Text = ""
        txtPrecio.Text = ""
        cmbCantidad.Text = 1
        txtTalle.Text = ""
        dtgTalles.Visible = False
        dtgTipoPrenda.Visible = False
        dtgMarcas.Visible = False
        dtgProveedores.Visible = False
    End Sub

    Private Sub dtgTarjetas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgTarjetas.CellClick
        txtTarjetas.Text = dtgTarjetas.CurrentRow.Cells(1).Value
        idTarjetaSeleccionada = dtgTarjetas.CurrentRow.Cells(0).Value
        dtgTarjetas.Visible = False
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If txtTipoPrenda.Text = "" Then
            MessageBox.Show("Debe seleccionar un Tipo de Articulo", "VENTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTipoPrenda.Focus()
        ElseIf txtTalle.Text = "" Then
            MessageBox.Show("Debe seleccionar el Talle", "VENTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTalle.Focus()
        ElseIf txtProveedor.Text = "" Then
            MessageBox.Show("Debe seleccionar el Proveedor", "VENTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProveedor.Focus()
        ElseIf txtPrecio.Text = "" Then
            MessageBox.Show("Debe Ingresar el Precio", "VENTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrecio.Focus()
        Else
            If txtMarca.Text = "" Then
                dtgDetalles.Rows.Add(cmbCantidad.SelectedItem, idTipoPrendaSeleccionada, txtTipoPrenda.Text, txtDescripcion.Text, idTalleSeleccionado, txtTalle.Text, "", txtMarca.Text, idProveedorSeleccionado, txtProveedor.Text, txtPrecio.Text, cmbCantidad.Text * txtPrecio.Text)
            Else
                dtgDetalles.Rows.Add(cmbCantidad.SelectedItem, idTipoPrendaSeleccionada, txtTipoPrenda.Text, txtDescripcion.Text, idTalleSeleccionado, txtTalle.Text, idMarcaSeleccionada, txtMarca.Text, idProveedorSeleccionado, txtProveedor.Text, txtPrecio.Text, cmbCantidad.Text * txtPrecio.Text)
            End If
            total = total + cmbCantidad.SelectedItem * txtPrecio.Text
            txtTotal.Text = total
            cmbCantidad.SelectedItem = "1"
            txtTipoPrenda.Text = ""
            txtMarca.Text = ""
            txtDescripcion.Text = ""
            txtProveedor.Text = ""
            txtPrecio.Text = ""
            txtTalle.Text = ""
            idTalleSeleccionado = 0
            idMarcaSeleccionada = 0
            idProveedorSeleccionado = 0
            idTipoPrendaSeleccionada = 0
            idTalleSeleccionado = 0
        End If

    End Sub

    Private Sub btnEliminarLinea_Click(sender As Object, e As EventArgs) Handles btnEliminarLinea.Click
        If dtgDetalles.RowCount = 0 Then
            MessageBox.Show("No existe linea para eliminar", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            total = total - dtgDetalles.CurrentRow.Cells(11).Value
            txtTotal.Text = total
            dtgDetalles.Rows.Remove(dtgDetalles.CurrentRow)

        End If
    End Sub

    Private Sub btnRegistrarVenta_Click(sender As Object, e As EventArgs) Handles btnRegistrarVenta.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Quiere Registrar la compra?", "VENTAS", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            If dtgDetalles.RowCount = 0 Then
                MessageBox.Show("No hay lineas ingresadas", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf txtCliente.Text = "" Then
                MessageBox.Show("Debe ingresar una descripcion del cliente", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCliente.Focus()
            Else

                'Insertar Venta

                Try
                    Dim cmd As New SqlCommand
                    Abrir()
                    cmd = New SqlCommand("InsertarVenta", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@Cliente", txtCliente.Text)
                    cmd.Parameters.AddWithValue("@Fecha", dtFecha.Text)
                    If optEfectivo.Checked = True Then
                        cmd.Parameters.AddWithValue("@idTipoPago", 1)
                        cmd.Parameters.AddWithValue("@idTarjeta", 1)
                    ElseIf idTarjetaSeleccionada = 3 Or idTarjetaSeleccionada = 4 Or idTarjetaSeleccionada = 6 Or idTarjetaSeleccionada = 10 Then
                        cmd.Parameters.AddWithValue("@idTipoPago", 2)
                        cmd.Parameters.AddWithValue("@idTarjeta", idTarjetaSeleccionada)
                    Else
                        cmd.Parameters.AddWithValue("@idTipoPago", 3)
                        cmd.Parameters.AddWithValue("@idTarjeta", idTarjetaSeleccionada)
                    End If
                    cmd.Parameters.AddWithValue("@Monto", txtTotal.Text)
                    cmd.Parameters.AddWithValue("@Anulada", 0)
                    cmd.ExecuteNonQuery()
                    Cerrar()
                Catch ex As Exception : MessageBox.Show(ex.Message)

                End Try
                ObtenerUltimoIdVenta()

                If optTarjeta.Checked = True Then
                    'Insertar venta tarjetas

                    Try
                        Dim cmd As New SqlCommand
                        Abrir()
                        cmd = New SqlCommand("InsertarVentaTarjeta", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@idVenta", idVentaGenerada)
                        If idTarjetaSeleccionada = 3 Or idTarjetaSeleccionada = 4 Or idTarjetaSeleccionada = 6 Or idTarjetaSeleccionada = 10 Then
                            cmd.Parameters.AddWithValue("@idTipoPago", 2)
                        Else
                            cmd.Parameters.AddWithValue("@idTipoPago", 3)
                        End If
                        cmd.Parameters.AddWithValue("@idTarjeta", idTarjetaSeleccionada)
                        cmd.Parameters.AddWithValue("@FechaVenta", dtFecha.Text)
                        cmd.Parameters.AddWithValue("@Total", txtTotal.Text)
                        cmd.Parameters.AddWithValue("@Transferido", 0)
                        cmd.Parameters.AddWithValue("@Anulada", 0)
                        cmd.ExecuteNonQuery()
                        Cerrar()

                    Catch ex As Exception : MessageBox.Show(ex.Message)

                    End Try
                End If
                'Insertar Detalle Venta

                For i = 0 To dtgDetalles.RowCount - 1
                    Try
                        Dim cmd As New SqlCommand
                        Abrir()
                        cmd = New SqlCommand("InsertarDetalleVenta", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@idVenta", idVentaGenerada)
                        cmd.Parameters.AddWithValue("@idTipoPrenda", dtgDetalles.Rows(i).Cells(1).Value)
                        cmd.Parameters.AddWithValue("@Descripcion", dtgDetalles.Rows(i).Cells(3).Value)
                        cmd.Parameters.AddWithValue("@idTalle", dtgDetalles.Rows(i).Cells(4).Value)
                        If dtgDetalles.Rows(i).Cells(7).Value = "" Then
                            cmd.Parameters.AddWithValue("@idMarca", 1)
                        Else
                            cmd.Parameters.AddWithValue("@idMarca", dtgDetalles.Rows(i).Cells(6).Value)
                        End If
                        cmd.Parameters.AddWithValue("@idProveedor", dtgDetalles.Rows(i).Cells(8).Value)
                        cmd.Parameters.AddWithValue("@Cantidad", dtgDetalles.Rows(i).Cells(0).Value)
                        cmd.Parameters.AddWithValue("@Precio", dtgDetalles.Rows(i).Cells(10).Value)
                        cmd.ExecuteNonQuery()
                        Cerrar()

                    Catch ex As Exception : MessageBox.Show(ex.Message)

                    End Try
                Next

                'Insertar Movimientos
                Try
                    Dim cmd As New SqlCommand
                    Abrir()
                    cmd = New SqlCommand("InsertarMovimiento", conexion)
                    cmd.CommandType = 4
                    If optEfectivo.Checked = True Then
                        cmd.Parameters.AddWithValue("@idTipoMovimiento", 1)
                    ElseIf idTarjetaSeleccionada = 3 Or idTarjetaSeleccionada = 4 Or idTarjetaSeleccionada = 6 Or idTarjetaSeleccionada = 10 Then
                        cmd.Parameters.AddWithValue("@idTipoMovimiento", 2)
                    Else
                        cmd.Parameters.AddWithValue("@idTipoMovimiento", 3)
                    End If
                    cmd.Parameters.AddWithValue("@Total", txtTotal.Text)
                    cmd.Parameters.AddWithValue("@Fecha", dtFecha.Text)
                    cmd.ExecuteNonQuery()
                    Cerrar()

                Catch ex As Exception : MessageBox.Show(ex.Message)

                End Try

                dtgDetalles.Rows.Clear()
                total = 0
                txtTotal.Text = total
                optEfectivo.Checked = True
                txtCliente.Text = "Consumidor Final"
                txtMontoEntrega.Text = ""
                txtVuelto.Text = ""

                MessageBox.Show("Venta Ingresada con éxito", "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Proceso cancelado con éxito", "VENTAS", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        End If
    End Sub


    Sub ObtenerUltimoIdVenta()
        Dim adaptador As New SqlDataAdapter
        Dim datos As DataSet
        Try
            Dim consulta As String
            Dim lista As Byte
            Abrir()
            consulta = "select top(1)* from Ventas order by idVenta desc"
            adaptador = New SqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "Ventas")
            lista = datos.Tables("Ventas").Rows(0).Item("idVenta")
            idVentaGenerada = lista
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Solo se puede ingresar Números", "MOVIMIENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrecio.Focus()
        End If
    End Sub


End Class