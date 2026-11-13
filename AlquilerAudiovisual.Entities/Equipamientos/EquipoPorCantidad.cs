namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public class EquipoPorCantidad : Equipo
    {
        public int Stock { get; set; }
        public bool AjustarStock()
        {
            throw new NotImplementedException();
        }
        public override bool EstaDisponible(DateTime desde, DateTime hasta, int cantidad)
        {
            throw new NotImplementedException();
        }
    }
}
