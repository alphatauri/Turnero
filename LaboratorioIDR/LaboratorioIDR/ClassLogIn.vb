Public Class ClassLogIn
    Private _Usuario As String
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            _Usuario = value
        End Set
    End Property
    Private _Contrasena As String
    Public Property Contrasena() As String
        Get
            Return _Contrasena
        End Get
        Set(value As String)
            _Contrasena = value
        End Set
    End Property
End Class
