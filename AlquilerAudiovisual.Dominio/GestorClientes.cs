using AlquilerAudiovisual.Entities.Clientes;
using AlquilerAudiovisual.Persistencia.DalDataBase;
using AlquilerAudiovisual.Persistencia.Interfaces;

namespace AlquilerAudiovisual.Dominio
{
    public class GestorClientes
    {
        private readonly IDalCliente dalCliente = new ClienteDb();

        public int RegistrarCliente(Cliente cliente)
        {
            ValidarCliente(cliente);
            if (dalCliente.ObtenerPorDocumento(cliente.Documento) != null)
            {
                throw new Exception("Ya existe un cliente con ese documento");
            }
            return dalCliente.AgregarCliente(cliente);
        }

        public bool ModificarCliente(Cliente cliente)
        {
            ValidarCliente(cliente);
            return dalCliente.ActualizarCliente(cliente);
        }

        public bool DesactivarCliente(int idCliente)
        {
            Cliente? cliente = dalCliente.ObtenerClientePorId(idCliente);
            if (cliente == null)
            {
                return false;
            }
            cliente.Desactivar();
            return dalCliente.ActualizarCliente(cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return dalCliente.LeerClientes();
        }

        public Cliente? BuscarPorDocumento(string documento)
        {
            return dalCliente.ObtenerPorDocumento(documento);
        }

        public int RegistrarTipoCliente(TipoCliente tipo)
        {
            return dalCliente.AgregarTipoCliente(tipo);
        }

        public List<TipoCliente> ListarTiposClientes()
        {
            return dalCliente.ListarTipoClientes();
        }

        private void ValidarCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Documento))
            {
                throw new Exception("El documento es obligatorio");
            }
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                throw new Exception("El nombre es obligatorio");
            }
            if (string.IsNullOrWhiteSpace(cliente.Telefono))
            {
                throw new Exception("El teléfono es obligatorio");
            }
            if (string.IsNullOrWhiteSpace(cliente.Direccion))
            {
                throw new Exception("La dirección es obligatoria");
            }
            if (cliente.TipoCliente == null)
            {
                throw new Exception("Debe seleccionar un tipo de cliente");
            }
        }
    }
}