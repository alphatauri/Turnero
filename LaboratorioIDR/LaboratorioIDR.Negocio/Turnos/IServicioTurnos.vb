Imports LaboratorioIDR.Negocio

Public Interface IServicioTurnos
    Function ListarProfesionales() As List(Of Profesional)
    Function ObtenerAgenda(profesional As Profesional, fecha As Date) As List(Of Turno)
    Function AsignarTurno(turno As Turno, paciente As Paciente) As Turno
End Interface
