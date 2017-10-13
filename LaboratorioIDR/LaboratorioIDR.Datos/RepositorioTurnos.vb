Imports System.Data.SqlClient
Imports LaboratorioIDR.Negocio

Public Class RepositorioTurnos : Implements IRepositorioTurnos

    Public Function ObtenerTurnos(dni As Decimal, fecha As Date) As List(Of TurnoAsignado) Implements IRepositorioTurnos.ObtenerTurnos
        Dim lista = New List(Of TurnoAsignado)
        Using con = Conexion.GetConnection()
            Using qr = con.CreateCommand
                qr.CommandType = CommandType.Text
                qr.CommandText = "select h.DniPacAgenda, h.HoraTurno, p.ApePac+', '+p.NomPac from Horarios h join Pacientes p on p.DniPac = h.DNIPacAgenda where h.DNIProfAgenda = @dniProf and h.FechaTurno = @Fecha "
                qr.Parameters.Add(New SqlParameter("@dniProf", dni))
                qr.Parameters.Add(New SqlParameter("@Fecha", fecha))
                Try
                    con.Open()
                    Dim reader = qr.ExecuteReader()
                    While (reader.HasRows AndAlso reader.Read())
                        lista.Add(New TurnoAsignado With {
                            .Dni = Int(reader.GetDecimal(0)),
                            .Hora = reader.GetDateTime(1).ToString("HH:mm"),
                            .Paciente = reader.GetString(2)
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
