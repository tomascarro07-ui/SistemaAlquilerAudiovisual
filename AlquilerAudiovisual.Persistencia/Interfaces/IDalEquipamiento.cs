using AlquilerAudiovisual.Entities.Equipamientos;
using Microsoft.Data.SqlClient;

namespace AlquilerAudiovisual.Persistencia.Interfaces
{
    public interface IDalEquipamiento
    {
        bool ActualizarEquipoIdentificable(EquipoIdentificable equipo);
        bool ActualizarEquipoPorCantidad(EquipoPorCantidad equipo);
        List<Caracteristica> ListarCaracteristicas(int idEquipo); Equipo? ObtenerEquipoPorId(int idEquipo);
        List<Equipo> ListarEquipos();
        int AgregarTipoEquipamiento(TipoEquipamiento tipoEquipamiento);
        List<TipoEquipamiento> ListarTiposEquipamientos();
        int AgregarDeposito(Deposito deposito);
        List<Deposito> ListarDepositos();
        int AgregarMantenimiento(Mantenimiento mantenimiento);
        List<Mantenimiento> ListarMantenimientos();
        int AgregarEquipoIdentificable(EquipoIdentificable equipo);
        int AgregarEquipoPorCantidad(EquipoPorCantidad equipo);
    }
}
