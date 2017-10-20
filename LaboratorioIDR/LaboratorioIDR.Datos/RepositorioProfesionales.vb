Imports LaboratorioIDR.Negocio

Public Class RepositorioProfesionales : Implements IRepositorioProfesionales

    Public Function Listar() As List(Of Profesional) Implements IRepositorioProfesionales.Listar
        Dim lista = New List(Of Profesional)
        Using con = Conexion.GetConnection()
            Using qr = con.CreateCommand
                qr.CommandType = CommandType.Text
                qr.CommandText = "SELECT [DniProf],[ApeProf],[NomProf],[FecIngProf],[CarTelProf],[ProvinciaProf],[DepartamentoProf],[LocalidadProf],[TelProf] FROM [dbo].[Profesionales]"

                Try
                    con.Open()
                    Dim reader = qr.ExecuteReader()
                    While (reader.HasRows AndAlso reader.Read())
                        lista.Add(New Profesional With {
                            .Dni = Int(reader.GetDecimal(0)),
                            .Apellido = reader.GetString(1),
                            .Nombre = reader.GetString(2),
                            .Ingreso = reader.GetDateTime(3)
                        })
                    End While
                Catch ex As Exception
                    Throw New ProblemaTecnicoException("Ha ocurrido un error al actualizar un paciente", ex)
                End Try
            End Using
        End Using
        Return lista
    End Function

    Public Function ObtenerAgenda(dni As Decimal, fecha As Date) As List(Of AgendaProfesional) Implements IRepositorioProfesionales.ObtenerAgenda
        Using con = Conexion.GetConnection()
            Using qr = con.CreateCommand
                qr.CommandType = CommandType.Text
                qr.CommandText = "declare @diaSemana int = DatePart(weekday, @fecha); select * from agenda where DniProfPlan = @dni and ((@diaSemana = 2 and Lunes = 1) or  (@diaSemana = 3 and Martes = 1) or  (@diaSemana = 4 and Miercoles = 1) or  (@diaSemana = 5 and Jueves = 1) or  (@diaSemana = 6 and Viernes = 1))"
                qr.Parameters.Add(New SqlClient.SqlParameter("@dni", dni))
                qr.Parameters.Add(New SqlClient.SqlParameter("@fecha", fecha))

                Dim lista As List(Of AgendaProfesional) = Nothing

                Try
                    con.Open()
                    lista = New List(Of AgendaProfesional)
                    Dim reader = qr.ExecuteReader()
                    While (reader.HasRows AndAlso reader.Read())
                        lista.Add(New AgendaProfesional With {
                            .Id = reader.GetInt32(0),
                            .Dni = reader.GetDecimal(1),
                            .Consultorio = reader.GetString(2),
                            .FechaDesde = reader.GetDateTime(3),
                            .FechaHasta = reader.GetDateTime(4),
                            .HoraDesde = DateTime.Today.Add(reader.GetTimeSpan(5)),
                            .HoraHasta = DateTime.Today.Add(reader.GetTimeSpan(6)),
                            .Slot = reader.GetDecimal(7),
                            .Lunes = If(reader.IsDBNull(8), Nothing, reader.GetBoolean(8)),
                            .Martes = If(reader.IsDBNull(9), Nothing, reader.GetBoolean(9)),
                            .Miercoles = If(reader.IsDBNull(10), Nothing, reader.GetBoolean(10)),
                            .Jueves = If(reader.IsDBNull(11), Nothing, reader.GetBoolean(11)),
                            .Viernes = If(reader.IsDBNull(12), Nothing, reader.GetBoolean(12))
                        })
                    End While
                Catch ex As Exception
                    Throw New ProblemaTecnicoException("Ha ocurrido un error al actualizar un paciente", ex)
                End Try
                Return lista
            End Using
        End Using
    End Function
End Class
