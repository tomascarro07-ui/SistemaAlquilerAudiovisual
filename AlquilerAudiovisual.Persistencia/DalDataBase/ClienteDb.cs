using AlquilerAudiovisual.Entities.Clientes;
using AlquilerAudiovisual.Persistencia.Interfaces;
using Microsoft.Data.SqlClient;

namespace AlquilerAudiovisual.Persistencia.DalDataBase
{
    public class ClienteDb : IDalCliente
    {
        public int AgregarCliente(Cliente cliente)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
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

        public List<Cliente> LeerClientes()
        {
            List<Cliente> clientes = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT c.IdCliente, c.Documento, c.Nombre, c.Telefono, c.Correo, c.Direccion, c.Activo, " +
                    "t.IdTipoCliente, t.Nombre AS NombreTipo " +
                    "FROM Cliente c INNER JOIN TipoCliente t ON c.IdTipoCliente = t.IdTipoCliente", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idCliente = reader.GetInt32(reader.GetOrdinal("IdCliente"));
                    string documento = reader.GetString(reader.GetOrdinal("Documento"));
                    string nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                    string telefono = reader.GetString(reader.GetOrdinal("Telefono"));
                    string? correo = reader.IsDBNull(reader.GetOrdinal("Correo")) ? null : reader.GetString(reader.GetOrdinal("Correo"));
                    string direccion = reader.GetString(reader.GetOrdinal("Direccion"));
                    bool activo = reader.GetBoolean(reader.GetOrdinal("Activo"));
                    TipoCliente tipoCliente = new TipoCliente
                    {
                        IdTipoCliente = reader.GetInt32(reader.GetOrdinal("IdTipoCliente")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreTipo"))
                    };
                    Cliente cliente = new Cliente(idCliente, documento, nombre, telefono, correo, direccion, activo, tipoCliente);
                    clientes.Add(cliente);
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
            return clientes;
        }

        public bool ActualizarCliente(Cliente cliente)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Cliente SET Documento = @Documento, Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo, Direccion = @Direccion, Activo = @Activo, IdTipoCliente = @IdTipoCliente " +
                    "WHERE IdCliente = @IdCliente", connection);
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

        public Cliente? ObtenerClientePorId(int idCliente)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT c.IdCliente, c.Documento, c.Nombre, c.Telefono, c.Correo, c.Direccion, c.Activo, " +
                    "t.IdTipoCliente, t.Nombre AS NombreTipo " +
                    "FROM Cliente c INNER JOIN TipoCliente t ON c.IdTipoCliente = t.IdTipoCliente " +
                    "WHERE c.IdCliente = @IdCliente", connection);
                command.Parameters.AddWithValue("@IdCliente", idCliente);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoCliente tipo = new TipoCliente
                    {
                        IdTipoCliente = reader.GetInt32(reader.GetOrdinal("IdTipoCliente")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreTipo"))
                    };

                    return new Cliente
                    (
                        reader.GetInt32(reader.GetOrdinal("IdCliente")),
                        reader.GetString(reader.GetOrdinal("Documento")),
                        reader.GetString(reader.GetOrdinal("Nombre")),
                        reader.GetString(reader.GetOrdinal("Telefono")),
                        reader.IsDBNull(reader.GetOrdinal("Correo")) ? null : reader.GetString(reader.GetOrdinal("Correo")),
                        reader.GetString(reader.GetOrdinal("Direccion")),
                        reader.GetBoolean(reader.GetOrdinal("Activo")),
                        tipo
                    );
                }
            } 
            catch(Exception ex)
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

        public Cliente? ObtenerPorDocumento(string documento)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT c.IdCliente, c.Documento, c.Nombre, c.Telefono, c.Correo, c.Direccion, c.Activo, " +
                    "t.IdTipoCliente, t.Nombre AS NombreTipo " +
                    "FROM Cliente c INNER JOIN TipoCliente t ON c.IdTipoCliente = t.IdTipoCliente " +
                    "WHERE c.Documento = @Documento", connection);
                command.Parameters.AddWithValue("@Documento", documento);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoCliente tipo = new TipoCliente
                    {
                        IdTipoCliente = reader.GetInt32(reader.GetOrdinal("IdTipoCliente")),
                        Nombre = reader.GetString(reader.GetOrdinal("NombreTipo"))
                    };

                    return new Cliente
                    (
                        reader.GetInt32(reader.GetOrdinal("IdCliente")),
                        reader.GetString(reader.GetOrdinal("Documento")),
                        reader.GetString(reader.GetOrdinal("Nombre")),
                        reader.GetString(reader.GetOrdinal("Telefono")),
                        reader.IsDBNull(reader.GetOrdinal("Correo")) ? null : reader.GetString(reader.GetOrdinal("Correo")),
                        reader.GetString(reader.GetOrdinal("Direccion")),
                        reader.GetBoolean(reader.GetOrdinal("Activo")),
                        tipo
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

        public int AgregarTipoCliente(TipoCliente tipo)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO TipoCliente(Nombre) " +
                    "VALUES (@Nombre)", connection);
                command.Parameters.AddWithValue("@Nombre", tipo.Nombre);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT MAX(IdTipoCliente) FROM TipoCliente";
                int tipoClienteId = Convert.ToInt32(command.ExecuteScalar());
                return tipoClienteId;
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

        public List<TipoCliente> ListarTipoClientes()
        {
            List<TipoCliente> tipos = [];
            SqlConnection connection = new SqlConnection(Constantes.CONNECTION_BD);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT t.IdTipoCliente, t.Nombre " +
                    "FROM TipoCliente t", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoCliente tipo = new TipoCliente
                    {
                        IdTipoCliente = reader.GetInt32(reader.GetOrdinal("IdTipoCliente")),
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
    }
}
