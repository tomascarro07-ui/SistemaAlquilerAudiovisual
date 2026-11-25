using AlquilerAudiovisual.Entities.Enumerados;

namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public class EquipoPorCantidad : Equipo
    {
        public int Stock { get; set; }
        public EquipoPorCantidad(int idEquipo, string marca, string modelo, string? descripcion, EstadoEquipo estado, List<Caracteristica> caracteristicas, TipoEquipamiento tipoEquipamiento, Deposito deposito, int stock)
            :base(idEquipo, marca, modelo, descripcion, estado, caracteristicas, tipoEquipamiento, deposito)
        {
            Stock = stock;
        }
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
