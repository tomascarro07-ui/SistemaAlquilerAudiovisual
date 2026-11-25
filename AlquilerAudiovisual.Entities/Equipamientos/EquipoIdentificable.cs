using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public class EquipoIdentificable : Equipo
    {
        public string NumeroSerie { get; set; }
        public string CodigoInterno { get; set; }
        public EquipoIdentificable(int idEquipo, string marca, string modelo, string? descripcion, EstadoEquipo estado, List<Caracteristica> caracteristicas, TipoEquipamiento tipoEquipamiento, Deposito deposito, string numeroSerie, string codigoInterno)
            :base(idEquipo, marca, modelo, descripcion, estado, caracteristicas, tipoEquipamiento, deposito)
        {
            NumeroSerie = numeroSerie;
            CodigoInterno = codigoInterno;
        }
        public override void CambiarEstado(EstadoEquipo nuevo, string obs)
        {
            Estado = nuevo;
            Historial.Add(new CambioEstadoEquipo { NuevoEstado = nuevo, FechaCambio = DateTime.Now, Observaciones = obs });
        }

        public override bool EstaDisponible(DateTime desde, DateTime hasta, int cantidad)
        {
            //Hacer luego
            throw new NotImplementedException();
        }
    }
}
