Imports System.Data.SqlClient
Imports System.Globalization

Public Class MetodoLogIn
    Private con As New SqlConnection
    Private com As New SqlCommand
    Private da As New SqlDataAdapter
    Private dt As New DataTable
    Private ds As New DataSet

    Public Sub New()
        Dim objcon As New conexion
        con = objcon.abrir()
        com.Connection = con
    End Sub
    'Agregar LogIn
    Public Sub Agregar(ByVal log As ClassLogIn)
        Dim CodAgregar As String
        CodAgregar = "INSERT INTO Login(Usuario, Contrasena) VALUES('" & log.Usuario & "','" & log.Contrasena & "')"
        com.CommandText = CodAgregar
        com.ExecuteNonQuery()
    End Sub
    'Cargar Grilla
    Public Function CargarGrilla()
        ds = New DataSet
        Dim sqlstr As String
        Try
            sqlstr = "Select Usuario from LogIn"

            da = New SqlDataAdapter(sqlstr, con)
            da.Fill(ds, "grilla_completa")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function
    'Eliminar Paciente
    Public Sub Eliminar_Usuario(ByVal log As ClassLogIn)
        Dim elim As String
        Try
            elim = "Delete from Login where Usuario = '" & log.Usuario & "'"
            com.CommandText = elim
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    'Cargar campos
    Public Function cargar_campos(ByVal Usuario As String)
        da = New SqlDataAdapter("select * from Login where Usuario like " & CStr(Usuario) & "", con)
        ds = New DataSet
        Dim dr As DataRow
        Try
            da.Fill(ds)
            dr = ds.Tables(0).Rows(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return dr
    End Function
End Class
