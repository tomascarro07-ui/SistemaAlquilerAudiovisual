namespace AlquilerAudiovisual.Desktop
{
    partial class FrmPrincipal
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
            pnlContenido = new DataGridView();
            menuStrip1 = new MenuStrip();
            TSMI_Clientes = new ToolStripMenuItem();
            TSMI_CliList = new ToolStripMenuItem();
            TSMI_CliRegistro = new ToolStripMenuItem();
            TSMI_Solicitudes = new ToolStripMenuItem();
            TSMI_SolicitudesList = new ToolStripMenuItem();
            TSMI_RegistrarSolicitud = new ToolStripMenuItem();
            TSMI_Contrataciones = new ToolStripMenuItem();
            TSMI_ContratacionesList = new ToolStripMenuItem();
            TSMI_PrepEquipo = new ToolStripMenuItem();
            TSMI_RegistroPagos = new ToolStripMenuItem();
            TSMI_Equipamiento = new ToolStripMenuItem();
            TSMI_EquiposList = new ToolStripMenuItem();
            TSMI_RegistroEquipo = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            TSMI_Deposito = new ToolStripMenuItem();
            TSMI_TipoEquip = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            TSMI_CambioEstado = new ToolStripMenuItem();
            TSMI_Devoluciones = new ToolStripMenuItem();
            TSMI_RegistroDevoluciones = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            TSMI_ConsultaReportes = new ToolStripMenuItem();
            TSMI_Salir = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pnlContenido).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenido
            // 
            pnlContenido.BackgroundColor = SystemColors.ActiveCaption;
            pnlContenido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 30);
            pnlContenido.Margin = new Padding(3, 4, 3, 4);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.RowHeadersWidth = 51;
            pnlContenido.Size = new Size(914, 570);
            pnlContenido.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMI_Clientes, TSMI_Solicitudes, TSMI_Contrataciones, TSMI_Equipamiento, TSMI_Devoluciones, reportesToolStripMenuItem, TSMI_Salir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Clientes
            // 
            TSMI_Clientes.DropDownItems.AddRange(new ToolStripItem[] { TSMI_CliList, TSMI_CliRegistro });
            TSMI_Clientes.Name = "TSMI_Clientes";
            TSMI_Clientes.Size = new Size(75, 24);
            TSMI_Clientes.Text = "&Clientes";
            // 
            // TSMI_CliList
            // 
            TSMI_CliList.Name = "TSMI_CliList";
            TSMI_CliList.Size = new Size(215, 26);
            TSMI_CliList.Text = "&Listado de clientes";
            TSMI_CliList.Click += TSMI_ListCli_Click;
            // 
            // TSMI_CliRegistro
            // 
            TSMI_CliRegistro.Name = "TSMI_CliRegistro";
            TSMI_CliRegistro.Size = new Size(215, 26);
            TSMI_CliRegistro.Text = "&Registrar cliente";
            TSMI_CliRegistro.Click += TSMI_CliRegistro_Click;
            // 
            // TSMI_Solicitudes
            // 
            TSMI_Solicitudes.DropDownItems.AddRange(new ToolStripItem[] { TSMI_SolicitudesList, TSMI_RegistrarSolicitud });
            TSMI_Solicitudes.Name = "TSMI_Solicitudes";
            TSMI_Solicitudes.Size = new Size(95, 24);
            TSMI_Solicitudes.Text = "&Solicitudes";
            // 
            // TSMI_SolicitudesList
            // 
            TSMI_SolicitudesList.Name = "TSMI_SolicitudesList";
            TSMI_SolicitudesList.Size = new Size(235, 26);
            TSMI_SolicitudesList.Text = "&Listado de solicitudes";
            TSMI_SolicitudesList.Click += TSMI_SolicitudesList_Click;
            // 
            // TSMI_RegistrarSolicitud
            // 
            TSMI_RegistrarSolicitud.Name = "TSMI_RegistrarSolicitud";
            TSMI_RegistrarSolicitud.Size = new Size(235, 26);
            TSMI_RegistrarSolicitud.Text = "&Registrar solicitud";
            TSMI_RegistrarSolicitud.Click += TSMI_RegistrarSolicitud_Click;
            // 
            // TSMI_Contrataciones
            // 
            TSMI_Contrataciones.DropDownItems.AddRange(new ToolStripItem[] { TSMI_ContratacionesList, TSMI_PrepEquipo, TSMI_RegistroPagos });
            TSMI_Contrataciones.Name = "TSMI_Contrataciones";
            TSMI_Contrataciones.Size = new Size(122, 24);
            TSMI_Contrataciones.Text = "&Contrataciones";
            // 
            // TSMI_ContratacionesList
            // 
            TSMI_ContratacionesList.Name = "TSMI_ContratacionesList";
            TSMI_ContratacionesList.Size = new Size(289, 26);
            TSMI_ContratacionesList.Text = "&Listado de contrataciones";
            TSMI_ContratacionesList.Click += TSMI_ContratacionesList_Click;
            // 
            // TSMI_PrepEquipo
            // 
            TSMI_PrepEquipo.Name = "TSMI_PrepEquipo";
            TSMI_PrepEquipo.Size = new Size(289, 26);
            TSMI_PrepEquipo.Text = "&Preparación de equipamiento";
            TSMI_PrepEquipo.Click += TSMI_PrepEquipo_Click;
            // 
            // TSMI_RegistroPagos
            // 
            TSMI_RegistroPagos.Name = "TSMI_RegistroPagos";
            TSMI_RegistroPagos.Size = new Size(289, 26);
            TSMI_RegistroPagos.Text = "&Registro de pagos";
            TSMI_RegistroPagos.Click += TSMI_RegistroPagos_Click;
            // 
            // TSMI_Equipamiento
            // 
            TSMI_Equipamiento.DropDownItems.AddRange(new ToolStripItem[] { TSMI_EquiposList, TSMI_RegistroEquipo, toolStripMenuItem1, TSMI_Deposito, TSMI_TipoEquip, toolStripMenuItem2, TSMI_CambioEstado });
            TSMI_Equipamiento.Name = "TSMI_Equipamiento";
            TSMI_Equipamiento.Size = new Size(116, 24);
            TSMI_Equipamiento.Text = "&Equipamiento";
            // 
            // TSMI_EquiposList
            // 
            TSMI_EquiposList.Name = "TSMI_EquiposList";
            TSMI_EquiposList.Size = new Size(246, 26);
            TSMI_EquiposList.Text = "&Listado de equipos";
            TSMI_EquiposList.Click += TSMI_EquiposList_Click;
            // 
            // TSMI_RegistroEquipo
            // 
            TSMI_RegistroEquipo.Name = "TSMI_RegistroEquipo";
            TSMI_RegistroEquipo.Size = new Size(246, 26);
            TSMI_RegistroEquipo.Text = "&Registrar equipo";
            TSMI_RegistroEquipo.Click += TSMI_RegistroEquipo_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(243, 6);
            // 
            // TSMI_Deposito
            // 
            TSMI_Deposito.Name = "TSMI_Deposito";
            TSMI_Deposito.Size = new Size(246, 26);
            TSMI_Deposito.Text = "&Depósitos";
            TSMI_Deposito.Click += TSMI_Deposito_Click;
            // 
            // TSMI_TipoEquip
            // 
            TSMI_TipoEquip.Name = "TSMI_TipoEquip";
            TSMI_TipoEquip.Size = new Size(246, 26);
            TSMI_TipoEquip.Text = "&Tipos de equipamiento";
            TSMI_TipoEquip.Click += TSMI_TipoEquip_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(243, 6);
            // 
            // TSMI_CambioEstado
            // 
            TSMI_CambioEstado.Name = "TSMI_CambioEstado";
            TSMI_CambioEstado.Size = new Size(246, 26);
            TSMI_CambioEstado.Text = "&Cambio de estado";
            TSMI_CambioEstado.Click += TSMI_CambioEstado_Click;
            // 
            // TSMI_Devoluciones
            // 
            TSMI_Devoluciones.DropDownItems.AddRange(new ToolStripItem[] { TSMI_RegistroDevoluciones });
            TSMI_Devoluciones.Name = "TSMI_Devoluciones";
            TSMI_Devoluciones.Size = new Size(112, 24);
            TSMI_Devoluciones.Text = "&Devoluciones";
            // 
            // TSMI_RegistroDevoluciones
            // 
            TSMI_RegistroDevoluciones.Name = "TSMI_RegistroDevoluciones";
            TSMI_RegistroDevoluciones.Size = new Size(228, 26);
            TSMI_RegistroDevoluciones.Text = "&Registrar devolución";
            TSMI_RegistroDevoluciones.Click += TSMI_RegistroDevoluciones_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TSMI_ConsultaReportes });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "&Reportes";
            // 
            // TSMI_ConsultaReportes
            // 
            TSMI_ConsultaReportes.Name = "TSMI_ConsultaReportes";
            TSMI_ConsultaReportes.Size = new Size(224, 26);
            TSMI_ConsultaReportes.Text = "&Consultar reportes";
            TSMI_ConsultaReportes.Click += TSMI_ConsultaReportes_Click;
            // 
            // TSMI_Salir
            // 
            TSMI_Salir.Name = "TSMI_Salir";
            TSMI_Salir.Size = new Size(52, 24);
            TSMI_Salir.Text = "&Salir";
            TSMI_Salir.Click += TSMI_Salir_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlContenido);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            ((System.ComponentModel.ISupportInitialize)pnlContenido).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private DataGridView pnlContenido;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMI_Clientes;
        private ToolStripMenuItem TSMI_CliList;
        private ToolStripMenuItem TSMI_CliRegistro;
        private ToolStripMenuItem TSMI_Solicitudes;
        private ToolStripMenuItem TSMI_SolicitudesList;
        private ToolStripMenuItem TSMI_RegistrarSolicitud;
        private ToolStripMenuItem TSMI_Contrataciones;
        private ToolStripMenuItem TSMI_ContratacionesList;
        private ToolStripMenuItem TSMI_PrepEquipo;
        private ToolStripMenuItem TSMI_RegistroPagos;
        private ToolStripMenuItem TSMI_Equipamiento;
        private ToolStripMenuItem TSMI_EquiposList;
        private ToolStripMenuItem TSMI_RegistroEquipo;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem TSMI_Deposito;
        private ToolStripMenuItem TSMI_TipoEquip;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem TSMI_CambioEstado;
        private ToolStripMenuItem TSMI_Devoluciones;
        private ToolStripMenuItem TSMI_RegistroDevoluciones;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem TSMI_ConsultaReportes;
        private ToolStripMenuItem TSMI_Salir;
    }
}