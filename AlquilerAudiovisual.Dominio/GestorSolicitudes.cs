using AlquilerAudiovisual.Entities.Clientes;
using AlquilerAudiovisual.Entities.Enumerados;
using AlquilerAudiovisual.Entities.Solicitudes;
using AlquilerAudiovisual.Persistencia.DalDataBase;
using AlquilerAudiovisual.Persistencia.Interfaces;

namespace AlquilerAudiovisual.Dominio
{
    public class GestorSolicitudes
    {
        private readonly IDalSolicitud dalSolicitud = new SolicitudDb();
        private readonly IDalCliente dalCliente = new ClienteDb();
        private readonly IDalContratacion dalContratacion = new ContratacionDb();

        public int AgregarSolicitud(Solicitud solicitud)
        {
            ValidarSolicitud(solicitud, true);
            if (solicitud.FechaInicio < solicitud.FechaSolicitud)
            {
                throw new Exception("La fecha de inicio no puede ser anterior a la fecha de la solicitud");
            }
            if (solicitud.Estado != EstadoSolicitud.Pendiente)
            {
                throw new Exception("Una solicitud nueva debe estar pendiente");
            }
            return dalSolicitud.AgregarSolicitud(solicitud);
        }

        public bool ActualizarSolicitud(Solicitud solicitud)
        {
            Solicitud? actual = dalSolicitud.ObtenerSolicitudPorId(solicitud.IdSolicitud);
            if (actual == null)
            {
                throw new Exception("La solicitud no existe");
            }
            if (actual.Estado == EstadoSolicitud.Rechazada || actual.Estado == EstadoSolicitud.Cancelada)
            {
                throw new Exception("No se puede modificar una solicitud rechazada o cancelada");
            }
            ValidarSolicitud(solicitud, false);

            if (solicitud.Estado != actual.Estado)
            {
                EstadoSolicitud desde = actual.Estado;
                EstadoSolicitud hasta = solicitud.Estado;
                bool transicionValida =
                    (desde == EstadoSolicitud.Pendiente && hasta != EstadoSolicitud.Pendiente) ||
                    (desde == EstadoSolicitud.Modificada && (hasta == EstadoSolicitud.Aceptada || hasta == EstadoSolicitud.Rechazada || hasta == EstadoSolicitud.Cancelada)) ||
                    (desde == EstadoSolicitud.Aceptada && hasta == EstadoSolicitud.Cancelada);
                if (!transicionValida)
                {
                    throw new Exception($"No se puede pasar de {desde} a {hasta}");
                }
                bool tieneContratacion = dalContratacion.LeerContrataciones().Any(c => c.IdSolicitud == solicitud.IdSolicitud);
                if (hasta == EstadoSolicitud.Cancelada && tieneContratacion)
                {
                    throw new Exception("No se puede cancelar una solicitud que ya tiene una contratación");
                }
            }
            return dalSolicitud.ActualizarSolicitud(solicitud);
        }

        public Solicitud? ObtenerSolicitudPorId(int idSolicitud)
        {
            return dalSolicitud.ObtenerSolicitudPorId(idSolicitud);
        }

        public List<Solicitud> LeerSolicitudes()
        {
            return dalSolicitud.LeerSolicitudes();
        }

        public int AgregarTipoEvento(TipoEvento tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo.Nombre))
            {
                throw new Exception("El nombre del tipo de evento es obligatorio");
            }
            if (dalSolicitud.LeerTiposEventos().Any(t => t.Nombre.Equals(tipo.Nombre, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Ya existe un tipo de evento con ese nombre");
            }
            return dalSolicitud.AgregarTipoEvento(tipo);
        }

        public List<TipoEvento> LeerTiposEventos()
        {
            return dalSolicitud.LeerTiposEventos();
        }

        private void ValidarSolicitud(Solicitud solicitud, bool esNueva)
        {
            if (string.IsNullOrWhiteSpace(solicitud.Ubicacion))
            {
                throw new Exception("La ubicación es obligatoria");
            }
            if (solicitud.FechaFin < solicitud.FechaInicio)
            {
                throw new Exception("La fecha de fin no puede ser anterior a la de inicio");
            }
            if (solicitud.FechaInicio == solicitud.FechaFin && solicitud.HoraFin <= solicitud.HoraInicio)
            {
                throw new Exception("Si el evento es de un solo día, la hora de fin debe ser posterior a la de inicio");
            }
            if (solicitud.CantidadAsistentes <= 0)
            {
                throw new Exception("La cantidad de asistentes debe ser mayor a 0");
            }
            if (solicitud.TipoEvento.IdTipoEvento <= 0)
            {
                throw new Exception("Debe seleccionar un tipo de evento");
            }
            Cliente? cliente = dalCliente.ObtenerClientePorId(solicitud.Cliente.IdCliente);
            if (cliente == null)
            {
                throw new Exception("El cliente no existe");
            }
            if (esNueva && !cliente.Activo)
            {
                throw new Exception("El cliente está desactivado");
            }
        }
    }
}