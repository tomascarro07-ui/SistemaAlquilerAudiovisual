namespace AlquilerAudiovisual.Desktop.Equipamiento
{
    partial class FrmRegistroEquipos
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
            Txt_Marca = new TextBox();
            Txt_Modelo = new TextBox();
            Txt_Descripcion = new TextBox();
            Lbl_Marca = new Label();
            Lbl_Modelo = new Label();
            Lbl_Descripcion = new Label();
            Lbl_Estado = new Label();
            Lbl_Caracteristicas = new Label();
            Lbl_TipoEquipamiento = new Label();
            Lbl_Deposito = new Label();
            Lbl_Titulo = new Label();
            Btn_AgregarEquipo = new Button();
            Btn_Cancelar = new Button();
            menuStrip1 = new MenuStrip();
            TSMI_Atras = new ToolStripMenuItem();
            TSMI_LimpiarControles = new ToolStripMenuItem();
            TSMI_ListarEquipos = new ToolStripMenuItem();
            CMB_Estado = new ComboBox();
            CMB_Deposito = new ComboBox();
            CMB_TipoEquipamiento = new ComboBox();
            DGV_Caracteristicas = new DataGridView();
            Lbl_Stock = new Label();
            NUD_Stock = new NumericUpDown();
            RB_Identificable = new RadioButton();
            Lbl_TipoEquipo = new Label();
            SPC_MainC = new SplitContainer();
            comboBox1 = new ComboBox();
            RD_PorCantidad = new RadioButton();
            Txt_IdEquipo = new TextBox();
            Lbl_IdEquipo = new Label();
            Lbl_NSerie = new Label();
            Txt_NumeroSerie = new TextBox();
            splitter1 = new Splitter();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Caracteristicas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Stock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SPC_MainC).BeginInit();
            SPC_MainC.Panel1.SuspendLayout();
            SPC_MainC.Panel2.SuspendLayout();
            SPC_MainC.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_Marca
            // 
            Txt_Marca.Location = new Point(279, 72);
            Txt_Marca.Name = "Txt_Marca";
            Txt_Marca.Size = new Size(198, 27);
            Txt_Marca.TabIndex = 1;
            // 
            // Txt_Modelo
            // 
            Txt_Modelo.Location = new Point(279, 128);
            Txt_Modelo.Name = "Txt_Modelo";
            Txt_Modelo.Size = new Size(198, 27);
            Txt_Modelo.TabIndex = 2;
            // 
            // Txt_Descripcion
            // 
            Txt_Descripcion.Location = new Point(279, 185);
            Txt_Descripcion.Name = "Txt_Descripcion";
            Txt_Descripcion.Size = new Size(198, 27);
            Txt_Descripcion.TabIndex = 3;
            // 
            // Lbl_Marca
            // 
            Lbl_Marca.AutoSize = true;
            Lbl_Marca.Location = new Point(203, 75);
            Lbl_Marca.Name = "Lbl_Marca";
            Lbl_Marca.Size = new Size(50, 20);
            Lbl_Marca.TabIndex = 9;
            Lbl_Marca.Text = "Marca";
            // 
            // Lbl_Modelo
            // 
            Lbl_Modelo.AutoSize = true;
            Lbl_Modelo.Location = new Point(192, 131);
            Lbl_Modelo.Name = "Lbl_Modelo";
            Lbl_Modelo.Size = new Size(61, 20);
            Lbl_Modelo.TabIndex = 10;
            Lbl_Modelo.Text = "Modelo";
            // 
            // Lbl_Descripcion
            // 
            Lbl_Descripcion.AutoSize = true;
            Lbl_Descripcion.Location = new Point(166, 188);
            Lbl_Descripcion.Name = "Lbl_Descripcion";
            Lbl_Descripcion.Size = new Size(87, 20);
            Lbl_Descripcion.TabIndex = 11;
            Lbl_Descripcion.Text = "Descripción";
            // 
            // Lbl_Estado
            // 
            Lbl_Estado.AutoSize = true;
            Lbl_Estado.Location = new Point(199, 247);
            Lbl_Estado.Name = "Lbl_Estado";
            Lbl_Estado.Size = new Size(54, 20);
            Lbl_Estado.TabIndex = 12;
            Lbl_Estado.Text = "Estado";
            // 
            // Lbl_Caracteristicas
            // 
            Lbl_Caracteristicas.AutoSize = true;
            Lbl_Caracteristicas.Location = new Point(3, 11);
            Lbl_Caracteristicas.Name = "Lbl_Caracteristicas";
            Lbl_Caracteristicas.Size = new Size(104, 20);
            Lbl_Caracteristicas.TabIndex = 13;
            Lbl_Caracteristicas.Text = "Caracteristicas";
            // 
            // Lbl_TipoEquipamiento
            // 
            Lbl_TipoEquipamiento.AutoSize = true;
            Lbl_TipoEquipamiento.Location = new Point(214, 310);
            Lbl_TipoEquipamiento.Name = "Lbl_TipoEquipamiento";
            Lbl_TipoEquipamiento.Size = new Size(39, 20);
            Lbl_TipoEquipamiento.TabIndex = 14;
            Lbl_TipoEquipamiento.Text = "Tipo";
            // 
            // Lbl_Deposito
            // 
            Lbl_Deposito.AutoSize = true;
            Lbl_Deposito.Location = new Point(177, 371);
            Lbl_Deposito.Name = "Lbl_Deposito";
            Lbl_Deposito.Size = new Size(70, 20);
            Lbl_Deposito.TabIndex = 15;
            Lbl_Deposito.Text = "Deposito";
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI", 15F);
            Lbl_Titulo.Location = new Point(231, 18);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(198, 35);
            Lbl_Titulo.TabIndex = 16;
            Lbl_Titulo.Text = "Registrar Equipo";
            // 
            // Btn_AgregarEquipo
            // 
            Btn_AgregarEquipo.BackColor = SystemColors.ActiveCaption;
            Btn_AgregarEquipo.Location = new Point(368, 192);
            Btn_AgregarEquipo.Name = "Btn_AgregarEquipo";
            Btn_AgregarEquipo.Size = new Size(109, 44);
            Btn_AgregarEquipo.TabIndex = 17;
            Btn_AgregarEquipo.Text = "&Agregar";
            Btn_AgregarEquipo.UseVisualStyleBackColor = false;
            Btn_AgregarEquipo.Click += Btn_AgregarEquipo_Click;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.BackColor = Color.IndianRed;
            Btn_Cancelar.Location = new Point(160, 192);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(109, 44);
            Btn_Cancelar.TabIndex = 18;
            Btn_Cancelar.Text = "&Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = false;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMI_Atras, TSMI_LimpiarControles, TSMI_ListarEquipos });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(695, 28);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Atras
            // 
            TSMI_Atras.Name = "TSMI_Atras";
            TSMI_Atras.Size = new Size(57, 24);
            TSMI_Atras.Text = "&Atras";
            TSMI_Atras.Click += TSMI_Atras_Click;
            // 
            // TSMI_LimpiarControles
            // 
            TSMI_LimpiarControles.Name = "TSMI_LimpiarControles";
            TSMI_LimpiarControles.Size = new Size(140, 24);
            TSMI_LimpiarControles.Text = "&Limpiar Controles";
            TSMI_LimpiarControles.Click += TSMI_LimpiarControles_Click;
            // 
            // TSMI_ListarEquipos
            // 
            TSMI_ListarEquipos.Name = "TSMI_ListarEquipos";
            TSMI_ListarEquipos.Size = new Size(115, 24);
            TSMI_ListarEquipos.Text = "L&istar Equipos";
            TSMI_ListarEquipos.Click += TSMI_ListarEquipos_Click;
            // 
            // CMB_Estado
            // 
            CMB_Estado.FormattingEnabled = true;
            CMB_Estado.Location = new Point(279, 244);
            CMB_Estado.Name = "CMB_Estado";
            CMB_Estado.Size = new Size(198, 28);
            CMB_Estado.TabIndex = 20;
            // 
            // CMB_Deposito
            // 
            CMB_Deposito.FormattingEnabled = true;
            CMB_Deposito.Location = new Point(279, 368);
            CMB_Deposito.Name = "CMB_Deposito";
            CMB_Deposito.Size = new Size(198, 28);
            CMB_Deposito.TabIndex = 21;
            // 
            // CMB_TipoEquipamiento
            // 
            CMB_TipoEquipamiento.FormattingEnabled = true;
            CMB_TipoEquipamiento.Location = new Point(279, 307);
            CMB_TipoEquipamiento.Name = "CMB_TipoEquipamiento";
            CMB_TipoEquipamiento.Size = new Size(198, 28);
            CMB_TipoEquipamiento.TabIndex = 23;
            // 
            // DGV_Caracteristicas
            // 
            DGV_Caracteristicas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Caracteristicas.Location = new Point(3, 34);
            DGV_Caracteristicas.Name = "DGV_Caracteristicas";
            DGV_Caracteristicas.RowHeadersWidth = 51;
            DGV_Caracteristicas.Size = new Size(656, 136);
            DGV_Caracteristicas.TabIndex = 24;
            // 
            // Lbl_Stock
            // 
            Lbl_Stock.AutoSize = true;
            Lbl_Stock.Location = new Point(196, 660);
            Lbl_Stock.Name = "Lbl_Stock";
            Lbl_Stock.Size = new Size(45, 20);
            Lbl_Stock.TabIndex = 25;
            Lbl_Stock.Text = "Stock";
            // 
            // NUD_Stock
            // 
            NUD_Stock.Location = new Point(279, 658);
            NUD_Stock.Name = "NUD_Stock";
            NUD_Stock.RightToLeft = RightToLeft.No;
            NUD_Stock.Size = new Size(110, 27);
            NUD_Stock.TabIndex = 26;
            NUD_Stock.TextAlign = HorizontalAlignment.Right;
            // 
            // RB_Identificable
            // 
            RB_Identificable.AutoSize = true;
            RB_Identificable.Location = new Point(134, 494);
            RB_Identificable.Name = "RB_Identificable";
            RB_Identificable.Size = new Size(113, 24);
            RB_Identificable.TabIndex = 27;
            RB_Identificable.TabStop = true;
            RB_Identificable.Text = "Identificable";
            RB_Identificable.UseVisualStyleBackColor = true;
            RB_Identificable.CheckedChanged += RB_Identificable_CheckedChanged;
            // 
            // Lbl_TipoEquipo
            // 
            Lbl_TipoEquipo.AutoSize = true;
            Lbl_TipoEquipo.Location = new Point(96, 431);
            Lbl_TipoEquipo.Name = "Lbl_TipoEquipo";
            Lbl_TipoEquipo.Size = new Size(111, 20);
            Lbl_TipoEquipo.TabIndex = 28;
            Lbl_TipoEquipo.Text = "Tipo de Equipo";
            // 
            // SPC_MainC
            // 
            SPC_MainC.Location = new Point(12, 31);
            SPC_MainC.Name = "SPC_MainC";
            SPC_MainC.Orientation = Orientation.Horizontal;
            // 
            // SPC_MainC.Panel1
            // 
            SPC_MainC.Panel1.Controls.Add(comboBox1);
            SPC_MainC.Panel1.Controls.Add(RD_PorCantidad);
            SPC_MainC.Panel1.Controls.Add(Txt_IdEquipo);
            SPC_MainC.Panel1.Controls.Add(Lbl_Titulo);
            SPC_MainC.Panel1.Controls.Add(Lbl_IdEquipo);
            SPC_MainC.Panel1.Controls.Add(Lbl_NSerie);
            SPC_MainC.Panel1.Controls.Add(Txt_NumeroSerie);
            SPC_MainC.Panel1.Controls.Add(splitter1);
            SPC_MainC.Panel1.Controls.Add(Lbl_TipoEquipo);
            SPC_MainC.Panel1.Controls.Add(Lbl_Marca);
            SPC_MainC.Panel1.Controls.Add(NUD_Stock);
            SPC_MainC.Panel1.Controls.Add(Lbl_Stock);
            SPC_MainC.Panel1.Controls.Add(RB_Identificable);
            SPC_MainC.Panel1.Controls.Add(Txt_Marca);
            SPC_MainC.Panel1.Controls.Add(Txt_Modelo);
            SPC_MainC.Panel1.Controls.Add(Txt_Descripcion);
            SPC_MainC.Panel1.Controls.Add(CMB_Deposito);
            SPC_MainC.Panel1.Controls.Add(Lbl_Modelo);
            SPC_MainC.Panel1.Controls.Add(Lbl_Descripcion);
            SPC_MainC.Panel1.Controls.Add(CMB_TipoEquipamiento);
            SPC_MainC.Panel1.Controls.Add(Lbl_Estado);
            SPC_MainC.Panel1.Controls.Add(Lbl_Deposito);
            SPC_MainC.Panel1.Controls.Add(Lbl_TipoEquipamiento);
            SPC_MainC.Panel1.Controls.Add(CMB_Estado);
            // 
            // SPC_MainC.Panel2
            // 
            SPC_MainC.Panel2.Controls.Add(Btn_AgregarEquipo);
            SPC_MainC.Panel2.Controls.Add(DGV_Caracteristicas);
            SPC_MainC.Panel2.Controls.Add(Btn_Cancelar);
            SPC_MainC.Panel2.Controls.Add(Lbl_Caracteristicas);
            SPC_MainC.Size = new Size(662, 961);
            SPC_MainC.SplitterDistance = 718;
            SPC_MainC.TabIndex = 29;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(279, 428);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 28);
            comboBox1.TabIndex = 34;
            // 
            // RD_PorCantidad
            // 
            RD_PorCantidad.AutoSize = true;
            RD_PorCantidad.Location = new Point(362, 494);
            RD_PorCantidad.Name = "RD_PorCantidad";
            RD_PorCantidad.Size = new Size(115, 24);
            RD_PorCantidad.TabIndex = 33;
            RD_PorCantidad.TabStop = true;
            RD_PorCantidad.Text = "Por Cantidad";
            RD_PorCantidad.UseVisualStyleBackColor = true;
            // 
            // Txt_IdEquipo
            // 
            Txt_IdEquipo.Location = new Point(279, 609);
            Txt_IdEquipo.Name = "Txt_IdEquipo";
            Txt_IdEquipo.ReadOnly = true;
            Txt_IdEquipo.Size = new Size(198, 27);
            Txt_IdEquipo.TabIndex = 32;
            // 
            // Lbl_IdEquipo
            // 
            Lbl_IdEquipo.AutoSize = true;
            Lbl_IdEquipo.Location = new Point(155, 612);
            Lbl_IdEquipo.Name = "Lbl_IdEquipo";
            Lbl_IdEquipo.Size = new Size(98, 20);
            Lbl_IdEquipo.TabIndex = 31;
            Lbl_IdEquipo.Text = "Id del Equipo";
            // 
            // Lbl_NSerie
            // 
            Lbl_NSerie.AutoSize = true;
            Lbl_NSerie.Location = new Point(132, 554);
            Lbl_NSerie.Name = "Lbl_NSerie";
            Lbl_NSerie.Size = new Size(121, 20);
            Lbl_NSerie.TabIndex = 30;
            Lbl_NSerie.Text = "Numero de Serie";
            // 
            // Txt_NumeroSerie
            // 
            Txt_NumeroSerie.Location = new Point(279, 551);
            Txt_NumeroSerie.Name = "Txt_NumeroSerie";
            Txt_NumeroSerie.PlaceholderText = "SN-123456";
            Txt_NumeroSerie.Size = new Size(198, 27);
            Txt_NumeroSerie.TabIndex = 29;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 718);
            splitter1.TabIndex = 24;
            splitter1.TabStop = false;
            // 
            // FrmRegistroEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(695, 1008);
            Controls.Add(SPC_MainC);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmRegistroEquipos";
            Text = "Registro de Equipos";
            Load += FrmRegistroEquipos_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Caracteristicas).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Stock).EndInit();
            SPC_MainC.Panel1.ResumeLayout(false);
            SPC_MainC.Panel1.PerformLayout();
            SPC_MainC.Panel2.ResumeLayout(false);
            SPC_MainC.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SPC_MainC).EndInit();
            SPC_MainC.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Txt_Marca;
        private TextBox Txt_Modelo;
        private TextBox Txt_Descripcion;

        public TextBox Txt_Caracteristicas { get; private set; }

        private TextBox textBox5;
        private TextBox textBox6;
        private Label Lbl_Marca;
        private Label Lbl_Modelo;
        private Label Lbl_Descripcion;
        private Label Lbl_Estado;
        private Label Lbl_Caracteristicas;
        private Label Lbl_TipoEquipamiento;
        private Label Lbl_Deposito;
        private Label Lbl_Titulo;
        private Button Btn_AgregarEquipo;
        private Button Btn_Cancelar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMI_Atras;
        private ToolStripMenuItem TSMI_LimpiarControles;
        private ToolStripMenuItem TSMI_ListarEquipos;
        private ComboBox CMB_Estado;
        private ComboBox CMB_Deposito;
        private ComboBox CMB_TipoEquipamiento;
        private DataGridView DGV_Caracteristicas;
        private Label Lbl_Stock;
        private NumericUpDown NUD_Stock;
        private RadioButton RB_Identificable;
        private Label Lbl_TipoEquipo;
        private SplitContainer SPC_MainC;
        private Splitter splitter1;
        private Label Lbl_NSerie;
        private TextBox Txt_NumeroSerie;
        private ComboBox comboBox1;
        private RadioButton RD_PorCantidad;
        private TextBox Txt_IdEquipo;
        private Label Lbl_IdEquipo;
    }
}