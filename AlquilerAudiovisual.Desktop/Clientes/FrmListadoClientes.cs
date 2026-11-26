using AlquilerAudiovisual.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlquilerAudiovisual.Desktop.Clientes
{
    public partial class FrmListadoClientes : Form
    {
        private GestorClientes _gestorClientes = new GestorClientes()

        public FrmListadoClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void TSMI_Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMI_AgregarCli_Click(object sender, EventArgs e)
        {
            var frmRegistro = new FrmRegistroClientes();
            frmRegistro.MdiParent = this;
            frmRegistro.Show();
        }

        public void CargarClientes()
        {
            DGV_CliList.DataSource = null;
            DGV_CliList.DataSource = _gestorClientes./*ObtenerCuentas*/(_gestorClientes);
        }
        private void DGV_CliList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Esta a medio hacer porque no se que le tengo que cargar. 
        }

    }
}
