using AlquilerAudiovisual.Entities.Equipamientos;

namespace AlquilerAudiovisual.Entities.Solicitudes
{
    public class DetalleSolicitud
    {
        public required int Cantidad { get; set; }
        public required TipoEquipamiento TipoEquipamiento { get; set; }
    }
}
