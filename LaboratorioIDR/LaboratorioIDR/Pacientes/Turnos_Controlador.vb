Imports LaboratorioIDR
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
        Dim profesionales = servicioTurnos.ListarProfesionales()
        form.MostrarProfesionales(profesionales)
        'si no hay profesionales no seguir
        form.LimpiarControles()
    End Sub

    Friend Sub BuscarPaciente(text As String)
        Dim paciente = servicioPacientes.EncontarPacientePorDni(text)
        If (paciente Is Nothing) Then
            form.LimpiarDatosPaciente()
            form.MostrarMensaje("No existe el paciente solicitado")
        Else
            form.MostrarPaciente(paciente)
        End If
    End Sub

    Friend Sub BuscarTurnos(profesional As Profesional, fecha As Date)
        profesionalBuscado = profesional
        fechaBuscada = fecha
        Dim agenda = servicioTurnos.ObtenerAgenda(profesional, fecha)
        form.MostrarAgenda(agenda)
    End Sub

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
        BuscarTurnos(profesionalBuscado, fechaBuscada)
        form.MostrarDatosTurno(turnoCreado)
    End Sub
End Class
