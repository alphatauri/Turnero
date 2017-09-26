Public Class Paciente
    Public Property Apellido As String
    Public Property Nombre As String
    Public Property Nacimiento As Date
    Public Property Genero As String
    Public Property DomicilioCalle As String
    Public Property DomicilioNumero As Integer
    Public Property DomicilioCiudad As String
    Public Property TelefonoPrefijo As Integer
    Public Property TelefonoNumero As Integer
    Public Property Dni As Decimal

    Public ReadOnly Property NombreCompleto() As String
        Get
            Return Apellido + ", " + Nombre
        End Get
    End Property

    Public ReadOnly Property Edad As Integer
        Get
            Return DateTime.Today.Year - Nacimiento.Year - If(DateTime.Today.DayOfYear < Nacimiento.DayOfYear, 1, 0)
        End Get
    End Property
End Class
