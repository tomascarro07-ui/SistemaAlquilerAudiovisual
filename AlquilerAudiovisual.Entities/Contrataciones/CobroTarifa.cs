namespace AlquilerAudiovisual.Entities.Contrataciones
{
    public class CobroTarifa
    {
        public required int CantidadUnidades { get; set; }
        public required decimal PrecioAplicado { get; set; }
        public required Tarifa Tarifa { get; set; }
        public decimal CalcularSubtotal()
        {
            return PrecioAplicado * CantidadUnidades;
        }
    }
}
