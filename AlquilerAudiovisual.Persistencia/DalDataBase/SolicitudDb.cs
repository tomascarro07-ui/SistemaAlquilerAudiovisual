using AlquilerAudiovisual.Entities.Solicitudes;
using AlquilerAudiovisual.Persistencia.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerAudiovisual.Persistencia.DalDataBase
{
    internal class SolicitudDb : IDalSolicitud
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
                command.Parameters.AddWithValue("@FechaSolicitud", solicitud.FechaSolicitud);
                command.Parameters.AddWithValue("@Ubicacion", solicitud.Ubicacion);
                command.Parameters.AddWithValue("@FechaInicio", solicitud.FechaInicio);
                command.Parameters.AddWithValue("@FechaFin", solicitud.FechaFin);
                command.Parameters.AddWithValue("@CantidadAsistentes", solicitud.CantidadAsistentes);
                command.Parameters.AddWithValue("@IdEstado", (int)solicitud.Estado);
                command.Parameters.AddWithValue("@IdCliente", solicitud.Cliente.IdCliente);
                command.Parameters.AddWithValue("@IdEstado", solicitud.TipoEvento.IdTipoEvento);
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
                command.Parameters.AddWithValue("@IdSolicitud", solicitud.IdSolicitud);
                command.Parameters.AddWithValue("@FechaSolicitud", solicitud.FechaSolicitud);
                command.Parameters.AddWithValue("@Ubicacion", solicitud.Ubicacion);
                command.Parameters.AddWithValue("@FechaInicio", solicitud.FechaInicio);
                command.Parameters.AddWithValue("@FechaFin", solicitud.FechaFin);
                command.Parameters.AddWithValue("@CantidadAsistentes", solicitud.CantidadAsistentes);
                command.Parameters.AddWithValue("@IdEstado", (int)solicitud.Estado);
                command.Parameters.AddWithValue("@IdCliente", solicitud.Cliente.IdCliente);
                command.Parameters.AddWithValue("@IdEstado", solicitud.TipoEvento.IdTipoEvento);
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
                SqlCommand command = new SqlCommand("SELECT s.IdSolicitud, s.FechaSolicitud, s.Ubicacion, s.FechaInicio, s.FechaFin, s.HoraInicio, s.HoraFin, s.CantidadAsistentes, s.IdEstado, s.IdCliente, s.IdTipoEvento, " +
                    "c.IdCliente, c.Documento, c.Nombre AS NombreCliente, c.Telefono, c.Correo, c.Direccion, c.Activo, " +
                    "tc.IdTipoCliente, tc.Nombre AS NombreTipoCliente, " +
                    "te.IdTipoEvento, te.Nombre AS NombreTipoEvento " +
                    "FROM Solicitud s" +
                    "INNER JOIN Cliente c ON s.IdCliente = c.IdCliente " +
                    "INNER JOIN TipoCliente tc ON c.IdTipoCliente = tc.IdTipoCliente " +
                    "INNER JOIN TipoEvento te ON s.IdTipoEvento = te.IdTipoEvento", connection);
            }
        }

        public List<TipoEvento> LeerTiposEventos()
        {
            throw new NotImplementedException();
        }

        public Solicitud? ObtenerSolicitudPorId(int idSolicitud)
        {
            throw new NotImplementedException();
        }
    }
}
