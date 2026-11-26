using AlquilerAudiovisual.Entities.Contrataciones;
using AlquilerAudiovisual.Entities.Devoluciones;
using AlquilerAudiovisual.Entities.Enumerados;
using AlquilerAudiovisual.Persistencia.DalDataBase;
using AlquilerAudiovisual.Persistencia.Interfaces;

namespace AlquilerAudiovisual.Dominio
{
    public class GestorDevoluciones
    {
        private readonly IDalDevolucion dalDevolucion = new DevolucionDb();
        private readonly IDalContratacion dalContratacion = new ContratacionDb();

        public void AgregarDevolucion(Devolucion devolucion)
        {
            Contratacion? contratacion = dalContratacion.ObtenerContratacionPorId(devolucion.Contratacion.IdContratacion);
            if (contratacion == null)
            {
                throw new Exception("La contratación no existe");
            }
            if (contratacion.Estado != EstadoContratacion.Entregada)
            {
                throw new Exception("Solo se puede devolver una contratación que fue entregada");
            }
            if (devolucion.Fecha < contratacion.FechaInicioAlquiler)
            {
                throw new Exception("La fecha de devolución no puede ser anterior al inicio del alquiler");
            }
            if (devolucion.Verificaciones.Count == 0)
            {
                throw new Exception("La devolución debe tener al menos un equipo verificado");
            }
            foreach (VerificacionEquipo verificacion in devolucion.Verificaciones)
            {
                if (verificacion.Equipo.IdEquipo <= 0 || verificacion.Cantidad <= 0)
                {
                    throw new Exception("Cada verificación debe tener un equipo y una cantidad mayor a 0");
                }
                if (string.IsNullOrWhiteSpace(verificacion.Observaciones))
                {
                    throw new Exception("Cada verificación debe tener observaciones");
                }
                if (verificacion.Problemas.Any(p => p.IdTipoProblema <= 0))
                {
                    throw new Exception("Hay un tipo de problema que no es válido");
                }
                if (verificacion.ImportesAdicionales.Any(i => i.Monto <= 0 || string.IsNullOrWhiteSpace(i.Motivo)))
                {
                    throw new Exception("Los importes adicionales deben tener un monto mayor a 0 y un motivo");
                }
            }

            dalDevolucion.AgregarDevolucion(devolucion);

            // Con la devolución registrada, la contratación queda finalizada
            contratacion.CambiarEstado(EstadoContratacion.Finalizada, "Equipamiento devuelto");
            dalContratacion.ActualizarContratacion(contratacion);
        }

        public List<Devolucion> LeerDevoluciones()
        {
            return dalDevolucion.LeerDevoluciones();
        }

        public void AgregarTipoProblema(TipoProblema tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo.Nombre))
            {
                throw new Exception("El nombre del tipo de problema es obligatorio");
            }
            if (dalDevolucion.LeerTiposProblemas().Any(t => t.Nombre.Equals(tipo.Nombre, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Ya existe un tipo de problema con ese nombre");
            }
            dalDevolucion.AgregarTipoProblema(tipo);
        }

        public List<TipoProblema> LeerTiposProblemas()
        {
            return dalDevolucion.LeerTiposProblemas();
        }
    }
}