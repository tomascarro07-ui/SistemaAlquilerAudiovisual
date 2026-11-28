using AlquilerAudiovisual.Entities.Solicitudes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlquilerAudiovisual.Desktop.Equipamiento
{
    public partial class FrmCambioEstadoEquipo : Form
    {
        

        public FrmCambioEstadoEquipo()
        {
            InitializeComponent();
            
        }

        private void TSMI_Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Botones
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        //Boton Guardar
        private void Btn_Cambiar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void LimpiarControles()
        {
            Txt_IdCambioEstado.Text = string.Empty;
            Txt_NuevoEstado.Text = string.Empty;
            Txt_Observaciones.Text = string.Empty;
            //DTP_FechaCambio
        }
    }
}
