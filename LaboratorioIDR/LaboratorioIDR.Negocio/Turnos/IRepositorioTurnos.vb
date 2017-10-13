Public Interface IRepositorioTurnos
    Function ObtenerTurnos(dni As Decimal, fecha As Date) As List(Of TurnoAsignado)
End Interface
