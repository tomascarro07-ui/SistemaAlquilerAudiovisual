using AlquilerAudiovisual.Entities.Solicitudes;
using AlquilerAudiovisual.Entities.Contrataciones;

namespace AlquilerAudiovisual.Entities.Clientes
{
    public class Cliente
    {
        public int IdCliente { set; get; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string? Correo { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; } = true;
        public TipoCliente TipoCliente { get; set; }
        public Cliente(int id, string documento, string nombre, string telefono, string? correo, string direccion, bool activo, TipoCliente tipoCliente)
        {
            IdCliente = id;
            Documento = documento;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
            Activo = activo;
            TipoCliente = tipoCliente;

        }
        public void ModificarDatos(string nombre, string telefono, string correo, string direccion)
        {
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }

        public void Desactivar()
        {
            Activo = false;
        }

        public bool TieneDatosCompletos()
        {
            if(string.IsNullOrEmpty(Documento) || 
                string.IsNullOrEmpty(Nombre) || 
                string.IsNullOrEmpty(Telefono) || 
                string.IsNullOrEmpty(Direccion))
            {
                return false;
            }

            return true;
        }
    }
}
