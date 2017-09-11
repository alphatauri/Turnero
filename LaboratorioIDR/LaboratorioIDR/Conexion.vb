Imports System.Configuration
Imports System.Data.SqlClient


Public Class conexion
    Public Function abrir()
        Dim con = New SqlConnection(ConfigurationManager.ConnectionStrings("laboratorio").ConnectionString)
        con.Open()
        Return con
    End Function
End Class