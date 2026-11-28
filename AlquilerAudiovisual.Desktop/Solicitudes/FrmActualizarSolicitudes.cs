using AlquilerAudiovisual.Dominio;
using AlquilerAudiovisual.Entities.Clientes;
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
    public partial class FrmActualizarSolicitudes : Form
    {
        private readonly Solicitud solicitud;
        private GestorSolicitudes gestorSolicitud = new GestorSolicitudes();
        private GestorClientes gestorCliente = new GestorClientes();
        public FrmActualizarSolicitudes(Solicitud solicitud)
        {
            InitializeComponent();
            this.solicitud = solicitud;

            nudAsistentes.Value = solicitud.CantidadAsistentes;
            dtpFechaInicio.Value = solicitud.FechaInicio.ToDateTime(TimeOnly.MinValue);
            dtpFechaFin.Value = solicitud.FechaFin.ToDateTime(TimeOnly.MinValue);
            txtUbicacion.Text = solicitud.Ubicacion;
            dtpHoraInicio.Value = DateTime.Today.Add(solicitud.HoraInicio.ToTimeSpan());
            dtpHoraFin.Value = DateTime.Today.Add(solicitud.HoraFin.ToTimeSpan());

            cbClientes.DataSource = gestorCliente.LeerClientes();
            cbClientes.DisplayMember = "Nombre";
            cbClientes.ValueMember = "IdCliente";
            cbClientes.SelectedValue = solicitud.Cliente.IdCliente;

            cbTipoEvento.DataSource = gestorSolicitud.LeerTiposEventos();
            cbTipoEvento.DisplayMember = "Nombre";
            cbTipoEvento.ValueMember = "IdTipoEvento";
            cbTipoEvento.SelectedValue = solicitud.TipoEvento.IdTipoEvento;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbClientes.SelectedItem is not Cliente cliente)
            {
                MessageBox.Show("Seleccione un cliente");
            }

            if (cbTipoEvento.SelectedItem is not TipoEvento tipoEvento)
            {
                MessageBox.Show("Seleccione un tipo de evento");
            }

            try
            {
                solicitud.Ubicacion = txtUbicacion.Text;
                solicitud.CantidadAsistentes = (int)nudAsistentes.Value;
                solicitud.FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value);
                solicitud.FechaFin = DateOnly.FromDateTime(dtpFechaFin.Value);
                solicitud.HoraInicio = TimeOnly.FromDateTime(dtpHoraInicio.Value);
                solicitud.HoraFin = TimeOnly.FromDateTime(dtpHoraFin.Value);
            }
        }
    }
}
