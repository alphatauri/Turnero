Imports LaboratorioIDR.Negocio

Public Class ServicioPacientes : Implements IServicioPacientes

    Private ReadOnly repositorioPacientes As IRepositorioPacientes

    Public Sub New(repositorioPacientes As IRepositorioPacientes)
        Me.repositorioPacientes = repositorioPacientes
    End Sub

    Public Sub AgregarPaciente(p As Paciente) Implements IServicioPacientes.AgregarPaciente
        Me.repositorioPacientes.Insertar(p)
    End Sub

    Public Sub ModificarPaciente(p As Paciente) Implements IServicioPacientes.ModificarPaciente
        Me.repositorioPacientes.Actualizar(p)
    End Sub

    Public Sub EliminarPaciente(p As Paciente) Implements IServicioPacientes.EliminarPaciente
        Me.repositorioPacientes.Eliminar(p)
    End Sub

    Public Function EncontarPacientePorDni(dni As String) As Paciente Implements IServicioPacientes.EncontarPacientePorDni
        Return Me.repositorioPacientes.EncontrarPorDni(dni)
    End Function
End Class
