using AlquilerAudiovisual.Entities.Devoluciones;
using AlquilerAudiovisual.Entities.Equipamientos;
using AlquilerAudiovisual.Entities.Solicitudes;


namespace AlquilerAudiovisual.Persistencia.Interfaces
{
    public interface IDalDevolucion
    {
        void AgregarDevolucion(Devolucion devolucion);
        List<Devolucion> LeerDevoluciones();
        void AgregarTipoProblema(TipoProblema tipo);
        List<TipoProblema> LeerTiposProblemas();
    }
}
