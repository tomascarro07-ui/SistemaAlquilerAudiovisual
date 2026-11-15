using AlquilerAudiovisual.Entities.Solicitudes;
using AlquilerAudiovisual.Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerAudiovisual.Dominio
{
    public class GestorSolicitudes : IDalSolicitud
    {
        public void ActualizarSolicitud(Solicitud solicitud)
        {
            throw new NotImplementedException();
        }

        public void AgregarSolicitud(Solicitud solicitud)
        {
            throw new NotImplementedException();
        }

        public void AgregarTipoEvento(TipoEvento tipo)
        {
            throw new NotImplementedException();
        }

        public List<Solicitud> ListarSolicitudes()
        {
            throw new NotImplementedException();
        }

        public List<TipoEvento> ListarTiposEventos()
        {
            throw new NotImplementedException();
        }

        public Solicitud? ObtenerSolicitudPorId(int idSolicitud)
        {
            throw new NotImplementedException();
        }
    }
}
