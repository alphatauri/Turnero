Imports LaboratorioIDR.Negocio

Public Class ServicioTurnos : Implements IServicioTurnos

    Private ReadOnly repositorioTurnos As IRepositorioTurnos
    Private ReadOnly repositorioProfesionales As IRepositorioProfesionales

    Public Sub New(repositorioTurnos As IRepositorioTurnos, repositorioProfesionales As IRepositorioProfesionales)
        Me.repositorioTurnos = repositorioTurnos
        Me.repositorioProfesionales = repositorioProfesionales
    End Sub

    Public Function ListarProfesionales() As List(Of Profesional) Implements IServicioTurnos.ListarProfesionales
        Return repositorioProfesionales.Listar()
    End Function

    Public Function ObtenerAgenda(profesional As Profesional, fecha As Date) As List(Of Turno) Implements IServicioTurnos.ObtenerAgenda
        'Dim registroAgenda = repositorioProfesionales.ObtenerAgenda(profesional.Dni, fecha)
        Return GenerarRegistrosAgenda()
    End Function

    Private Function GenerarRegistrosAgenda() As List(Of Turno)
        Dim lista = New List(Of Turno) From {
            New Turno("08:00", "Libre", Nothing),
            New Turno("08:15", "Libre", Nothing),
            New Turno("08:30", "Libre", Nothing),
            New Turno("08:45", "Libre", Nothing),
            New Turno("09:00", "Libre", Nothing),
            New Turno("09:15", "Libre", Nothing),
            New Turno("09:30", "Libre", Nothing),
            New Turno("09:45", "Libre", Nothing),
            New Turno("10:00", "Libre", Nothing),
            New Turno("10:15", "Libre", Nothing),
            New Turno("10:30", "Libre", Nothing),
            New Turno("10:45", "Libre", Nothing),
            New Turno("11:00", "Libre", Nothing),
            New Turno("11:15", "Libre", Nothing),
            New Turno("11:30", "Libre", Nothing),
            New Turno("11:45", "Libre", Nothing),
            New Turno("12:00", "Libre", Nothing),
            New Turno("12:15", "Libre", Nothing),
            New Turno("12:30", "Libre", Nothing),
            New Turno("12:45", "Libre", Nothing),
            New Turno("13:00", "Libre", Nothing),
            New Turno("13:15", "Libre", Nothing),
            New Turno("13:30", "Libre", Nothing),
            New Turno("13:45", "Libre", Nothing),
            New Turno("14:00", "Libre", Nothing),
            New Turno("14:15", "Libre", Nothing),
            New Turno("14:30", "Libre", Nothing),
            New Turno("14:45", "Libre", Nothing)
        }
        Return lista
    End Function
End Class
