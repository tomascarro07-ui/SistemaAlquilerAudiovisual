using AlquilerAudiovisual.Entities.Clientes;
using AlquilerAudiovisual.Persistencia.Interfaces;
using Microsoft.Data.SqlClient;

namespace AlquilerAudiovisual.Dominio
{
    public class GestorClientes
    {
        private string CONNECTION_STRING = @"Data Source=DESKTOP-O6J4D0J\SQLEXPRESS;Initial Catalog=AlquilerAudiovisual;Integrated Security=True;Trust Server Certificate=True";
        public int AgregarCliente(Cliente cliente)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Cliente(Documento, Nombre, Telefono, Correo, Direccion, Activo, IdTipoCliente)" +
                    "VALUES(@Documento, @Nombre, @Telefono, @Correo, @Direccion, @Activo, @IdTipoCliente)", connection);
                command.Parameters.AddWithValue("@Documento", cliente.Documento);
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Correo", cliente.Correo);
                command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@Activo", cliente.Activo);
                command.Parameters.AddWithValue("@IdTipoCliente", cliente.TipoCliente);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectarse con la base de datos: {ex.Message}");
            }
            finally
            {
                if(connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return cliente.IdCliente;
        }

        public bool EliminarCliente(int id)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Cliente WHERE IdCliente = @IdCliente", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectarse con la base de datos: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return true;
        }

        public int ObtenerUltimoId(List<Cliente>? listaCliente)
        {
            if(listaCliente == null)
            {
                listaCliente = LeerClientes();
            }

            if(listaCliente.Count == 0)
            {
                return 1;
            }
            else
            {
                return listaCliente.Max(v => v.IdCliente) + 1;
            }
        }
    }
}
