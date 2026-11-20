using AlquilerAudiovisual.Entities.Clientes;
using AlquilerAudiovisual.Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerAudiovisual.Persistencia.DalArchivos
{
    public class ClienteArchivo : IDalCliente
    {
        private string _filePath = Path.Combine(Constantes.CARPETA_ARCHIVOS, $"{Constantes.ARCHIVO_CLIENTES}.json");
        
        public void ActualizarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void AgregarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void AgregarTipoCliente(TipoCliente tipo)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarClientes()
        {
            throw new NotImplementedException();
        }

        public List<TipoCliente> ListarTipoClientes()
        {
            throw new NotImplementedException();
        }

        public Cliente? ObtenerClientePorId(int idCliente)
        {
            throw new NotImplementedException();
        }

        public Cliente? ObtenerPorDocumento(string documento)
        {
            throw new NotImplementedException();
        }
    }
}
