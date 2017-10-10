Imports LaboratorioIDR.Negocio

Public Interface IServicioTurnos
    Function ListarProfesionales() As List(Of Profesional)
    Function ObtenerAgenda(profesional As Profesional, fecha As Date) As List(Of Turno)
End Interface
