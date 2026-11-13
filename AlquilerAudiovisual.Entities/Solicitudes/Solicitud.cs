using AlquilerAudiovisual.Entities.Clientes;
using AlquilerAudiovisual.Entities.Enumerados;
using AlquilerAudiovisual.Entities.Contrataciones;

namespace AlquilerAudiovisual.Entities.Solicitudes
{
    public class Solicitud
    {
        public int IdSolicitud { get; set; }
        public DateOnly FechaSolicitud { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public required string Ubicacion { get; set; }
        public required DateOnly FechaInicio { get; set; }
        public required DateOnly FechaFin { get; set; }
        public required TimeOnly HoraInicio { get; set; }
        public required TimeOnly HoraFin { get; set; }
        public required int CantidadAsistentes { get; set; }
        public EstadoSolicitud Estado { get; set; } = EstadoSolicitud.Pendiente;
        public List<CambioEstadoSolicitud> Historial { get; set; } = new();
        public required Cliente Cliente { get; set; }
        public required TipoEvento TipoEvento { get; set; }
        public required List<DetalleSolicitud> Detalles { get; set; } = new();
        public Contratacion? Contratacion { get; set; }
        public void CambiarEstado(EstadoSolicitud nuevo, string obs)
        {
            Estado = nuevo;
            Historial.Add(new CambioEstadoSolicitud 
            { EstadoNuevo = nuevo, 
              FechaCambio = DateTime.Now, 
              Observaciones = obs 
            });
        }
    }
}
