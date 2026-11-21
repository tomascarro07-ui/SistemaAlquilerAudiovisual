using AlquilerAudiovisual.Entities.Clientes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerAudiovisual.Persistencia.DalDataBase
{
    public class ClienteDb
    {
        private string CONNECTION_STRING = @"Data Source=DESKTOP-O6J4D0J\SQLEXPRESS;Initial Catalog=AlquilerAudiovisual;Integrated Security=True;Trust Server Certificate=True";
        public int AgregarCliente(Cliente cliente)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Cliente(Documento, Nombre, Telefono, Correo, Direccion, Activo, IdTipoCliente)" +
                    "VALUES (@Documento, @Nombre, @Telefono, @Correo, @Direccion, @Activo, @IdTipoCliente)", connection);
                command.Parameters.AddWithValue("@Documento", cliente.Documento);
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Correo", (object?)cliente.Correo ?? DBNull.Value);
                command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@Activo", cliente.Activo);
                command.Parameters.AddWithValue("@IdTipoCliente", cliente.TipoCliente.IdTipoCliente);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(IdCliente) FROM Cliente";
                int clienteId = Convert.ToInt32(command.ExecuteScalar());
                return clienteId;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectarse con la base de datos: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public bool EliminarCliente(int id)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Cliente WHERE IdCliente = @IdCliente", connection);
                command.Parameters.AddWithValue("@IdCliente", id);
                int filasAfectadas = command.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectarse con la base de datos: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public List<Cliente> LeerClientes()
        {
            List<Cliente> clientes = [];
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT c.IdCliente, c.Documento, c.Nombre, c.Telefono, c.Correo, c.Direccion, c.Activo, " +
                    "t.IdTipoCliente, t.Nombre AS NombreTipo " +
                    "FROM Cliente c INNER JOIN TipoCliente t ON c.IdTipoCliente = t.IdTipoCliente", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int IdCliente = reader.GetInt32(reader.GetOrdinal("IdCliente"));
                    string Documento = reader.GetString(reader.GetOrdinal("Documento"));
                    string Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                    string Telefono = reader.GetString(reader.GetOrdinal("Telefono"));
                    string? Correo = reader.IsDBNull(reader.GetOrdinal("Correo")) ? null : reader.GetString(reader.GetOrdinal("Correo"));
                    string Direccion = reader.GetString(reader.GetOrdinal("Direccion"));
                    bool Activo = reader.GetBoolean(reader.GetOrdinal("Activo"));
                    TipoCliente tipoCliente = new TipoCliente
                    {
                        IdTipoCliente = reader.GetInt32(reader.GetOrdinal("IdTipoCliente")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreTipo"))
                    };
                    Cliente cliente = new Cliente(IdCliente, Documento, Nombre, Telefono, Correo, Direccion, Activo, tipoCliente);
                    clientes.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectarse con la base de datos: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return clientes;
        }

        public bool ActualizarCliente(Cliente cliente)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Cliente SET Documento = @Documento, Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo, Direccion = @Direccion, Activo = @Activo, IdTipoCliente = @IdTipoCliente WHERE IdCliente = @IdCliente", connection);
                command.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                command.Parameters.AddWithValue("@Documento", cliente.Documento);
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Correo", (object?)cliente.Correo ?? DBNull.Value);
                command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@Activo", cliente.Activo);
                command.Parameters.AddWithValue("@IdTipoCliente", cliente.TipoCliente.IdTipoCliente);
                int filasAfectadas = command.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectarse con la base de datos: {ex.Message}");
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
