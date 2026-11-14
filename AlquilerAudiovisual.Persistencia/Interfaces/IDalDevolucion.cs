using AlquilerAudiovisual.Entities.Devoluciones;


namespace AlquilerAudiovisual.Persistencia.Interfaces
{
    public interface IDalDevolucion
    {
        void AgregarDevolucion(Devolucion devolucion);
        List<Devolucion> ListarDevoluciones();
        List<TipoProblema> ListarTiposProblemas();
    }
}
