using AlquilerAudiovisual.Desktop.Clientes;
using AlquilerAudiovisual.Desktop.Solicitudes;

namespace AlquilerAudiovisual.Desktop
{
    public partial class FrmPrincipal : Form
    {
        private Form? formActual;

        public void AbrirEnPanel(Form formulario)
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
        public void MostrarInicio()
        {
            formActual?.Close();
            formActual = null;
        }
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FrmListadoClientes());
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FrmRegistroClientes());
        }

        private void listadoDeSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FrmListadoSolicitudes());
        }

        private void registrarSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new FrmRegistroSolicitudes());
        }
    }
}
