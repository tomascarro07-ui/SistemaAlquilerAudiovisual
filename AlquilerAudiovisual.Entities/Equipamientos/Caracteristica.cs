using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerAudiovisual.Entities.Equipamientos
{
    public class Caracteristica
    {
        public int IdCaracteristica { get; set; }
        public required string Nombre { get; set; }
        public required string Valor { get; set; }
    }
}
