using AlquilerAudiovisual.Dominio;
using AlquilerAudiovisual.Entities.Clientes;

namespace AlquilerAudiovisual.Desktop.Clientes
{
    public partial class FrmListadoClientes : Form
    {
        private readonly GestorClientes gestorClientes = new GestorClientes();
        public FrmListadoClientes()
        {
            InitializeComponent();
            CargarClientes();
        }
        private void CargarClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = gestorClientes.LeerClientes();
        }

        private void btnDesactivarUsuario_Click(object sender, EventArgs e)
        {
            if (!IsSelectedRowValid())
            {
                MessageBox.Show("Por favor seleccione un usuario para desactivar.");
                return;
            }

            if (dgvClientes.SelectedRows[0].DataBoundItem is not Cliente cliente)
            {
                return;
            }
            try
            {
                if (!gestorClientes.DesactivarCliente(cliente.IdCliente))
                {
                    MessageBox.Show("No se encontró el cliente.");
                    return;
                }
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnActivarUsuario_Click(object sender, EventArgs e)
        {
            if (!IsSelectedRowValid())
            {
                MessageBox.Show("Por favor seleccione un usuario para activar");
                return;
            }
            if (dgvClientes.SelectedRows[0].DataBoundItem is not Cliente cliente)
            {
                return;
            }
            try
            {
                cliente.Activo = true;
                gestorClientes.ActualizarCliente(cliente);
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsSelectedRowValid()
        {
            return dgvClientes.SelectedRows.Count > 0;
        }

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            if (!IsSelectedRowValid())
            {
                MessageBox.Show("Por favor seleccione un usuario para editar.");
                return;
            }
            if (dgvClientes.SelectedRows[0].DataBoundItem is not Cliente cliente)
            {
                return;
            }

            if (ParentForm is FrmPrincipal principal)
            {
                principal.AbrirEnPanel(new FrmActualizarClientes(cliente));
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (ParentForm is FrmPrincipal principal)
            {
                principal.AbrirEnPanel(new FrmRegistroClientes());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ParentForm is FrmPrincipal principal)
            {
                principal.MostrarInicio();
            }
        }
    }
}
