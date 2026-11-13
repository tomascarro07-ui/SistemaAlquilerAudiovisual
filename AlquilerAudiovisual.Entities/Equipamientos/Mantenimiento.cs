namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public class Mantenimiento
    {
        public int IdMantenimiento { get; set; }
        public required DateOnly Fecha { get; set; }
        public required string Motivo { get; set; }
        public required string Resultado { get; set; }
        public required string Tipo { get; set; }
        public required string TrabajoRealizado { get; set; }
        public required decimal Costo { get; set; }
        public required EquipoIdentificable EquipoIdentificable { get; set; }
        public required Contratacion Contratacion { get; set; }
    }
}
