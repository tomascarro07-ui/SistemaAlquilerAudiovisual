using AlquilerAudiovisual.Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace AlquilerAudiovisual.Persistencia.FileProviders
{
    public class JsonFileProvider : IDalSolicitud
    {
        public void GuardarRegistros<T>(string filePath, List<T> registros)
        {
            var json = JsonSerializer.Serialize(registros);
            File.WriteAllText(filePath, json);
        }

        public List<T> LeerRegistros<T>(string filePath)
        {
            if(!File.Exists(filePath))
            {
                return [];
            }
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<T>>(json) ?? [];
        }
    }
}
