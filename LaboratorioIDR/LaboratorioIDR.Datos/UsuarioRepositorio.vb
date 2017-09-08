Imports LaboratorioIDR.Negocio

Public Class UsuarioRepositorio : Implements IRepositorioUsuario

    Public Function GetUsuarioByUserName(usuario As String) As Usuario Implements IRepositorioUsuario.GetUsuarioByUserName
        Dim user As Usuario = Nothing
        Using con = Conexion.GetConnection()
            Using qr = con.CreateCommand
                qr.CommandType = CommandType.Text
                qr.CommandText = "select * from login where usuario = @usuario"
                qr.Parameters.Add(New SqlClient.SqlParameter("@usuario", usuario))
                Try
                    con.Open()
                    Dim reader = qr.ExecuteReader()
                    If reader.HasRows AndAlso reader.Read() Then
                        user = New Usuario(reader.GetString(1)) With {
                            .Contraseña = reader.GetString(2)
                        }
                    End If
                Catch ex As Exception
                    Throw New ProblemaTecnicoException("Ha ocurrido un error al buscar un usuario", ex)
                End Try
            End Using
        End Using
        Return user
    End Function
End Class
