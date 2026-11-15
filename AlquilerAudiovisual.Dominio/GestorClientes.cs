using AlquilerAudiovisual.Entities.Clientes;
using AlquilerAudiovisual.Persistencia.Interfaces;

namespace AlquilerAudiovisual.Dominio
{
    public class GestorClientes : IDalCliente
    {
        public void ActualizarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void AgregarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void AgregarTipoCliente(TipoCliente tipo)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarClientes()
        {
            throw new NotImplementedException();
        }

        public List<TipoCliente> ListarTipoClientes()
        {
            throw new NotImplementedException();
        }

        public Cliente? ObtenerClientePorId(int idCliente)
        {
            throw new NotImplementedException();
        }

        public Cliente? ObtenerPorDocumento(string documento)
        {
            throw new NotImplementedException();
        }
    }
}
