using AlquilerAudiovisual.Dominio;
using AlquilerAudiovisual.Entities.Clientes;

namespace AlquilerAudiovisual.Desktop.Clientes
{
    public partial class FrmRegistroClientes : Form
    {
        private List<TipoCliente> _tipoCliente = new();
        GestorClientes gestor = new GestorClientes();
        public FrmRegistroClientes()
        {
            InitializeComponent();
            GestorClientes gestor = new GestorClientes();
            _tipoCliente = gestor.LeerTipoClientes();
            cbTipoCliente.DataSource = _tipoCliente;
            cbTipoCliente.DisplayMember = "Nombre";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (ParentForm is FrmPrincipal principal)
            {
                principal.AbrirEnPanel(new FrmListadoClientes());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(cbTipoCliente.SelectedItem is not TipoCliente tipo)
            {
                MessageBox.Show("Seleccione un tipo de cliente.");
                return;
            }

            try
            {
                string documento = txtDocumento.Text;
                string nombre = txtNombre.Text;
                string telefono = txtTelefono.Text;
                string correo = txtCorreo.Text;
                string direccion = txtDireccion.Text;
                Cliente cliente = new Cliente(0, documento, nombre, telefono, correo, direccion, true, tipo);
                gestor.AgregarCliente(cliente);
                if (ParentForm is FrmPrincipal principal)
                {
                    MessageBox.Show("Usuario registrado correctamente.");
                    principal.AbrirEnPanel(new FrmListadoClientes());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}