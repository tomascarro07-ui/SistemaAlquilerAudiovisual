using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public class EquipoPorCantidad : Equipo
    {
        public int Stock { get; set; }
        public void AjustarStock(int diferencia)
        {
            if(Stock + diferencia < 0)
            {
                throw new InvalidOperationException("El stock no puede quedar en negativo");
            }
            Stock += diferencia;

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
