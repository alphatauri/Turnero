Imports LaboratorioIDR
Imports LaboratorioIDR.Negocio

Public Class Turnos_Controlador
    Private form As Turnos
    Private servicioTurnos As IServicioTurnos
    Private ReadOnly servicioPacientes As IServicioPacientes

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

    Friend Function BuscarPaciente(text As String) As Object
        Dim paciente = servicioPacientes.EncontarPacientePorDni(text)
        If (paciente Is Nothing) Then
            form.LimpiarDatosPaciente()
            form.MostrarMensaje("No existe el paciente solicitado")
        Else
            form.MostrarPaciente(paciente)
        End If
    End Function

    Friend Sub BuscarTurnos(profesional As Profesional, fecha As Date)
        Dim agenda = servicioTurnos.ObtenerAgenda(profesional, fecha)
        form.MostrarAgenda(agenda)
    End Sub
End Class
