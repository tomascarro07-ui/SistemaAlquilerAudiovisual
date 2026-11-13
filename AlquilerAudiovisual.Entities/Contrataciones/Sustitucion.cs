using AlquilerAudiovisual.Entities.Equipamientos;

namespace AlquilerAudiovisual.Entities.Contrataciones
{
    public class Sustitucion
    {
        public int IdSustitucion { get; set; }
        public required DateOnly Fecha { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public required string Motivo { get; set; }
        public required Equipo EquipoRetirado { get; set; }
        public required Equipo EquipoIncorporado { get; set; }
    }
}
