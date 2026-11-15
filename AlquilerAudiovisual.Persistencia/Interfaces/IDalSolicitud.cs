using AlquilerAudiovisual.Entities.Solicitudes;

namespace AlquilerAudiovisual.Persistencia.Interfaces
{
    public interface IDalSolicitud
    {
        void AgregarSolicitud(Solicitud solicitud);
        void ActualizarSolicitud(Solicitud solicitud);
        Solicitud? ObtenerSolicitudPorId(int idSolicitud);
        List<Solicitud> ListarSolicitudes();
        void AgregarTipoEvento(TipoEvento tipo);
        List<TipoEvento> ListarTiposEventos();
    }
}
