﻿Public Class Turno
    Private HoraAux As String
    Public Property Hora() As String
        Get
            Return HoraAux
        End Get
        Friend Set(value As String)
            HoraAux = value
        End Set
    End Property

    Private PacienteNombreAux As String

    Public Property PacienteNombre() As String
        Get
            Return PacienteNombreAux
        End Get
        Friend Set(ByVal value As String)
            PacienteNombreAux = value
        End Set
    End Property

    Private DniAux As String
    Public Property PacienteDni As String
        Get
            Return DniAux
        End Get
        Friend Set(value As String)
            DniAux = value
        End Set
    End Property

    Public Property Consultorio As String
    Public ReadOnly Property ProfesionalDni As Decimal
    Public ReadOnly Property FechaTurno As Date
    Public Property Id As Integer

    Public Sub New(hora As String, nombre As String, dni As String, consultorio As String, dniProfesional As Decimal, fecha As Date)
        Me.Hora = hora
        Me.PacienteNombre = nombre
        Me.PacienteDni = dni
        Me.Consultorio = consultorio
        Me.ProfesionalDni = dniProfesional
        Me.FechaTurno = fecha
    End Sub
End Class
