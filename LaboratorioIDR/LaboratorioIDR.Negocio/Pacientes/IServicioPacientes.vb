Imports LaboratorioIDR.Negocio

Public Interface IServicioPacientes
    Function EncontarPacientePorDni(dni As String) As Paciente
    Sub AgregarPaciente(p As Paciente)
    Sub ModificarPaciente(p As Paciente)
    Sub EliminarPaciente(p As Paciente)
    Function ListarTodos() As Object
End Interface
