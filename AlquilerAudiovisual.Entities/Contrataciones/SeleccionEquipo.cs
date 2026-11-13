using AlquilerAudiovisual.Entities.Equipamientos;

namespace AlquilerAudiovisual.Entities.Contrataciones
{
    public class SeleccionEquipo
    {
        public required int Cantidad { get; set; }
        public required Equipo Equipo { get; set; }
    }
}
