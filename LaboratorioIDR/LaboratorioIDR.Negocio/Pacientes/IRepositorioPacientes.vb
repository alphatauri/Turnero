Imports LaboratorioIDR.Negocio

Public Interface IRepositorioPacientes
    Sub Insertar(p As Paciente)
    Sub Actualizar(p As Paciente)
    Function EncontrarPorDni(dni As String) As Paciente
End Interface
