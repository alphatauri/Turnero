Imports LaboratorioIDR.Negocio

Public Class Turnos_Controlador
    Private form As Turnos
    Private servicioTurnos As IServicioTurnos
    Private ReadOnly servicioPacientes As IServicioPacientes
    Private profesionalBuscado As Profesional
    Private fechaBuscada As Date
    Private turnoActual As Turno

    Public Sub New(turnos As Turnos, servicioTurnos As IServicioTurnos, servicioPacientes As IServicioPacientes)
        Me.form = turnos
        Me.servicioTurnos = servicioTurnos
        Me.servicioPacientes = servicioPacientes
    End Sub

    Friend Sub Inicializar()
        LimpiarTodo()

        Dim profesionales = servicioTurnos.ListarProfesionales()
        form.MostrarProfesionales(profesionales)
    End Sub

    Private Sub LimpiarTodo()
        form.LimpiarControles()
        form.DeshabilitarAsignarTurno()
        form.DeshabilitarLiberarTurno()
    End Sub

    Friend Sub BuscarPaciente(dniPaciente As String)
        Dim paciente = servicioPacientes.EncontarPacientePorDni(dniPaciente)
        If (paciente Is Nothing) Then
            form.LimpiarDatosPaciente()
            form.MostrarMensaje("No existe el paciente solicitado")
        Else
            form.MostrarPaciente(paciente)
        End If
    End Sub

    Friend Sub BuscarTurnos()
        MostrarAgenda()
    End Sub

    Private Function MostrarAgenda() As List(Of Turno)
        Dim agenda = ObtenerAgenda()
        form.MostrarAgenda(agenda)
        Return agenda
    End Function

    Private Function ObtenerAgenda() As List(Of Turno)
        If profesionalBuscado Is Nothing OrElse fechaBuscada = Date.MinValue Then
            Return New List(Of Turno)
        End If

        Return servicioTurnos.ObtenerAgenda(profesionalBuscado, fechaBuscada)
    End Function

    Friend Sub TurnoSeleccionado(turno As Turno)
        If (turno.PacienteDni > 0) Then
            form.HabilitarLiberarTurno()
            form.DeshabilitarAsignarTurno()
        Else
            form.DeshabilitarLiberarTurno()
            form.HabilitarAsignarTurno()
        End If
        turnoActual = turno
        form.MostrarDatosTurno(turno)
    End Sub

    Friend Sub AsignarTurnoSeleccionadoAPaciente(paciente As Paciente)
        Dim turnoCreado = servicioTurnos.AsignarTurno(turnoActual, paciente)
        BuscarTurnos()
        TurnoSeleccionado(turnoCreado)
    End Sub

    Friend Sub LiberarTurnoSeleccionado()
        Dim hora = turnoActual.Hora
        servicioTurnos.LiberarTurno(turnoActual)
        Dim agenda = MostrarAgenda()
        Dim turno = (From t In agenda
                     Where t.Hora = hora).FirstOrDefault()
        If turno IsNot Nothing Then
            TurnoSeleccionado(turno)
        Else
            LimpiarTodo()
        End If
    End Sub

    Friend Sub CambioDeProfesional(profesional As Profesional)
        profesionalBuscado = profesional
        MostrarAgenda()
        LimpiarTodo()
    End Sub

    Friend Sub CambioDeFecha(nuevaFecha As Date)
        fechaBuscada = nuevaFecha
        MostrarAgenda()
        LimpiarTodo()
    End Sub
End Class
