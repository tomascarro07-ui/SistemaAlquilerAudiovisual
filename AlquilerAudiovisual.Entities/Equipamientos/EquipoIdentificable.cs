using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public class EquipoIdentificable : Equipo
    {
        public required string NumeroSerie { get; set; }
        public required string CodigoInterno { get; set; }
        public void CambiarEstado(EstadoEquipo nuevo, string obs)
        {
            Estado = nuevo;
            Historial.Add(new CambioEstadoEquipo { EstadoNuevo = nuevo, FechaCambio = DateTime.Now, Observaciones = obs });
        }

        public override bool EstaDisponible(DateTime desde, DateTime hasta, int cantidad)
        {
            throw new NotImplementedException();
        }
    }
}
