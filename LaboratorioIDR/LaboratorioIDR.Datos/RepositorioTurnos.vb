Imports System.Data.SqlClient
Imports System.Globalization
Imports LaboratorioIDR.Negocio

Public Class RepositorioTurnos : Implements IRepositorioTurnos

    Public Function Asignar(dni As Decimal, dniProfesional As Decimal, fechaTurno As Date, hora As String, consultorio As String) As TurnoAsignado Implements IRepositorioTurnos.Asignar
        Dim turnoAsignado As TurnoAsignado = Nothing
        Dim horaTurno As DateTime = DateTime.ParseExact(DateTime.Today.ToString("dd/MM/yyyy") & " " & hora, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
        Using con = Conexion.GetConnection()
            Using qr = con.CreateCommand
                qr.CommandType = CommandType.Text
                qr.CommandText = "insert into Horarios(DniPacAgenda, DniProfAgenda, FechaTurno, HoraTurno, Consultorio) values (@dniPaciente, @dniProfesional, @Fecha, @Hora, @Consultorio)"
                qr.Parameters.Add(New SqlParameter("@dniPaciente", dni))
                qr.Parameters.Add(New SqlParameter("@dniProfesional", dniProfesional))
                qr.Parameters.Add(New SqlParameter("@fecha", fechaTurno))
                qr.Parameters.Add(New SqlParameter("@hora", horaTurno.ToString("HH:mm")))
                qr.Parameters.Add(New SqlParameter("@Consultorio", consultorio))
                Try
                    con.Open()
                    Dim reader = qr.ExecuteNonQuery()
                    turnoAsignado = ObtenerTurno(dni, dniProfesional, fechaTurno, horaTurno)
                Catch ex As Exception
                    Throw New ProblemaTecnicoException("Ha ocurrido un error al obtener los turnos", ex)
                End Try
            End Using
        End Using
        Return turnoAsignado
    End Function

    Private Function ObtenerTurno(dni As Decimal, dniProfesional As Decimal, fechaTurno As Date, horaTurno As Date) As TurnoAsignado
        Dim turnoAsignado As TurnoAsignado = Nothing
        Using con = Conexion.GetConnection()
            Using qr = con.CreateCommand
                qr.CommandType = CommandType.Text
                qr.CommandText = "select h.DniPacAgenda, h.HoraTurno, p.ApePac+', '+p.NomPac, IdTurno from Horarios h join Pacientes p on p.DniPac = h.DNIPacAgenda where h.DNIProfAgenda = @dniProf and h.FechaTurno = @Fecha and h.HoraTurno = @HoraTurno and h.DNIPacAgenda = @dniPac "
                qr.Parameters.Add(New SqlParameter("@dniProf", dniProfesional))
                qr.Parameters.Add(New SqlParameter("@Fecha", fechaTurno))
                qr.Parameters.Add(New SqlParameter("@HoraTurno", horaTurno.ToString("HH:mm")))
                qr.Parameters.Add(New SqlParameter("@dniPac", dni))
                Try
                    con.Open()
                    Dim reader = qr.ExecuteReader()
                    If reader.HasRows AndAlso reader.Read() Then
                        turnoAsignado = New TurnoAsignado With {
                            .Dni = Int(reader.GetDecimal(0)),
                            .Hora = reader.GetTimeSpan(1).ToString("hh\:mm"),
                            .Paciente = reader.GetString(2),
                            .Id = reader.GetInt32(3)
                        }
                    End If
                Catch ex As Exception
                    Throw New ProblemaTecnicoException("Ha ocurrido un error al obtener los turnos", ex)
                End Try
            End Using
        End Using
        Return turnoAsignado
    End Function

    Public Function ObtenerTurnos(dni As Decimal, fecha As Date) As List(Of TurnoAsignado) Implements IRepositorioTurnos.ObtenerTurnos
        Dim lista = New List(Of TurnoAsignado)
        Using con = Conexion.GetConnection()
            Using qr = con.CreateCommand
                qr.CommandType = CommandType.Text
                qr.CommandText = "select h.DniPacAgenda, h.HoraTurno, p.ApePac+', '+p.NomPac, IdTurno from Horarios h join Pacientes p on p.DniPac = h.DNIPacAgenda where h.DNIProfAgenda = @dniProf and h.FechaTurno = @Fecha "
                qr.Parameters.Add(New SqlParameter("@dniProf", dni))
                qr.Parameters.Add(New SqlParameter("@Fecha", fecha))
                Try
                    con.Open()
                    Dim reader = qr.ExecuteReader()
                    While (reader.HasRows AndAlso reader.Read())
                        lista.Add(New TurnoAsignado With {
                            .Dni = Int(reader.GetDecimal(0)),
                            .Hora = reader.GetTimeSpan(1).ToString("hh\:mm"),
                            .Paciente = reader.GetString(2),
                            .Id = reader.GetInt32(3)
                        })
                    End While
                Catch ex As Exception
                    Throw New ProblemaTecnicoException("Ha ocurrido un error al obtener los turnos", ex)
                End Try
            End Using
        End Using
        Return lista
    End Function
End Class
