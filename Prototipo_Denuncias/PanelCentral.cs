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

        private List<Expediente> listaExpedientes = new List<Expediente>();

        public PanelCentral()
        {
            InitializeComponent();
            CargarTiposDelitos(comboBoxTipoDenuncia);
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

        private void ActualizarTabla()
        {
            // Limpiamos la tabla visual para no duplicar datos (cambia el nombre si tu tabla se llama distinto)
            dgvExpedientes.Rows.Clear();

            // Recorremos nuestra lista en memoria
            foreach (Expediente exp in listaExpedientes)
            {
                // Agregamos una nueva fila. 
                // OJO: El orden en que pones las variables aquí DEBE ser el mismo 
                // orden de las columnas que creaste visualmente en tu DataGridView.
                dgvExpedientes.Rows.Add(
                    exp.Codigo,
                    exp.FechaRegistro,
                    exp.Categoria,
                    exp.Nombres, // En tu tabla dice "REMITENTE"
                    "Jhon Doe", // En tu tabla dice "EFECTIVO A CARGO" (Dato estático por ahora)
                    exp.Estado
                );
            }
        }

        private void btnNuevaSolicitud_Click(object sender, EventArgs e)
        {
            // Creamos la ventana modal
            FormNuevaDenuncia modal = new FormNuevaDenuncia();

            // ShowDialog() abre la ventana y pausa el Panel Central. 
            // Si el usuario presionó "Registrar Expediente", DialogResult será OK.
            if (modal.ShowDialog() == DialogResult.OK)
            {
                // Extraemos la "caja" de datos que llenó el modal y la guardamos en nuestra memoria
                listaExpedientes.Add(modal.ExpedienteGenerado);

                // Refrescamos la tabla para que se vea el nuevo registro
                ActualizarTabla();
            }
        }

        //private void Login_Resize(object sender, EventArgs e)
        //{
        //    PanelCentral.Left = (this.ClientSize.Width - PanelCentral.Width) / 2;
        //    panelForm.Top = (this.ClientSize.Height - panelForm.Height) / 2;
        //}


    }
}
