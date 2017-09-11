Public Class ServicioPacientes : Implements IServicioPacientes

    Private ReadOnly repositorioPacientes As IRepositorioPacientes

    Public Sub New(repositorioPacientes As IRepositorioPacientes)
        Me.repositorioPacientes = repositorioPacientes
    End Sub

    Public Function EncontarPacientePorDni(dni As String) As Paciente Implements IServicioPacientes.EncontarPacientePorDni
        Throw New NotImplementedException()
    End Function
End Class
