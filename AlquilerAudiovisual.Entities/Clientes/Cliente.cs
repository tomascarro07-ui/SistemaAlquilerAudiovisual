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
        public required TipoCliente TipoCliente { get; set; }
        public required TipoEvento TipoEvento { get; set; }
        public string? Correo { get; set; }
        public required string Direccion { get; set; }
        public bool Activo { get; set; } = true;

        public List<Solicitud> Solicitudes { get; set; }
        public List<Contratacion> Contrataciones { get; set; }
        //Falta ModificarDatos();
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
