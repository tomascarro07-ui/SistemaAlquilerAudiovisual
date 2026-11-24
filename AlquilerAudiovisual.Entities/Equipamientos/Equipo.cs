using AlquilerAudiovisual.Entities.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public abstract class Equipo
    {
        public int IdEquipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string? Descripcion { get; set; }
        public EstadoEquipo Estado { get; set; } = EstadoEquipo.Disponible;
        public List<CambioEstadoEquipo> Historial { get; set; } = new();
        public required List<Caracteristica> Caracteristicas { get; set; } = new();
        public TipoEquipamiento TipoEquipamiento { get; set; }
        public Deposito Deposito { get; set; }
        public Equipo(int idEquipo, string marca, string modelo, string? descripcion, EstadoEquipo estado, TipoEquipamiento tipoEquipamiento, Deposito deposito)
        {
            IdEquipo = idEquipo;
            Marca = marca;
            Modelo = modelo;
            Descripcion = descripcion;
            Estado = estado;
            TipoEquipamiento = tipoEquipamiento;
            Deposito = deposito;
        }
        public abstract bool EstaDisponible(DateTime desde, DateTime hasta, int cantidad);
        public abstract void CambiarEstado(EstadoEquipo nuevo, string obs);
    }
}
