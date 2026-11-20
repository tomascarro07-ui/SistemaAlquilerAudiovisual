using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public class CambioEstadoEquipo
    {
        public int IdCambioEstado { get; set; }
        public DateTime FechaCambio { get; set; } = DateTime.Now;
        public required EstadoEquipo NuevoEstado { get; set; }
        public string? Observaciones { get; set; }
    }
}
