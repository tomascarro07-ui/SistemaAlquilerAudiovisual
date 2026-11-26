using AlquilerAudiovisual.Entities.Equipamientos;
using Microsoft.Data.SqlClient;

namespace AlquilerAudiovisual.Persistencia.Interfaces
{
    public interface IDalEquipamiento
    {
        bool ActualizarEquipoIdentificable(EquipoIdentificable equipo);
        bool ActualizarEquipoPorCantidad(EquipoPorCantidad equipo);
        List<Caracteristica> LeerCaracteristicas(int idEquipo); Equipo? ObtenerEquipoPorId(int idEquipo);
        List<Equipo> LeerEquipos();
        int AgregarTipoEquipamiento(TipoEquipamiento tipoEquipamiento);
        List<TipoEquipamiento> LeerTiposEquipamientos();
        int AgregarDeposito(Deposito deposito);
        List<Deposito> LeerDepositos();
        int AgregarMantenimiento(Mantenimiento mantenimiento);
        List<Mantenimiento> LeerMantenimientos();
        int AgregarEquipoIdentificable(EquipoIdentificable equipo);
        int AgregarEquipoPorCantidad(EquipoPorCantidad equipo);
    }
}
