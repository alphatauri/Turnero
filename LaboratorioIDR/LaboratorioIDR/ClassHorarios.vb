Public Class ClassHorarios
    Private _DNIProf As Integer
    Public Property DNIProf() As Integer
        Get
            Return _DNIProf
        End Get
        Set(value As Integer)
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
    Private _Consultorio As String
    Public Property Consultorio() As String
        Get
            Return _Consultorio
        End Get
        Set(value As String)
            _Consultorio = value
        End Set
    End Property
    Private _FecDsd As Date
    Public Property FecDsd() As Date
        Get
            Return _FecDsd
        End Get
        Set(value As Date)
            _FecDsd = value
        End Set
    End Property
    Private _FecHst As Date
    Public Property FecHst() As Date
        Get
            Return _FecHst
        End Get
        Set(value As Date)
            _FecHst = value
        End Set
    End Property
    Private _HoraDsd As Date
    Public Property HoraDsd() As Date
        Get
            Return _HoraDsd
        End Get
        Set(value As Date)
            _HoraDsd = value
        End Set
    End Property
    Private _HoraHst As Date
    Public Property HoraHst() As Date
        Get
            Return _HoraHst
        End Get
        Set(value As Date)
            _HoraHst = value
        End Set
    End Property
    Private _Slot As Integer
    Public Property Slot() As Integer
        Get
            Return _Slot
        End Get
        Set(value As Integer)
            _Slot = value
        End Set
    End Property
    Private _Lunes As Boolean
    Public Property Lunes() As Boolean
        Get
            Return _Lunes
        End Get
        Set(value As Boolean)
            _Lunes = value
        End Set
    End Property
    Private _Martes As Boolean
    Public Property Martes() As Boolean
        Get
            Return _Martes
        End Get
        Set(value As Boolean)
            _Martes = value
        End Set
    End Property
    Private _Miercoles As Boolean
    Public Property Miercoles() As Boolean
        Get
            Return _Miercoles
        End Get
        Set(value As Boolean)
            _Miercoles = value
        End Set
    End Property
    Private _Jueves As Boolean
    Public Property Jueves() As Boolean
        Get
            Return _Jueves
        End Get
        Set(value As Boolean)
            _Jueves = value
        End Set
    End Property
    Private _Viernes As Boolean
    Public Property Viernes() As Boolean
        Get
            Return _Viernes
        End Get
        Set(value As Boolean)
            _Viernes = value
        End Set
    End Property
End Class
