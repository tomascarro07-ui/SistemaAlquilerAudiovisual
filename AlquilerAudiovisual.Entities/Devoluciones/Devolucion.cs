using AlquilerAudiovisual.Entities.Contrataciones;

namespace AlquilerAudiovisual.Entities.Devoluciones
{
    public class Devolucion
    {
        public int IdDevolucion { get; set; }
        public DateOnly Fecha { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public TimeOnly Hora { get; set; } = TimeOnly.FromDateTime(DateTime.Now);
        public string? Lugar { get; set; }
        public required Contratacion Contratacion { get; set; }
        public List<VerificacionEquipo> Verificaciones { get; set; } = new();
    }
}
