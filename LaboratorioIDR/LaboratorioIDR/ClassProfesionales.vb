Public Class ClassProfesionales
    Private _DNIProf As String
    Public Property DNIProf() As String
        Get
            Return _DNIProf
        End Get
        Set(value As String)
            _DNIProf = value
        End Set
    End Property
    Private _NomProf As String
    Public Property NomProf() As String
        Get
            Return _NomProf
        End Get
        Set(value As String)
            _NomProf = value
        End Set
    End Property
    Private _ApeProf As String
    Public Property ApeProf() As String
        Get
            Return _ApeProf
        End Get
        Set(value As String)
            _ApeProf = value
        End Set
    End Property
    Private _FecIngProf As Date
    Public Property FecIngProf() As Date
        Get
            Return _FecIngProf
        End Get
        Set(value As Date)
            _FecIngProf = value
        End Set
    End Property
    Private _PrefijoProf As String
    Public Property PrefijoProf() As String
        Get
            Return _PrefijoProf
        End Get
        Set(value As String)
            _PrefijoProf = value
        End Set
    End Property
    Private _TelProf As String
    Public Property TelProf() As String
        Get
            Return _TelProf
        End Get
        Set(value As String)
            _TelProf = value
        End Set
    End Property
End Class
