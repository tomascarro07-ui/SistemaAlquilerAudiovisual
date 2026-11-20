using AlquilerAudiovisual.Entities.Enumerados;
using AlquilerAudiovisual.Entities.Equipamientos;
using AlquilerAudiovisual.Entities.Contrataciones;

namespace AlquilerAudiovisual.Entities.Devoluciones
{
    public class VerificacionEquipo
    {
        public int IdVerificacion { get; set; }
        public required string Observaciones { get; set; }
        public int Cantidad { get; set; }
        public required EstadoDevolucion Estado { get; set; }
        public List<ImporteAdicional> ImportesAdicionales { get; set; } = new();
        public List<TipoProblema> Problemas { get; set; } = new();
        public required Equipo Equipo { get; set; }
    }
}
