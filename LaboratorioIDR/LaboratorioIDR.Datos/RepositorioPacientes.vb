Imports LaboratorioIDR.Negocio

Public Class RepositorioPacientes : Implements IRepositorioPacientes

    Public Sub Insertar(p As Paciente) Implements IRepositorioPacientes.Insertar
        Using con = Conexion.GetConnection()
            Using qr = con.CreateCommand
                qr.CommandType = CommandType.Text
                qr.CommandText = "insert into Pacientes(DNIPac, NomPac, ApePac, FecNacPac, CallePac, AlturaPac, GeneroPac, CiudadPac, CarTelPac, TelPac) values (@dni, @nombre, @apellido, @nacimiento, @calle, @altura, @genero, @ciudad, @caracteristicaTelefonica, @telefono)"
                qr.Parameters.Add(New SqlClient.SqlParameter("@dni", p.Dni))
                qr.Parameters.Add(New SqlClient.SqlParameter("@nombre", p.Nombre))
                qr.Parameters.Add(New SqlClient.SqlParameter("@apellido", p.Apellido))
                qr.Parameters.Add(New SqlClient.SqlParameter("@nacimiento", p.Nacimiento))
                qr.Parameters.Add(New SqlClient.SqlParameter("@calle", p.DomicilioCalle))
                qr.Parameters.Add(New SqlClient.SqlParameter("@altura", p.DomicilioNumero))
                qr.Parameters.Add(New SqlClient.SqlParameter("@genero", p.Genero))
                qr.Parameters.Add(New SqlClient.SqlParameter("@ciudad", p.DomicilioCiudad))
                qr.Parameters.Add(New SqlClient.SqlParameter("@caracteristicaTelefonica", p.TelefonoPrefijo))
                qr.Parameters.Add(New SqlClient.SqlParameter("@telefono", p.TelefonoNumero))
                Try
                    con.Open()
                    qr.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New ProblemaTecnicoException("Ha ocurrido un error al insertar un paciente", ex)
                End Try
            End Using
        End Using
    End Sub

    Public Sub Actualizar(p As Paciente) Implements IRepositorioPacientes.Actualizar
        Using con = Conexion.GetConnection()
            Using qr = con.CreateCommand
                qr.CommandType = CommandType.Text
                qr.CommandText = "update Pacientes set NomPac = @nombre, ApePac = @apellido, FecNacPac = @nacimiento, CallePac = @calle, AlturaPac = @altura, GeneroPac = @genero, CiudadPac = @ciudad, CarTelPac = @caracteristicaTelefonica, TelPac =  @telefono where DNIPac = @dni"
                qr.Parameters.Add(New SqlClient.SqlParameter("@dni", p.Dni))
                qr.Parameters.Add(New SqlClient.SqlParameter("@nombre", p.Nombre))
                qr.Parameters.Add(New SqlClient.SqlParameter("@apellido", p.Apellido))
                qr.Parameters.Add(New SqlClient.SqlParameter("@nacimiento", p.Nacimiento))
                qr.Parameters.Add(New SqlClient.SqlParameter("@calle", p.DomicilioCalle))
                qr.Parameters.Add(New SqlClient.SqlParameter("@altura", p.DomicilioNumero))
                qr.Parameters.Add(New SqlClient.SqlParameter("@genero", p.Genero))
                qr.Parameters.Add(New SqlClient.SqlParameter("@ciudad", p.DomicilioCiudad))
                qr.Parameters.Add(New SqlClient.SqlParameter("@caracteristicaTelefonica", p.TelefonoPrefijo))
                qr.Parameters.Add(New SqlClient.SqlParameter("@telefono", p.TelefonoNumero))
                Try
                    con.Open()
                    qr.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New ProblemaTecnicoException("Ha ocurrido un error al actualizar un paciente", ex)
                End Try
            End Using
        End Using
    End Sub

    Public Sub Eliminar(p As Paciente) Implements IRepositorioPacientes.Eliminar
        Using con = Conexion.GetConnection()
            Using qr = con.CreateCommand
                qr.CommandType = CommandType.Text
                qr.CommandText = "delete from Pacientes where DNIPac = @dni"
                qr.Parameters.Add(New SqlClient.SqlParameter("@dni", p.Dni))
                Try
                    con.Open()
                    qr.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New ProblemaTecnicoException("Ha ocurrido un error al eliminar un paciente", ex)
                End Try
            End Using
        End Using
    End Sub

    Public Function EncontrarPorDni(dni As String) As Paciente Implements IRepositorioPacientes.EncontrarPorDni
        Dim paciente As Paciente = Nothing
        Using con = Conexion.GetConnection()
            Using qr = con.CreateCommand
                qr.CommandType = CommandType.Text
                qr.CommandText = "select DNIPac, NomPac, ApePac, FecNacPac, CallePac, AlturaPac, GeneroPac, CiudadPac, CarTelPac, TelPac from Pacientes where dniPac = @dni"
                qr.Parameters.Add(New SqlClient.SqlParameter("@dni", dni))
                Try
                    con.Open()
                    Dim reader = qr.ExecuteReader()
                    If (reader.HasRows AndAlso reader.Read()) Then
                        paciente = New Paciente With {
                            .Dni = Int(reader.GetDecimal(0)),
                            .Nombre = reader.GetString(1),
                            .Apellido = reader.GetString(2),
                            .Nacimiento = reader.GetDateTime(3),
                            .DomicilioCalle = reader.GetString(4),
                            .DomicilioNumero = Int(reader.GetDecimal(5)),
                            .Genero = reader.GetString(6),
                            .DomicilioCiudad = If(reader.IsDBNull(7), Nothing, reader.GetString(7)),
                            .TelefonoPrefijo = Int(reader.GetDecimal(8)),
                            .TelefonoNumero = Int(reader.GetDecimal(9))
                        }
                    End If
                Catch ex As Exception
                    Throw New ProblemaTecnicoException("Ha ocurrido un error al actualizar un paciente", ex)
                End Try
            End Using
        End Using
        Return paciente
    End Function

    Public Function ListarPacientes() As Object Implements IRepositorioPacientes.ListarPacientes
        Dim lista = New List(Of Paciente)
        Using con = Conexion.GetConnection()
            Using qr = con.CreateCommand
                qr.CommandType = CommandType.Text
                qr.CommandText = "select DNIPac, NomPac, ApePac, FecNacPac, CallePac, AlturaPac, GeneroPac, CiudadPac, CarTelPac, TelPac from Pacientes"
                Try
                    con.Open()
                    Dim reader = qr.ExecuteReader()
                    While (reader.HasRows AndAlso reader.Read())
                        lista.Add(New Paciente With {
                            .Dni = Int(reader.GetDecimal(0)),
                            .Nombre = reader.GetString(1),
                            .Apellido = reader.GetString(2),
                            .Nacimiento = reader.GetDateTime(3),
                            .DomicilioCalle = reader.GetString(4),
                            .DomicilioNumero = Int(reader.GetDecimal(5)),
                            .Genero = reader.GetString(6),
                            .DomicilioCiudad = If(reader.IsDBNull(7), Nothing, reader.GetString(7)),
                            .TelefonoPrefijo = Int(reader.GetDecimal(8)),
                            .TelefonoNumero = Int(reader.GetDecimal(9))
                        })
                    End While
                Catch ex As Exception
                    Throw New ProblemaTecnicoException("Ha ocurrido un error al actualizar un paciente", ex)
                End Try
            End Using
        End Using
        Return lista
    End Function
End Class
