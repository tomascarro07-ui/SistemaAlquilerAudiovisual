using AlquilerAudiovisual.Entities.Equipamientos;
using AlquilerAudiovisual.Persistencia.DalDataBase;
using AlquilerAudiovisual.Persistencia.Interfaces;

namespace AlquilerAudiovisual.Dominio
{
    public class GestorEquipamiento
    {
        private readonly IDalEquipamiento dalEquipamiento = new EquipamientoDb();

        public int AgregarEquipoIdentificable(EquipoIdentificable equipo)
        {
            ValidarEquipoIdentificable(equipo);
            return dalEquipamiento.AgregarEquipoIdentificable(equipo);
        }

        public bool ActualizarEquipoIdentificable(EquipoIdentificable equipo)
        {
            if (dalEquipamiento.ObtenerEquipoPorId(equipo.IdEquipo) == null)
            {
                throw new Exception("El equipo no existe");
            }
            ValidarEquipoIdentificable(equipo);
            return dalEquipamiento.ActualizarEquipoIdentificable(equipo);
        }

        public int AgregarEquipoPorCantidad(EquipoPorCantidad equipo)
        {
            ValidarEquipoPorCantidad(equipo);
            return dalEquipamiento.AgregarEquipoPorCantidad(equipo);
        }

        public bool ActualizarEquipoPorCantidad(EquipoPorCantidad equipo)
        {
            if (dalEquipamiento.ObtenerEquipoPorId(equipo.IdEquipo) == null)
            {
                throw new Exception("El equipo no existe");
            }
            ValidarEquipoPorCantidad(equipo);
            return dalEquipamiento.ActualizarEquipoPorCantidad(equipo);
        }

        public List<Equipo> LeerEquipos()
        {
            return dalEquipamiento.LeerEquipos();
        }

        public Equipo? ObtenerEquipoPorId(int idEquipo)
        {
            return dalEquipamiento.ObtenerEquipoPorId(idEquipo);
        }

        public List<Caracteristica> LeerCaracteristicas(int idEquipo)
        {
            return dalEquipamiento.LeerCaracteristicas(idEquipo);
        }

        public int AgregarTipoEquipamiento(TipoEquipamiento tipoEquipamiento)
        {
            if (string.IsNullOrWhiteSpace(tipoEquipamiento.Nombre))
            {
                throw new Exception("El nombre del tipo de equipamiento es obligatorio");
            }
            if (dalEquipamiento.LeerTiposEquipamientos().Any(t => t.Nombre.Equals(tipoEquipamiento.Nombre, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Ya existe un tipo de equipamiento con ese nombre");
            }
            return dalEquipamiento.AgregarTipoEquipamiento(tipoEquipamiento);
        }

        public List<TipoEquipamiento> LeerTiposEquipamientos()
        {
            return dalEquipamiento.LeerTiposEquipamientos();
        }

        public int AgregarDeposito(Deposito deposito)
        {
            if (string.IsNullOrWhiteSpace(deposito.Nombre) || string.IsNullOrWhiteSpace(deposito.Direccion))
            {
                throw new Exception("El nombre y la dirección del depósito son obligatorios");
            }
            return dalEquipamiento.AgregarDeposito(deposito);
        }

        public List<Deposito> LeerDepositos()
        {
            return dalEquipamiento.LeerDepositos();
        }

        public int AgregarMantenimiento(Mantenimiento mantenimiento)
        {
            if (string.IsNullOrWhiteSpace(mantenimiento.Motivo))
            {
                throw new Exception("El motivo del mantenimiento es obligatorio");
            }
            if (string.IsNullOrWhiteSpace(mantenimiento.Tipo))
            {
                throw new Exception("El tipo de mantenimiento es obligatorio");
            }
            if (mantenimiento.Costo < 0)
            {
                throw new Exception("El costo no puede ser negativo");
            }
            if (dalEquipamiento.ObtenerEquipoPorId(mantenimiento.EquipoIdentificable.IdEquipo) is not EquipoIdentificable)
            {
                throw new Exception("El equipo del mantenimiento no existe o no es un equipo identificable");
            }
            return dalEquipamiento.AgregarMantenimiento(mantenimiento);
        }

        public List<Mantenimiento> LeerMantenimientos()
        {
            return dalEquipamiento.LeerMantenimientos();
        }

        private void ValidarEquipo(Equipo equipo)
        {
            if (string.IsNullOrWhiteSpace(equipo.Marca) || string.IsNullOrWhiteSpace(equipo.Modelo))
            {
                throw new Exception("La marca y el modelo son obligatorios");
            }
            if (equipo.TipoEquipamiento.IdTipoEquipamiento <= 0 || equipo.Deposito.IdDeposito <= 0)
            {
                throw new Exception("Debe seleccionar el tipo de equipamiento y el depósito");
            }
            if (equipo.Caracteristicas.Any(c => string.IsNullOrWhiteSpace(c.Nombre) || string.IsNullOrWhiteSpace(c.Valor)))
            {
                throw new Exception("Las características deben tener nombre y valor");
            }
        }

        private void ValidarEquipoIdentificable(EquipoIdentificable equipo)
        {
            ValidarEquipo(equipo);
            if (string.IsNullOrWhiteSpace(equipo.NumeroSerie) || string.IsNullOrWhiteSpace(equipo.CodigoInterno))
            {
                throw new Exception("El número de serie y el código interno son obligatorios");
            }
            List<EquipoIdentificable> otros = dalEquipamiento.LeerEquipos().OfType<EquipoIdentificable>().Where(e => e.IdEquipo != equipo.IdEquipo).ToList();
            if (otros.Any(e => e.NumeroSerie == equipo.NumeroSerie))
            {
                throw new Exception("Ya existe un equipo con ese número de serie");
            }
            if (otros.Any(e => e.CodigoInterno == equipo.CodigoInterno))
            {
                throw new Exception("Ya existe un equipo con ese código interno");
            }
        }

        private void ValidarEquipoPorCantidad(EquipoPorCantidad equipo)
        {
            ValidarEquipo(equipo);
            if (equipo.Stock < 0)
            {
                throw new Exception("El stock no puede ser negativo");
            }
        }
    }
}