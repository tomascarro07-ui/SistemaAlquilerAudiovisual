using AlquilerAudiovisual.Entities.Contrataciones;
using AlquilerAudiovisual.Persistencia.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerAudiovisual.Persistencia.DalDataBase
{
    internal class ContratacionDb : IDalContratacion
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
                command.Parameters.AddWithValue("@Fecha", contratacion.Fecha);
                command.Parameters.AddWithValue("@FechaInicioAlquiler", contratacion.FechaInicioAlquiler);
                command.Parameters.AddWithValue("@FechaFinAlquiler", contratacion.FechaFinAlquiler);
                command.Parameters.AddWithValue("@Estado", contratacion.Estado);
                int filasAfectadas = command.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectarse con la base de datos: {ex.Message}", ex);
            }
            finally
            {
                if(connection.State == System.Data.ConnectionState.Open)
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
            }

        public int AgregarContratacion(Contratacion contratacion)
        {
            throw new NotImplementedException();
        }

        public int AgregarPreparacion(Preparacion preparacion)
        {
            throw new NotImplementedException();
        }

        public int AgregarTarifa(Tarifa tarifa)
        {
            throw new NotImplementedException();
        }

        public List<Contratacion> ListarContrataciones()
        {
            throw new NotImplementedException();
        }

        public List<Preparacion> ListarPreparaciones()
        {
            throw new NotImplementedException();
        }

        public List<Tarifa> ListarTarifas()
        {
            throw new NotImplementedException();
        }

        public Contratacion? ObtenerContratacionPorId(int idContratacion)
        {
            throw new NotImplementedException();
        }
    }
}
