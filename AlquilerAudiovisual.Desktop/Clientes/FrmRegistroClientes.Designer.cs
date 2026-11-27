namespace AlquilerAudiovisual.Desktop.Clientes
{
    partial class FrmRegistroClientes
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            lblDocumento = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            cbTipoCliente = new ComboBox();
            lblTipoCliente = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(190, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(190, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(410, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(190, 102);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(410, 23);
            txtDocumento.TabIndex = 3;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(190, 84);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(73, 15);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(190, 166);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(410, 23);
            txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(188, 148);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(190, 224);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(410, 23);
            txtCorreo.TabIndex = 7;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(188, 206);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(46, 15);
            lblCorreo.TabIndex = 6;
            lblCorreo.Text = "Correo:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(190, 289);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(410, 23);
            txtDireccion.TabIndex = 9;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(188, 271);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "Direccion:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(596, 398);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(460, 398);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbTipoCliente
            // 
            cbTipoCliente.FormattingEnabled = true;
            cbTipoCliente.Location = new Point(190, 347);
            cbTipoCliente.Name = "cbTipoCliente";
            cbTipoCliente.Size = new Size(121, 23);
            cbTipoCliente.TabIndex = 12;
            cbTipoCliente.SelectedIndexChanged += cbTipoCliente_SelectedIndexChanged;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(188, 327);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(90, 15);
            lblTipoCliente.TabIndex = 13;
            lblTipoCliente.Text = "Tipo de Cliente:";
            // 
            // FrmRegistroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTipoCliente);
            Controls.Add(cbTipoCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "FrmRegistroClientes";
            Text = "FrmRegistroClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private Label lblDocumento;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private Button btnGuardar;
        private Button btnCancelar;
        private ComboBox cbTipoCliente;
        private Label lblTipoCliente;
    }
}