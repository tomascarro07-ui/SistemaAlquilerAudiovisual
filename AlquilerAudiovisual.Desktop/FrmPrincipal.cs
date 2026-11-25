using AlquilerAudiovisual.Desktop.Clientes;
using AlquilerAudiovisual.Desktop.Contrataciones;
using AlquilerAudiovisual.Desktop.Devoluciones;
using AlquilerAudiovisual.Desktop.Equipamiento;
using AlquilerAudiovisual.Desktop.Reportes;
using AlquilerAudiovisual.Desktop.Solicitudes;
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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool CerrarSesion { get; set; } = false;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void TSMI_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void TSMI_Logout_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Desea cerrar sesion?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                CerrarSesion = true;
                this.Close();
            }
        }

        #region BtnClientes
        private void TSMI_RegCli_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmRegistroClientes().ShowDialog();
            this.Show();
        }

        private void TSMI_ListCli_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmListadoClientes().ShowDialog();
            this.Show();
        }
        #endregion

        #region BtnContrataciones
        private void TSMI_ListContrat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmListadoContrataciones().ShowDialog();
            this.Close();
        }

        private void TSMI_PrepEquipamiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPreparacionEquipamiento().ShowDialog();
            this.Close();
        }

        private void TSMI_RegistroPagos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmRegistroPagos().ShowDialog();
            this.Close();
        }
        #endregion

        #region BtnDevoluciones
        private void TSMI_RegistroDevoluciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmRegistroDevolucion().ShowDialog();
            this.Close();
        }
        #endregion

        #region BtnEquipamiento
        private void TSMI_CambioEstado_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCambioEstadoEquipo().ShowDialog();
            this.Close();
        }

        private void TSMI_GestionDeposito_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmGestionDepositos().ShowDialog();
            this.Close();
        }

        private void TSMI_TipoEquipamiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmGestionTiposEquipamiento().ShowDialog();
            this.Close();
        }

        private void TSMI_ListEquipos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmListadoEquipos().ShowDialog();
            this.Close();
        }

        private void TSMI_RegistroEquipos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmRegistroEquipos().ShowDialog();
            this.Close();
        }
        #endregion

        #region BtnReportes
        private void TSMI_ConsultaReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmConsultaReportes().ShowDialog();
            this.Close();
        }
        #endregion

        #region BtnSolicitudes
        private void TSMI_ListSolicitudes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmListadoSolicitudes().ShowDialog();
            this.Close();
        }

        private void TSMI_RegistroSolicitudes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmRegistroSolicitudes().ShowDialog();
            this.Close();
        }
        #endregion

    }
}
