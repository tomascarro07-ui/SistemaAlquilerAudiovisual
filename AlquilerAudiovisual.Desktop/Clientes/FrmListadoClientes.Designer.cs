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
            menuStrip1 = new MenuStrip();
            TSMI_Atras = new ToolStripMenuItem();
            TSMI_AgregarCli = new ToolStripMenuItem();
            DGV_CliList = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_CliList).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMI_Atras, TSMI_AgregarCli });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Atras
            // 
            TSMI_Atras.Name = "TSMI_Atras";
            TSMI_Atras.Size = new Size(57, 24);
            TSMI_Atras.Text = "&Atras";
            TSMI_Atras.Click += TSMI_Atras_Click;
            // 
            // TSMI_AgregarCli
            // 
            TSMI_AgregarCli.Name = "TSMI_AgregarCli";
            TSMI_AgregarCli.Size = new Size(127, 24);
            TSMI_AgregarCli.Text = "A&gregar Cliente";
            TSMI_AgregarCli.Click += TSMI_AgregarCli_Click;
            // 
            // DGV_CliList
            // 
            DGV_CliList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_CliList.Location = new Point(12, 31);
            DGV_CliList.Name = "DGV_CliList";
            DGV_CliList.RowHeadersWidth = 51;
            DGV_CliList.Size = new Size(776, 354);
            DGV_CliList.TabIndex = 1;
            // 
            // FrmListadoClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DGV_CliList);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmListadoClientes";
            Text = "Listado de Clientes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_CliList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMI_Atras;
        private ToolStripMenuItem TSMI_AgregarCli;
        private DataGridView DGV_CliList;
    }
}