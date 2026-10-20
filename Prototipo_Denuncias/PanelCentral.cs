using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipo_Denuncias
{
    public partial class PanelCentral : FormBase
    {
        public PanelCentral()
        {
            InitializeComponent();
            cargarTiposDelitos();
        }

        void cargarTiposDelitos()
        {
            string[] tiposDelitos = {"Delito Contra el Patrimonio","Extorsion y Cobro de Cupos", "Delito Contra la Vida, el Cuerpo y la Salud","Microcomercialización de Drogas","Delitos Informaticos y Estafas"};
            comboBoxTipoDenuncia.Items.AddRange(tiposDelitos);
        }

        void Salir()
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Estas seguro de salir?",
                                        "Mensaje de confirmacion",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        void Limpiar()
        {
            comboBoxTipoDenuncia.SelectedIndex = -1;
            txtCodigoDenuncia.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //private void Login_Resize(object sender, EventArgs e)
        //{
        //    PanelCentral.Left = (this.ClientSize.Width - PanelCentral.Width) / 2;
        //    panelForm.Top = (this.ClientSize.Height - panelForm.Height) / 2;
        //}


    }
}
