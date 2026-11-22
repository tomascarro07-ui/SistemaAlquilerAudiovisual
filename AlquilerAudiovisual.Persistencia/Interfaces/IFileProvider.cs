using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerAudiovisual.Persistencia.Interfaces
{
    public interface IDalSolicitud
    {
        List<T> LeerRegistros<T>(string filePath);
        void GuardarRegistros<T>(string filePath, List<T> registros);
    }
}
