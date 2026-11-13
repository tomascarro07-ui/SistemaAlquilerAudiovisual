using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerAudiovisual.Entities.Devoluciones
{
    public class TipoProblema
    {
        public int IdTipoProblema { get; set; }
        public required string Nombre { get; set; }
        public string? Descripcion { get; set; }
    }
}
