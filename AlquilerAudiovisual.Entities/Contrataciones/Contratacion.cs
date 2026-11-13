using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Contrataciones
{
    public class Contratacion
    {
        public int IdContratacion { get; set; }
        public required DateOnly Fecha { get; set; }
        public required DateOnly FechaInicioAlquiler { get; set; }
        public DateOnly FechaFinAlquiler { get; set; }
        public required EstadoContratacion Estado { get; set; }
        public required List<CambioEstadoContratacion> Historial { get; set; }
        public required Pago Pago { get; set; }
        public ImporteAdicional ImporteAdicional { get; set; }

        public void CalcularImporteTotal()
        {
            
        }
        public void CalcularSaldoPendiente()
        {

        }
        public void CambiarEstado(EstadoContratacion nuevo, string obs) 
        {
            Estado = nuevo;
            Historial.Add(new CambioEstadoContratacion { NuevoEstado = nuevo, FechaCambio = DateTime.Now, Observaciones = obs });
        }
    }
}
