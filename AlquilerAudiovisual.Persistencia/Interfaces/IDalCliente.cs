using AlquilerAudiovisual.Entities.Clientes;
using AlquilerAudiovisual.Entities.Solicitudes;

namespace AlquilerAudiovisual.Persistencia.Interfaces
{
    public interface IDalCliente
    {
        void AgregarCliente(Cliente cliente);
        void ActualizarCliente(Cliente cliente);
        List<Cliente> ListarClientes();
        Cliente? ObtenerClientePorId(int idCliente);
        Cliente? ObtenerPorDocumento(string documento);
        void AgregarTipoCliente(TipoCliente tipo);
        List<TipoCliente> ListarTipoClientes();
    }
}
