namespace AlquilerAudiovisual.Desktop.Solicitudes
{
    partial class FrmRegistroSolicitudes
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
            lblUbicacion = new Label();
            lblFechaInicio = new Label();
            lblFechaFin = new Label();
            lblHoraInicio = new Label();
            lblHoraFinalizacion = new Label();
            lblCantidadAsistentes = new Label();
            lblTipoEvento = new Label();
            txtUbicacion = new TextBox();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            dtpHoraFin = new DateTimePicker();
            cbTipoEvento = new ComboBox();
            nudAsistentes = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            cbClientes = new ComboBox();
            lblCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAsistentes).BeginInit();
            SuspendLayout();
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Location = new Point(426, 228);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(63, 15);
            lblUbicacion.TabIndex = 1;
            lblUbicacion.Text = "Ubicacion:";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(109, 95);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(89, 15);
            lblFechaInicio.TabIndex = 2;
            lblFechaInicio.Text = "Fecha de inicio:";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(426, 95);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(120, 15);
            lblFechaFin.TabIndex = 3;
            lblFechaFin.Text = "Fecha de finalización:";
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.Location = new Point(108, 163);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(84, 15);
            lblHoraInicio.TabIndex = 4;
            lblHoraInicio.Text = "Hora de inicio:";
            // 
            // lblHoraFinalizacion
            // 
            lblHoraFinalizacion.AutoSize = true;
            lblHoraFinalizacion.Location = new Point(427, 163);
            lblHoraFinalizacion.Name = "lblHoraFinalizacion";
            lblHoraFinalizacion.Size = new Size(115, 15);
            lblHoraFinalizacion.TabIndex = 5;
            lblHoraFinalizacion.Text = "Hora de finalización:";
            // 
            // lblCantidadAsistentes
            // 
            lblCantidadAsistentes.AutoSize = true;
            lblCantidadAsistentes.Location = new Point(111, 32);
            lblCantidadAsistentes.Name = "lblCantidadAsistentes";
            lblCantidadAsistentes.Size = new Size(128, 15);
            lblCantidadAsistentes.TabIndex = 6;
            lblCantidadAsistentes.Text = "Cantidad de asistentes:";
            // 
            // lblTipoEvento
            // 
            lblTipoEvento.AutoSize = true;
            lblTipoEvento.Location = new Point(428, 32);
            lblTipoEvento.Name = "lblTipoEvento";
            lblTipoEvento.Size = new Size(89, 15);
            lblTipoEvento.TabIndex = 7;
            lblTipoEvento.Text = "Tipo de evento:";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(426, 246);
            txtUbicacion.Multiline = true;
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(201, 57);
            txtUbicacion.TabIndex = 9;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(110, 113);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 23);
            dtpFechaInicio.TabIndex = 10;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(427, 113);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 23);
            dtpFechaFin.TabIndex = 11;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.CustomFormat = "HH:mm";
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.Location = new Point(111, 181);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new Size(200, 23);
            dtpHoraInicio.TabIndex = 12;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.CustomFormat = "HH:mm";
            dtpHoraFin.Format = DateTimePickerFormat.Custom;
            dtpHoraFin.Location = new Point(426, 181);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.ShowUpDown = true;
            dtpHoraFin.Size = new Size(200, 23);
            dtpHoraFin.TabIndex = 13;
            // 
            // cbTipoEvento
            // 
            cbTipoEvento.FormattingEnabled = true;
            cbTipoEvento.Location = new Point(428, 50);
            cbTipoEvento.Name = "cbTipoEvento";
            cbTipoEvento.Size = new Size(199, 23);
            cbTipoEvento.TabIndex = 14;
            // 
            // nudAsistentes
            // 
            nudAsistentes.Location = new Point(111, 50);
            nudAsistentes.Name = "nudAsistentes";
            nudAsistentes.Size = new Size(200, 23);
            nudAsistentes.TabIndex = 15;
            nudAsistentes.TextAlign = HorizontalAlignment.Right;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(385, 394);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 23);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(234, 394);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 23);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(111, 247);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(199, 23);
            cbClientes.TabIndex = 18;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(108, 228);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(123, 15);
            lblCliente.TabIndex = 19;
            lblCliente.Text = "Cliente de la solicitud:";
            // 
            // FrmRegistroSolicitudes
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
            Name = "FrmRegistroSolicitudes";
            Text = "FrmRegistroSolicitudes";
            ((System.ComponentModel.ISupportInitialize)nudAsistentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUbicacion;
        private Label lblFechaInicio;
        private Label lblFechaFin;
        private Label lblHoraInicio;
        private Label lblHoraFinalizacion;
        private Label lblCantidadAsistentes;
        private Label lblTipoEvento;
        private TextBox txtUbicacion;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpHoraFin;
        private ComboBox cbTipoEvento;
        private NumericUpDown nudAsistentes;
        private Button btnGuardar;
        private Button btnCancelar;
        private ComboBox cbClientes;
        private Label lblCliente;
    }
}