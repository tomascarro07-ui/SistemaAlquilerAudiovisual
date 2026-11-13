namespace AlquilerAudiovisual.Entities.Contrataciones
{
    public class CobroTarifa
    {
        public required int CantidadUnidades { get; set; }
        public required decimal PrecioAplicado { get; set; }
        public required Tarifa tarifa { get; set; }
        public decimal CalcularSubtotoal()
        {
            return PrecioAplicado * CantidadUnidades;
        }
    }
}
