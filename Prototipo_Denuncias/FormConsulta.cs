using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipo_Denuncias
{
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim().ToUpper();

            if (codigo == "")
            {
                MessageBox.Show("Ingrese el código de la denuncia.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Permite escribir solo en numero: "10001" se convierte en "EXP-10001"
            if (!codigo.StartsWith("EXP-"))
            {
                codigo = "EXP-" + codigo;
            }

            Expediente exp = ArchivoExpediente.BuscarPorCodigo(codigo);

            if (exp == null)
            {
                panelResumen.Visible = false;
                MessageBox.Show("No se encontró ninguna denuncia con el código " + codigo,
                                "Sin resultados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            MostrarResumen(exp);
        }

        private void MostrarResumen(Expediente exp)
        {
            txtCo.Text = exp.Codigo;
            txtFechaHora.Text = exp.FechaRegistro;
            txtDni.Text = exp.DNI;
            txtDenunciante.Text = exp.Nombres;
            txtDelito.Text = exp.Categoria;
            txtDistrito.Text = exp.Distrito;
            txtEstado.Text = exp.Estado;
            txtDescripcion.Text = exp.Descripcion;

            panelResumen.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
