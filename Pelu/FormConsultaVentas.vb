Imports System.Data.SqlClient

Public Class FormConsultaVentas

    Dim idVentaSeleccionada As Integer
    Private Sub Movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarVentas()
        dtFecha1.Text = Date.Today
        dtFecha2.Text = Date.Today

        txtTotalEfectivo.ReadOnly = True
        txtTotalCredito.ReadOnly = True
        txtTotalDebito.ReadOnly = True
        dtgVentas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


    End Sub
    Sub MostrarVentas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("MostrarVentas", conexion)
            da.Fill(dt)
            dtgVentas.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub BuscarDetalleVenta()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("BuscarDetalleVenta", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@idVenta", idVentaSeleccionada)
            da.Fill(dt)
            dtgDetalleVenta.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub

    Sub BuscarVentasxFechas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("BuscarVentasxFechas", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Fecha1", dtFecha1.Text)
            da.SelectCommand.Parameters.AddWithValue("@Fecha2", dtFecha2.Text)
            da.Fill(dt)
            dtgVentas.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If dtFecha1.Text > dtFecha2.Text Then
            MessageBox.Show("La fecha de inicio no puede superar a la de Fin", "Buscar por Fechas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            BuscarVentasxFechas()
            dtgDetalleVenta.DataSource = Nothing

        End If

    End Sub

    Private Sub dtgVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgVentas.CellClick
        idVentaSeleccionada = dtgVentas.CurrentRow.Cells(0).Value
        BuscarDetalleVenta()
    End Sub

    Private Sub btnCalcularTotales_Click(sender As Object, e As EventArgs) Handles btnCalcularTotales.Click
        Dim totalEfectivo As Integer
        Dim totalDebito As Integer
        Dim totalCredito As Integer
        Dim totalAnuladas As Integer
        Dim TotalDetalles As Integer
        totalEfectivo = 0
        totalDebito = 0
        totalCredito = 0
        totalAnuladas = 0
        TotalDetalles = 0


        If dtgVentas.RowCount <> 0 Then
            For i = 0 To dtgVentas.RowCount - 1
                If dtgVentas.Rows(i).Cells(6).Value = True Then
                    totalAnuladas = totalAnuladas + dtgVentas.Rows(i).Cells(5).Value
                ElseIf dtgVentas.Rows(i).Cells(3).Value = "EFECTIVO" Then
                    totalEfectivo = totalEfectivo + dtgVentas.Rows(i).Cells(5).Value
                ElseIf dtgVentas.Rows(i).Cells(3).Value = "CREDITO" Then
                    totalCredito = totalCredito + dtgVentas.Rows(i).Cells(5).Value
                Else
                    totalDebito = totalDebito + dtgVentas.Rows(i).Cells(5).Value

                End If
            Next
            txtTotalCredito.Text = totalCredito
            txtTotalEfectivo.Text = totalEfectivo
            txtTotalDebito.Text = totalDebito
            txtTotalAnuladas.Text = totalAnuladas
        End If




    End Sub

    Private Sub btnLimpiarBusqueda_Click(sender As Object, e As EventArgs) Handles btnLimpiarBusqueda.Click
        MostrarVentas()
        txtTotalAnuladas.Text = ""
        txtTotalCredito.Text = ""
        txtTotalDebito.Text = ""

        txtTotalEfectivo.Text = ""
        dtgDetalleVenta.DataSource = Nothing
    End Sub

    Private Sub btnAnularFactura_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult
        result = MessageBox.Show("¿Esta seguro de anular la Venta?", "ANULAR VENTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            If dtgDetalleVenta.RowCount = 0 Then
                MessageBox.Show("Debe seleccionar la venta a anular", "ANULAR VENTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim totalAnulado As Integer
                totalAnulado = 0
                For i = 0 To dtgDetalleVenta.RowCount - 1
                    totalAnulado = totalAnulado + dtgDetalleVenta.Rows(i).Cells(5).Value * dtgDetalleVenta.Rows(i).Cells(6).Value
                Next

                'Anular Factura
                Try
                    Dim cmd As New SqlCommand
                    Abrir()
                    cmd = New SqlCommand("ModificarAnularVenta", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idVenta", dtgVentas.CurrentRow.Cells(0).Value)
                    cmd.Parameters.AddWithValue("@Anulada", 1)
                    cmd.ExecuteNonQuery()
                    Cerrar()
                Catch ex As Exception : MessageBox.Show(ex.Message)

                End Try

                'Insertar Movimiento
                Try
                    Dim cmd As New SqlCommand
                    Abrir()
                    cmd = New SqlCommand("InsertarMovimiento", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idTipoMovimiento", 9)
                    cmd.Parameters.AddWithValue("@Total", totalAnulado)
                    cmd.Parameters.AddWithValue("@Fecha", Date.Today)
                    cmd.ExecuteNonQuery()
                    Cerrar()

                Catch ex As Exception : MessageBox.Show(ex.Message)

                End Try
                MostrarVentas()
                MessageBox.Show("Venta anulada con éxito", "ANULAR VENTA", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Else
            MessageBox.Show("Proceso cancelado con éxito", "ANULAR VENTA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnularVenta_Click(sender As Object, e As EventArgs) Handles btnAnularVenta.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea anular la venta seleccionada?", "VENTAS", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            If dtgVentas.CurrentRow.Cells(6).Value = True Then
                MessageBox.Show("La venta ya se encuentra Anulada", "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf dtgDetalleVenta.RowCount = 0 Then
                MessageBox.Show("Debe seleccionar la venta a anular", "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Anula Venta
                Try
                    Dim cmd As New SqlCommand
                    Abrir()
                    cmd = New SqlCommand("ModificarAnularVenta", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idVenta", dtgVentas.CurrentRow.Cells(0).Value)
                    cmd.Parameters.AddWithValue("@Anulada", 1)
                    cmd.ExecuteNonQuery()
                    Cerrar()

                Catch ex As Exception : MessageBox.Show(ex.Message)

                End Try

                'InsertarMovimiento
                Try
                    Dim cmd As New SqlCommand
                    Abrir()
                    cmd = New SqlCommand("InsertarMovimiento", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idTipoMovimiento", 9)
                    cmd.Parameters.AddWithValue("@Total", dtgVentas.CurrentRow.Cells(5).Value)
                    cmd.Parameters.AddWithValue("@Fecha", Date.Today)
                    cmd.ExecuteNonQuery()
                    Cerrar()

                Catch ex As Exception : MessageBox.Show(ex.Message)

                End Try
                If dtgVentas.CurrentRow.Cells(3).Value = "DEBITO" Or dtgVentas.CurrentRow.Cells(3).Value = "CREDITO" Then
                    'ModificarVentaTarjetaAnulada
                    Try
                        Dim cmd As New SqlCommand
                        Abrir()
                        cmd = New SqlCommand("ModificarVentaTarjetaAnulada", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@idVenta", dtgVentas.CurrentRow.Cells(0).Value)
                        cmd.Parameters.AddWithValue("@Anulada", 1)
                        cmd.ExecuteNonQuery()
                        Cerrar()

                    Catch ex As Exception : MessageBox.Show(ex.Message)

                    End Try
                End If



                MessageBox.Show("Venta anulada forma correcta", "VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MostrarVentas()
                End If
                Else
            MessageBox.Show("Proceso cancelado con éxito", "VENTAS ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim SAVE As New SaveFileDialog
        Dim ruta As String
        Dim xlApp As Object = CreateObject("Excel.Application")
        Dim pth As String = ""
        Dim xlwb As Object = xlApp.workbooks.add
        Dim xlws As Object = xlwb.worksheets(1)
        Try
            For c As Integer = 0 To dtgVentas.Columns.Count - 1
                xlws.cells(1, c + 1).value = dtgVentas.Columns(c).HeaderText
            Next
            For r As Integer = 0 To dtgVentas.RowCount - 1
                For c As Integer = 0 To dtgVentas.Columns.Count - 1
                    xlws.cells(r + 2, c + 1).value = Convert.ToString(dtgVentas.Item(c, r).Value)
                Next
            Next

            Dim savefiledialog1 As SaveFileDialog = New SaveFileDialog
            savefiledialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            savefiledialog1.Filter = "Archivo Excel|*.xlsx"
            savefiledialog1.FilterIndex = 2
            If savefiledialog1.ShowDialog = DialogResult.OK Then
                ruta = savefiledialog1.FileName
                xlwb.saveas(ruta)
                xlws = Nothing
                xlwb = Nothing
                xlApp.quit()
                MsgBox("Exportado Correctamente", MsgBoxStyle.Information)


            End If
        Catch ex As Exception

        End Try
    End Sub
End Class