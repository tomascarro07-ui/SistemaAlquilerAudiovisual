using AlquilerAudiovisual.Entities.Contrataciones;


namespace AlquilerAudiovisual.Persistencia.Interfaces
{
    public interface IDalContratacion
    {
        int AgregarContratacion(Contratacion contratacion);
        bool ActualizarContratacion(Contratacion contratacion);
        List<Contratacion> ListarContrataciones();
        Contratacion? ObtenerContratacionPorId(int idContratacion);
        int AgregarPreparacion(Preparacion preparacion);
        bool ActualizarPreparacion(Preparacion preparacion);
        List<Preparacion> ListarPreparaciones();
        int AgregarTarifa(Tarifa tarifa);
        List<Tarifa> ListarTarifas();
    }
}
