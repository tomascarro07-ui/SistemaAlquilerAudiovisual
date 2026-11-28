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
            clientesToolStripMenuItem = new ToolStripMenuItem();
            listadoDeClientesToolStripMenuItem = new ToolStripMenuItem();
            registrarClienteToolStripMenuItem = new ToolStripMenuItem();
            solicitudesToolStripMenuItem = new ToolStripMenuItem();
            listadoDeSolicitudesToolStripMenuItem = new ToolStripMenuItem();
            registrarSolicitudToolStripMenuItem = new ToolStripMenuItem();
            contratacionesToolStripMenuItem = new ToolStripMenuItem();
            listadoDeContratacionesToolStripMenuItem = new ToolStripMenuItem();
            preparaciónDeEquipamientoToolStripMenuItem = new ToolStripMenuItem();
            registroDePagosToolStripMenuItem = new ToolStripMenuItem();
            equipamientoToolStripMenuItem = new ToolStripMenuItem();
            listadoDeEquiposToolStripMenuItem = new ToolStripMenuItem();
            registrarEquipoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            depósitosToolStripMenuItem = new ToolStripMenuItem();
            tiposDeEquipamientoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            cambioDeEstadoToolStripMenuItem = new ToolStripMenuItem();
            devolucionesToolStripMenuItem = new ToolStripMenuItem();
            registrarDevoluciónToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            consultarReportesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pnlContenido).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenido
            // 
            pnlContenido.BackgroundColor = SystemColors.ActiveCaption;
            pnlContenido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 24);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(800, 489);
            pnlContenido.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, solicitudesToolStripMenuItem, contratacionesToolStripMenuItem, equipamientoToolStripMenuItem, devolucionesToolStripMenuItem, reportesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadoDeClientesToolStripMenuItem, registrarClienteToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "&Clientes";
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            listadoDeClientesToolStripMenuItem.Size = new Size(171, 22);
            listadoDeClientesToolStripMenuItem.Text = "&Listado de clientes";
            listadoDeClientesToolStripMenuItem.Click += listadoDeClientesToolStripMenuItem_Click;
            // 
            // registrarClienteToolStripMenuItem
            // 
            registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            registrarClienteToolStripMenuItem.Size = new Size(171, 22);
            registrarClienteToolStripMenuItem.Text = "&Registrar cliente";
            registrarClienteToolStripMenuItem.Click += registrarClienteToolStripMenuItem_Click;
            // 
            // solicitudesToolStripMenuItem
            // 
            solicitudesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadoDeSolicitudesToolStripMenuItem, registrarSolicitudToolStripMenuItem });
            solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            solicitudesToolStripMenuItem.Size = new Size(76, 20);
            solicitudesToolStripMenuItem.Text = "&Solicitudes";
            // 
            // listadoDeSolicitudesToolStripMenuItem
            // 
            listadoDeSolicitudesToolStripMenuItem.Name = "listadoDeSolicitudesToolStripMenuItem";
            listadoDeSolicitudesToolStripMenuItem.Size = new Size(187, 22);
            listadoDeSolicitudesToolStripMenuItem.Text = "&Listado de solicitudes";
            listadoDeSolicitudesToolStripMenuItem.Click += listadoDeSolicitudesToolStripMenuItem_Click;
            // 
            // registrarSolicitudToolStripMenuItem
            // 
            registrarSolicitudToolStripMenuItem.Name = "registrarSolicitudToolStripMenuItem";
            registrarSolicitudToolStripMenuItem.Size = new Size(187, 22);
            registrarSolicitudToolStripMenuItem.Text = "&Registrar solicitud";
            registrarSolicitudToolStripMenuItem.Click += registrarSolicitudToolStripMenuItem_Click;
            // 
            // contratacionesToolStripMenuItem
            // 
            contratacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadoDeContratacionesToolStripMenuItem, preparaciónDeEquipamientoToolStripMenuItem, registroDePagosToolStripMenuItem });
            contratacionesToolStripMenuItem.Name = "contratacionesToolStripMenuItem";
            contratacionesToolStripMenuItem.Size = new Size(99, 20);
            contratacionesToolStripMenuItem.Text = "&Contrataciones";
            // 
            // listadoDeContratacionesToolStripMenuItem
            // 
            listadoDeContratacionesToolStripMenuItem.Name = "listadoDeContratacionesToolStripMenuItem";
            listadoDeContratacionesToolStripMenuItem.Size = new Size(230, 22);
            listadoDeContratacionesToolStripMenuItem.Text = "&Listado de contrataciones";
            // 
            // preparaciónDeEquipamientoToolStripMenuItem
            // 
            preparaciónDeEquipamientoToolStripMenuItem.Name = "preparaciónDeEquipamientoToolStripMenuItem";
            preparaciónDeEquipamientoToolStripMenuItem.Size = new Size(230, 22);
            preparaciónDeEquipamientoToolStripMenuItem.Text = "&Preparación de equipamiento";
            // 
            // registroDePagosToolStripMenuItem
            // 
            registroDePagosToolStripMenuItem.Name = "registroDePagosToolStripMenuItem";
            registroDePagosToolStripMenuItem.Size = new Size(230, 22);
            registroDePagosToolStripMenuItem.Text = "&Registro de pagos";
            // 
            // equipamientoToolStripMenuItem
            // 
            equipamientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadoDeEquiposToolStripMenuItem, registrarEquipoToolStripMenuItem, toolStripMenuItem1, depósitosToolStripMenuItem, tiposDeEquipamientoToolStripMenuItem, toolStripMenuItem2, cambioDeEstadoToolStripMenuItem });
            equipamientoToolStripMenuItem.Name = "equipamientoToolStripMenuItem";
            equipamientoToolStripMenuItem.Size = new Size(93, 20);
            equipamientoToolStripMenuItem.Text = "&Equipamiento";
            // 
            // listadoDeEquiposToolStripMenuItem
            // 
            listadoDeEquiposToolStripMenuItem.Name = "listadoDeEquiposToolStripMenuItem";
            listadoDeEquiposToolStripMenuItem.Size = new Size(196, 22);
            listadoDeEquiposToolStripMenuItem.Text = "&Listado de equipos";
            // 
            // registrarEquipoToolStripMenuItem
            // 
            registrarEquipoToolStripMenuItem.Name = "registrarEquipoToolStripMenuItem";
            registrarEquipoToolStripMenuItem.Size = new Size(196, 22);
            registrarEquipoToolStripMenuItem.Text = "&Registrar equipo";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(193, 6);
            // 
            // depósitosToolStripMenuItem
            // 
            depósitosToolStripMenuItem.Name = "depósitosToolStripMenuItem";
            depósitosToolStripMenuItem.Size = new Size(196, 22);
            depósitosToolStripMenuItem.Text = "&Depósitos";
            // 
            // tiposDeEquipamientoToolStripMenuItem
            // 
            tiposDeEquipamientoToolStripMenuItem.Name = "tiposDeEquipamientoToolStripMenuItem";
            tiposDeEquipamientoToolStripMenuItem.Size = new Size(196, 22);
            tiposDeEquipamientoToolStripMenuItem.Text = "&Tipos de equipamiento";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(193, 6);
            // 
            // cambioDeEstadoToolStripMenuItem
            // 
            cambioDeEstadoToolStripMenuItem.Name = "cambioDeEstadoToolStripMenuItem";
            cambioDeEstadoToolStripMenuItem.Size = new Size(196, 22);
            cambioDeEstadoToolStripMenuItem.Text = "&Cambio de estado";
            // 
            // devolucionesToolStripMenuItem
            // 
            devolucionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarDevoluciónToolStripMenuItem });
            devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            devolucionesToolStripMenuItem.Size = new Size(90, 20);
            devolucionesToolStripMenuItem.Text = "&Devoluciones";
            // 
            // registrarDevoluciónToolStripMenuItem
            // 
            registrarDevoluciónToolStripMenuItem.Name = "registrarDevoluciónToolStripMenuItem";
            registrarDevoluciónToolStripMenuItem.Size = new Size(182, 22);
            registrarDevoluciónToolStripMenuItem.Text = "&Registrar devolución";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarReportesToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "&Reportes";
            // 
            // consultarReportesToolStripMenuItem
            // 
            consultarReportesToolStripMenuItem.Name = "consultarReportesToolStripMenuItem";
            consultarReportesToolStripMenuItem.Size = new Size(171, 22);
            consultarReportesToolStripMenuItem.Text = "&Consultar reportes";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "&Salir";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 513);
            Controls.Add(pnlContenido);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private ToolStripMenuItem registrarClienteToolStripMenuItem;
        private ToolStripMenuItem solicitudesToolStripMenuItem;
        private ToolStripMenuItem listadoDeSolicitudesToolStripMenuItem;
        private ToolStripMenuItem registrarSolicitudToolStripMenuItem;
        private ToolStripMenuItem contratacionesToolStripMenuItem;
        private ToolStripMenuItem listadoDeContratacionesToolStripMenuItem;
        private ToolStripMenuItem preparaciónDeEquipamientoToolStripMenuItem;
        private ToolStripMenuItem registroDePagosToolStripMenuItem;
        private ToolStripMenuItem equipamientoToolStripMenuItem;
        private ToolStripMenuItem listadoDeEquiposToolStripMenuItem;
        private ToolStripMenuItem registrarEquipoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem depósitosToolStripMenuItem;
        private ToolStripMenuItem tiposDeEquipamientoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem cambioDeEstadoToolStripMenuItem;
        private ToolStripMenuItem devolucionesToolStripMenuItem;
        private ToolStripMenuItem registrarDevoluciónToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem consultarReportesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}