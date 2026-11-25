using AlquilerAudiovisual.Entities.Contrataciones;
using AlquilerAudiovisual.Entities.Enumerados;
using AlquilerAudiovisual.Entities.Equipamientos;
using AlquilerAudiovisual.Persistencia.Interfaces;
using Microsoft.Data.SqlClient;

namespace AlquilerAudiovisual.Persistencia.DalDataBase
{
    public class EquipamientoDb : IDalEquipamiento
    {
        public bool ActualizarEquipoIdentificable(EquipoIdentificable equipo)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                ActualizarEquipoBase(equipo, connection);

                SqlCommand command = new SqlCommand("UPDATE EquipoIdentificable SET NumeroSerie = @NumeroSerie, CodigoInterno = @CodigoInterno " +
                    "WHERE IdEquipo = @IdEquipo", connection);
                command.Parameters.AddWithValue("@IdEquipo", equipo.IdEquipo);
                command.Parameters.AddWithValue("@NumeroSerie", equipo.NumeroSerie);
                command.Parameters.AddWithValue("@CodigoInterno", equipo.CodigoInterno);
                int filasAfectadas = command.ExecuteNonQuery();

                ActualizarCaracteristicas(equipo, connection);
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

        public bool ActualizarEquipoPorCantidad(EquipoPorCantidad equipo)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                ActualizarEquipoBase(equipo, connection);
                SqlCommand command = new SqlCommand("UPDATE EquipoPorCantidad SET Stock = @Stock " +
                    "WHERE IdEquipo = @IdEquipo", connection);
                command.Parameters.AddWithValue("@IdEquipo", equipo.IdEquipo);
                command.Parameters.AddWithValue("@Stock", equipo.Stock);
                int filasAfectadas = command.ExecuteNonQuery();

                ActualizarCaracteristicas(equipo, connection);
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

        private void ActualizarEquipoBase(Equipo equipo, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("UPDATE Equipo SET Marca = @Marca, Modelo = @Modelo, Descripcion = @Descripcion, Estado = @Estado, IdTipoEquipamiento = @IdTipoEquipamiento, IdDeposito = @IdDeposito " +
                "WHERE IdEquipo = @IdEquipo", connection);
            command.Parameters.AddWithValue("@IdEquipo", equipo.IdEquipo);
            command.Parameters.AddWithValue("@Marca", equipo.Marca);
            command.Parameters.AddWithValue("@Modelo", equipo.Modelo);
            command.Parameters.AddWithValue("@Descripcion", (object?)equipo.Descripcion ?? DBNull.Value);
            command.Parameters.AddWithValue("@Estado", (int)equipo.Estado);
            command.Parameters.AddWithValue("@IdTipoEquipamiento", equipo.TipoEquipamiento.IdTipoEquipamiento);
            command.Parameters.AddWithValue("@IdDeposito", equipo.Deposito.IdDeposito);
            command.ExecuteNonQuery();
        }

        private void ActualizarCaracteristicas(Equipo equipo, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Caracteristica WHERE IdEquipo = @IdEquipo", connection);
            command.Parameters.AddWithValue("@IdEquipo", equipo.IdEquipo);
            command.ExecuteNonQuery();
            InsertarCaracteristicas(equipo, equipo.IdEquipo, connection);
        }

        public int AgregarDeposito(Deposito deposito)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Deposito(Nombre, Direccion) " +
                    "VALUES (@Nombre, @Direccion)", connection);
                command.Parameters.AddWithValue("@Nombre", deposito.Nombre);
                command.Parameters.AddWithValue("@Direccion", deposito.Direccion);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(IdDeposito) FROM Deposito";
                int idDeposito = Convert.ToInt32(command.ExecuteScalar());
                return idDeposito;
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

        public int AgregarEquipoIdentificable(EquipoIdentificable equipo)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                int idEquipo = AgregarEquipoBase(equipo, connection);

                SqlCommand command = new SqlCommand("INSERT INTO EquipoIdentificable (IdEquipo, NumeroSerie, CodigoInterno) " +
                    "VALUES(@IdEquipo, @NumeroSerie, @CodigoInterno)", connection);
                command.Parameters.AddWithValue("@IdEquipo", idEquipo);
                command.Parameters.AddWithValue("@NumeroSerie", equipo.NumeroSerie);
                command.Parameters.AddWithValue("@CodigoInterno", equipo.CodigoInterno);
                command.ExecuteNonQuery();

                InsertarCaracteristicas(equipo, idEquipo, connection);
                return idEquipo;
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

        public int AgregarEquipoPorCantidad(EquipoPorCantidad equipo)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                int idEquipo = AgregarEquipoBase(equipo, connection);

                SqlCommand command = new SqlCommand("INSERT INTO EquipoPorCantidad(IdEquipo, Stock) " +
                    "VALUES(@IdEquipo, @Stock)", connection);
                command.Parameters.AddWithValue("@IdEquipo", idEquipo);
                command.Parameters.AddWithValue("@Stock", equipo.Stock);
                command.ExecuteNonQuery();

                InsertarCaracteristicas(equipo, idEquipo, connection);
                return idEquipo;
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

        private int AgregarEquipoBase(Equipo equipo, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Equipo(Marca, Modelo, Descripcion, Estado, IdTipoEquipamiento, IdDeposito) " +
                "VALUES(@Marca, @Modelo, @Descripcion, @Estado, @IdTipoEquipamiento, @IdDeposito)", connection);
            command.Parameters.AddWithValue("@Marca", equipo.Marca);
            command.Parameters.AddWithValue("@Modelo", equipo.Modelo);
            command.Parameters.AddWithValue("@Descripcion", (object?)equipo.Descripcion ?? DBNull.Value);
            command.Parameters.AddWithValue("@Estado", (int)equipo.Estado);
            command.Parameters.AddWithValue("@IdTipoEquipamiento", equipo.TipoEquipamiento.IdTipoEquipamiento);
            command.Parameters.AddWithValue("@IdDeposito", equipo.Deposito.IdDeposito);
            command.ExecuteNonQuery();
            command.CommandText = "SELECT MAX(IdEquipo) FROM Equipo";
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private void InsertarCaracteristicas(Equipo equipo, int idEquipo, SqlConnection connection)
        {
            foreach (Caracteristica caracteristica in equipo.Caracteristicas)
            {
                SqlCommand command = new SqlCommand("INSERT INTO Caracteristica(IdEquipo, Nombre, Valor) " +
                    "VALUES(@IdEquipo, @Nombre, @Valor)", connection);
                command.Parameters.AddWithValue("@IdEquipo", idEquipo);
                command.Parameters.AddWithValue("@Nombre", caracteristica.Nombre);
                command.Parameters.AddWithValue("@Valor", caracteristica.Valor);
                command.ExecuteNonQuery();
            }
        }

        public int AgregarMantenimiento(Mantenimiento mantenimiento)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Mantenimiento(Fecha, Motivo, Resultado, Tipo, TrabajoRealizado, Costo, IdEquipo, IdContratacion) " +
                    "VALUES(@Fecha, @Motivo, @Resultado, @Tipo, @TrabajoRealizado, @Costo, @IdEquipo, @IdContratacion)", connection);
                command.Parameters.AddWithValue("@Fecha", mantenimiento.Fecha.ToDateTime(TimeOnly.MinValue));
                command.Parameters.AddWithValue("@Motivo", mantenimiento.Motivo);
                command.Parameters.AddWithValue("@Resultado", (object?)mantenimiento.Resultado ?? DBNull.Value);
                command.Parameters.AddWithValue("@Tipo", mantenimiento.Tipo);
                command.Parameters.AddWithValue("@TrabajoRealizado", (object?)mantenimiento.TrabajoRealizado ?? DBNull.Value);
                command.Parameters.AddWithValue("@Costo", mantenimiento.Costo);
                command.Parameters.AddWithValue("@IdEquipo", mantenimiento.EquipoIdentificable.IdEquipo);
                command.Parameters.AddWithValue("@IdContratacion", mantenimiento.Contratacion == null ? DBNull.Value : mantenimiento.Contratacion.IdContratacion);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(IdMantenimiento) FROM Mantenimiento";
                int mantenimientoId = Convert.ToInt32(command.ExecuteScalar());
                return mantenimientoId;
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

        public int AgregarTipoEquipamiento(TipoEquipamiento tipoEquipamiento)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO TipoEquipamiento(Nombre, Descripcion) " +
                    "VALUES(@Nombre, @Descripcion)", connection);
                command.Parameters.AddWithValue("@Nombre", tipoEquipamiento.Nombre);
                command.Parameters.AddWithValue("@Descripcion", (object?)tipoEquipamiento.Descripcion ?? DBNull.Value);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(IdTipoEquipamiento) FROM TipoEquipamiento";
                int tipoEquipamientoId = Convert.ToInt32(command.ExecuteScalar());
                return tipoEquipamientoId;
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

        public List<Deposito> ListarDepositos()
        {
            List<Deposito> depositos = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT d.IdDeposito, d.Nombre, d.Direccion " +
                    "FROM Deposito d", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Deposito deposito = new Deposito
                    {
                        IdDeposito = reader.GetInt32(reader.GetOrdinal("IdDeposito")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                        Direccion = reader.GetString(reader.GetOrdinal("Direccion"))
                    };
                    depositos.Add(deposito);
                }
                return depositos;
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

        public List<Equipo> ListarEquipos()
        {
            List<Equipo> equipos = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT e.IdEquipo, e.Marca, e.Modelo, e.Descripcion, e.Estado AS EstadoEquipo, " +
                    "te.IdTipoEquipamiento, te.Nombre AS NombreTipoEquipamiento, " +
                    "d.IdDeposito, d.Nombre AS NombreDeposito, d.Direccion, " +
                    "ei.NumeroSerie, ei.CodigoInterno, ep.Stock " +
                    "FROM Equipo e " +
                    "INNER JOIN TipoEquipamiento te ON e.IdTipoEquipamiento = te.IdTipoEquipamiento " +
                    "INNER JOIN Deposito d ON e.IdDeposito = d.IdDeposito " +
                    "LEFT JOIN EquipoIdentificable ei ON e.IdEquipo = ei.IdEquipo " +
                    "LEFT JOIN EquipoPorCantidad ep ON e.IdEquipo = ep.IdEquipo", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idEquipo = reader.GetInt32(reader.GetOrdinal("IdEquipo"));
                    string marca = reader.GetString(reader.GetOrdinal("Marca"));
                    string modelo = reader.GetString(reader.GetOrdinal("Modelo"));
                    string? descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString(reader.GetOrdinal("Descripcion"));
                    EstadoEquipo estado = (EstadoEquipo)reader.GetInt32(reader.GetOrdinal("EstadoEquipo"));

                    TipoEquipamiento tipoEquipamiento = new TipoEquipamiento
                    {
                        IdTipoEquipamiento = reader.GetInt32(reader.GetOrdinal("IdTipoEquipamiento")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreTipoEquipamiento"))
                    };

                    Deposito deposito = new Deposito
                    {
                        IdDeposito = reader.GetInt32(reader.GetOrdinal("IdDeposito")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreDeposito")),
                        Direccion = reader.GetString(reader.GetOrdinal("Direccion"))
                    };

                    if (!reader.IsDBNull(reader.GetOrdinal("NumeroSerie")))
                    {
                        equipos.Add(new EquipoIdentificable
                        (
                            idEquipo,
                            marca,
                            modelo,
                            descripcion,
                            estado,
                            ListarCaracteristicas(idEquipo),
                            tipoEquipamiento,
                            deposito,
                            reader.GetString(reader.GetOrdinal("NumeroSerie")),
                            reader.GetString(reader.GetOrdinal("CodigoInterno"))
                        ));
                    }
                    else
                    {
                        equipos.Add(new EquipoPorCantidad
                        (
                            idEquipo,
                            marca,
                            modelo,
                            descripcion,
                            estado,
                            ListarCaracteristicas(idEquipo),
                            tipoEquipamiento,
                            deposito,
                            reader.GetInt32(reader.GetOrdinal("Stock"))
                        ));
                    }
                }
                return equipos;
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

        public List<Caracteristica> ListarCaracteristicas(int idEquipo)
        {
            List<Caracteristica> caracteristicas = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT c.Nombre, c.Valor " +
                    "FROM Caracteristica c " +
                    "WHERE c.IdEquipo = @IdEquipo", connection);
                command.Parameters.AddWithValue("@IdEquipo", idEquipo);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Caracteristica caracteristica = new Caracteristica
                    {
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                        Valor = reader.GetString(reader.GetOrdinal("Valor")),
                    };
                    caracteristicas.Add(caracteristica);
                }
                return caracteristicas;
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

        public List<Mantenimiento> ListarMantenimientos()
        {
            List<Mantenimiento> mantenimientos = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT m.IdMantenimiento, m.Fecha AS FechaMantenimiento, m.Motivo, m.Resultado, m.Tipo, m.TrabajoRealizado, m.Costo, " +
                    "e.IdEquipo, e.Marca, e.Modelo, e.Descripcion as DescripcionEquipo, e.Estado AS EstadoEquipo, " +
                    "ei.NumeroSerie, ei.CodigoInterno, " +
                    "te.IdTipoEquipamiento, te.Nombre, te.Descripcion, " +
                    "d.IdDeposito, d.Nombre AS NombreDeposito, d.Direccion, " +
                    "c.IdContratacion, c.IdSolicitud, c.Fecha AS FechaContratacion, c.FechaInicioAlquiler, c.FechaFinAlquiler, c.Estado AS EstadoContratacion " +
                    "FROM Mantenimiento m " +
                    "INNER JOIN Equipo e ON m.IdEquipo = e.IdEquipo " +
                    "INNER JOIN EquipoIdentificable ei ON e.IdEquipo = ei.IdEquipo " +
                    "INNER JOIN TipoEquipamiento te ON e.IdTipoEquipamiento = te.IdTipoEquipamiento " +
                    "INNER JOIN Deposito d ON e.IdDeposito = d.IdDeposito " +
                    "LEFT JOIN Contratacion c ON m.IdContratacion = c.IdContratacion", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoEquipamiento tipoEquipamiento = new TipoEquipamiento
                    {
                        IdTipoEquipamiento = reader.GetInt32(reader.GetOrdinal("IdTipoEquipamiento")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
                    };

                    Deposito deposito = new Deposito
                    {
                        IdDeposito = reader.GetInt32(reader.GetOrdinal("IdDeposito")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreDeposito")),
                        Direccion = reader.GetString(reader.GetOrdinal("Direccion"))
                    };

                    EquipoIdentificable equipoIdentificable = new EquipoIdentificable
                    (
                        reader.GetInt32(reader.GetOrdinal("IdEquipo")),
                        reader.GetString(reader.GetOrdinal("Marca")),
                        reader.GetString(reader.GetOrdinal("Modelo")),
                        reader.IsDBNull(reader.GetOrdinal("DescripcionEquipo")) ? null : reader.GetString(reader.GetOrdinal("DescripcionEquipo")),
                        (EstadoEquipo)reader.GetInt32(reader.GetOrdinal("EstadoEquipo")),
                        ListarCaracteristicas(reader.GetInt32(reader.GetOrdinal("IdEquipo"))),
                        tipoEquipamiento,
                        deposito,
                        reader.GetString(reader.GetOrdinal("NumeroSerie")),
                        reader.GetString(reader.GetOrdinal("CodigoInterno"))
                    );

                    Contratacion? contratacion = null;
                    if (!reader.IsDBNull(reader.GetOrdinal("IdContratacion")))
                    {
                        contratacion = new Contratacion
                        {
                            IdContratacion = reader.GetInt32(reader.GetOrdinal("IdContratacion")),
                            IdSolicitud = reader.GetInt32(reader.GetOrdinal("IdSolicitud")),
                            Fecha = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaContratacion"))),
                            FechaInicioAlquiler = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaInicioAlquiler"))),
                            FechaFinAlquiler = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaFinAlquiler"))),
                            Estado = (EstadoContratacion)reader.GetInt32(reader.GetOrdinal("EstadoContratacion"))
                        };
                    }

                    Mantenimiento mantenimiento = new Mantenimiento
                    {
                        IdMantenimiento = reader.GetInt32(reader.GetOrdinal("IdMantenimiento")),
                        Fecha = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("FechaMantenimiento"))),
                        Motivo = reader.GetString(reader.GetOrdinal("Motivo")),
                        Resultado = reader.IsDBNull(reader.GetOrdinal("Resultado")) ? null : reader.GetString(reader.GetOrdinal("Resultado")),
                        Tipo = reader.GetString(reader.GetOrdinal("Tipo")),
                        TrabajoRealizado = reader.IsDBNull(reader.GetOrdinal("TrabajoRealizado")) ? null : reader.GetString(reader.GetOrdinal("TrabajoRealizado")),
                        Costo = reader.GetDecimal(reader.GetOrdinal("Costo")),
                        EquipoIdentificable = equipoIdentificable,
                        Contratacion = contratacion
                    };
                    mantenimientos.Add(mantenimiento);
                }
                return mantenimientos;
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

        public List<TipoEquipamiento> ListarTiposEquipamientos()
        {
            List<TipoEquipamiento> tipos = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT te.IdTipoEquipamiento, te.Nombre, te.Descripcion " +
                    "FROM TipoEquipamiento te", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoEquipamiento tipo = new TipoEquipamiento
                    {
                        IdTipoEquipamiento = reader.GetInt32(reader.GetOrdinal("IdTipoEquipamiento")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                        Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString(reader.GetOrdinal("Descripcion"))
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

        public Equipo? ObtenerEquipoPorId(int idEquipo)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT e.IdEquipo, e.Marca, e.Modelo, e.Descripcion, e.Estado AS EstadoEquipo, " +
                    "te.IdTipoEquipamiento, te.Nombre AS NombreTipoEquipamiento, te.Descripcion AS DescripcionTipoEquipamiento, " +
                    "d.IdDeposito, d.Nombre AS NombreDeposito, d.Direccion, " +
                    "ei.NumeroSerie, ei.CodigoInterno, ep.Stock " +
                    "FROM Equipo e " +
                    "INNER JOIN TipoEquipamiento te ON e.IdTipoEquipamiento = te.IdTipoEquipamiento " +
                    "INNER JOIN Deposito d ON e.IdDeposito = d.IdDeposito " +
                    "LEFT JOIN EquipoIdentificable ei ON e.IdEquipo = ei.IdEquipo " +
                    "LEFT JOIN EquipoPorCantidad ep ON e.IdEquipo = ep.IdEquipo " +
                    "WHERE e.IdEquipo = @IdEquipo", connection);
                command.Parameters.AddWithValue("@IdEquipo", idEquipo);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoEquipamiento tipoEquipamiento = new TipoEquipamiento
                    {
                        IdTipoEquipamiento = reader.GetInt32(reader.GetOrdinal("IdTipoEquipamiento")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreTipoEquipamiento")),
                        Descripcion = reader.IsDBNull(reader.GetOrdinal("DescripcionTipoEquipamiento")) ? null : reader.GetString(reader.GetOrdinal("DescripcionTipoEquipamiento"))
                    };

                    Deposito deposito = new Deposito
                    {
                        IdDeposito = reader.GetInt32(reader.GetOrdinal("IdDeposito")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreDeposito")),
                        Direccion = reader.GetString(reader.GetOrdinal("Direccion"))
                    };

                    if (!reader.IsDBNull(reader.GetOrdinal("NumeroSerie")))
                    {
                        return new EquipoIdentificable
                        (
                            reader.GetInt32(reader.GetOrdinal("IdEquipo")),
                            reader.GetString(reader.GetOrdinal("Marca")),
                            reader.GetString(reader.GetOrdinal("Modelo")),
                            reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString(reader.GetOrdinal("Descripcion")),
                            (EstadoEquipo)reader.GetInt32(reader.GetOrdinal("EstadoEquipo")),
                            ListarCaracteristicas(idEquipo),
                            tipoEquipamiento,
                            deposito,
                            reader.GetString(reader.GetOrdinal("NumeroSerie")),
                            reader.GetString(reader.GetOrdinal("CodigoInterno"))
                        );
                    }
                    return new EquipoPorCantidad
                        (
                            reader.GetInt32(reader.GetOrdinal("IdEquipo")),
                            reader.GetString(reader.GetOrdinal("Marca")),
                            reader.GetString(reader.GetOrdinal("Modelo")),
                            reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString(reader.GetOrdinal("Descripcion")),
                            (EstadoEquipo)reader.GetInt32(reader.GetOrdinal("EstadoEquipo")),
                            ListarCaracteristicas(idEquipo),
                            tipoEquipamiento,
                            deposito,
                            reader.GetInt32(reader.GetOrdinal("Stock"))
                        );
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
