using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Contrataciones
{
    public class CambioEstadoPreparacion
    {
        public int IdCambioEstado { get; set; }
        public required DateOnly FechaCambio { get; set; }
        public string? Observaciones { get; set; }
        public required EstadoPreparacion NuevoEstado { get; set; }
    }
}
