using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipo_Denuncias
{
    public partial class FormNuevaDenuncia : FormBase
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Expediente ExpedienteGenerado { get; set; }
        public FormNuevaDenuncia()
        {
            InitializeComponent();
            CargarTiposDelitos(comboBoxCategoriaDenuncia);
            
        }


        private void FormNuevaDenuncia_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            // Genera el código con la convención solicitada
            string codigoAleatorio = "EXP-" + rnd.Next(10000, 99999).ToString();

            lblCodigoExpediente.Text = codigoAleatorio;
        }

        private void btnRegistrarExpediente_Click(object sender, EventArgs e)
        {
            ExpedienteGenerado = new Expediente
            {
                Codigo = label2.Text,
                FechaRegistro = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                DNI = txtDNI.Text,
                Nombres = txtNombreCompleto.Text,
                Categoria = comboBoxCategoriaDenuncia.Text,
                Distrito = comboBoxDistritoSuceso.Text,
                Estado = comboBoxEstado.Text,
                Descripcion = txtDescripcion.Text
            };

            // Le decimos a Windows que la operación fue un éxito y cerramos la ventana
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
