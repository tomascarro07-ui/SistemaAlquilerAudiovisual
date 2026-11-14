using AlquilerAudiovisual.Entities.Equipamientos;

namespace AlquilerAudiovisual.Persistencia.Interfaces
{
    public interface IDalEquipamiento
    {
        void AgregarEquipo(Equipo equipo);
        void ActualizarEquipo(Equipo equipo);
        Equipo? ObtenerEquipoPorId(int idEquipo);
        List<Equipo> ListarEquipos();
        void AgregarTipoEquipamiento(TipoEquipamiento tipoEquipamiento);
        List<TipoEquipamiento> ListarTiposEquipamientos();
        void AgregarDeposito(Deposito deposito);
        List<Deposito> ListarDepositos();
        void AgregarMantenimiento(Mantenimiento mantenimiento);
        List<Mantenimiento> ListarMantenimientos();
    }
}
