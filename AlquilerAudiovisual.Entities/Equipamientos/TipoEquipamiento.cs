namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public class TipoEquipamiento
    {
        public int IdTipoEquipamiento { get; set; }
        public required string Nombre { get; set; }
        public string? Descripcion { get; set; }
    }
}
