namespace AlquilerAudiovisual.Desktop.Equipamiento
{
    partial class FrmCambioEstadoEquipo
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
            DTP_FechaCambio = new DateTimePicker();
            Txt_NuevoEstado = new TextBox();
            Txt_Observaciones = new TextBox();
            Lbl_Id = new Label();
            Lbl_Observaciones = new Label();
            LblTitulo = new Label();
            Btn_Cambiar = new Button();
            Btn_Cancelar = new Button();
            menuStrip1 = new MenuStrip();
            TSMI_Atras = new ToolStripMenuItem();
            Txt_IdCambioEstado = new TextBox();
            Lbl_CambioFecha = new Label();
            Lbl_NuevoEstado = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DTP_FechaCambio
            // 
            DTP_FechaCambio.Location = new Point(256, 238);
            DTP_FechaCambio.MinDate = new DateTime(2026, 11, 26, 0, 0, 0, 0);
            DTP_FechaCambio.Name = "DTP_FechaCambio";
            DTP_FechaCambio.Size = new Size(250, 27);
            DTP_FechaCambio.TabIndex = 1;
            // 
            // Txt_NuevoEstado
            // 
            Txt_NuevoEstado.Location = new Point(256, 322);
            Txt_NuevoEstado.Name = "Txt_NuevoEstado";
            Txt_NuevoEstado.Size = new Size(250, 27);
            Txt_NuevoEstado.TabIndex = 2;
            // 
            // Txt_Observaciones
            // 
            Txt_Observaciones.Location = new Point(256, 388);
            Txt_Observaciones.Multiline = true;
            Txt_Observaciones.Name = "Txt_Observaciones";
            Txt_Observaciones.Size = new Size(250, 80);
            Txt_Observaciones.TabIndex = 3;
            // 
            // Lbl_Id
            // 
            Lbl_Id.AutoSize = true;
            Lbl_Id.Location = new Point(88, 165);
            Lbl_Id.Name = "Lbl_Id";
            Lbl_Id.Size = new Size(127, 20);
            Lbl_Id.TabIndex = 4;
            Lbl_Id.Text = "Id Cambio Estado";
            // 
            // Lbl_Observaciones
            // 
            Lbl_Observaciones.AutoSize = true;
            Lbl_Observaciones.Location = new Point(110, 391);
            Lbl_Observaciones.Name = "Lbl_Observaciones";
            Lbl_Observaciones.Size = new Size(105, 20);
            Lbl_Observaciones.TabIndex = 7;
            Lbl_Observaciones.Text = "Observaciones";
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 15F);
            LblTitulo.Location = new Point(160, 65);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(310, 35);
            LblTitulo.TabIndex = 8;
            LblTitulo.Text = "Cambiar Estado de Equipo";
            // 
            // Btn_Cambiar
            // 
            Btn_Cambiar.BackColor = SystemColors.ActiveCaption;
            Btn_Cambiar.Location = new Point(370, 549);
            Btn_Cambiar.Name = "Btn_Cambiar";
            Btn_Cambiar.Size = new Size(100, 32);
            Btn_Cambiar.TabIndex = 9;
            Btn_Cambiar.Text = "&Guardar";
            Btn_Cambiar.UseVisualStyleBackColor = false;
            Btn_Cambiar.Click += Btn_Cambiar_Click;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.BackColor = Color.IndianRed;
            Btn_Cancelar.Location = new Point(160, 549);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(100, 32);
            Btn_Cancelar.TabIndex = 10;
            Btn_Cancelar.Text = "&Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = false;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMI_Atras });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(625, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Atras
            // 
            TSMI_Atras.Name = "TSMI_Atras";
            TSMI_Atras.Size = new Size(57, 24);
            TSMI_Atras.Text = "&Atras";
            TSMI_Atras.Click += TSMI_Atras_Click;
            // 
            // Txt_IdCambioEstado
            // 
            Txt_IdCambioEstado.Location = new Point(256, 162);
            Txt_IdCambioEstado.Name = "Txt_IdCambioEstado";
            Txt_IdCambioEstado.PlaceholderText = "Read Only";
            Txt_IdCambioEstado.ReadOnly = true;
            Txt_IdCambioEstado.Size = new Size(250, 27);
            Txt_IdCambioEstado.TabIndex = 12;
            // 
            // Lbl_CambioFecha
            // 
            Lbl_CambioFecha.AutoSize = true;
            Lbl_CambioFecha.Location = new Point(91, 243);
            Lbl_CambioFecha.Name = "Lbl_CambioFecha";
            Lbl_CambioFecha.Size = new Size(124, 20);
            Lbl_CambioFecha.TabIndex = 13;
            Lbl_CambioFecha.Text = "Cambio de Fecha";
            // 
            // Lbl_NuevoEstado
            // 
            Lbl_NuevoEstado.AutoSize = true;
            Lbl_NuevoEstado.Location = new Point(114, 325);
            Lbl_NuevoEstado.Name = "Lbl_NuevoEstado";
            Lbl_NuevoEstado.Size = new Size(101, 20);
            Lbl_NuevoEstado.TabIndex = 14;
            Lbl_NuevoEstado.Text = "Nuevo Estado";
            // 
            // FrmCambioEstadoEquipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(625, 689);
            Controls.Add(Lbl_NuevoEstado);
            Controls.Add(Lbl_CambioFecha);
            Controls.Add(Txt_IdCambioEstado);
            Controls.Add(Btn_Cancelar);
            Controls.Add(Btn_Cambiar);
            Controls.Add(LblTitulo);
            Controls.Add(Lbl_Observaciones);
            Controls.Add(Lbl_Id);
            Controls.Add(Txt_Observaciones);
            Controls.Add(Txt_NuevoEstado);
            Controls.Add(DTP_FechaCambio);
            Controls.Add(menuStrip1);
            Name = "FrmCambioEstadoEquipo";
            Text = "Cambio Estado de Equipo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private DateTimePicker DTP_FechaCambio;
        private TextBox Txt_NuevoEstado;
        private TextBox Txt_Observaciones;
        private Label Lbl_Id;



        private Label label2;
        private Label label3;
        private Label Lbl_Observaciones;
        private Label LblTitulo;
        private Button Btn_Cambiar;
        private Button Btn_Cancelar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMI_Atras;
        private TextBox Txt_IdCambioEstado;
        private Label Lbl_CambioFecha;
        private Label Lbl_NuevoEstado;
    }
}