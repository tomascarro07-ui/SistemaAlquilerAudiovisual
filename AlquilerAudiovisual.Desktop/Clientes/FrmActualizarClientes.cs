using AlquilerAudiovisual.Dominio;
using AlquilerAudiovisual.Entities.Clientes;

namespace AlquilerAudiovisual.Desktop.Clientes
{
    public partial class FrmActualizarClientes : Form
    {
        private readonly Cliente cliente;
        private readonly GestorClientes gestor = new GestorClientes();
        public FrmActualizarClientes(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtCorreo.Text = cliente.Correo;
            txtDireccion.Text = cliente.Direccion;
            cbTipoCliente.DataSource = gestor.LeerTipoClientes();
            cbTipoCliente.DisplayMember = "Nombre";
            cbTipoCliente.ValueMember = "IdTipoCliente";
            cbTipoCliente.SelectedValue = cliente.TipoCliente.IdTipoCliente;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbTipoCliente.SelectedItem is not TipoCliente tipo)
            {
                MessageBox.Show("Seleccione un tipo de cliente");
                return;
            }

            try
            {
                string nombre = txtNombre.Text;
                string telefono = txtTelefono.Text;
                string correo = txtCorreo.Text;
                string direccion = txtDireccion.Text;
                cliente.ModificarDatos(nombre, telefono, correo, direccion);
                cliente.TipoCliente = tipo;
                gestor.ActualizarCliente(cliente);
                if (ParentForm is FrmPrincipal principal)
                {
                    MessageBox.Show("Usuario modificado correctamente.");
                    principal.AbrirEnPanel(new FrmListadoClientes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(ParentForm is FrmPrincipal principal)
            {
                principal.AbrirEnPanel(new FrmListadoClientes());
            }
        }
    }
}
