using AlquilerAudiovisual.Entities.Contrataciones;
using AlquilerAudiovisual.Entities.Enumerados;
using AlquilerAudiovisual.Entities.Solicitudes;
using AlquilerAudiovisual.Persistencia.DalDataBase;
using AlquilerAudiovisual.Persistencia.Interfaces;

namespace AlquilerAudiovisual.Dominio
{
    public class GestorContrataciones
    {
        private readonly IDalContratacion dalContratacion = new ContratacionDb();
        private readonly IDalSolicitud dalSolicitud = new SolicitudDb();
        public int AgregarContratacion(Contratacion contratacion)
        {
            ValidarContratacion(contratacion);
            Solicitud? solicitud = dalSolicitud.ObtenerSolicitudPorId(contratacion.IdSolicitud);
            if(solicitud == null)
            {
                throw new Exception("La solicitud no existe");
            }

            if(solicitud.Estado != EstadoSolicitud.Aceptada)
            {
                throw new Exception("Solo se puede contratar una solicitud aceptada");
            }

            if(dalContratacion.LeerContrataciones().Any(c => c.IdSolicitud == contratacion.IdSolicitud))
            {
                throw new Exception("La solicitud ya tiene una contratacion");
            }
            return dalContratacion.AgregarContratacion(contratacion);
        }

        public bool ActualizarContratacion(Contratacion contratacion)
        {
            ValidarContratacion(contratacion);
            Contratacion? existente = dalContratacion.ObtenerContratacionPorId(contratacion.IdContratacion);
            if(existente != null)
            {
                throw new Exception("La contratacion no existe");
            }

            if(contratacion.IdSolicitud != existente.IdSolicitud)
            {
                throw new Exception("No se puede cambiar la solicitud de una contratación");
            }
        }
    }
}
