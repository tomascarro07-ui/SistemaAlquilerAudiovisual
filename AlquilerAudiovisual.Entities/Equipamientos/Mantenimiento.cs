using AlquilerAudiovisual.Entities.Contrataciones;

namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public class Mantenimiento
    {
        public int IdMantenimiento { get; set; }
        public required DateOnly Fecha { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public required string Motivo { get; set; }
        public string? Resultado { get; set; }
        public required string Tipo { get; set; }
        public string? TrabajoRealizado { get; set; }
        public decimal Costo { get; set; }
        public required EquipoIdentificable EquipoIdentificable { get; set; }
        public Contratacion? Contratacion { get; set; }
    }
}
