using AlquilerAudiovisual.Entities.Contrataciones;


namespace AlquilerAudiovisual.Persistencia.Interfaces
{
    public interface IDalContratacion
    {
        void AgregarContratacion(Contratacion contratacion);
        void ActualizarContratacion(Contratacion contratacion);
        List<Contratacion> ListarContrataciones();
        Contratacion? ObtenerContratacionPorId(int idContratacion);
        void AgregarPreparacion(Preparacion preparacion);
        void ActualizarPreparacion(Preparacion preparacion);
        List<Preparacion> ListarPreparaciones();
        void AgregarTarifa(Tarifa tarifa);
        List<Tarifa> ListarTarifas();
    }
}
