Imports LaboratorioIDR.Negocio

Public Interface IRepositorioProfesionales
    Function Listar() As List(Of Profesional)
    Function ObtenerAgenda(dni As Decimal, fecha As Date) As List(Of AgendaProfesional)
End Interface
