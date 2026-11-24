using AlquilerAudiovisual.Entities.Enumerados;
using AlquilerAudiovisual.Entities.Equipamientos;
using AlquilerAudiovisual.Persistencia.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AlquilerAudiovisual.Persistencia.DalDataBase
{
    public class EquipamientoDb : IDalEquipamiento
    {
        public bool ActualizarEquipo(Equipo equipo)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Equipo SET Marca = @Marca, Modelo = @Modelo, Descripcion = @Descripcion, Estado = @Estado, IdTipoEquipamiento = @IdTipoEquipamiento, IdDeposito = @IdDeposito " +
                    "WHERE IdEquipo = @IdEquipo", connection);
                command.Parameters.AddWithValue("@IdEquipo", equipo.IdEquipo);
                command.Parameters.AddWithValue("@Marca", equipo.Marca);
                command.Parameters.AddWithValue("@Modelo", equipo.Modelo);
                command.Parameters.AddWithValue("@Descripcion", equipo.Descripcion);
                command.Parameters.AddWithValue("@Estado", equipo.Estado);
                command.Parameters.AddWithValue("@IdTipoEquipamiento", equipo.TipoEquipamiento.IdTipoEquipamiento);
                command.Parameters.AddWithValue("@IdDeposito", equipo.Deposito.IdDeposito);
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
                command.CommandText = "SELECT MAX(IdDepositpo) FROM Deposito";
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

                SqlCommand command = new SqlCommand("INSERT INTO EquipoIdentificable IdEquipo, NumeroSerie, CodigoInterno " +
                    "VALUES(@IdEquipo, @NumeroSerie, @CodigoInterno)", connection);
                command.Parameters.AddWithValue("@IdEquipo", equipo.IdEquipo);
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
                    "VALUES(@IdEquipo, @Stock)",connection);
                command.Parameters.AddWithValue("@IdEquipo", equipo.IdEquipo);
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
                "VALUES(@Marca, @Modelo, @Descripcion, @Estado, @IdEquipamiento, @IdTipoEquipamiento, IdDeposito)", connection);
            command.Parameters.AddWithValue("@Marca", equipo.Marca);
            command.Parameters.AddWithValue("@Modelo", equipo.Modelo);
            command.Parameters.AddWithValue("@Descripcion", (object?)equipo.Descripcion == DBNull.Value);
            command.Parameters.AddWithValue("@Estado", (int)equipo.Estado);
            command.Parameters.AddWithValue("@IdTipoEquipamiento", equipo.TipoEquipamiento.IdTipoEquipamiento);
            command.Parameters.AddWithValue("@IdDeposito", equipo.Deposito.IdDeposito);
            command.ExecuteNonQuery();
            command.CommandText = "SELECT MAX(IdEquipo) FROM Equipo";
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private void InsertarCaracteristicas(Equipo equipo, int idEquipo, SqlConnection connection)
        {
            foreach(Caracteristica caracteristica in equipo.Caracteristicas)
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
                command.Parameters.AddWithValue("@Costo", (int)mantenimiento.Costo);
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
                command.Parameters.AddWithValue("@Nombre", tipoEquipamiento.Descripcion);
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
                SqlCommand command = new SqlCommand("SELECT e.IdEquipo, e.Marca, e.Modelo, e.Descripcion, e.Estado, " +
                    "te.IdTipoEquipamiento, te.Nombre AS NombreTipoEquipamiento, " +
                    "d.IdDeposito, d.Nombre AS NombreDeposito, d.Direccion " +
                    "ei.NumeroSerie, ei.CodigoInterno, ep.Stock " +
                    "FROM Equipo e " +
                    "INNER JOIN TipoEquipamiento te ON e.IdTipoEquipamiento = te.IdTipoEquipamiento " +
                    "INNER JOIN Deposito d ON e.Estado = d.IdDeposito " +
                    "LEFT JOIN EquipoIdentificable ei ON e.IdEquipo = ei.IdEquipo " +
                    "LEFT JOIN EquipoPorCantidad ep ON e.IdEquipo = ep.IdEquipo", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idEquipo = reader.GetInt32(reader.GetOrdinal("IdEquipo"));
                    string marca = reader.GetString(reader.GetOrdinal("Marca"));
                    string modelo = reader.GetString(reader.GetOrdinal("Modelo"));
                    string? descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString(reader.GetOrdinal("Descripcion"));
                    EstadoEquipo estado = (EstadoEquipo)reader.GetInt32(reader.GetOrdinal("IdEstado"));

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

                    if(!reader.IsDBNull(reader.GetOrdinal("NumeroSerie")))
                    {
                        equipos.Add(new EquipoIdentificable
                        {
                            IdEquipo = idEquipo,
                            Marca = marca,
                            Modelo = modelo,
                            Descripcion = descripcion,
                            Estado = estado,
                            Caracteristicas = new List<Caracteristica>(),
                            TipoEquipamiento = tipoEquipamiento,
                            Deposito = deposito,
                            NumeroSerie = reader.GetString(reader.GetOrdinal("NumeroSerie")),
                            CodigoInterno = reader.GetString(reader.GetOrdinal("CodigoInterno"))
                        });
                    } 
                    else
                    {
                        equipos.Add(new EquipoPorCantidad
                        {
                            IdEquipo = idEquipo,
                            Marca = marca,
                            Modelo = modelo,
                            Descripcion = descripcion,
                            Estado = estado,
                            Caracteristicas = new List<Caracteristica>(),
                            TipoEquipamiento = tipoEquipamiento,
                            Deposito = deposito,
                            Stock = reader.GetInt32(reader.GetOrdinal("Stock"))
                        });
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

        public List<Mantenimiento> ListarMantenimientos()
        {
            List<Mantenimiento> mantenimientos = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT m.IdMantenimiento, m.Fecha AS FechaMantenimiento, m.Motivo, m.Resultado, m.Tipo, m.TrabajoRealizado, m.Costo, " +
                    "e.IdEquipo, e.Marca, e.Modelo, e.Descripcion, e.Estado AS EstadoEquipo, " +
                    "ei.NumeroSerie, ei.CodigoInterno, " +
                    "te.IdTipoEquipamiento, te.Nombre, te.Descripcion " +
                    "c.IdContratacion, c.IdSolicitud, c.Fecha, c.FechaInicioAlquiler, c.FechaFinAlquiler, c.Estado AS EstadoContratacion " +
                    "FROM Mantenimiento m " +
                    "INNER JOIN Equipo e ON m.IdEquipo = e.IdEquipo " +
                    "INNER JOIN EquipoIdentificable te ON e.IdEquipo = ei.IdEquipo " +
                    "INNER JOIN TipoEquipamiento e.IdTipoEquipamiento = te.IdTipoEquipamiento " +
                    "INNER JOIN Deposito d ON e.IdDeposito = d.IdDeposito " +
                    "LEFT JOIN Contratacion c ON m.IdContratacion = c.IdContratacion", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                }
            }
        }

        public List<TipoEquipamiento> ListarTiposEquipamientos()
        {
            throw new NotImplementedException();
        }

        public Equipo? ObtenerEquipoPorId(int idEquipo)
        {
            throw new NotImplementedException();
        }
    }
}
