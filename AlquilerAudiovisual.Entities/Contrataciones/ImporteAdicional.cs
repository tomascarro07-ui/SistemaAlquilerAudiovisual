namespace AlquilerAudiovisual.Entities.Contrataciones
{
    public class ImporteAdicional
    {
        public int IdImporte { get; set; }
        public required decimal Monto { get; set; }
        public required string Motivo { get; set; }
        public DateOnly Fecha { get; set; } = DateOnly.FromDateTime(DateTime.Today);
    }
}
