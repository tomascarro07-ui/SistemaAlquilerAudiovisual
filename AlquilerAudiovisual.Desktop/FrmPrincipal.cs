using AlquilerAudiovisual.Desktop.Clientes;
using AlquilerAudiovisual.Desktop.Equipamiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlquilerAudiovisual.Desktop
{
    public partial class FrmPrincipal : Form
    {
        private Form? formActual;

        private void AbrirEnPanel(Form formulario)
        {
            formActual?.Close();          // cierra el que estaba abierto
            formActual = formulario;
            formulario.TopLevel = false;  // lo vuelve "hijo" en vez de ventana
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();
        }
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        #region Cliente
        private void TSMI_ListCli_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_CliRegistro_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Solicitudes
        private void TSMI_SolicitudesList_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_RegistrarSolicitud_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Contrataciones
        private void TSMI_ContratacionesList_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_PrepEquipo_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_RegistroPagos_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Equipamiento
        private void TSMI_EquiposList_Click(object sender, EventArgs e)
        {
            
        }

        private void TSMI_RegistroEquipo_Click(object sender, EventArgs e)
        {
            FrmRegistroEquipos frmRegistroEquipos = new FrmRegistroEquipos();
            frmRegistroEquipos.Show();
        }

        private void TSMI_Deposito_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_TipoEquip_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_CambioEstado_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Devoluciones
        private void TSMI_RegistroDevoluciones_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Reportes
        private void TSMI_ConsultaReportes_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Salir
        private void TSMI_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        } 
        #endregion
    }
}
