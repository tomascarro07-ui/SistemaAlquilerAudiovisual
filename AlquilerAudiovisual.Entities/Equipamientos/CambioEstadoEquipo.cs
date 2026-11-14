using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public class CambioEstadoEquipo
    {
        public int IdCambioEstado { get; set; }
        public DateOnly FechaCambio { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public required EstadoEquipo NuevoEstado { get; set; }
        public string? Observaciones { get; set; }
    }
}
