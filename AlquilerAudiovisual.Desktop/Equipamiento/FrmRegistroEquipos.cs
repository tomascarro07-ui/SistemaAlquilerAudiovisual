using AlquilerAudiovisual.Dominio;
using AlquilerAudiovisual.Entities.Enumerados;
using AlquilerAudiovisual.Entities.Equipamientos;
using AlquilerAudiovisual.Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlquilerAudiovisual.Desktop.Equipamiento
{
    public partial class FrmRegistroEquipos : Form
    {
        private readonly GestorEquipamiento? gestor = new GestorEquipamiento();

        public FrmRegistroEquipos()
        {
            InitializeComponent();

        }

        #region Botones
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_AgregarEquipo_Click(object sender, EventArgs e)
        {
            if (CMB_TipoEquipamiento.SelectedItem == null ||
                CMB_Deposito.SelectedItem == null ||
                CMB_Estado.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná tipo, depósito y estado.", "Faltan datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string marca = Txt_Marca.Text.Trim();
                string modelo = Txt_Modelo.Text.Trim();
                string? descripcion = string.IsNullOrWhiteSpace(Txt_Descripcion.Text) ? null : Txt_Descripcion.Text.Trim();
                var estado = (EstadoEquipo)CMB_Estado.SelectedItem;
                var tipo = (TipoEquipamiento)CMB_TipoEquipamiento.SelectedItem;
                var deposito = (Deposito)CMB_Deposito.SelectedItem;
                var caracteristicas = ObtenerCaracteristicas();

                string mensaje;

                if (RB_Identificable.Checked)
                {
                    var equipo = new EquipoIdentificable(0, marca, modelo, descripcion, estado,
                        caracteristicas, tipo, deposito,
                        Txt_NumeroSerie.Text.Trim(),
                        "");   // el código interno lo genera el gestor

                    int id = gestor.AgregarEquipoIdentificable(equipo);
                    mensaje = $"Equipo registrado.\nId: {id}\nCódigo interno: {equipo.CodigoInterno}";
                }
                else
                {
                    var equipo = new EquipoPorCantidad(0, marca, modelo, descripcion, estado,
                        caracteristicas, tipo, deposito,
                        (int)NUD_Stock.Value);

                    int id = gestor.AgregarEquipoPorCantidad(equipo);
                    mensaje = $"Equipo registrado.\nId: {id}";
                }

                MessageBox.Show(mensaje, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrillaCaracteristicas()
        {
            DGV_Caracteristicas.Columns.Clear();
            DGV_Caracteristicas.Columns.Add("Col_Nombre", "Nombre");
            DGV_Caracteristicas.Columns.Add("Col_Valor", "Valor");
            DGV_Caracteristicas.AllowUserToAddRows = true;
            DGV_Caracteristicas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Caracteristicas.RowHeadersVisible = false;
        }

        
        private void RB_TipoEquipo_CheckedChanged(object sender, EventArgs e)
        {
            bool identificable = RB_Identificable.Checked;

            Txt_NumeroSerie.Enabled = identificable;
            Lbl_IdEquipo.Enabled = identificable;
            NUD_Stock.Enabled = !identificable;

            if (identificable) NUD_Stock.Value = 0;
            else Txt_NumeroSerie.Clear();
        }

        
        private List<Caracteristica> ObtenerCaracteristicas()
        {
            var lista = new List<Caracteristica>();

            foreach (DataGridViewRow fila in DGV_Caracteristicas.Rows)
            {
                if (fila.IsNewRow) continue;

                string nombre = fila.Cells["Col_Nombre"].Value?.ToString()?.Trim() ?? "";
                string valor = fila.Cells["Col_Valor"].Value?.ToString()?.Trim() ?? "";

                if (nombre == "" && valor == "") continue;

                lista.Add(new Caracteristica { Nombre = nombre, Valor = valor });
            }
            return lista;
        }
        #endregion

        #region MenuStripAction
        private void TSMI_Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMI_LimpiarControles_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void TSMI_ListarEquipos_Click(object sender, EventArgs e)
        {
            FrmListadoEquipos frmListadoEquipos = new FrmListadoEquipos();
            frmListadoEquipos.Show();
        }
        #endregion


        private void FrmRegistroEquipos_Load(object sender, EventArgs e)
        {
            try
            {
                CMB_TipoEquipamiento.DataSource = gestor.LeerTiposEquipamientos();
                CMB_TipoEquipamiento.DisplayMember = "Nombre";

                CMB_Deposito.DataSource = gestor.LeerDepositos();
                CMB_Deposito.DisplayMember = "Nombre";

                CMB_Estado.DataSource = Enum.GetValues(typeof(EstadoEquipo));

                ConfigurarGrillaCaracteristicas();

                NUD_Stock.Maximum = 1000;
                Lbl_IdEquipo.Text = "Se asigna al guardar";
                RB_Identificable.Checked = true;

                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarControles()
        {
            Txt_Marca.Clear();
            Txt_Modelo.Clear();
            Txt_Descripcion.Clear();

           
            CMB_Deposito.SelectedIndex = 0;
            CMB_Estado.SelectedIndex = 0;
            CMB_TipoEquipamiento.SelectedIndex = 0;

            Txt_Marca.Focus();
        }

        private void RB_Identificable_CheckedChanged(object sender, EventArgs e)
        {
            Txt_NumeroSerie.Enabled = RB_Identificable.Checked;
            Txt_IdEquipo.Enabled = RB_Identificable.Checked;
            NUD_Stock.Enabled = RD_PorCantidad.Checked;
        }

    }
}
