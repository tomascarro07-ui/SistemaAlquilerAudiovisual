using AlquilerAudiovisual.Entities.Clientes;

namespace AlquilerAudiovisual.Persistencia.Interfaces
{
    public interface IDalCliente
    {
        void AgregarCliente(Cliente cliente);
        void ActualizarCliente(Cliente cliente);
        List<Cliente> ListarClientes();
        Cliente? ObtenerClientePorId(int idCliente);
        Cliente? ObtenerPorDocumento(string documento);
        List<TipoCliente> ListarTipos();
    }
}
