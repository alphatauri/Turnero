Imports System.Data.SqlClient

Public Class MetodoPacientes
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
    'Llamar a SQL y pedir todos los datos de Pacientes
    Public Function cargarGrilla()
        ds = New DataSet
        Dim sqlstr As String
        Try
            sqlstr = "select DNIPac [Documento], ApePac + ',' + ' ' + NomPac [Apellido y Nombre], GeneroPac [Genero], FecNacPac [Fecha de Nacimiento], " &
                "CarTelPac [Prefijo], TelPac [Telefono], CallePac [Calle], AlturaPac [Altura], CiudadPac [Ciudad] " &
                "from Pacientes order by apepac"
            da = New SqlDataAdapter(sqlstr, con)
            da.Fill(ds, "grilla_completa")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function
    'Cargar Grilla DNI
    Public Function cargar_grilla_DNI(ByVal pac As ClassPacientes)
        ds = New DataSet
        Dim consul_DNI As String
        Try
            consul_DNI = "select DNIPac [Documento], NomPac + ' ' + ApePac [Nombre y Apellido], FecNacPac [Fecha de Nacimiento], " &
            "CallePac [Calle], AlturaPac [Altura], GeneroPac [Genero], CiudadPac [Ciudad], CarTelPac [Prefijo], TelPac [Telefono] " &
            "from Pacientes where DNIPac = '" & CInt(pac.DNIPac) & "'"
            da = New SqlDataAdapter(consul_DNI, con)
            da.Fill(ds, "consulta_DNI_grilla")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function
    'Agregar
    Public Sub agregar(ByVal pac As ClassPacientes)
        Dim CodAgregar As String
        Try
            CodAgregar = "set dateformat dmy INSERT INTO Pacientes(DNIPac, NomPac, ApePac, FecNacPac, CallePac, AlturaPac, GeneroPac, CiudadPac, CarTelPac, TelPac) " &
    "VALUES('" & pac.DNIPac & "','" & pac.NomPac & "', '" & pac.ApePac & "', '" & pac.FecNacPac & "', '" & pac.CallePac & "', '" & pac.AlturaPac & "', '" & pac.GeneroPac & "', '" & pac.CiudadPac & "','" & pac.PreFijoPac & "','" & pac.TelPac & "')"
            com.CommandText = CodAgregar
            com.ExecuteNonQuery()
            MessageBox.Show("Paciente agregado al Padron con Éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "El Paciente ya se encuentra en el Padrón")
        End Try
    End Sub
    'Modificar
    Public Sub modificar_Pacientes(ByVal pac As ClassPacientes)
        Dim modif As String
        Try
            modif = "set dateformat dmy UPDATE Pacientes set NomPac = '" & pac.NomPac & "', ApePac = '" & pac.ApePac & "', FecNacPac = '" & pac.FecNacPac & "', CallePac = '" & pac.CallePac & "', AlturaPac = '" & pac.AlturaPac & "',CiudadPac= '" & pac.CiudadPac & "', GeneroPac = '" & pac.GeneroPac & "', CarTelPac = '" & pac.PreFijoPac & "', Telpac = '" & pac.TelPac & "' " &
                "where DNIpac = '" & CInt(pac.DNIPac) & "'"
            com.CommandText = modif
            com.ExecuteNonQuery()
            MessageBox.Show("Paciente Modificado con Éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    'Eliminar Paciente
    Public Sub eliminar_Paciente(ByVal pac As ClassPacientes)
        Dim elim As String
        Try
            elim = "delete from Pacientes where DNIPac = '" & CInt(pac.DNIPac) & "'"
            com.CommandText = elim
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    'Buscar Apellido
    Public Function Buscar_Apellido(ByVal pac As ClassPacientes)
        ds = New DataSet
        Dim busq_ape As String
        Try
            busq_ape = "Select DNIPac Documento, NomPac + ' ' + ApePac [Nombre y Apellido], FecNacPac [Fecha de Nacimiento], " &
                "CallePac Calle, AlturaPac Altura, GeneroPac Genero, CarTelPac Prefijo, TelPac TelPac" &
                " from Pacientes where ApePac like '" & pac.ApePac & "%'"
            da = New SqlDataAdapter(busq_ape, con)
            da.Fill(ds, "busqueda_apellido")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function
    'Buscar DNI
    Public Function buscar_DNI(ByVal pac As ClassPacientes)
        Dim busc_DNI As String
        ds = New DataSet
        ' Dim dr As DataRow
        Try
            busc_DNI = "select * from Pacientes where DNIPac = '" & CInt(pac.DNIPac) & "'"
            da = New SqlDataAdapter(busc_DNI, con)
            da.Fill(ds, "buqueda_DNIPac")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function
    'Pedir a SQL todos los campos con el nombre y el apellido concatenado para llenar la grilla
    Public Function cargar_grilla_legajo(ByVal pac As ClassPacientes)
        ds = New DataSet
        Dim consul_DNI As String
        Try
            consul_DNI = "select DNIPac Documento, NomPac + ' ' + ApePac [Nombre y Apellido], FecNacpac [Fecha de Nacimiento], " &
                "CallePac Calle, AlturaPac Altura, GeneroPac Genero, CarTelPac Prefijo, TelPac TelPac " &
                "from Pacientes where DNIPac = '" & CInt(pac.DNIPac) & "'"
            da = New SqlDataAdapter(consul_DNI, con)
            da.Fill(ds, "consulta_DNI_grilla")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function
    'Cargar campos
    Public Function cargar_campos(ByVal DNIPac As String)
        da = New SqlDataAdapter("select * from Pacientes where DNIPac like " & CInt(DNIPac) & "", con)
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
