using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Contrataciones
{
    public class CambioEstadoContratacion
    {
        public int IdCambioEstado { get; set; }
        public DateTime FechaCambio { get; set; } = DateTime.Now;
        public string? Observaciones { get; set; }
        public required EstadoContratacion NuevoEstado { get; set; }
    }
}
