Imports System.Data.SqlClient
Public Class FormConsultaMovimientos
    Dim idMovimientoSeleccionado As Integer
    Dim idTipoMovimientoSeleccionado As Integer
    Private Sub FormConsultaMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarMovimientos()
        MostrarTiposMovimiento1()
        MostrarTiposMovimiento2()
        txtMovimiento2.ReadOnly = True
        dtFechaMovimiento.Text = Date.Today
        txtMovimiento1.ReadOnly = True
        txtMovimiento2.ReadOnly = True
        dtgMovimientos1.Visible = False
        dtgMovimientos2.Visible = False
        dtFecha1.Enabled = False
        dtFecha2.Enabled = False
        btnBuscar.Enabled = False
        txtPositivo.ReadOnly = True
        txtNegativo.ReadOnly = True
        dtgMovimientos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub
    Sub MostrarMovimientos()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("MostrarMovimientos", conexion)
            da.Fill(dt)
            dtgMovimientos.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub MostrarTiposMovimiento1()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("MostrarTiposMovimiento", conexion)
            da.Fill(dt)
            dtgMovimientos1.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub MostrarTiposMovimiento2()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("MostrarTiposMovimientoNuevos", conexion)
            da.Fill(dt)
            dtgMovimientos2.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub


    'Sub BuscarMovimiento()
    '    Dim dt As New DataTable
    '    Dim da As SqlDataAdapter
    '    Try
    '        Abrir()
    '        da = New SqlDataAdapter("BuscarTipoMovimiento", conexion)
    '        da.SelectCommand.CommandType = 4
    '        da.SelectCommand.Parameters.AddWithValue("@Letra", txtMovimiento1.Text)
    '        da.Fill(dt)
    '        dtgMovimientos1.DataSource = dt
    '        Cerrar()

    '    Catch ex As Exception : MessageBox.Show(ex.Message)

    '    End Try
    'End Sub

    Sub BuscarMovimientoSeleccionado()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("BuscarMovimientosxidTipoMovimiento", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@idTipoMovimiento", idMovimientoSeleccionado)
            da.Fill(dt)
            dtgMovimientos.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub BuscarMovimientosxFechas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("BuscarMovimientosxFechas", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Fecha1", dtFecha1.Text)
            da.SelectCommand.Parameters.AddWithValue("@Fecha2", dtFecha2.Text)
            da.Fill(dt)
            dtgMovimientos.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub BuscarMovimientosxiTipoMovimientoFechas()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("BuscarMovimientosxidMovimientoFechas", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@idTipoMovimiento", idMovimientoSeleccionado)
            da.SelectCommand.Parameters.AddWithValue("@Fecha1", dtFecha1.Text)
            da.SelectCommand.Parameters.AddWithValue("@Fecha2", dtFecha2.Text)
            da.Fill(dt)
            dtgMovimientos.DataSource = dt
            Cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub dtgMovimientos1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgMovimientos1.CellClick
        txtMovimiento1.Text = dtgMovimientos1.CurrentRow.Cells(1).Value
        idMovimientoSeleccionado = dtgMovimientos1.CurrentRow.Cells(0).Value
        dtgMovimientos1.Visible = False
        BuscarMovimientoSeleccionado()

    End Sub

    Private Sub btnBuscarMoviiento_Click(sender As Object, e As EventArgs) Handles btnBuscarMovimiento.Click
        dtgMovimientos1.Visible = True
        dtgMovimientos2.Visible = False
    End Sub

    Private Sub btnBorrarBusqueda_Click(sender As Object, e As EventArgs) Handles btnBorrarBusqueda.Click
        txtMovimiento1.Text = ""
        txtMovimiento2.Text = ""
        txtMonto.Text = ""
        txtNegativo.Text = ""
        txtPositivo.Text = ""
        dtgMovimientos1.Visible = False
        dtgMovimientos2.Visible = False
        MostrarMovimientos()
    End Sub

    Private Sub chkBuscarFecha_CheckedChanged(sender As Object, e As EventArgs) Handles chkBuscarFecha.CheckedChanged
        If chkBuscarFecha.Checked = True Then
            dtFecha1.Enabled = True
            dtFecha2.Enabled = True
            btnBuscar.Enabled = True
        Else
            btnBuscar.Enabled = False
            dtFecha1.Enabled = False
            dtFecha2.Enabled = False

        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If dtFecha1.Text > dtFecha2.Text Then
            MessageBox.Show("La fecha de inicio no puede superar a la de Fin", "Buscar por Fechas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtMovimiento1.Text = "" Then
                BuscarMovimientosxFechas()
            Else
                BuscarMovimientosxiTipoMovimientoFechas()
            End If
        End If
    End Sub

    Private Sub btnCalcularTotales_Click(sender As Object, e As EventArgs) Handles btnCalcularTotales.Click
        Dim totalMas As Integer
        Dim totalMenos As Integer
        totalMas = 0
        totalMenos = 0
        If dtgMovimientos.RowCount <> 0 Then
            For i = 0 To dtgMovimientos.RowCount - 1
                If dtgMovimientos.Rows(i).Cells(4).Value = True Then
                    totalMas = totalMas + dtgMovimientos.Rows(i).Cells(2).Value
                Else
                    totalMenos = totalMenos + dtgMovimientos.Rows(i).Cells(2).Value
                End If
            Next
            txtPositivo.Text = totalMas
            txtNegativo.Text = totalMenos
        End If

    End Sub

    Private Sub btnBuscarMov_Click(sender As Object, e As EventArgs) Handles btnBuscarMov.Click
        txtMovimiento2.Text = ""
        dtgMovimientos2.Visible = True
        dtgMovimientos1.Visible = False

    End Sub


    Private Sub dtgMovi2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgMovimientos2.CellClick
        idTipoMovimientoSeleccionado = dtgMovimientos2.CurrentRow.Cells(0).Value
        txtMovimiento2.Text = dtgMovimientos2.CurrentRow.Cells(1).Value
        dtgMovimientos2.Visible = False
    End Sub

    Private Sub btnCrearMovimiento_Click(sender As Object, e As EventArgs) Handles btnCrearMovimiento.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Quiere ingresar un Movimiento Nuevo?", "MOVIMIENTOS", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            If txtMovimiento2.Text = "" Then
                MessageBox.Show("Debe seleccionar un Tipo de Movimiento", "MOVIMIENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnBuscarMov.Focus()
            ElseIf txtMonto.Text = "" Then
                MessageBox.Show("Debe ingresar el Monto del Movimiento", "MOVIMIENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMonto.Focus()
            Else
                Try
                    Dim cmd As New SqlCommand
                    Abrir()
                    cmd = New SqlCommand("InsertarMovimiento", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idTipoMovimiento", idTipoMovimientoSeleccionado)
                    cmd.Parameters.AddWithValue("@Total", txtMonto.Text)
                    cmd.Parameters.AddWithValue("@Fecha", dtFechaMovimiento.Text)
                    cmd.ExecuteNonQuery()
                    Cerrar()
                    MostrarMovimientos()
                    MessageBox.Show("Proceso Exitoso", "MOVIMIENTOS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtMovimiento2.Text = ""
                    txtMonto.Text = ""
                Catch ex As Exception : MessageBox.Show(ex.Message)

                End Try
            End If
        Else
            MessageBox.Show("Proceso cancelado con éxito", "MOVIMIENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Solo se puede ingresar Números", "MOVIMIENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMonto.Focus()
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
            For c As Integer = 0 To dtgMovimientos.Columns.Count - 1
                xlws.cells(1, c + 1).value = dtgMovimientos.Columns(c).HeaderText
            Next
            For r As Integer = 0 To dtgMovimientos.RowCount - 1
                For c As Integer = 0 To dtgMovimientos.Columns.Count - 1
                    xlws.cells(r + 2, c + 1).value = Convert.ToString(dtgMovimientos.Item(c, r).Value)
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