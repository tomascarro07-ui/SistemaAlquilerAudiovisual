using AlquilerAudiovisual.Entities.Clientes;
using AlquilerAudiovisual.Entities.Solicitudes;
using AlquilerAudiovisual.Entities.Equipamientos;

namespace AlquilerAudiovisual.Entities.Contrataciones
{
    public class Tarifa
    {
        public int IdTarifa { get; set; }
        public required int DiasContrato { get; set; }
        public required DateOnly FechaInicio { get; set; }
        public DateOnly? FechaFin { get; set; }
        public required decimal PrecioVigente { get; set; }
        public required TipoEvento TipoEvento { get; set; }
        public required TipoCliente TipoCliente { get; set; }
        public required TipoEquipamiento TipoEquipamiento { get; set; }

    }
}
