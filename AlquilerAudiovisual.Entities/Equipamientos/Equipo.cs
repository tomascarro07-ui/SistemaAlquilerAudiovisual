using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public abstract class Equipo
    {
        public int IdEquipo { get; set; }
        public required string Marca { get; set; }
        public required string Modelo { get; set; }
        public string? Descripcion { get; set; }
        public required TipoEquipamiento TipoEquipamiento { get; set; }
        public List<CambioEstadoEquipo> Historial { get; set; } = new();
        public abstract bool EstaDisponible(DateTime desde, DateTime hasta, int cantidad);
    }
}
