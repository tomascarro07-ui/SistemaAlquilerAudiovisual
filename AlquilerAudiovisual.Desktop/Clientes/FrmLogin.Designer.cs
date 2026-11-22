namespace AlquilerAudiovisual.Desktop.Clientes
{
    partial class FrmLogin
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
            TxtUserName = new TextBox();
            textBox2 = new TextBox();
            BtnAcceder = new Button();
            BtnSalir = new Button();
            LblName = new Label();
            LblPassword = new Label();
            LlblRegistro = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TxtUserName
            // 
            TxtUserName.Location = new Point(320, 368);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(249, 27);
            TxtUserName.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(320, 454);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 27);
            textBox2.TabIndex = 1;
            // 
            // BtnAcceder
            // 
            BtnAcceder.BackColor = Color.RoyalBlue;
            BtnAcceder.Location = new Point(460, 516);
            BtnAcceder.Name = "BtnAcceder";
            BtnAcceder.Size = new Size(94, 29);
            BtnAcceder.TabIndex = 2;
            BtnAcceder.Text = "&Acceder";
            BtnAcceder.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.IndianRed;
            BtnSalir.Location = new Point(339, 516);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(94, 29);
            BtnSalir.TabIndex = 3;
            BtnSalir.Text = "&Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(415, 345);
            LblName.Name = "LblName";
            LblName.Size = new Size(59, 20);
            LblName.TabIndex = 4;
            LblName.Text = "Usuario";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Location = new Point(402, 431);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(83, 20);
            LblPassword.TabIndex = 5;
            LblPassword.Text = "Contraseña";
            // 
            // LlblRegistro
            // 
            LlblRegistro.AutoSize = true;
            LlblRegistro.Location = new Point(417, 569);
            LlblRegistro.Name = "LlblRegistro";
            LlblRegistro.Size = new Size(64, 20);
            LlblRegistro.TabIndex = 4;
            LlblRegistro.TabStop = true;
            LlblRegistro.Text = "&Registro";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AVPro_850x290;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(850, 290);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 647);
            Controls.Add(pictureBox1);
            Controls.Add(LlblRegistro);
            Controls.Add(LblPassword);
            Controls.Add(LblName);
            Controls.Add(BtnSalir);
            Controls.Add(BtnAcceder);
            Controls.Add(textBox2);
            Controls.Add(TxtUserName);
            Name = "FrmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtUserName;
        private TextBox textBox2;
        private Button BtnAcceder;
        private Button BtnSalir;
        private Label LblName;
        private Label LblPassword;
        private LinkLabel LlblRegistro;
        private PictureBox pictureBox1;
    }
}