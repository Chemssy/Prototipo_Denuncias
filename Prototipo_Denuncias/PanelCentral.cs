using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototipo_Denuncias
{
    public partial class PanelCentral : FormBase
    {

        private List<Expediente> listaExpedientes = new List<Expediente>();
        private string[] tiposDelitos = { "Delito Contra el Patrimonio", "Extorsion y Cobro de Cupos", "Delito Contra la Vida, el Cuerpo y la Salud", "Microcomercialización de Drogas", "Delitos Informaticos y Estafas" };
        private string[] tiposDistritos = { "Independencia", "Los Olivos", "Comas", "Carabayllo", "Miraflores" };
        private string[] tiposEstados = { "Recibida", "En trámite", "Resuelta" };

        public PanelCentral()
        {
            InitializeComponent();
            CargarTiposDelitos(comboBoxTipoDenuncia);

            CargarDatosPrueba();
            ActualizarTabla();
        }

        public void CargarDatosPrueba()
        {
            // Agregamos 3 expedientes falsos a nuestra memoria
            listaExpedientes.Add(new Expediente
            {
                Codigo = "EXP-10001",
                FechaRegistro = "19/10/2026 08:30",
                DNI = "72458912",
                Nombres = "Juan Perez Garcia",
                Categoria = tiposDelitos[0],
                Distrito = tiposDistritos[0],
                Estado = tiposEstados[1],
                Descripcion = "Robo de celular"
            });

            listaExpedientes.Add(new Expediente
            {
                Codigo = "EXP-10002",
                FechaRegistro = "19/10/2026 14:15",
                DNI = "45871236",
                Nombres = "Maria Gomez Silva",
                Categoria = tiposDelitos[1],
                Distrito = tiposDistritos[2],
                Estado = tiposEstados[0],
                Descripcion = "Llamadas extorsivas"
            });

            listaExpedientes.Add(new Expediente
            {
                Codigo = "EXP-10003",
                FechaRegistro = "20/10/2026 09:45",
                DNI = "09876543",
                Nombres = "Carlos Ruiz Diaz",
                Categoria = tiposDelitos[4],
                Distrito = tiposDistritos[0],
                Estado = tiposEstados[2],
                Descripcion = "Estafa por WhatsApp"
            });
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
            ActualizarTabla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ActualizarTabla(List<Expediente> listaFiltrada = null)
        {
            List<Expediente> datosAMostrar = listaFiltrada ?? listaExpedientes;

            dgvExpedientes.Rows.Clear();

            // Recorremos nuestra lista en memoria
            foreach (Expediente exp in datosAMostrar)
            {

                dgvExpedientes.Rows.Add(
                    exp.Codigo,
                    exp.FechaRegistro,
                    exp.Categoria,
                    exp.Nombres,
                    "Jhon Doe", // dato estatico
                    exp.Estado
                );
            }
        }

        private void btnNuevaSolicitud_Click(object sender, EventArgs e)
        {
            // Creamos la ventana modal
            FormNuevaDenuncia modal = new FormNuevaDenuncia();

            if (modal.ShowDialog() == DialogResult.OK)
            {
                listaExpedientes.Add(modal.ExpedienteGenerado);
                ActualizarTabla();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busquedaCodigo = txtCodigoDenuncia.Text.Trim().ToUpper();
            string busquedaTipo = comboBoxTipoDenuncia.Text;

            var resultados = listaExpedientes.Where(exp =>
                (string.IsNullOrEmpty(busquedaCodigo) || exp.Codigo.ToUpper().Contains(busquedaCodigo))
                &&
                (string.IsNullOrEmpty(busquedaTipo) || busquedaTipo == "Elige opción" || exp.Categoria == busquedaTipo)
            ).ToList();

            ActualizarTabla(resultados);
        }


    }
}
