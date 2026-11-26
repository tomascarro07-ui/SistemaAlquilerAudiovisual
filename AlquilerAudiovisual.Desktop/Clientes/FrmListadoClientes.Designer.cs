namespace AlquilerAudiovisual.Desktop.Clientes
{
    partial class FrmListadoClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvClientes = new DataGridView();
            ColIdCliente = new DataGridViewTextBoxColumn();
            ColDocumento = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColTelefono = new DataGridViewTextBoxColumn();
            ColCorreo = new DataGridViewTextBoxColumn();
            ColDireccion = new DataGridViewTextBoxColumn();
            ColActivo = new DataGridViewTextBoxColumn();
            ColTipoCliente = new DataGridViewTextBoxColumn();
            btnDesactivarUsuario = new Button();
            btnActivarUsuario = new Button();
            btnEditarDatos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.BackgroundColor = SystemColors.Window;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { ColIdCliente, ColDocumento, ColNombre, ColTelefono, ColCorreo, ColDireccion, ColActivo, ColTipoCliente });
            dgvClientes.Location = new Point(12, 12);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(776, 377);
            dgvClientes.TabIndex = 0;
            // 
            // ColIdCliente
            // 
            ColIdCliente.DataPropertyName = "IdCliente";
            ColIdCliente.HeaderText = "ID";
            ColIdCliente.Name = "ColIdCliente";
            ColIdCliente.ReadOnly = true;
            // 
            // ColDocumento
            // 
            ColDocumento.DataPropertyName = "Documento";
            ColDocumento.HeaderText = "Documento";
            ColDocumento.Name = "ColDocumento";
            ColDocumento.ReadOnly = true;
            // 
            // ColNombre
            // 
            ColNombre.DataPropertyName = "Nombre";
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            // 
            // ColTelefono
            // 
            ColTelefono.DataPropertyName = "Telefono";
            ColTelefono.HeaderText = "Telefono";
            ColTelefono.Name = "ColTelefono";
            ColTelefono.ReadOnly = true;
            // 
            // ColCorreo
            // 
            ColCorreo.DataPropertyName = "Correo";
            ColCorreo.HeaderText = "Correo";
            ColCorreo.Name = "ColCorreo";
            ColCorreo.ReadOnly = true;
            // 
            // ColDireccion
            // 
            ColDireccion.DataPropertyName = "Direccion";
            ColDireccion.HeaderText = "Direccion";
            ColDireccion.Name = "ColDireccion";
            ColDireccion.ReadOnly = true;
            // 
            // ColActivo
            // 
            ColActivo.DataPropertyName = "Activo";
            ColActivo.HeaderText = "Activo";
            ColActivo.Name = "ColActivo";
            ColActivo.ReadOnly = true;
            // 
            // ColTipoCliente
            // 
            ColTipoCliente.DataPropertyName = "TipoCliente";
            ColTipoCliente.HeaderText = "TipoCliente";
            ColTipoCliente.Name = "ColTipoCliente";
            ColTipoCliente.ReadOnly = true;
            // 
            // btnDesactivarUsuario
            // 
            btnDesactivarUsuario.Location = new Point(662, 395);
            btnDesactivarUsuario.Name = "btnDesactivarUsuario";
            btnDesactivarUsuario.Size = new Size(126, 23);
            btnDesactivarUsuario.TabIndex = 2;
            btnDesactivarUsuario.Text = "&Desactivar usuario";
            btnDesactivarUsuario.UseVisualStyleBackColor = true;
            btnDesactivarUsuario.Click += btnDesactivarUsuario_Click;
            // 
            // btnActivarUsuario
            // 
            btnActivarUsuario.Location = new Point(530, 395);
            btnActivarUsuario.Name = "btnActivarUsuario";
            btnActivarUsuario.Size = new Size(126, 23);
            btnActivarUsuario.TabIndex = 3;
            btnActivarUsuario.Text = "&Activar usuario";
            btnActivarUsuario.UseVisualStyleBackColor = true;
            btnActivarUsuario.Click += btnActivarUsuario_Click;
            // 
            // btnEditarDatos
            // 
            btnEditarDatos.Location = new Point(12, 395);
            btnEditarDatos.Name = "btnEditarDatos";
            btnEditarDatos.Size = new Size(139, 23);
            btnEditarDatos.TabIndex = 4;
            btnEditarDatos.Text = "&Editar datos de usuario";
            btnEditarDatos.UseVisualStyleBackColor = true;
            btnEditarDatos.Click += btnEditarDatos_Click;
            // 
            // FrmListadoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditarDatos);
            Controls.Add(btnActivarUsuario);
            Controls.Add(btnDesactivarUsuario);
            Controls.Add(dgvClientes);
            Name = "FrmListadoClientes";
            Text = "FrmListadoClientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnDesactivarUsuario;
        private DataGridViewTextBoxColumn ColIdCliente;
        private DataGridViewTextBoxColumn ColDocumento;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColTelefono;
        private DataGridViewTextBoxColumn ColCorreo;
        private DataGridViewTextBoxColumn ColDireccion;
        private DataGridViewTextBoxColumn ColActivo;
        private DataGridViewTextBoxColumn ColTipoCliente;
        private Button btnActivarUsuario;
        private Button btnEditarDatos;
    }
}