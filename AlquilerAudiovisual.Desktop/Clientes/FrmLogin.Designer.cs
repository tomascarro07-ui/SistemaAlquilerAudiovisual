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
            TxtPassword = new TextBox();
            BtnAcceder = new Button();
            BtnSalir = new Button();
            LblName = new Label();
            LblPassword = new Label();
            LlblRegistro = new LinkLabel();
            SuspendLayout();
            // 
            // TxtUserName
            // 
            TxtUserName.Location = new Point(108, 140);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(249, 27);
            TxtUserName.TabIndex = 0;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(108, 246);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(249, 27);
            TxtPassword.TabIndex = 1;
            // 
            // BtnAcceder
            // 
            BtnAcceder.BackColor = Color.RoyalBlue;
            BtnAcceder.Location = new Point(248, 308);
            BtnAcceder.Name = "BtnAcceder";
            BtnAcceder.Size = new Size(94, 29);
            BtnAcceder.TabIndex = 2;
            BtnAcceder.Text = "&Acceder";
            BtnAcceder.UseVisualStyleBackColor = false;
            BtnAcceder.Click += BtnAcceder_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.IndianRed;
            BtnSalir.Location = new Point(127, 308);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(94, 29);
            BtnSalir.TabIndex = 3;
            BtnSalir.Text = "&Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(203, 117);
            LblName.Name = "LblName";
            LblName.Size = new Size(59, 20);
            LblName.TabIndex = 4;
            LblName.Text = "Usuario";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Location = new Point(190, 223);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(83, 20);
            LblPassword.TabIndex = 5;
            LblPassword.Text = "Contraseña";
            // 
            // LlblRegistro
            // 
            LlblRegistro.AutoSize = true;
            LlblRegistro.Location = new Point(205, 361);
            LlblRegistro.Name = "LlblRegistro";
            LlblRegistro.Size = new Size(64, 20);
            LlblRegistro.TabIndex = 4;
            LlblRegistro.TabStop = true;
            LlblRegistro.Text = "&Registro";
            LlblRegistro.LinkClicked += LlblRegistro_LinkClicked;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 522);
            Controls.Add(LlblRegistro);
            Controls.Add(LblPassword);
            Controls.Add(LblName);
            Controls.Add(BtnSalir);
            Controls.Add(BtnAcceder);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUserName);
            Name = "FrmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtUserName;
        private TextBox TxtPassword;
        private Button BtnAcceder;
        private Button BtnSalir;
        private Label LblName;
        private Label LblPassword;
        private LinkLabel LlblRegistro;
    }
}