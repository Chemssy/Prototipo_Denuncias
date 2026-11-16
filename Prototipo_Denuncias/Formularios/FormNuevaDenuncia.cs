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
            DatosSistema.CargarTiposDelitos(comboBoxCategoriaDenuncia);
            DatosSistema.CargarTiposDistritos(comboBoxDistritoSuceso);
            DatosSistema.CargarTiposEstados(comboBoxEstado);


            ConfigurarModal();

        }

        private void FormNuevaDenuncia_Load(object sender, EventArgs e)
        {
            lblCodigoExpediente.Text = ArchivoExpediente.SiguienteCodigo();
        }

        private void btnRegistrarExpediente_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;//No se guarda si falta algun dato

            ExpedienteGenerado = new Expediente
            {
                Codigo = lblCodigoExpediente.Text,
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

        private bool ValidarCampos()
        {
            if (txtDNI.Text.Trim() == "")
            {
                MostrarAviso("Ingrese el DNI del denunciante.", txtDNI);
                return false;
            }

            if (txtDNI.Text.Trim().Length != 8 || !txtDNI.Text.Trim().All(char.IsDigit))
            {
                MostrarAviso("El DNI debe tener exactamente 8 dígitos numéricos.", txtDNI);
                return false;
            }

            if (txtNombreCompleto.Text.Trim() == "")
            {
                MostrarAviso("Ingrese el nombre completo del denunciante.", txtNombreCompleto);
                return false;
            }

            if (comboBoxCategoriaDenuncia.SelectedIndex == -1)
            {
                MostrarAviso("Seleccione la categoría de la denuncia.", comboBoxCategoriaDenuncia);
                return false;
            }

            if (comboBoxDistritoSuceso.SelectedIndex == -1)
            {
                MostrarAviso("Seleccione el distrito del suceso.", comboBoxDistritoSuceso);
                return false;
            }

            if (comboBoxEstado.SelectedIndex == -1)
            {
                MostrarAviso("Seleccione el estado de la denuncia.", comboBoxEstado);
                return false;
            }

            if (txtDescripcion.Text.Trim() == "")
            {
                MostrarAviso("Ingrese la descripción de la denuncia.", txtDescripcion);
                return false;
            }

            return true;   // todo está completo
        }

        private void MostrarAviso(string mensaje, Control campo)
        {
            MessageBox.Show(mensaje,
                            "Campo requerido",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            campo.Focus();   // deja el cursor en el campo con problema
        }

        void cargarPLantilla()
        {
            if (comboBoxCategoriaDenuncia.SelectedIndex == -1) return;

            string categoria = comboBoxCategoriaDenuncia.Text;
            string plantilla = DatosSistema.ObtenerPlantilla(categoria);

            if (!string.IsNullOrEmpty(plantilla))
            {
                txtDescripcion.Text = plantilla;
            }
        }

        private void comboBoxCategoriaDenuncia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarPLantilla();
        }
    }
}
