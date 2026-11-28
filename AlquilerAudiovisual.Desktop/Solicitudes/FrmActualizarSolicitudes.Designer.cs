namespace AlquilerAudiovisual.Desktop.Solicitudes
{
    partial class FrmActualizarSolicitudes
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
            lblCliente = new Label();
            cbClientes = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            nudAsistentes = new NumericUpDown();
            cbTipoEvento = new ComboBox();
            dtpHoraFin = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            txtUbicacion = new TextBox();
            lblTipoEvento = new Label();
            lblCantidadAsistentes = new Label();
            lblHoraFinalizacion = new Label();
            lblHoraInicio = new Label();
            lblFechaFin = new Label();
            lblFechaInicio = new Label();
            lblUbicacion = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAsistentes).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(141, 229);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(123, 15);
            lblCliente.TabIndex = 37;
            lblCliente.Text = "Cliente de la solicitud:";
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(144, 248);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(199, 23);
            cbClientes.TabIndex = 36;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(267, 395);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 23);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(418, 395);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 23);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // nudAsistentes
            // 
            nudAsistentes.Location = new Point(144, 51);
            nudAsistentes.Name = "nudAsistentes";
            nudAsistentes.Size = new Size(200, 23);
            nudAsistentes.TabIndex = 33;
            nudAsistentes.TextAlign = HorizontalAlignment.Right;
            // 
            // cbTipoEvento
            // 
            cbTipoEvento.FormattingEnabled = true;
            cbTipoEvento.Location = new Point(461, 51);
            cbTipoEvento.Name = "cbTipoEvento";
            cbTipoEvento.Size = new Size(199, 23);
            cbTipoEvento.TabIndex = 32;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.CustomFormat = "HH:mm";
            dtpHoraFin.Format = DateTimePickerFormat.Custom;
            dtpHoraFin.Location = new Point(459, 182);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.ShowUpDown = true;
            dtpHoraFin.Size = new Size(200, 23);
            dtpHoraFin.TabIndex = 31;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.CustomFormat = "HH:mm";
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.Location = new Point(144, 182);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new Size(200, 23);
            dtpHoraInicio.TabIndex = 30;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(460, 114);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 23);
            dtpFechaFin.TabIndex = 29;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(143, 114);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 23);
            dtpFechaInicio.TabIndex = 28;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(459, 247);
            txtUbicacion.Multiline = true;
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(201, 57);
            txtUbicacion.TabIndex = 27;
            // 
            // lblTipoEvento
            // 
            lblTipoEvento.AutoSize = true;
            lblTipoEvento.Location = new Point(461, 33);
            lblTipoEvento.Name = "lblTipoEvento";
            lblTipoEvento.Size = new Size(89, 15);
            lblTipoEvento.TabIndex = 26;
            lblTipoEvento.Text = "Tipo de evento:";
            // 
            // lblCantidadAsistentes
            // 
            lblCantidadAsistentes.AutoSize = true;
            lblCantidadAsistentes.Location = new Point(144, 33);
            lblCantidadAsistentes.Name = "lblCantidadAsistentes";
            lblCantidadAsistentes.Size = new Size(128, 15);
            lblCantidadAsistentes.TabIndex = 25;
            lblCantidadAsistentes.Text = "Cantidad de asistentes:";
            // 
            // lblHoraFinalizacion
            // 
            lblHoraFinalizacion.AutoSize = true;
            lblHoraFinalizacion.Location = new Point(460, 164);
            lblHoraFinalizacion.Name = "lblHoraFinalizacion";
            lblHoraFinalizacion.Size = new Size(115, 15);
            lblHoraFinalizacion.TabIndex = 24;
            lblHoraFinalizacion.Text = "Hora de finalización:";
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.Location = new Point(141, 164);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(84, 15);
            lblHoraInicio.TabIndex = 23;
            lblHoraInicio.Text = "Hora de inicio:";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(459, 96);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(120, 15);
            lblFechaFin.TabIndex = 22;
            lblFechaFin.Text = "Fecha de finalización:";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(142, 96);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(89, 15);
            lblFechaInicio.TabIndex = 21;
            lblFechaInicio.Text = "Fecha de inicio:";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Location = new Point(459, 229);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(63, 15);
            lblUbicacion.TabIndex = 20;
            lblUbicacion.Text = "Ubicacion:";
            // 
            // FrmActualizarSolicitudes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCliente);
            Controls.Add(cbClientes);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(nudAsistentes);
            Controls.Add(cbTipoEvento);
            Controls.Add(dtpHoraFin);
            Controls.Add(dtpHoraInicio);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(txtUbicacion);
            Controls.Add(lblTipoEvento);
            Controls.Add(lblCantidadAsistentes);
            Controls.Add(lblHoraFinalizacion);
            Controls.Add(lblHoraInicio);
            Controls.Add(lblFechaFin);
            Controls.Add(lblFechaInicio);
            Controls.Add(lblUbicacion);
            Name = "FrmActualizarSolicitudes";
            Text = "FrmActualizarSolicitudes";
            ((System.ComponentModel.ISupportInitialize)nudAsistentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private ComboBox cbClientes;
        private Button btnCancelar;
        private Button btnGuardar;
        private NumericUpDown nudAsistentes;
        private ComboBox cbTipoEvento;
        private DateTimePicker dtpHoraFin;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private TextBox txtUbicacion;
        private Label lblTipoEvento;
        private Label lblCantidadAsistentes;
        private Label lblHoraFinalizacion;
        private Label lblHoraInicio;
        private Label lblFechaFin;
        private Label lblFechaInicio;
        private Label lblUbicacion;
    }
}