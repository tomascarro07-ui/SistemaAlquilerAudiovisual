using AlquilerAudiovisual.Entities.Solicitudes;

namespace AlquilerAudiovisual.Persistencia.Interfaces
{
    public interface IDalSolicitud
    {
        int AgregarSolicitud(Solicitud solicitud);
        bool ActualizarSolicitud(Solicitud solicitud);
        Solicitud? ObtenerSolicitudPorId(int idSolicitud);
        List<Solicitud> LeerSolicitudes();
        int AgregarTipoEvento(TipoEvento tipo);
        List<TipoEvento> LeerTiposEventos();
    }
}
