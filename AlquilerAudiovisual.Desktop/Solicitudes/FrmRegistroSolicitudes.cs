using AlquilerAudiovisual.Desktop.Clientes;
using AlquilerAudiovisual.Dominio;
using AlquilerAudiovisual.Entities.Clientes;
using AlquilerAudiovisual.Entities.Enumerados;
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
    public partial class FrmRegistroSolicitudes : Form
    {
        private List<TipoEvento> _tipoEvento = new();
        private GestorSolicitudes gestorSolicitud = new GestorSolicitudes();
        private List<Cliente> _clientes = new();
        private GestorClientes gestorCliente = new();
        public FrmRegistroSolicitudes()
        {
            InitializeComponent();
            _tipoEvento = gestorSolicitud.LeerTiposEventos();
            cbTipoEvento.DataSource = _tipoEvento;
            cbTipoEvento.DisplayMember = "Nombre";

            _clientes = gestorCliente.LeerClientes();
            cbClientes.DataSource = _clientes;
            cbClientes.DisplayMember = "Nombre";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (ParentForm is FrmPrincipal principal)
            {
                principal.MostrarInicio();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(cbTipoEvento.SelectedItem is not TipoEvento tipoEvento)
            {
                MessageBox.Show("Seleccione un tipo de evento.");
                return;
            }

            if(cbClientes.SelectedItem is not Cliente cliente)
            {
                MessageBox.Show("Seleccione un tipo de evento.");
                return;
            }

            try
            {
                var ubicacion = txtUbicacion.Text;
                var fechaInicio = dtpFechaInicio.Value;
                var fechaFin = dtpFechaFin.Value;
                var horaInicio = dtpHoraInicio.Value;
                var horaFin = dtpHoraFin.Value;
                var cantidadAsistentes = nudAsistentes.Value;
                Solicitud solicitud = new Solicitud(0, DateOnly.FromDateTime(DateTime.Today), ubicacion, DateOnly.FromDateTime(fechaInicio), DateOnly.FromDateTime(fechaFin), TimeOnly.FromDateTime(horaInicio), TimeOnly.FromDateTime(horaFin), (int)cantidadAsistentes, EstadoSolicitud.Pendiente, cliente, tipoEvento);
                gestorSolicitud.AgregarSolicitud(solicitud);
                if(ParentForm is FrmPrincipal principal)
                {
                    MessageBox.Show("Solicitud registrada correctamente.");
                    principal.AbrirEnPanel(new FrmListadoSolicitudes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
