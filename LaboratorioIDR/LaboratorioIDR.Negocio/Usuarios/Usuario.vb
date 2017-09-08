Public Class Usuario

    Sub New(usuario As String)
        Me.Usuario = usuario
    End Sub

    Public ReadOnly Property Usuario As String
    Public Property Contraseña As String

    Friend Function PuedeLogear(clave As String) As Boolean
        Return Contraseña = clave
    End Function
End Class
