using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Contrataciones
{
    public class Contratacion
    {
        public int IdContratacion { get; set; }
        public DateOnly Fecha { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public required DateOnly FechaInicioAlquiler { get; set; }
        public required DateOnly FechaFinAlquiler { get; set; }
        public EstadoContratacion Estado { get; set; }
        public List<CobroTarifa>? CobrosTarifas = new();
        public List<CambioEstadoContratacion>? Historial { get; set; }
        public List<Pago>? Pagos { get; set; } = new();
        public List<ImporteAdicional>? ImportesAdicionales { get; set; } = new();
        public List<EquipoContratado>? EquiposContratados { get; set; }
        public decimal CalcularImporteTotal()
        {
            decimal tarifas = CobrosTarifas.Sum(t => t.CalcularSubtotal());
            decimal adicionales = ImportesAdicionales.Sum(i => i.Monto);
            return tarifas + adicionales;
        }
        public decimal CalcularSaldoPendiente()
        {
            decimal pagado = Pagos.Sum(p => p.Importe);
            return CalcularImporteTotal() - pagado;
        }
        public void CambiarEstado(EstadoContratacion nuevo, string obs) 
        {
            Estado = nuevo;
            Historial.Add(new CambioEstadoContratacion { NuevoEstado = nuevo, FechaCambio = DateTime.Now, Observaciones = obs });
        }
    }
}
