#region Usings
using AlquilerAudiovisual.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using AlquilerAudiovisual.Entities.Clientes; 
#endregion

namespace AlquilerAudiovisual.Desktop.Clientes
{
    public partial class FrmListadoClientes : Form
    {
        private GestorClientes _gestorClientes = new GestorClientes();
        

        public FrmListadoClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        #region BtnMenuStrip
        private void TSMI_Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMI_AgregarCli_Click(object sender, EventArgs e)
        {
            var registro = new FrmRegistroClientes();

        }
        #endregion

        public void CargarClientes()
        {
            DGV_CliList.DataSource = null;
            DGV_CliList.DataSource = _gestorClientes.ObtenerCuentas(_gestorClientes);
        }
        private void DGV_CliList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Esta a medio hacer porque no se que le tengo que cargar. 
        }

    }
}
