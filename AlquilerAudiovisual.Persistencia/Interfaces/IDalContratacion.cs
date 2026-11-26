using AlquilerAudiovisual.Entities.Contrataciones;


namespace AlquilerAudiovisual.Persistencia.Interfaces
{
    public interface IDalContratacion
    {
        int AgregarContratacion(Contratacion contratacion);
        bool ActualizarContratacion(Contratacion contratacion);
        List<Contratacion> LeerContrataciones();
        Contratacion? ObtenerContratacionPorId(int idContratacion);
        int AgregarPreparacion(Preparacion preparacion);
        bool ActualizarPreparacion(Preparacion preparacion);
        List<Preparacion> LeerPreparaciones();
        int AgregarTarifa(Tarifa tarifa);
        List<Tarifa> LeerTarifas();
    }
}
