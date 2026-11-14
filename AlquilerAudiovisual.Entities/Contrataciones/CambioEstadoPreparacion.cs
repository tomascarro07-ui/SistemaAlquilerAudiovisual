using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Contrataciones
{
    public class CambioEstadoPreparacion
    {
        public int IdCambioEstado { get; set; }
        public DateOnly FechaCambio { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public string? Observaciones { get; set; }
        public required EstadoPreparacion NuevoEstado { get; set; }
    }
}
