Imports System.Configuration
Imports System.Data.SqlClient


Public Class Conexion
    Public Shared Function GetConnection() As SqlConnection
        Dim cs As String = ConfigurationManager.ConnectionStrings("laboratorio").ConnectionString
        Return New SqlConnection(cs)
    End Function
End Class