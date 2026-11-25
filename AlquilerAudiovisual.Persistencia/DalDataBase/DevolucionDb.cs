using AlquilerAudiovisual.Entities.Contrataciones;
using AlquilerAudiovisual.Entities.Devoluciones;
using AlquilerAudiovisual.Entities.Enumerados;
using AlquilerAudiovisual.Entities.Equipamientos;
using AlquilerAudiovisual.Persistencia.Interfaces;
using Microsoft.Data.SqlClient;

namespace AlquilerAudiovisual.Persistencia.DalDataBase
{
    public class DevolucionDb : IDalDevolucion
    {
        public void AgregarDevolucion(Devolucion devolucion)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Devolucion(Fecha, Hora, Lugar, IdContratacion) " +
                    "VALUES(@Fecha, @Hora, @Lugar, @IdContratacion)", connection);
                command.Parameters.AddWithValue("@Fecha", devolucion.Fecha.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@Hora", devolucion.Hora.ToTimeSpan());
                command.Parameters.AddWithValue("@Lugar", (object?)devolucion.Lugar ?? DBNull.Value);
                command.Parameters.AddWithValue("@IdContratacion", devolucion.Contratacion.IdContratacion);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(IdDevolucion) FROM Devolucion";
                int idDevolucion = Convert.ToInt32(command.ExecuteScalar());

                foreach (VerificacionEquipo verificacion in devolucion.Verificaciones)
                {
                    SqlCommand commandVerificacion = new SqlCommand("INSERT INTO VerificacionEquipo(Observaciones, Cantidad, IdEstado, IdEquipo, IdDevolucion) " +
                        "VALUES(@Observaciones, @Cantidad, @IdEstado, @IdEquipo, @IdDevolucion)", connection);
                    commandVerificacion.Parameters.AddWithValue("@Observaciones", verificacion.Observaciones);
                    commandVerificacion.Parameters.AddWithValue("@Cantidad", verificacion.Cantidad);
                    commandVerificacion.Parameters.AddWithValue("@IdEstado", (int)verificacion.Estado);
                    commandVerificacion.Parameters.AddWithValue("@IdEquipo", verificacion.Equipo.IdEquipo);
                    commandVerificacion.Parameters.AddWithValue("@IdDevolucion", idDevolucion);
                    commandVerificacion.ExecuteNonQuery();
                    commandVerificacion.CommandText = "SELECT MAX(IdVerificacion) FROM VerificacionEquipo";
                    int idVerificacion = Convert.ToInt32(commandVerificacion.ExecuteScalar());

                    foreach (TipoProblema problema in verificacion.Problemas)
                    {
                        SqlCommand commandProblema = new SqlCommand("INSERT INTO VerificacionProblema(IdVerificacion, IdTipoProblema) " +
                            "VALUES(@IdVerificacion, @IdTipoProblema)", connection);
                        commandProblema.Parameters.AddWithValue("@IdVerificacion", idVerificacion);
                        commandProblema.Parameters.AddWithValue("@IdTipoProblema", problema.IdTipoProblema);
                        commandProblema.ExecuteNonQuery();
                    }

                    foreach (ImporteAdicional importe in verificacion.ImportesAdicionales)
                    {
                        SqlCommand commandImporte = new SqlCommand("INSERT INTO ImporteAdicional(IdContratacion, IdVerificacion, Monto, Motivo, Fecha) " +
                            "VALUES(@IdContratacion, @IdVerificacion, @Monto, @Motivo, @Fecha)", connection);
                        commandImporte.Parameters.AddWithValue("@IdContratacion", devolucion.Contratacion.IdContratacion);
                        commandImporte.Parameters.AddWithValue("@IdVerificacion", idVerificacion);
                        commandImporte.Parameters.AddWithValue("@Monto", importe.Monto);
                        commandImporte.Parameters.AddWithValue("@Motivo", importe.Motivo);
                        commandImporte.Parameters.AddWithValue("@Fecha", importe.Fecha.ToDateTime(TimeOnly.MinValue));
                        commandImporte.ExecuteNonQuery();
                    }
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
        }

        public void AgregarTipoProblema(TipoProblema tipo)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO TipoProblema(Nombre, Descripcion) " +
                    "VALUES(@Nombre, @Descripcion)", connection);
                command.Parameters.AddWithValue("@Nombre", tipo.Nombre);
                command.Parameters.AddWithValue("@Descripcion", (object?)tipo.Descripcion ?? DBNull.Value);
                command.ExecuteNonQuery();
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

        public List<Devolucion> ListarDevoluciones()
        {
            List<Devolucion> devoluciones = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT d.IdDevolucion, d.Fecha AS FechaDevolucion, d.Hora, d.Lugar, " +
                    "c.IdContratacion, c.IdSolicitud, c.Fecha AS FechaContratacion, c.FechaInicioAlquiler, c.FechaFinAlquiler, c.Estado AS EstadoContratacion " +
                    "FROM Devolucion d " +
                    "INNER JOIN Contratacion c ON d.IdContratacion = c.IdContratacion", connection);
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

                    Devolucion devolucion = new Devolucion
                    {
                        IdDevolucion = reader.GetInt32(reader.GetOrdinal("IdDevolucion")),
                        Fecha = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaDevolucion"))),
                        Hora = TimeOnly.FromTimeSpan(reader.GetTimeSpan(reader.GetOrdinal("Hora"))),
                        Lugar = reader.IsDBNull(reader.GetOrdinal("Lugar")) ? null : reader.GetString(reader.GetOrdinal("Lugar")),
                        Contratacion = contratacion,
                        Verificaciones = ListarVerificaciones(reader.GetInt32(reader.GetOrdinal("IdDevolucion")))
                    };
                    devoluciones.Add(devolucion);
                }
                return devoluciones;
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

        private List<VerificacionEquipo> ListarVerificaciones(int idDevolucion)
        {
            List<VerificacionEquipo> verificaciones = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT v.IdVerificacion, v.Observaciones, v.Cantidad, v.IdEstado, v.IdEquipo " +
                    "FROM VerificacionEquipo v " +
                    "WHERE v.IdDevolucion = @IdDevolucion", connection);
                command.Parameters.AddWithValue("@IdDevolucion", idDevolucion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idVerificacion = reader.GetInt32(reader.GetOrdinal("IdVerificacion"));
                    EquipamientoDb equipamientoDb = new EquipamientoDb();
                    Equipo? equipo = equipamientoDb.ObtenerEquipoPorId(reader.GetInt32(reader.GetOrdinal("IdEquipo")));
                    if (equipo != null)
                    {
                        VerificacionEquipo verificacion = new VerificacionEquipo
                        {
                            IdVerificacion = idVerificacion,
                            Observaciones = reader.GetString(reader.GetOrdinal("Observaciones")),
                            Cantidad = reader.GetInt32(reader.GetOrdinal("Cantidad")),
                            Estado = (EstadoDevolucion)reader.GetInt32(reader.GetOrdinal("IdEstado")),
                            ImportesAdicionales = ListarImportesAdicionales(idVerificacion),
                            Problemas = ListarProblemas(idVerificacion),
                            Equipo = equipo
                        };
                        verificaciones.Add(verificacion);
                    }
                }
                return verificaciones;
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

        private List<TipoProblema> ListarProblemas(int idVerificacion)
        {
            List<TipoProblema> problemas = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT tp.IdTipoProblema, tp.Nombre, tp.Descripcion " +
                    "FROM VerificacionProblema vp " +
                    "INNER JOIN TipoProblema tp ON vp.IdTipoProblema = tp.IdTipoProblema " +
                    "WHERE vp.IdVerificacion = @IdVerificacion", connection);
                command.Parameters.AddWithValue("@IdVerificacion", idVerificacion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoProblema problema = new TipoProblema
                    {
                        IdTipoProblema = reader.GetInt32(reader.GetOrdinal("IdTipoProblema")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                        Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString(reader.GetOrdinal("Descripcion"))
                    };
                    problemas.Add(problema);
                }
                return problemas;
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

        private List<ImporteAdicional> ListarImportesAdicionales(int idVerificacion)
        {
            List<ImporteAdicional> importes = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT i.IdImporte, i.Monto, i.Motivo, i.Fecha " +
                    "FROM ImporteAdicional i " +
                    "WHERE i.IdVerificacion = @IdVerificacion", connection);
                command.Parameters.AddWithValue("@IdVerificacion", idVerificacion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ImporteAdicional importe = new ImporteAdicional
                    {
                        IdImporte = reader.GetInt32(reader.GetOrdinal("IdImporte")),
                        Monto = reader.GetDecimal(reader.GetOrdinal("Monto")),
                        Motivo = reader.GetString(reader.GetOrdinal("Motivo")),
                        Fecha = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("Fecha")))
                    };
                    importes.Add(importe);
                }
                return importes;
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

        public List<TipoProblema> ListarTiposProblemas()
        {
            List<TipoProblema> tiposProblemas = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT tp.IdTipoProblema, tp.Nombre, tp.Descripcion " +
                    "FROM TipoProblema tp", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoProblema tipoProblema = new TipoProblema
                    {
                        IdTipoProblema = reader.GetInt32(reader.GetOrdinal("IdTipoProblema")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                        Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString(reader.GetOrdinal("Descripcion"))
                    };
                    tiposProblemas.Add(tipoProblema);
                }
                return tiposProblemas;
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
