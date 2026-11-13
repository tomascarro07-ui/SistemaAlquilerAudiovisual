using AlquilerAudiovisual.Entities.Enumerados;
using AlquilerAudiovisual.Entities.Equipamientos;
using AlquilerAudiovisual.Entities.Contrataciones;

namespace AlquilerAudiovisual.Entities.Devoluciones
{
    public class VerificacionEquipo
    {
        public required string Observaciones { get; set; }
        public int Cantidad { get; set; }
        public required List<EstadoDevolucion> Estado { get; set; }
        public List<ImporteAdicional>? ImportesAdicionales { get; set; }
        public List<TipoProblema>? Problemas { get; set; }
        public required Equipo Equipo { get; set; }
    }
}
