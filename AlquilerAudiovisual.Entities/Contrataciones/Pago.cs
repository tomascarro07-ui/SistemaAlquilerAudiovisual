namespace AlquilerAudiovisual.Entities.Contrataciones
{
    public class Pago
    {
        public int IdPago { get; set; }
        public required DateOnly Fecha { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public required decimal Importe { get; set; }
        public required string Metodo { get; set; }
    }
}
