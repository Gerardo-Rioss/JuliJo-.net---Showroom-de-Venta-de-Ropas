Imports System.Data.SqlClient
Public Class FormVentasTarjetas
    Dim idVentaSeleccionada As Integer
    Private Sub FormVentasTarjetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFecha1.Text = Date.Today
        dtFecha2.Text = Date.Today
        dtFechaTransferencia.Text = Date.Today
        MostrarVentasTarjeta()
        dtgVentas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub
    Sub MostrarVentasTarjeta()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("MostrarVentasTarjeta", conexion)
            da.Fill(dt)
            dtgVentas.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub


    Sub MostrarVentasTarjetaSinTransferir()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("MostrarVentasTarjetaSinTransferir", conexion)
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
            dtgDetallesVenta.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub BuscarVentasTarjetaFechas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("BuscarVentasTarjetaFechas", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Fecha1", dtFecha1.Text)
            da.SelectCommand.Parameters.AddWithValue("@Fecha2", dtFecha2.Text)
            da.Fill(dt)
            dtgVentas.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub dtgVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgVentas.CellClick
        idVentaSeleccionada = dtgVentas.CurrentRow.Cells(1).Value
        BuscarDetalleVenta()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If dtFecha1.Text > dtFecha2.Text Then
            MessageBox.Show("La fecha de inicio no puede superar a la de Fin", "Buscar por Fechas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            BuscarVentasTarjetaFechas()
        End If
    End Sub

    Private Sub btnLimpiarBusqueda_Click(sender As Object, e As EventArgs) Handles btnLimpiarBusqueda.Click
        MostrarVentasTarjeta()
        txtTotalCredito.Text = ""
        txtTotalDebito.Text = ""
        chkSinTransferir.Checked = False
        dtgDetallesVenta.DataSource = Nothing
    End Sub

    Private Sub btnCalcularTotales_Click(sender As Object, e As EventArgs) Handles btnCalcularTotales.Click
        Dim totalDebito As Integer
        Dim totalCredito As Integer
        totalDebito = 0
        totalCredito = 0

        If dtgVentas.RowCount <> 0 Then
            For i = 0 To dtgVentas.RowCount - 1
                If dtgVentas.Rows(i).Cells(2).Value = "DEBITO" Then
                    totalDebito = totalDebito + dtgVentas.Rows(i).Cells(5).Value
                Else
                    totalCredito = totalCredito + dtgVentas.Rows(i).Cells(5).Value
                End If
            Next

            txtTotalCredito.Text = totalCredito
            txtTotalDebito.Text = totalDebito

        End If
    End Sub

    Private Sub chkSinTransferir_CheckedChanged(sender As Object, e As EventArgs) Handles chkSinTransferir.CheckedChanged
        If chkSinTransferir.Checked = True Then
            MostrarVentasTarjetaSinTransferir()
        Else
            MostrarVentasTarjeta()
        End If
    End Sub

    Private Sub btnMarcar_Click(sender As Object, e As EventArgs) Handles btnMarcar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea marcar la venta como transferida?", "VENTAS TARJETAS", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            If dtgVentas.CurrentRow.Cells(6).Value = True Then
                MessageBox.Show("La venta ya se encuentra Transferida", "VENTAS TARJETAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf dtgDetallesVenta.RowCount = 0 Then
                MessageBox.Show("Debe seleccionar la venta a marcar", "VENTAS TARJETAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    Dim cmd As New SqlCommand
                    Abrir()
                    cmd = New SqlCommand("ModificarVentaTarjetaTransferido", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idVenta", dtgVentas.CurrentRow.Cells(1).Value)
                    cmd.Parameters.AddWithValue("@Fecha", dtFechaTransferencia.Text)
                    cmd.Parameters.AddWithValue("@Transferido", 1)
                    cmd.ExecuteNonQuery()
                    Cerrar()

                Catch ex As Exception : MessageBox.Show(ex.Message)

                End Try
                MessageBox.Show("Venta marcada de forma correcta", "VENTAS TARJETAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarVentasTarjeta()
            End If
        Else
            MessageBox.Show("Proceso cancelado con éxito", "VENTAS TARJETAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
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