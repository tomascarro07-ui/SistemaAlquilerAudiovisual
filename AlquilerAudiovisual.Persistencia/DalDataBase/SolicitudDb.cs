using AlquilerAudiovisual.Entities.Clientes;
using AlquilerAudiovisual.Entities.Enumerados;
using AlquilerAudiovisual.Entities.Solicitudes;
using AlquilerAudiovisual.Persistencia.Interfaces;
using Microsoft.Data.SqlClient;

namespace AlquilerAudiovisual.Persistencia.DalDataBase
{
    public class SolicitudDb : IDalSolicitud
    {
        public bool ActualizarSolicitud(Solicitud solicitud)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Solicitud SET FechaSolicitud = @FechaSolicitud, Ubicacion = @Ubicacion, FechaInicio = @FechaInicio, " +
                    "FechaFin = @FechaFin, HoraInicio = @HoraInicio, HoraFin = @HoraFin, CantidadAsistentes = @CantidadAsistentes, IdEstado = @IdEstado, IdCliente = @IdCliente, " +
                    "IdTipoEvento = @IdTipoEvento WHERE IdSolicitud = @IdSolicitud", connection);
                command.Parameters.AddWithValue("@IdSolicitud", solicitud.IdSolicitud);
                command.Parameters.AddWithValue("@FechaSolicitud", solicitud.FechaSolicitud.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@Ubicacion", solicitud.Ubicacion);
                command.Parameters.AddWithValue("@FechaInicio", solicitud.FechaInicio.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@FechaFin", solicitud.FechaFin.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@HoraInicio", solicitud.HoraInicio.ToTimeSpan());
                command.Parameters.AddWithValue("@HoraFin", solicitud.HoraFin.ToTimeSpan());
                command.Parameters.AddWithValue("@CantidadAsistentes", solicitud.CantidadAsistentes);
                command.Parameters.AddWithValue("@IdEstado", (int)solicitud.Estado);
                command.Parameters.AddWithValue("@IdCliente", solicitud.Cliente.IdCliente);
                command.Parameters.AddWithValue("@IdTipoEvento", solicitud.TipoEvento.IdTipoEvento);
                int filasAfectadas = command.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectarse con la base de datos: {ex.Message}", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public int AgregarSolicitud(Solicitud solicitud)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Solicitud(FechaSolicitud, Ubicacion, FechaInicio, FechaFin, HoraInicio, HoraFin, CantidadAsistentes, IdEstado, IdCliente, IdTipoEvento) " +
                    "VALUES(@FechaSolicitud, @Ubicacion, @FechaInicio, @FechaFin, @HoraInicio, @HoraFin, @CantidadAsistentes, @IdEstado, @IdCliente, @IdTipoEvento)", connection);
                command.Parameters.AddWithValue("@FechaSolicitud", solicitud.FechaSolicitud.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@Ubicacion", solicitud.Ubicacion);
                command.Parameters.AddWithValue("@FechaInicio", solicitud.FechaInicio.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@FechaFin", solicitud.FechaFin.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@HoraInicio", solicitud.HoraInicio.ToTimeSpan());
                command.Parameters.AddWithValue("@HoraFin", solicitud.HoraFin.ToTimeSpan());
                command.Parameters.AddWithValue("@CantidadAsistentes", solicitud.CantidadAsistentes);
                command.Parameters.AddWithValue("@IdEstado", (int)solicitud.Estado);
                command.Parameters.AddWithValue("@IdCliente", solicitud.Cliente.IdCliente);
                command.Parameters.AddWithValue("@IdTipoEvento", solicitud.TipoEvento.IdTipoEvento);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(IdSolicitud) FROM Solicitud";
                int solicitudId = Convert.ToInt32(command.ExecuteScalar());
                return solicitudId;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectarse con la base de datos: {ex.Message}", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public int AgregarTipoEvento(TipoEvento tipo)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO TipoEvento(Nombre) " +
                    "VALUES(@Nombre)", connection);
                command.Parameters.AddWithValue("@Nombre", tipo.Nombre);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(IdTipoEvento) FROM TipoEvento";
                int tipoEventoId = Convert.ToInt32(command.ExecuteScalar());
                return tipoEventoId;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectarse con la base de datos: {ex.Message}", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public List<Solicitud> LeerSolicitudes()
        {
            List<Solicitud> solicitudes = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT s.IdSolicitud, s.FechaSolicitud, s.Ubicacion, s.FechaInicio, s.FechaFin, s.HoraInicio, s.HoraFin, s.CantidadAsistentes, s.IdEstado, " +
                    "c.IdCliente, c.Documento, c.Nombre AS NombreCliente, c.Telefono, c.Correo, c.Direccion, c.Activo, " +
                    "tc.IdTipoCliente, tc.Nombre AS NombreTipoCliente, " +
                    "te.IdTipoEvento, te.Nombre AS NombreTipoEvento " +
                    "FROM Solicitud s " +
                    "INNER JOIN Cliente c ON s.IdCliente = c.IdCliente " +
                    "INNER JOIN TipoCliente tc ON c.IdTipoCliente = tc.IdTipoCliente " +
                    "INNER JOIN TipoEvento te ON s.IdTipoEvento = te.IdTipoEvento", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idSolicitud = reader.GetInt32(reader.GetOrdinal("IdSolicitud"));
                    DateOnly fechaSolicitud = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaSolicitud")));
                    string ubicacion = reader.GetString(reader.GetOrdinal("Ubicacion"));
                    DateOnly fechaInicio = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaInicio")));
                    DateOnly fechaFin = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaFin")));
                    TimeOnly horaInicio = TimeOnly.FromTimeSpan(reader.GetTimeSpan(reader.GetOrdinal("HoraInicio")));
                    TimeOnly horaFin = TimeOnly.FromTimeSpan(reader.GetTimeSpan(reader.GetOrdinal("HoraFin")));
                    int cantidadAsistentes = reader.GetInt32(reader.GetOrdinal("CantidadAsistentes"));

                    TipoCliente tipoCliente = new TipoCliente
                    {
                        IdTipoCliente = reader.GetInt32(reader.GetOrdinal("IdTipoCliente")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreTipoCliente"))
                    };

                    Cliente cliente = new Cliente
                    (
                        reader.GetInt32(reader.GetOrdinal("IdCliente")),
                        reader.GetString(reader.GetOrdinal("Documento")),
                        reader.GetString(reader.GetOrdinal("NombreCliente")),
                        reader.GetString(reader.GetOrdinal("Telefono")),
                        reader.IsDBNull(reader.GetOrdinal("Correo")) ? null : reader.GetString(reader.GetOrdinal("Correo")),
                        reader.GetString(reader.GetOrdinal("Direccion")),
                        reader.GetBoolean(reader.GetOrdinal("Activo")),
                        tipoCliente
                    );

                    TipoEvento tipoEvento = new TipoEvento
                    {
                        IdTipoEvento = reader.GetInt32(reader.GetOrdinal("IdTipoEvento")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreTipoEvento"))
                    };

                    EstadoSolicitud estado = (EstadoSolicitud)reader.GetInt32(reader.GetOrdinal("IdEstado"));

                    Solicitud solicitud = new Solicitud(idSolicitud, fechaSolicitud, ubicacion, fechaInicio, fechaFin, horaInicio, horaFin, cantidadAsistentes, estado, cliente, tipoEvento);
                    solicitudes.Add(solicitud);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectarse con la base de datos: {ex.Message}", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return solicitudes;
        }

        public List<TipoEvento> LeerTiposEventos()
        {
            List<TipoEvento> tipos = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT t.IdTipoEvento, t.Nombre " +
                    "FROM TipoEvento t", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoEvento tipo = new TipoEvento
                    {
                        IdTipoEvento = reader.GetInt32(reader.GetOrdinal("IdTipoEvento")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
                    };
                    tipos.Add(tipo);
                }
                return tipos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectarse con la base de datos: {ex.Message}", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public Solicitud? ObtenerSolicitudPorId(int idSolicitud)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT s.IdSolicitud, s.FechaSolicitud, s.Ubicacion, s.FechaInicio, s.FechaFin, s.HoraInicio, s.HoraFin, s.CantidadAsistentes, s.IdEstado, " +
                    "c.IdCliente, c.Documento, c.Nombre AS NombreCliente, c.Telefono, c.Correo, c.Direccion, c.Activo, " +
                    "tc.IdTipoCliente, tc.Nombre AS NombreTipoCliente, " +
                    "te.IdTipoEvento, te.Nombre AS NombreTipoEvento " +
                    "FROM Solicitud s " +
                    "INNER JOIN Cliente c ON s.IdCliente = c.IdCliente " +
                    "INNER JOIN TipoCliente tc ON c.IdTipoCliente = tc.IdTipoCliente " +
                    "INNER JOIN TipoEvento te ON s.IdTipoEvento = te.IdTipoEvento " +
                    "WHERE s.IdSolicitud = @IdSolicitud", connection);
                command.Parameters.AddWithValue("@IdSolicitud", idSolicitud);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EstadoSolicitud estado = (EstadoSolicitud)reader.GetInt32(reader.GetOrdinal("IdEstado"));

                    TipoCliente tipo = new TipoCliente
                    {
                        IdTipoCliente = reader.GetInt32(reader.GetOrdinal("IdTipoCliente")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreTipoCliente"))
                    };

                    Cliente cliente = new Cliente
                    (
                        reader.GetInt32(reader.GetOrdinal("IdCliente")),
                        reader.GetString(reader.GetOrdinal("Documento")),
                        reader.GetString(reader.GetOrdinal("NombreCliente")),
                        reader.GetString(reader.GetOrdinal("Telefono")),
                        reader.IsDBNull(reader.GetOrdinal("Correo")) ? null : reader.GetString(reader.GetOrdinal("Correo")),
                        reader.GetString(reader.GetOrdinal("Direccion")),
                        reader.GetBoolean(reader.GetOrdinal("Activo")),
                        tipo
                    );

                    TipoEvento tipoEvento = new TipoEvento
                    {
                        IdTipoEvento = reader.GetInt32(reader.GetOrdinal("IdTipoEvento")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreTipoEvento"))
                    };

                    return new Solicitud
                    (
                        reader.GetInt32(reader.GetOrdinal("IdSolicitud")),
                        DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaSolicitud"))),
                        reader.GetString(reader.GetOrdinal("Ubicacion")),
                        DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaInicio"))),
                        DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaFin"))),
                        TimeOnly.FromTimeSpan(reader.GetTimeSpan(reader.GetOrdinal("HoraInicio"))),
                        TimeOnly.FromTimeSpan(reader.GetTimeSpan(reader.GetOrdinal("HoraFin"))),
                        reader.GetInt32(reader.GetOrdinal("CantidadAsistentes")),
                        estado,
                        cliente,
                        tipoEvento
                    );
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectarse con la base de datos: {ex.Message}", ex);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return null;
        }
    }
}
