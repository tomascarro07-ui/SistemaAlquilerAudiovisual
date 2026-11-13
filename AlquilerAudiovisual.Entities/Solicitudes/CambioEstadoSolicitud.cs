using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Solicitudes
{
    public class CambioEstadoSolicitud
    {
        public int IdCambioEstado { get; set; }
        public required DateTime FechaCambio { get; set; } = DateTime.Now;
        public string? Observaciones { get; set; }
        public required EstadoSolicitud EstadoNuevo { get; set; } 
    }
}
