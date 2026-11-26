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
        private readonly IDalDevolucion dalDevolucion = new DevolucionDb();

        public int AgregarContratacion(Contratacion contratacion)
        {
            if (contratacion.FechaFinAlquiler < contratacion.FechaInicioAlquiler)
            {
                throw new Exception("La fecha de fin del alquiler no puede ser anterior a la de inicio");
            }
            Solicitud? solicitud = dalSolicitud.ObtenerSolicitudPorId(contratacion.IdSolicitud);
            if (solicitud == null)
            {
                throw new Exception("La solicitud no existe");
            }
            if (solicitud.Estado != EstadoSolicitud.Aceptada)
            {
                throw new Exception("Solo se puede contratar una solicitud aceptada");
            }
            if (dalContratacion.LeerContrataciones().Any(c => c.IdSolicitud == contratacion.IdSolicitud))
            {
                throw new Exception("La solicitud ya tiene una contratación");
            }
            if (contratacion.Estado != EstadoContratacion.PendientePreparacion)
            {
                throw new Exception("Una contratación nueva debe estar pendiente de preparación");
            }
            return dalContratacion.AgregarContratacion(contratacion);
        }

        public bool ActualizarContratacion(Contratacion contratacion)
        {
            if (contratacion.FechaFinAlquiler < contratacion.FechaInicioAlquiler)
            {
                throw new Exception("La fecha de fin del alquiler no puede ser anterior a la de inicio");
            }
            Contratacion? actual = dalContratacion.ObtenerContratacionPorId(contratacion.IdContratacion);
            if (actual == null)
            {
                throw new Exception("La contratación no existe");
            }
            if (contratacion.IdSolicitud != actual.IdSolicitud)
            {
                throw new Exception("No se puede cambiar la solicitud de una contratación");
            }
            bool cambioFechas = contratacion.FechaInicioAlquiler != actual.FechaInicioAlquiler || contratacion.FechaFinAlquiler != actual.FechaFinAlquiler;
            if (cambioFechas && actual.Estado != EstadoContratacion.PendientePreparacion)
            {
                throw new Exception("Solo se pueden modificar las fechas de una contratación pendiente de preparación");
            }

            if (contratacion.Estado != actual.Estado)
            {
                EstadoContratacion desde = actual.Estado;
                EstadoContratacion hasta = contratacion.Estado;
                bool transicionValida =
                    (desde == EstadoContratacion.PendientePreparacion && hasta == EstadoContratacion.EnPreparacion) ||
                    (desde == EstadoContratacion.EnPreparacion && (hasta == EstadoContratacion.Entregada || hasta == EstadoContratacion.PendientePreparacion)) ||
                    (desde == EstadoContratacion.Entregada && hasta == EstadoContratacion.Finalizada);
                if (!transicionValida)
                {
                    throw new Exception($"No se puede pasar de {desde} a {hasta}");
                }
                bool preparacionCompletada = dalContratacion.LeerPreparaciones()
                    .Any(p => p.Contratacion.IdContratacion == contratacion.IdContratacion && p.Estado == EstadoPreparacion.Completada);
                if (hasta == EstadoContratacion.Entregada && !preparacionCompletada)
                {
                    throw new Exception("La preparación del equipamiento todavía no está completada");
                }
                if (hasta == EstadoContratacion.Finalizada && !dalDevolucion.LeerDevoluciones().Any(d => d.Contratacion.IdContratacion == contratacion.IdContratacion))
                {
                    throw new Exception("No se puede finalizar una contratación sin registrar su devolución");
                }
            }
            return dalContratacion.ActualizarContratacion(contratacion);
        }

        public List<Contratacion> LeerContrataciones()
        {
            return dalContratacion.LeerContrataciones();
        }

        public Contratacion? ObtenerContratacionPorId(int idContratacion)
        {
            return dalContratacion.ObtenerContratacionPorId(idContratacion);
        }

        public int AgregarPreparacion(Preparacion preparacion)
        {
            Contratacion? contratacion = dalContratacion.ObtenerContratacionPorId(preparacion.Contratacion.IdContratacion);
            if (contratacion == null)
            {
                throw new Exception("La contratación no existe");
            }
            if (contratacion.Estado != EstadoContratacion.PendientePreparacion)
            {
                throw new Exception("Solo se puede preparar una contratación pendiente de preparación");
            }
            if (preparacion.Estado != EstadoPreparacion.EnCurso)
            {
                throw new Exception("Una preparación nueva debe estar en curso");
            }
            int idPreparacion = dalContratacion.AgregarPreparacion(preparacion);
            contratacion.CambiarEstado(EstadoContratacion.EnPreparacion, "Preparación iniciada");
            dalContratacion.ActualizarContratacion(contratacion);
            return idPreparacion;
        }

        public bool ActualizarPreparacion(Preparacion preparacion)
        {
            Preparacion? actual = dalContratacion.LeerPreparaciones().FirstOrDefault(p => p.IdPreparacion == preparacion.IdPreparacion);
            if (actual == null)
            {
                throw new Exception("La preparación no existe");
            }
            if (preparacion.Contratacion.IdContratacion != actual.Contratacion.IdContratacion)
            {
                throw new Exception("No se puede cambiar la contratación de una preparación");
            }
            if (actual.Estado != EstadoPreparacion.EnCurso)
            {
                throw new Exception("Solo se puede modificar una preparación en curso");
            }
            bool actualizada = dalContratacion.ActualizarPreparacion(preparacion);

            if (preparacion.Estado == EstadoPreparacion.Cancelada)
            {
                Contratacion? contratacion = dalContratacion.ObtenerContratacionPorId(actual.Contratacion.IdContratacion);
                if (contratacion != null && contratacion.Estado == EstadoContratacion.EnPreparacion)
                {
                    contratacion.CambiarEstado(EstadoContratacion.PendientePreparacion, "Preparación cancelada");
                    dalContratacion.ActualizarContratacion(contratacion);
                }
            }
            return actualizada;
        }

        public List<Preparacion> LeerPreparaciones()
        {
            return dalContratacion.LeerPreparaciones();
        }

        public int AgregarTarifa(Tarifa tarifa)
        {
            if (tarifa.DiasContrato <= 0 || tarifa.PrecioVigente <= 0)
            {
                throw new Exception("Los días de contrato y el precio deben ser mayores a 0");
            }
            if (tarifa.FechaFin < tarifa.FechaInicio)
            {
                throw new Exception("La fecha de fin no puede ser anterior a la de inicio");
            }
            if (tarifa.TipoEvento.IdTipoEvento <= 0 || tarifa.TipoCliente.IdTipoCliente <= 0 || tarifa.TipoEquipamiento.IdTipoEquipamiento <= 0)
            {
                throw new Exception("Debe seleccionar el tipo de evento, de cliente y de equipamiento");
            }
            bool seSuperpone = dalContratacion.LeerTarifas().Any(t =>
                t.TipoEvento.IdTipoEvento == tarifa.TipoEvento.IdTipoEvento &&
                t.TipoCliente.IdTipoCliente == tarifa.TipoCliente.IdTipoCliente &&
                t.TipoEquipamiento.IdTipoEquipamiento == tarifa.TipoEquipamiento.IdTipoEquipamiento &&
                t.DiasContrato == tarifa.DiasContrato &&
                t.FechaInicio <= tarifa.FechaFin &&
                tarifa.FechaInicio <= t.FechaFin);
            if (seSuperpone)
            {
                throw new Exception("Ya existe una tarifa para ese evento, cliente, equipamiento y días en ese período");
            }
            return dalContratacion.AgregarTarifa(tarifa);
        }

        public List<Tarifa> LeerTarifas()
        {
            return dalContratacion.LeerTarifas();
        }
    }
}