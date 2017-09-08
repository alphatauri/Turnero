Public Class ServicioLogin
    Private repositorioUsuario As IRepositorioUsuario

    Sub New(repositorioUsuario As IRepositorioUsuario)
        Me.repositorioUsuario = repositorioUsuario
    End Sub

    Public Function EsUsuarioValido(usuario As String, clave As String) As Boolean
        Dim user = repositorioUsuario.GetUsuarioByUserName(usuario)
        Return user.PuedeLogear(clave)
    End Function
End Class
