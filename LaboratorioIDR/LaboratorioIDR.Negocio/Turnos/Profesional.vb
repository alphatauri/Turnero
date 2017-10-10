Public Class Profesional
    Public Property Dni As Decimal
    Public Property Apellido As String
    Public Property Nombre As String
    Public Property Ingreso As Date

    Public ReadOnly Property NombreCompleto As String
        Get
            Return Apellido + ", " + Nombre
        End Get
    End Property
End Class
