namespace AlquilerAudiovisual.Entities.Solicitudes
{
    public class TipoEvento
    {
        public int IdTipoEvento { get; set; }
        public required string Nombre { get; set; }
        public override string ToString() => Nombre;
    }
}
