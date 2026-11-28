using AlquilerAudiovisual.Dominio;
using AlquilerAudiovisual.Entities.Solicitudes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlquilerAudiovisual.Desktop.Solicitudes
{
    public partial class FrmListadoSolicitudes : Form
    {
        private GestorSolicitudes gestorSolicitudes = new GestorSolicitudes();
        public FrmListadoSolicitudes()
        {
            InitializeComponent();
            CargarSolicitudes();
        }

        private void CargarSolicitudes()
        {
            dgvSolicitudes.DataSource = null;
            dgvSolicitudes.DataSource = gestorSolicitudes.LeerSolicitudes();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (ParentForm is FrmPrincipal principal)
            {
                principal.AbrirEnPanel(new FrmRegistroSolicitudes());
            }
        }

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            if (!IsSelectedRowValid())
            {
                MessageBox.Show("Por favor seleccione una solicitud para editar.");
                return;
            }
            if (dgvSolicitudes.SelectedRows[0].DataBoundItem is not Solicitud solicitud)
            {
                return;
            }
            if(ParentForm is FrmPrincipal principal)
            {
                principal.AbrirEnPanel(new FrmActualizarSolicitudes(solicitud));
            }
        }

        private bool IsSelectedRowValid()
        {
            return dgvSolicitudes.SelectedRows.Count > 0;
        }
    }
}
