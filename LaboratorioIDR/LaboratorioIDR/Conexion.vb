Imports System.Data.SqlClient
Imports LaboratorioIDR.My

Public Class conexion
    Private con As String
    Private scon As New SqlConnection

    'Crear la conexion
    Public Function abrir()
        'string de conexion
        'con = "Data Source=.\SQLEXPRESS01;Initial Catalog=laboratorio1;Integrated Security=True"
        con = "Data Source=PCJORGE;Initial Catalog=laboratorio;Integrated Security=True"
        scon = New SqlConnection(con)
        scon.Open()
        Return scon
    End Function
End Class