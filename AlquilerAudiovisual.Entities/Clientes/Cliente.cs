using AlquilerAudiovisual.Entities.Solicitudes;
using AlquilerAudiovisual.Entities.Contrataciones;

namespace AlquilerAudiovisual.Entities.Clientes
{
    public class Cliente
    {
        public int IdCliente { set; get; }
        public required string Documento { get; set; }
        public required string Nombre { get; set; }
        public required string Telefono { get; set; }
        public string? Correo { get; set; }
        public required string Direccion { get; set; }
        public bool Activo { get; set; } = true;
        public required TipoCliente TipoCliente { get; set; }

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
