using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            DatosSistema.CargarTiposDelitos(comboBoxTipoDenuncia);

            dgvEstado.Items.AddRange(DatosSistema.TiposEstados);
            dgvExpedientes.EditMode = DataGridViewEditMode.EditOnEnter;  // se abre el combobox del data grid view 
            dgvExpedientes.CurrentCellDirtyStateChanged += dgvExpedientes_CurrentCellDirtyStateChanged;
            dgvExpedientes.CellValueChanged += dgvExpedientes_CellValueChanged;

            if (ArchivoExpediente.Existe())
            {
                listaExpedientes = ArchivoExpediente.Cargar();
            }
            else
            {
                CargarDatosPrueba();
                ArchivoExpediente.Guardar(listaExpedientes);
            }

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
                Categoria = DatosSistema.TiposDelitos[0],
                Distrito = DatosSistema.TiposDistritos[0],
                Estado = DatosSistema.TiposEstados[1],
                Descripcion = "Robo de celular"
            });

            listaExpedientes.Add(new Expediente
            {
                Codigo = "EXP-10002",
                FechaRegistro = "19/10/2026 14:15",
                DNI = "45871236",
                Nombres = "Maria Gomez Silva",
                Categoria = DatosSistema.TiposDelitos[1],
                Distrito = DatosSistema.TiposDistritos[2],
                Estado = DatosSistema.TiposEstados[0],
                Descripcion = "Llamadas extorsivas"
            });

            listaExpedientes.Add(new Expediente
            {
                Codigo = "EXP-10003",
                FechaRegistro = "20/10/2026 09:45",
                DNI = "09876543",
                Nombres = "Carlos Ruiz Diaz",
                Categoria = DatosSistema.TiposDelitos[4],
                Distrito = DatosSistema.TiposDistritos[0],
                Estado = DatosSistema.TiposEstados[2],
                Descripcion = "Estafa por WhatsApp"
            });
        }


        void CerrarSesion()
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Estas seguro de Cerrar Sesion?",
                                        "Mensaje de confirmacion",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Restart();
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
            CerrarSesion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ActualizarTabla(List<Expediente> listaFiltrada = null)
        {
            actualizandoTabla = true;

            List<Expediente> datosAMostrar = listaFiltrada ?? listaExpedientes;
            dgvExpedientes.Rows.Clear();

            foreach (Expediente exp in datosAMostrar)
            {
                dgvExpedientes.Rows.Add(exp.Codigo, exp.FechaRegistro, exp.Categoria,
                                        exp.Nombres, "Jhon Doe", exp.Estado);
            }

            actualizandoTabla = false;
            lblTotalRegistros.Text = listaExpedientes.Count.ToString();
        }

        private void btnNuevaSolicitud_Click(object sender, EventArgs e)
        {
            // Creamos la ventana modal
            FormNuevaDenuncia modal = new FormNuevaDenuncia();

            if (modal.ShowDialog() == DialogResult.OK)
            {
                listaExpedientes.Add(modal.ExpedienteGenerado);
                ArchivoExpediente.Guardar(listaExpedientes);   //
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

        private bool actualizandoTabla = false;

        //Confirmacion para el cambio del estado
        private void dgvExpedientes_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvExpedientes.IsCurrentCellDirty)
            {
                dgvExpedientes.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        //Para actualizacion de estado
        private void dgvExpedientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (actualizandoTabla || e.RowIndex < 0 || e.ColumnIndex != dgvEstado.Index) return;

            string codigo = dgvExpedientes.Rows[e.RowIndex].Cells[dgvCodigo.Index].Value?.ToString();
            string nuevoEstado = dgvExpedientes.Rows[e.RowIndex].Cells[dgvEstado.Index].Value?.ToString();

            foreach (Expediente exp in listaExpedientes)
            {
                if (exp.Codigo == codigo)
                {
                    exp.Estado = nuevoEstado;
                    break;
                }
            }

            ArchivoExpediente.Guardar(listaExpedientes);
        }

        private void btnConsultarDenuncia_Click(object sender, EventArgs e)
        {
            FormConsulta consulta = new FormConsulta();
            consulta.ShowDialog();
        }
    }
}
