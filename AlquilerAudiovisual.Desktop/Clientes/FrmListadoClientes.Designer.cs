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
            DGV_CliList = new DataGridView();
            LblClientList = new Label();
            MS_Menu = new MenuStrip();
            TSMI_Atras = new ToolStripMenuItem();
            TSMI_AgregarCli = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)DGV_CliList).BeginInit();
            MS_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_CliList
            // 
            DGV_CliList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_CliList.Location = new Point(76, 81);
            DGV_CliList.Name = "DGV_CliList";
            DGV_CliList.RowHeadersWidth = 51;
            DGV_CliList.Size = new Size(976, 472);
            DGV_CliList.TabIndex = 0;
            DGV_CliList.CellContentClick += DGV_CliList_CellContentClick;
            // 
            // LblClientList
            // 
            LblClientList.AutoSize = true;
            LblClientList.Font = new Font("Segoe UI", 12F);
            LblClientList.Location = new Point(76, 50);
            LblClientList.Name = "LblClientList";
            LblClientList.Size = new Size(151, 28);
            LblClientList.TabIndex = 1;
            LblClientList.Text = "Lista de Clientes";
            // 
            // MS_Menu
            // 
            MS_Menu.ImageScalingSize = new Size(20, 20);
            MS_Menu.Items.AddRange(new ToolStripItem[] { TSMI_Atras, TSMI_AgregarCli });
            MS_Menu.Location = new Point(0, 0);
            MS_Menu.Name = "MS_Menu";
            MS_Menu.Size = new Size(1132, 28);
            MS_Menu.TabIndex = 2;
            MS_Menu.Text = "menuStrip1";
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
            TSMI_AgregarCli.Size = new Size(133, 24);
            TSMI_AgregarCli.Text = "Agregar &Clientes";
            TSMI_AgregarCli.Click += TSMI_AgregarCli_Click;
            // 
            // FrmListadoClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 803);
            Controls.Add(LblClientList);
            Controls.Add(DGV_CliList);
            Controls.Add(MS_Menu);
            MainMenuStrip = MS_Menu;
            Name = "FrmListadoClientes";
            Text = "Listado de Clientes";
            ((System.ComponentModel.ISupportInitialize)DGV_CliList).EndInit();
            MS_Menu.ResumeLayout(false);
            MS_Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_CliList;
        private Label LblClientList;
        private MenuStrip MS_Menu;
        private ToolStripMenuItem TSMI_Atras;
        private ToolStripMenuItem TSMI_AgregarCli;
    }
}