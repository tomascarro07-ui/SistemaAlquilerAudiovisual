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
        public override bool EstaDisponible(DateTime desde, DateTime hasta, int cantidad)
        {
            //Hacer luego
            throw new NotImplementedException();
        }
    }
}
