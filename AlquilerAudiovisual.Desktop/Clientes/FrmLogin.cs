using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlquilerAudiovisual.Desktop.Clientes
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            //Preguntar despues el manejo de los usuarios para ingresar a la app.
            if (TxtUserName.Text == "admin" && TxtPassword.Text == "1234")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void LlblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Preguntar despues!
        }
    }
}
