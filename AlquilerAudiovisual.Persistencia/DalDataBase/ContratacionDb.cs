using AlquilerAudiovisual.Entities.Clientes;
using AlquilerAudiovisual.Entities.Contrataciones;
using AlquilerAudiovisual.Entities.Enumerados;
using AlquilerAudiovisual.Entities.Equipamientos;
using AlquilerAudiovisual.Entities.Solicitudes;
using AlquilerAudiovisual.Persistencia.Interfaces;
using Microsoft.Data.SqlClient;

namespace AlquilerAudiovisual.Persistencia.DalDataBase
{
    public class ContratacionDb : IDalContratacion
    {
        public bool ActualizarContratacion(Contratacion contratacion)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Contratacion SET IdSolicitud = @IdSolicitud, Fecha = @Fecha, FechaInicioAlquiler = @FechaInicioAlquiler, FechaFinAlquiler = @FechaFinAlquiler, Estado = @Estado " +
                    "WHERE IdContratacion = @IdContratacion", connection);
                command.Parameters.AddWithValue("@IdContratacion", contratacion.IdContratacion);
                command.Parameters.AddWithValue("@IdSolicitud", contratacion.IdSolicitud);
                command.Parameters.AddWithValue("@Fecha", contratacion.Fecha.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@FechaInicioAlquiler", contratacion.FechaInicioAlquiler.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@FechaFinAlquiler", contratacion.FechaFinAlquiler.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@Estado", (int)contratacion.Estado);
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

        public bool ActualizarPreparacion(Preparacion preparacion)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Preparacion SET Fecha = @Fecha, Hora = @Hora, Observaciones = @Observaciones, IdContratacion = @IdContratacion, IdEstado = @IdEstado " +
                    "WHERE IdPreparacion = @IdPreparacion", connection);
                command.Parameters.AddWithValue("@IdPreparacion", preparacion.IdPreparacion);
                command.Parameters.AddWithValue("@Fecha", preparacion.Fecha.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@Hora", preparacion.Hora.ToTimeSpan());
                command.Parameters.AddWithValue("@Observaciones", (object?)preparacion.Observaciones ?? DBNull.Value);
                command.Parameters.AddWithValue("@IdContratacion", preparacion.Contratacion.IdContratacion);
                command.Parameters.AddWithValue("@IdEstado", (int)preparacion.Estado);
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

        public int AgregarContratacion(Contratacion contratacion)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Contratacion (IdSolicitud, Fecha, FechaInicioAlquiler, FechaFinAlquiler, Estado) " +
                    "VALUES(@IdSolicitud, @Fecha, @FechaInicioAlquiler, @FechaFinAlquiler, @Estado)", connection);
                command.Parameters.AddWithValue("@IdSolicitud", contratacion.IdSolicitud);
                command.Parameters.AddWithValue("@Fecha", contratacion.Fecha.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@FechaInicioAlquiler", contratacion.FechaInicioAlquiler.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@FechaFinAlquiler", contratacion.FechaFinAlquiler.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@Estado", (int)contratacion.Estado);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(IdContratacion) FROM Contratacion";
                int idContratacion = Convert.ToInt32(command.ExecuteScalar());
                return idContratacion;
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

        public int AgregarPreparacion(Preparacion preparacion)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Preparacion (Fecha, Hora, Observaciones, IdContratacion, IdEstado) " +
                    "VALUES (@Fecha, @Hora, @Observaciones, @IdContratacion, @IdEstado)", connection);
                command.Parameters.AddWithValue("@Fecha", preparacion.Fecha.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@Hora", preparacion.Hora.ToTimeSpan());
                command.Parameters.AddWithValue("@Observaciones", (object?)preparacion.Observaciones ?? DBNull.Value);
                command.Parameters.AddWithValue("@IdContratacion", preparacion.Contratacion.IdContratacion);
                command.Parameters.AddWithValue("@IdEstado", (int)preparacion.Estado);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(IdPreparacion) FROM Preparacion";
                int idPreparacion = Convert.ToInt32(command.ExecuteScalar());
                return idPreparacion;
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

        public int AgregarTarifa(Tarifa tarifa)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Tarifa (DiasContrato, FechaInicio, FechaFin, PrecioVigente, IdTipoEvento, IdTipoCliente, IdTipoEquipamiento) " +
                    "VALUES(@DiasContrato, @FechaInicio, @FechaFin, @PrecioVigente, @IdTipoEvento, @IdTipoCliente, @IdTipoEquipamiento)", connection);
                command.Parameters.AddWithValue("@DiasContrato", tarifa.DiasContrato);
                command.Parameters.AddWithValue("@FechaInicio", tarifa.FechaInicio.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@FechaFin", tarifa.FechaFin.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@PrecioVigente", tarifa.PrecioVigente);
                command.Parameters.AddWithValue("@IdTipoEvento", tarifa.TipoEvento.IdTipoEvento);
                command.Parameters.AddWithValue("@IdTipoCliente", tarifa.TipoCliente.IdTipoCliente);
                command.Parameters.AddWithValue("@IdTipoEquipamiento", tarifa.TipoEquipamiento.IdTipoEquipamiento);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(IdTarifa) FROM Tarifa";
                int idTarifa = Convert.ToInt32(command.ExecuteScalar());
                return idTarifa;
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

        public List<Contratacion> LeerContrataciones()
        {
            List<Contratacion> contrataciones = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT c.IdContratacion, c.IdSolicitud, c.Fecha, c.FechaInicioAlquiler, c.FechaFinAlquiler, c.Estado " +
                    "FROM Contratacion c", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Contratacion contratacion = new Contratacion
                    {
                        IdContratacion = reader.GetInt32(reader.GetOrdinal("IdContratacion")),
                        IdSolicitud = reader.GetInt32(reader.GetOrdinal("IdSolicitud")),
                        Fecha = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("Fecha"))),
                        FechaInicioAlquiler = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaInicioAlquiler"))),
                        FechaFinAlquiler = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaFinAlquiler"))),
                        Estado = (EstadoContratacion)reader.GetInt32(reader.GetOrdinal("Estado"))
                    };
                    contrataciones.Add(contratacion);
                }
                return contrataciones;
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
        public List<Preparacion> LeerPreparaciones()
        {
            List<Preparacion> preparaciones = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT p.IdPreparacion, p.Fecha AS FechaPreparacion, p.Hora, p.Observaciones, p.IdEstado AS EstadoPreparacion, " +
                    "c.IdContratacion, c.IdSolicitud, c.Fecha AS FechaContratacion, c.FechaInicioAlquiler, c.FechaFinAlquiler, c.Estado AS EstadoContratacion " +
                    "FROM Preparacion p " +
                    "INNER JOIN Contratacion c ON p.IdContratacion = c.IdContratacion", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Contratacion contratacion = new Contratacion
                    {
                        IdContratacion = reader.GetInt32(reader.GetOrdinal("IdContratacion")),
                        IdSolicitud = reader.GetInt32(reader.GetOrdinal("IdSolicitud")),
                        Fecha = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaContratacion"))),
                        FechaInicioAlquiler = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaInicioAlquiler"))),
                        FechaFinAlquiler = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaFinAlquiler"))),
                        Estado = (EstadoContratacion)reader.GetInt32(reader.GetOrdinal("EstadoContratacion"))
                    };

                    Preparacion preparacion = new Preparacion
                    {
                        IdPreparacion = reader.GetInt32(reader.GetOrdinal("IdPreparacion")),
                        Fecha = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaPreparacion"))),
                        Hora = TimeOnly.FromTimeSpan(reader.GetTimeSpan(reader.GetOrdinal("Hora"))),
                        Observaciones = reader.IsDBNull(reader.GetOrdinal("Observaciones")) ? null : reader.GetString(reader.GetOrdinal("Observaciones")),
                        Contratacion = contratacion,
                        Estado = (EstadoPreparacion)reader.GetInt32(reader.GetOrdinal("EstadoPreparacion"))
                    };
                    preparaciones.Add(preparacion);
                }
                return preparaciones;
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
        public List<Tarifa> LeerTarifas()
        {
            List<Tarifa> tarifas = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT t.IdTarifa, t.DiasContrato, t.FechaInicio, t.FechaFin, t.PrecioVigente, " +
                    "ev.IdTipoEvento, ev.Nombre AS NombreTipoEvento, " +
                    "tc.IdTipoCliente, tc.Nombre AS NombreTipoCliente, " +
                    "te.IdTipoEquipamiento, te.Nombre AS NombreTipoEquipamiento, te.Descripcion " +
                    "FROM Tarifa t " +
                    "INNER JOIN TipoEvento ev ON t.IdTipoEvento = ev.IdTipoEvento " +
                    "INNER JOIN TipoCliente tc ON t.IdTipoCliente = tc.IdTipoCliente " +
                    "INNER JOIN TipoEquipamiento te ON t.IdTipoEquipamiento = te.IdTipoEquipamiento", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoEvento tipoEvento = new TipoEvento
                    {
                        IdTipoEvento = reader.GetInt32(reader.GetOrdinal("IdTipoEvento")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreTipoEvento"))
                    };

                    TipoCliente tipoCliente = new TipoCliente
                    {
                        IdTipoCliente = reader.GetInt32(reader.GetOrdinal("IdTipoCliente")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreTipoCliente"))
                    };

                    TipoEquipamiento tipoEquipamiento = new TipoEquipamiento
                    {
                        IdTipoEquipamiento = reader.GetInt32(reader.GetOrdinal("IdTipoEquipamiento")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreTipoEquipamiento")),
                        Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString(reader.GetOrdinal("Descripcion"))
                    };

                    Tarifa tarifa = new Tarifa
                    {
                        IdTarifa = reader.GetInt32(reader.GetOrdinal("IdTarifa")),
                        DiasContrato = reader.GetInt32(reader.GetOrdinal("DiasContrato")),
                        FechaInicio = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaInicio"))),
                        FechaFin = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaFin"))),
                        PrecioVigente = reader.GetDecimal(reader.GetOrdinal("PrecioVigente")),
                        TipoEvento = tipoEvento,
                        TipoCliente = tipoCliente,
                        TipoEquipamiento = tipoEquipamiento
                    };
                    tarifas.Add(tarifa);
                }
                return tarifas;
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
        public Contratacion? ObtenerContratacionPorId(int idContratacion)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT c.IdContratacion, c.IdSolicitud, c.Fecha, c.FechaInicioAlquiler, c.FechaFinAlquiler, c.Estado " +
                    "FROM Contratacion c " +
                    "WHERE c.IdContratacion = @IdContratacion", connection);
                command.Parameters.AddWithValue("@IdContratacion", idContratacion);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Contratacion
                    {
                        IdContratacion = reader.GetInt32(reader.GetOrdinal("IdContratacion")),
                        IdSolicitud = reader.GetInt32(reader.GetOrdinal("IdSolicitud")),
                        Fecha = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("Fecha"))),
                        FechaInicioAlquiler = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaInicioAlquiler"))),
                        FechaFinAlquiler = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaFinAlquiler"))),
                        Estado = (EstadoContratacion)reader.GetInt32(reader.GetOrdinal("Estado"))
                    };
                }
                return null;
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
    }
}