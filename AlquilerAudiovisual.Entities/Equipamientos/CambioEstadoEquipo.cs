using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public class CambioEstadoEquipo
    {
        public int IdCambioEstado { get; set; }
        public required DateTime FechaCambio { get; set; } = DateTime.Now;
        public required EstadoEquipo EstadoNuevo { get; set; }
        public string? Observaciones { get; set; }
    }
}
