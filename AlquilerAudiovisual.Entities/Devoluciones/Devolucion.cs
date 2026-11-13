using AlquilerAudiovisual.Entities.Contrataciones;

namespace AlquilerAudiovisual.Entities.Devoluciones
{
    public class Devolucion
    {
        public int IdDevolucion { get; set; }
        public required DateOnly Fecha { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public DateTime Hora { get; set; } = DateTime.Now;
        public string? Lugar { get; set; }
        public required Contratacion Contratacion { get; set; }
        public List<VerificacionEquipo> Verificaciones { get; set; } = new();
    }
}
