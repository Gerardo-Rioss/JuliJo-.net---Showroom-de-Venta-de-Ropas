Public Class FormPrincipal



    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        FormVentas.Show()

    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnConsultaVentas_Click(sender As Object, e As EventArgs) Handles btnConsultaVentas.Click
        FormConsultaVentas.Show()

    End Sub



    Private Sub btnConsultaMovimientos_Click(sender As Object, e As EventArgs) Handles btnConsultaMovimientos.Click
        FormConsultaMovimientos.Show()

    End Sub

    Private Sub btnVentasTarjeta_Click(sender As Object, e As EventArgs) Handles btnVentasTarjeta.Click
        FormVentasTarjetas.Show()
    End Sub
End Class