Public Interface IRepositorioTurnos
    Function ObtenerTurnos(dni As Decimal, fecha As Date) As List(Of TurnoAsignado)
    Function Asignar(dni As Decimal, dniProfesional As Decimal, fechaTurno As Date, hora As String, consultorio As String) As TurnoAsignado
    Sub Liberar(id As Integer)
End Interface
