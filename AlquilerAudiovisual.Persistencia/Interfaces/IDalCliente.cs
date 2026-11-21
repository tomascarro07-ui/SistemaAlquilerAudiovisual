using AlquilerAudiovisual.Entities.Clientes;
using AlquilerAudiovisual.Entities.Solicitudes;

namespace AlquilerAudiovisual.Persistencia.Interfaces
{
    public interface IDalCliente
    {
        int AgregarCliente(Cliente cliente);
        bool ActualizarCliente(Cliente cliente);
        List<Cliente> LeerClientes();
        Cliente? ObtenerClientePorId(int idCliente);
        Cliente? ObtenerPorDocumento(string documento);
        int AgregarTipoCliente(TipoCliente tipo);
        List<TipoCliente> ListarTipoClientes();
    }
}
