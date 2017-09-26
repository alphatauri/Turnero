Imports System.Data.SqlClient
Imports System.Globalization

Public Class MetodoHorarios
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
    'Agregar Horarios
    Public Sub Agregar(ByVal agen As ClassHorarios)
        Dim CodAgregar As String
        Try
            CodAgregar = "set dateformat dmy INSERT INTO agenda(DNIProfPlan, Consultorio, FechaDesde, FechaHasta, HoraDesde, HoraHasta, Slot, Lunes, Martes, Miercoles, Jueves, Viernes) " &
    "VALUES('" & agen.DNIProf & "','" & agen.Consultorio & "', '" & agen.FecDsd & "', '" & agen.FecHst & "', '" & agen.HoraDsd & "', '" & agen.HoraHst & "', '" & agen.Slot & "', '" & agen.Lunes & "', '" & agen.Martes & "','" & agen.Miercoles & "','" & agen.Jueves & "','" & agen.Viernes & "')"
            com.CommandText = CodAgregar
            com.ExecuteNonQuery()
            MessageBox.Show("Horario agregado con Éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    'Llenar ComboBox1
    Public Sub LlenarComboBox(ByVal cb As ComboBox)
        Try
            da = New SqlDataAdapter("SELECT DNIProf, ApeProf FROM profesionales", con)
            da.Fill(dt)
            With cb
                .DisplayMember = "ApeProf"
                .ValueMember = "DNIProf"
                .DataSource = dt
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    'Cargar Grilla
    Public Function CargarGrilla()
        ds = New DataSet
        Dim sqlstr As String
        Try
            sqlstr = "Select Idplan [Identificación del Plan],DNIProfPlan [DNI Profesional], Consultorio, FechaDesde [Fecha Desde], FechaHasta [Fecha Hasta]" &
            ",HoraDesde [Hora Desde], HoraHasta [Hora Hasta], Slot [Duración],Lunes, Martes, Miercoles Miércoles, Jueves, Viernes from Agenda"

            da = New SqlDataAdapter(sqlstr, con)
            da.Fill(ds, "grilla_completa")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function
    'Agregar en Agenda
    Public Sub Generar(ByVal agen As ClassHorarios)
        Dim CodGenerar As String
        CodGenerar = "Set dateformat dmy INSERT INTO agenda(DNIProfPlan, Consultorio, FechaDesde, FechaHasta, HoraDesde, HoraHasta, Slot, Lunes, Martes, Miercoles, Jueves, Viernes) " &
    "VALUES('" & agen.DNIProf & "','" & agen.Consultorio & "', '" & agen.FecDsd & "', '" & agen.FecHst & "', '" & agen.HoraDsd & "', '" & agen.HoraHst & "', '" & agen.Slot & "', '" & agen.Lunes & "', '" & agen.Martes & "', '" & agen.Miercoles & "', '" & agen.Jueves & "', '" & agen.Viernes & "')"
        MessageBox.Show("Horario agregado con Éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        com.CommandText = CodGenerar
        com.ExecuteNonQuery()
    End Sub
    'Buscar DNI en la Base de Datos
    Public Function Buscar_DNI(ByVal agen As ClassHorarios)
        Dim busc_DNI As String
        ds = New DataSet
        ' Dim dr As DataRow
        Try
            busc_DNI = "select DNIProf from Pacientes where ApeProf = '" & CInt(agen.NomProf) & "'"
            da = New SqlDataAdapter(busc_DNI, con)
            da.Fill(ds, "buqueda_DNIProf")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function

End Class