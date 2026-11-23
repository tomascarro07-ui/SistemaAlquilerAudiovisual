using AlquilerAudiovisual.Entities.Clientes;
using AlquilerAudiovisual.Entities.Enumerados;
using AlquilerAudiovisual.Entities.Contrataciones;

namespace AlquilerAudiovisual.Entities.Solicitudes
{
    public class Solicitud
    {
        public int IdSolicitud { get; set; }
        public DateOnly FechaSolicitud { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public string Ubicacion { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFin { get; set; }
        public int CantidadAsistentes { get; set; }
        public EstadoSolicitud Estado { get; set; } = EstadoSolicitud.Pendiente;
        public List<CambioEstadoSolicitud> Historial { get; set; } = new();
        public Cliente Cliente { get; set; }
        public TipoEvento TipoEvento { get; set; }
        public List<DetalleSolicitud> Detalles { get; set; } = new();
        public Contratacion? Contratacion { get; set; }
        public Solicitud(int idSolicitud, DateOnly fechaSolicitud, string ubicacion, DateOnly fechaInicio, DateOnly fechaFin, TimeOnly horaInicio, TimeOnly horaFin, int cantidadAsistentes, EstadoSolicitud estado, Cliente cliente, TipoEvento tipoEvento)
        {
            IdSolicitud = idSolicitud;
            FechaSolicitud = fechaSolicitud;
            Ubicacion = ubicacion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            CantidadAsistentes = cantidadAsistentes;
            Estado = estado;
            Cliente = cliente;
            TipoEvento = tipoEvento;
        }
        public void CambiarEstado(EstadoSolicitud nuevo, string obs)
        {
            Estado = nuevo;
            Historial.Add(new CambioEstadoSolicitud 
            {
              NuevoEstado = nuevo, 
              FechaCambio = DateTime.Now, 
              Observaciones = obs 
            });
        }
    }
}
