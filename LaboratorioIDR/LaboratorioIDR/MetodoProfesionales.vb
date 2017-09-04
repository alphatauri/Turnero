Imports System.Data.SqlClient

Public Class MetodoProfesionales
    Private con As New SqlConnection
    Private com As New SqlCommand
    Private da As New SqlDataAdapter
    Private dt As New DataTable
    Private ds As New DataSet

    'Llamar demas Funciones
    Public Sub New()
        Dim objcon As New conexion
        con = objcon.abrir()
        com.Connection = con
    End Sub
    'Llamar a SQL y pedir todos los datos de Profesionales
    Public Function cargarGrilla()
        ds = New DataSet
        Dim sqlstr As String
        Try
            sqlstr = "select DNIProf Documento, ApeProf + ',' +' ' + NomProf [Apellido y Nombre], FecIngProf [Fecha de Ingreso],CarTelProf Prefijo ,TelProf Teléfono " &
                "from Profesionales"
            da = New SqlDataAdapter(sqlstr, con)
            da.Fill(ds, "grilla_completa")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function
    'Cargar Grilla DNI
    Public Function cargar_grilla_DNI(ByVal Prof As ClassProfesionales)
        ds = New DataSet
        Dim consul_DNI As String
        Try
            consul_DNI = "select DNIProf Documento, ApeProf + ',' +' ' + NomProf [Apellido y Nombre], FecIngProf [Fecha de Ingreso], CarTelProf Prefijo, TelProf Teléfono " &
                "from Profesionales where DNIProf = '" & CInt(Prof.DNIProf) & "'"
            da = New SqlDataAdapter(consul_DNI, con)
            da.Fill(ds, "consulta_DNI_grilla")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function
    'Agregar
    Public Sub agregar(ByVal Prof As ClassProfesionales)
        Dim CodAgregar As String
        CodAgregar = "set dateformat dmy INSERT INTO Profesionales(DNIProf, NomProf, ApeProf, FecIngProf,CarTelProf, TelProf) " &
    "VALUES('" & Prof.DNIProf & "','" & Prof.NomProf & "', '" & Prof.ApeProf & "', '" & Prof.FecIngProf & "', '" & Prof.PrefijoProf & "', '" & Prof.TelProf & "')"
        com.CommandText = CodAgregar
        com.ExecuteNonQuery()
        MessageBox.Show("Profesional agregado al Padron con Éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
    'Modificar
    Public Sub modificar_Profesionales(ByVal Prof As ClassProfesionales)
        Dim modif As String
        Try
            modif = "set dateformat dmy UPDATE Profesionales set NomProf = '" & Prof.NomProf & "', ApeProf = '" & Prof.ApeProf & "', FecIngProf = '" & Prof.FecIngProf & "',CarTelProf = '" & Prof.PrefijoProf & "', TelProf = '" & Prof.TelProf & "' " &
                "where DNIProf = '" & CInt(Prof.DNIProf) & "'"
            com.CommandText = modif
            com.ExecuteNonQuery()
            MessageBox.Show("Profesional Modificado con Éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    'Eliminar Profesional
    Public Sub eliminar_Profesional(ByVal Prof As ClassProfesionales)
        Dim elim As String
        Try
            elim = "Delete from Profesionales where DNIProf = '" & CInt(Prof.DNIProf) & "'"
            com.CommandText = elim
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    'Buscar Apellido
    Public Function Buscar_Apellido(ByVal Prof As ClassProfesionales)
        ds = New DataSet
        Dim busq_ape As String
        Try
            busq_ape = "Select DNIProf Documento, ApeProf + ',' +' ' + NomProf [Apellido y Nombre], FecIngProf [Fecha de Ingreso], CarTelProf Prefijo, TelProf Teléfono " &
                "from Profesionales where ApeProf like '" & Prof.ApeProf & "%'"
            da = New SqlDataAdapter(busq_ape, con)
            da.Fill(ds, "busqueda_apellido")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function
    'Buscar DNI
    Public Function buscar_DNI(ByVal Prof As ClassProfesionales)
        Dim busc_DNI As String
        ds = New DataSet
        ' Dim dr As DataRow
        Try
            busc_DNI = "select * from Profesionales where DNIProf = '" & CInt(Prof.DNIProf) & "'"
            da = New SqlDataAdapter(busc_DNI, con)
            da.Fill(ds, "buqueda_DNIProf")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function
    'Pedir a SQL todos los campos con el nombre y el apellido concatenado para llenar la grilla
    Public Function cargar_grilla_DNIProf(ByVal Prof As ClassProfesionales)
        ds = New DataSet
        Dim consul_DNI As String
        Try
            consul_DNI = "select DNIProf Documento, ApeProf + ',' +' ' + NomProf [Apellido y Nombre], FecIngProf [Fecha de Ingreso], " &
                " CarTelProf Prefijo, TelProf Teléfono " &
                "from Profesionales where DNIProf = '" & CInt(Prof.DNIProf) & "'"
            da = New SqlDataAdapter(consul_DNI, con)
            da.Fill(ds, "consulta_DNI_grilla")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function
    'Cargar campos
    Public Function cargar_campos(ByVal DNIProf As String)
        da = New SqlDataAdapter("select * from Profesionales where DNIProf like " & CInt(DNIProf) & "", con)
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
