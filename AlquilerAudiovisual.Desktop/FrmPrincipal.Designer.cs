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
            menuStrip1 = new MenuStrip();
            TSMI_Cliente = new ToolStripMenuItem();
            TSMI_ListCli = new ToolStripMenuItem();
            TSMI_RegCli = new ToolStripMenuItem();
            TSMI_Contrataciones = new ToolStripMenuItem();
            TSMI_ListContrat = new ToolStripMenuItem();
            TSMI_PrepEquipamiento = new ToolStripMenuItem();
            TSMI_RegistroPagos = new ToolStripMenuItem();
            TSMI_Devoluciones = new ToolStripMenuItem();
            TSMI_RegistroDevoluciones = new ToolStripMenuItem();
            TSMI_Equipamiento = new ToolStripMenuItem();
            TSMI_CambioEstado = new ToolStripMenuItem();
            TSMI_GestionDeposito = new ToolStripMenuItem();
            TSMI_TipoEquipamiento = new ToolStripMenuItem();
            TSMI_ListEquipos = new ToolStripMenuItem();
            TSMI_RegistroEquipos = new ToolStripMenuItem();
            TSMI_Reportes = new ToolStripMenuItem();
            TSMI_ConsultaReportes = new ToolStripMenuItem();
            TSMI_Solicitudes = new ToolStripMenuItem();
            TSMI_ListSolicitudes = new ToolStripMenuItem();
            TSMI_RegistroSolicitudes = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMI_Cliente, TSMI_Contrataciones, TSMI_Devoluciones, TSMI_Equipamiento, TSMI_Reportes, TSMI_Solicitudes });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1069, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Cliente
            // 
            TSMI_Cliente.DropDownItems.AddRange(new ToolStripItem[] { TSMI_ListCli, TSMI_RegCli });
            TSMI_Cliente.Name = "TSMI_Cliente";
            TSMI_Cliente.Size = new Size(75, 24);
            TSMI_Cliente.Text = "&Clientes";
            // 
            // TSMI_ListCli
            // 
            TSMI_ListCli.Name = "TSMI_ListCli";
            TSMI_ListCli.Size = new Size(224, 26);
            TSMI_ListCli.Text = "&Listado de Clientes";
            // 
            // TSMI_RegCli
            // 
            TSMI_RegCli.Name = "TSMI_RegCli";
            TSMI_RegCli.Size = new Size(224, 26);
            TSMI_RegCli.Text = "&Registro de Clientes";
            // 
            // TSMI_Contrataciones
            // 
            TSMI_Contrataciones.DropDownItems.AddRange(new ToolStripItem[] { TSMI_ListContrat, TSMI_PrepEquipamiento, TSMI_RegistroPagos });
            TSMI_Contrataciones.Name = "TSMI_Contrataciones";
            TSMI_Contrataciones.Size = new Size(122, 24);
            TSMI_Contrataciones.Text = "C&ontrataciones";
            // 
            // TSMI_ListContrat
            // 
            TSMI_ListContrat.Name = "TSMI_ListContrat";
            TSMI_ListContrat.Size = new Size(289, 26);
            TSMI_ListContrat.Text = "&Listado de Contrataciones";
            // 
            // TSMI_PrepEquipamiento
            // 
            TSMI_PrepEquipamiento.Name = "TSMI_PrepEquipamiento";
            TSMI_PrepEquipamiento.Size = new Size(289, 26);
            TSMI_PrepEquipamiento.Text = "&Preparacion de Equipamiento";
            // 
            // TSMI_RegistroPagos
            // 
            TSMI_RegistroPagos.Name = "TSMI_RegistroPagos";
            TSMI_RegistroPagos.Size = new Size(289, 26);
            TSMI_RegistroPagos.Text = "&Registro de Pagos";
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
            TSMI_RegistroDevoluciones.Size = new Size(261, 26);
            TSMI_RegistroDevoluciones.Text = "&Registro de Devoluciones";
            // 
            // TSMI_Equipamiento
            // 
            TSMI_Equipamiento.DropDownItems.AddRange(new ToolStripItem[] { TSMI_CambioEstado, TSMI_GestionDeposito, TSMI_TipoEquipamiento, TSMI_ListEquipos, TSMI_RegistroEquipos });
            TSMI_Equipamiento.Name = "TSMI_Equipamiento";
            TSMI_Equipamiento.Size = new Size(116, 24);
            TSMI_Equipamiento.Text = "&Equipamiento";
            // 
            // TSMI_CambioEstado
            // 
            TSMI_CambioEstado.Name = "TSMI_CambioEstado";
            TSMI_CambioEstado.Size = new Size(228, 26);
            TSMI_CambioEstado.Text = "&Cambio de Estado";
            // 
            // TSMI_GestionDeposito
            // 
            TSMI_GestionDeposito.Name = "TSMI_GestionDeposito";
            TSMI_GestionDeposito.Size = new Size(228, 26);
            TSMI_GestionDeposito.Text = "&Gestion de Deposito";
            // 
            // TSMI_TipoEquipamiento
            // 
            TSMI_TipoEquipamiento.Name = "TSMI_TipoEquipamiento";
            TSMI_TipoEquipamiento.Size = new Size(228, 26);
            TSMI_TipoEquipamiento.Text = "&Tipo Equipamiento";
            // 
            // TSMI_ListEquipos
            // 
            TSMI_ListEquipos.Name = "TSMI_ListEquipos";
            TSMI_ListEquipos.Size = new Size(228, 26);
            TSMI_ListEquipos.Text = "&Listado de Equipos";
            // 
            // TSMI_RegistroEquipos
            // 
            TSMI_RegistroEquipos.Name = "TSMI_RegistroEquipos";
            TSMI_RegistroEquipos.Size = new Size(228, 26);
            TSMI_RegistroEquipos.Text = "&Registro de Equipos";
            // 
            // TSMI_Reportes
            // 
            TSMI_Reportes.DropDownItems.AddRange(new ToolStripItem[] { TSMI_ConsultaReportes });
            TSMI_Reportes.Name = "TSMI_Reportes";
            TSMI_Reportes.Size = new Size(82, 24);
            TSMI_Reportes.Text = "&Reportes";
            // 
            // TSMI_ConsultaReportes
            // 
            TSMI_ConsultaReportes.Name = "TSMI_ConsultaReportes";
            TSMI_ConsultaReportes.Size = new Size(233, 26);
            TSMI_ConsultaReportes.Text = "&Consulta de Reportes";
            // 
            // TSMI_Solicitudes
            // 
            TSMI_Solicitudes.DropDownItems.AddRange(new ToolStripItem[] { TSMI_ListSolicitudes, TSMI_RegistroSolicitudes });
            TSMI_Solicitudes.Name = "TSMI_Solicitudes";
            TSMI_Solicitudes.Size = new Size(95, 24);
            TSMI_Solicitudes.Text = "&Solicitudes";
            // 
            // TSMI_ListSolicitudes
            // 
            TSMI_ListSolicitudes.Name = "TSMI_ListSolicitudes";
            TSMI_ListSolicitudes.Size = new Size(244, 26);
            TSMI_ListSolicitudes.Text = "&Listado de Solicitudes";
            // 
            // TSMI_RegistroSolicitudes
            // 
            TSMI_RegistroSolicitudes.Name = "TSMI_RegistroSolicitudes";
            TSMI_RegistroSolicitudes.Size = new Size(244, 26);
            TSMI_RegistroSolicitudes.Text = "&Registro de Solicitudes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AVPro_850x290;
            pictureBox1.Location = new Point(84, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(850, 290);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 780);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Gestor Audiovisual";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMI_Cliente;
        private ToolStripMenuItem TSMI_ListCli;
        private ToolStripMenuItem TSMI_RegCli;
        private ToolStripMenuItem TSMI_Contrataciones;
        private ToolStripMenuItem TSMI_ListContrat;
        private ToolStripMenuItem TSMI_PrepEquipamiento;
        private ToolStripMenuItem TSMI_RegistroPagos;
        private ToolStripMenuItem TSMI_Devoluciones;
        private ToolStripMenuItem TSMI_RegistroDevoluciones;
        private ToolStripMenuItem TSMI_Equipamiento;
        private ToolStripMenuItem TSMI_CambioEstado;
        private ToolStripMenuItem TSMI_GestionDeposito;
        private ToolStripMenuItem TSMI_TipoEquipamiento;
        private ToolStripMenuItem TSMI_ListEquipos;
        private ToolStripMenuItem TSMI_RegistroEquipos;
        private ToolStripMenuItem TSMI_Reportes;
        private ToolStripMenuItem TSMI_ConsultaReportes;
        private ToolStripMenuItem TSMI_Solicitudes;
        private ToolStripMenuItem TSMI_ListSolicitudes;
        private ToolStripMenuItem TSMI_RegistroSolicitudes;
        private PictureBox pictureBox1;
    }
}