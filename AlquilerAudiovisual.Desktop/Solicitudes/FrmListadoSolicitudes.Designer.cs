namespace AlquilerAudiovisual.Desktop.Solicitudes
{
    partial class FrmListadoSolicitudes
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
            btnVolver = new Button();
            btnAgregarUsuario = new Button();
            btnEditarDatos = new Button();
            btnActivarUsuario = new Button();
            btnDesactivarUsuario = new Button();
            dgvSolicitudes = new DataGridView();
            IdSolicitud = new DataGridViewTextBoxColumn();
            FechaSolicitud = new DataGridViewTextBoxColumn();
            Ubicacion = new DataGridViewTextBoxColumn();
            FechaInicio = new DataGridViewTextBoxColumn();
            FechaFin = new DataGridViewTextBoxColumn();
            HoraInicio = new DataGridViewTextBoxColumn();
            HoraFin = new DataGridViewTextBoxColumn();
            CantidadAsistentes = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            TipoEvento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.MenuBar;
            btnVolver.Location = new Point(12, 451);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(92, 28);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "&Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(173, 395);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(115, 23);
            btnAgregarUsuario.TabIndex = 11;
            btnAgregarUsuario.Text = "&Agregar solicitud";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnEditarDatos
            // 
            btnEditarDatos.Location = new Point(12, 395);
            btnEditarDatos.Name = "btnEditarDatos";
            btnEditarDatos.Size = new Size(155, 23);
            btnEditarDatos.TabIndex = 10;
            btnEditarDatos.Text = "&Editar datos de solicitud";
            btnEditarDatos.UseVisualStyleBackColor = true;
            btnEditarDatos.Click += btnEditarDatos_Click;
            // 
            // btnActivarUsuario
            // 
            btnActivarUsuario.Location = new Point(530, 395);
            btnActivarUsuario.Name = "btnActivarUsuario";
            btnActivarUsuario.Size = new Size(126, 23);
            btnActivarUsuario.TabIndex = 9;
            btnActivarUsuario.Text = "&Activar usuario";
            btnActivarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnDesactivarUsuario
            // 
            btnDesactivarUsuario.Location = new Point(662, 395);
            btnDesactivarUsuario.Name = "btnDesactivarUsuario";
            btnDesactivarUsuario.Size = new Size(126, 23);
            btnDesactivarUsuario.TabIndex = 8;
            btnDesactivarUsuario.Text = "&Desactivar usuario";
            btnDesactivarUsuario.UseVisualStyleBackColor = true;
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.AllowUserToAddRows = false;
            dgvSolicitudes.BackgroundColor = SystemColors.Window;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Columns.AddRange(new DataGridViewColumn[] { IdSolicitud, FechaSolicitud, Ubicacion, FechaInicio, FechaFin, HoraInicio, HoraFin, CantidadAsistentes, Estado, TipoEvento });
            dgvSolicitudes.Location = new Point(12, 12);
            dgvSolicitudes.MultiSelect = false;
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSolicitudes.Size = new Size(776, 377);
            dgvSolicitudes.TabIndex = 7;
            // 
            // IdSolicitud
            // 
            IdSolicitud.DataPropertyName = "IdSolicitud";
            IdSolicitud.HeaderText = "ID";
            IdSolicitud.Name = "IdSolicitud";
            IdSolicitud.ReadOnly = true;
            // 
            // FechaSolicitud
            // 
            FechaSolicitud.DataPropertyName = "FechaSolicitud";
            FechaSolicitud.HeaderText = "Fecha de Solicitud";
            FechaSolicitud.Name = "FechaSolicitud";
            FechaSolicitud.ReadOnly = true;
            // 
            // Ubicacion
            // 
            Ubicacion.DataPropertyName = "Ubicacion";
            Ubicacion.HeaderText = "Ubicacion";
            Ubicacion.Name = "Ubicacion";
            Ubicacion.ReadOnly = true;
            // 
            // FechaInicio
            // 
            FechaInicio.DataPropertyName = "FechaInicio";
            FechaInicio.HeaderText = "Fecha de inicio";
            FechaInicio.Name = "FechaInicio";
            FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            FechaFin.DataPropertyName = "FechaFin";
            FechaFin.HeaderText = "Fecha de finalizacion";
            FechaFin.Name = "FechaFin";
            FechaFin.ReadOnly = true;
            // 
            // HoraInicio
            // 
            HoraInicio.DataPropertyName = "HoraInicio";
            HoraInicio.HeaderText = "Hora de inicio";
            HoraInicio.Name = "HoraInicio";
            HoraInicio.ReadOnly = true;
            // 
            // HoraFin
            // 
            HoraFin.DataPropertyName = "HoraFin";
            HoraFin.HeaderText = "Hora de finalizacion";
            HoraFin.Name = "HoraFin";
            HoraFin.ReadOnly = true;
            // 
            // CantidadAsistentes
            // 
            CantidadAsistentes.DataPropertyName = "CantidadAsistentes";
            CantidadAsistentes.HeaderText = "Cantidad de asistentes";
            CantidadAsistentes.Name = "CantidadAsistentes";
            CantidadAsistentes.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // TipoEvento
            // 
            TipoEvento.DataPropertyName = "TipoEvento";
            TipoEvento.HeaderText = "Tipo de evento";
            TipoEvento.Name = "TipoEvento";
            TipoEvento.ReadOnly = true;
            // 
            // FrmListadoSolicitudes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 493);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(btnEditarDatos);
            Controls.Add(btnActivarUsuario);
            Controls.Add(btnDesactivarUsuario);
            Controls.Add(dgvSolicitudes);
            Name = "FrmListadoSolicitudes";
            Text = "FrmListadoSolicitudes";
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private Button btnAgregarUsuario;
        private Button btnEditarDatos;
        private Button btnActivarUsuario;
        private Button btnDesactivarUsuario;
        private DataGridView dgvSolicitudes;
        private DataGridViewTextBoxColumn IdSolicitud;
        private DataGridViewTextBoxColumn FechaSolicitud;
        private DataGridViewTextBoxColumn Ubicacion;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaFin;
        private DataGridViewTextBoxColumn HoraInicio;
        private DataGridViewTextBoxColumn HoraFin;
        private DataGridViewTextBoxColumn CantidadAsistentes;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn TipoEvento;
    }
}