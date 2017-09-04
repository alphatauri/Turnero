Public Class ClassPacientes
    Private _DNIPac As String
    Public Property DNIPac() As String
        Get
            Return _DNIPac
        End Get
        Set(value As String)
            _DNIPac = value
        End Set
    End Property
    Private _NomPac As String
    Public Property NomPac() As String
        Get
            Return _NomPac
        End Get
        Set(value As String)
            _NomPac = value
        End Set
    End Property
    Private _ApePac As String
    Public Property ApePac() As String
        Get
            Return _ApePac
        End Get
        Set(value As String)
            _ApePac = value
        End Set
    End Property
    Private _FecNacPac As Date
    Public Property FecNacPac() As Date
        Get
            Return _FecNacPac
        End Get
        Set(value As Date)
            _FecNacPac = value
        End Set
    End Property
    Private _GeneroPac As String
    Public Property GeneroPac() As String
        Get
            Return _GeneroPac
        End Get
        Set(value As String)
            _GeneroPac = value
        End Set
    End Property
    Private _CallePac As String
    Public Property CallePac() As String
        Get
            Return _CallePac
        End Get
        Set(value As String)
            _CallePac = value
        End Set
    End Property
    Private _AlturaPac As String
    Public Property AlturaPac() As String
        Get
            Return _AlturaPac
        End Get
        Set(value As String)
            _AlturaPac = value
        End Set
    End Property
    Private _CiudadPac As String
    Public Property CiudadPac() As String
        Get
            Return _CiudadPac
        End Get
        Set(value As String)
            _CiudadPac = value
        End Set
    End Property
    Private _PreFijoPac As String
    Public Property PreFijoPac() As String
        Get
            Return _PreFijoPac
        End Get
        Set(value As String)
            _PreFijoPac = value
        End Set
    End Property
    Private _TelPac As String
    Public Property TelPac() As String
        Get
            Return _TelPac
        End Get
        Set(value As String)
            _TelPac = value
        End Set
    End Property
End Class
