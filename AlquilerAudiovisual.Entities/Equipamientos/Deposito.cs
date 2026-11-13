namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public class Deposito
    {
        public int IdDeposito { get; set; }
        public required string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public required List<Equipo> Equipos { get; set; } = new();
    }
}
