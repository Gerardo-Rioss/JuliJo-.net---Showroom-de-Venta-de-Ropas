Imports System.Data.SqlClient


Module ConexionMaestra

    Public conexion As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=BASEJULIJO;Integrated Security=True")

    Sub Abrir()
        If conexion.State = 0 Then
            conexion.Open()
        End If

    End Sub
    Sub Cerrar()
        If conexion.State = 1 Then
            conexion.Close()

        End If
    End Sub
End Module
