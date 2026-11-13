using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public class CambioEstadoEquipo
    {
        public int IdCambioEstado { get; set; }
        public required DateOnly FechaCambio { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public required EstadoEquipo EstadoNuevo { get; set; }
        public string? Observaciones { get; set; }
    }
}
