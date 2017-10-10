Public Class Turno
    Public ReadOnly Property Hora As String
    Public ReadOnly Property PacienteNombre As String
    Public ReadOnly Property PacienteDni As String

    Public Sub New(hora As String, nombre As String, dni As String)
        Me.Hora = hora
        Me.PacienteNombre = nombre
        Me.PacienteDni = dni
    End Sub
End Class
