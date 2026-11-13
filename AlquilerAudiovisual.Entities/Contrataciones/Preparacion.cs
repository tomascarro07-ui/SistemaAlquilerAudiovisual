using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Contrataciones
{
    public class Preparacion
    {
        public int IdPreparacion { get; set; }
        public DateOnly Fecha { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public TimeOnly Hora { get; set; } = TimeOnly.FromDateTime(DateTime.Now);
        public string? Observaciones { get; set; }
        public required Contratacion Contratacion { get; set; }
        public required EstadoPreparacion Estado { get; set; } = EstadoPreparacion.EnCurso;
        public List<CambioEstadoContratacion>? Historial { get; set; }
        public List<Sustitucion>? Sustituciones { get; set; }
        public List<SeleccionEquipo>? Selecciones { get; set; }
        public void AsignarUnidad()
        {
            //Hacer luego
        }
        public void SustituirUnidad()
        {
            //Hacer luego
        }

        public void CambiarEstado()
        {
            //Hacer luego
        }
    }
}
