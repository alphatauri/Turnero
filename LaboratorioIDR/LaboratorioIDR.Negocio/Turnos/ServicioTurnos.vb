Imports LaboratorioIDR.Negocio

Public Class ServicioTurnos : Implements IServicioTurnos

    Private ReadOnly repositorioTurnos As IRepositorioTurnos
    Private ReadOnly repositorioProfesionales As IRepositorioProfesionales

    Public Sub New(repositorioTurnos As IRepositorioTurnos, repositorioProfesionales As IRepositorioProfesionales)
        Me.repositorioTurnos = repositorioTurnos
        Me.repositorioProfesionales = repositorioProfesionales
    End Sub

    Public Function AsignarTurno(turno As Turno, paciente As Paciente) As Turno Implements IServicioTurnos.AsignarTurno
        Dim turnoCreado = repositorioTurnos.Asignar(paciente.Dni, turno.ProfesionalDni, turno.FechaTurno, turno.Hora, turno.Consultorio)
        turno.PacienteDni = turnoCreado.Dni
        turno.PacienteNombre = turnoCreado.Paciente
        turno.Id = turnoCreado.Id
        Return turno
    End Function

    Public Function ListarProfesionales() As List(Of Profesional) Implements IServicioTurnos.ListarProfesionales
        Return repositorioProfesionales.Listar()
    End Function

    Public Function ObtenerAgenda(profesional As Profesional, fecha As Date) As List(Of Turno) Implements IServicioTurnos.ObtenerAgenda
        Dim registroAgenda = repositorioProfesionales.ObtenerAgenda(profesional.Dni, fecha)
        Dim registroTurnos = repositorioTurnos.ObtenerTurnos(profesional.Dni, fecha)
        Return GenerarRegistros(registroAgenda, registroTurnos, profesional.Dni, fecha)
    End Function

    Private Function GenerarRegistros(registroAgenda As List(Of AgendaProfesional),
                                      registroTurnos As List(Of TurnoAsignado),
                                      dniProfesional As Decimal,
                                      fecha As Date) As List(Of Turno)
        Dim lista = New List(Of Turno)

        For Each agenda In registroAgenda
            Dim horaTurno = agenda.HoraDesde
            While horaTurno < agenda.HoraHasta
                lista.Add(New Turno(horaTurno.ToString("HH:mm"), "Libre", Nothing, agenda.Consultorio, dniProfesional, fecha))
                horaTurno = horaTurno.AddMinutes(agenda.Slot)
            End While
        Next

        For Each turno In registroTurnos
            Dim encontrado = (From c In lista
                              Where c.Hora = turno.Hora
                              Select c).FirstOrDefault()
            If encontrado Is Nothing Then
                lista.Add(New Turno(turno.Hora, turno.Paciente, turno.Dni, "Sobreturno", dniProfesional, fecha))
            Else
                encontrado.PacienteNombre = turno.Paciente
                encontrado.PacienteDni = turno.Dni
            End If
        Next

        lista.Sort(Function(x, y) x.Hora.CompareTo(y.Hora))

        Return lista
    End Function

    Private Function OrdenarPorHora(x As Turno, y As Turno) As Integer
        Return x.Hora.CompareTo(y.Hora)
    End Function

End Class
