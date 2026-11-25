namespace AlquilerAudiovisual.Desktop.Clientes
{
    partial class FrmRegistroClientes
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            LblNombre = new Label();
            LblDocumento = new Label();
            LblEmail = new Label();
            LblTelefono = new Label();
            LblDireccion = new Label();
            LblText = new Label();
            BtnAgregarCli = new Button();
            BtnCancelar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 125);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Maria Jose";
            textBox1.Size = new Size(315, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 173);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "12345678";
            textBox2.Size = new Size(315, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 222);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "ejemplo@correo.com";
            textBox3.Size = new Size(315, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(199, 267);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "098123456";
            textBox4.Size = new Size(315, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(199, 308);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Dr Luis Casanello 830";
            textBox5.Size = new Size(315, 27);
            textBox5.TabIndex = 4;
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Location = new Point(129, 132);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(64, 20);
            LblNombre.TabIndex = 5;
            LblNombre.Text = "Nombre";
            // 
            // LblDocumento
            // 
            LblDocumento.AutoSize = true;
            LblDocumento.Location = new Point(106, 180);
            LblDocumento.Name = "LblDocumento";
            LblDocumento.Size = new Size(87, 20);
            LblDocumento.TabIndex = 6;
            LblDocumento.Text = "Documento";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(147, 229);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(46, 20);
            LblEmail.TabIndex = 7;
            LblEmail.Text = "Email";
            // 
            // LblTelefono
            // 
            LblTelefono.AutoSize = true;
            LblTelefono.Location = new Point(126, 274);
            LblTelefono.Name = "LblTelefono";
            LblTelefono.Size = new Size(67, 20);
            LblTelefono.TabIndex = 8;
            LblTelefono.Text = "Teléfono";
            // 
            // LblDireccion
            // 
            LblDireccion.AutoSize = true;
            LblDireccion.Location = new Point(121, 315);
            LblDireccion.Name = "LblDireccion";
            LblDireccion.Size = new Size(72, 20);
            LblDireccion.TabIndex = 9;
            LblDireccion.Text = "Dirección";
            // 
            // LblText
            // 
            LblText.AutoSize = true;
            LblText.Font = new Font("Segoe UI", 11F);
            LblText.Location = new Point(235, 68);
            LblText.Name = "LblText";
            LblText.Size = new Size(178, 25);
            LblText.TabIndex = 10;
            LblText.Text = "Registro de Clientes";
            // 
            // BtnAgregarCli
            // 
            BtnAgregarCli.BackColor = SystemColors.ActiveCaption;
            BtnAgregarCli.Location = new Point(389, 398);
            BtnAgregarCli.Name = "BtnAgregarCli";
            BtnAgregarCli.Size = new Size(99, 35);
            BtnAgregarCli.TabIndex = 5;
            BtnAgregarCli.Text = "&Agregar";
            BtnAgregarCli.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.IndianRed;
            BtnCancelar.Location = new Point(170, 398);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(99, 35);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmRegistroClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 499);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAgregarCli);
            Controls.Add(LblText);
            Controls.Add(LblDireccion);
            Controls.Add(LblTelefono);
            Controls.Add(LblEmail);
            Controls.Add(LblDocumento);
            Controls.Add(LblNombre);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FrmRegistroClientes";
            Text = "Registro Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label LblNombre;
        private Label LblDocumento;
        private Label LblEmail;
        private Label LblTelefono;
        private Label LblDireccion;
        private Label LblText;
        private Button BtnAgregarCli;
        private Button BtnCancelar;
    }
}