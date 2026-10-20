namespace Prototipo_Denuncias
{
    partial class PanelCentral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            dgvCodigo = new DataGridViewTextBoxColumn();
            dgvFechaRegistro = new DataGridViewTextBoxColumn();
            dgvCategoria = new DataGridViewTextBoxColumn();
            dgvRemitente = new DataGridViewTextBoxColumn();
            dgvEfectivoPolicial = new DataGridViewTextBoxColumn();
            dgvEstado = new DataGridViewTextBoxColumn();
            label5 = new Label();
            panel3 = new Panel();
            txtCodigoDenuncia = new TextBox();
            lblTotalRegistros = new Label();
            label8 = new Label();
            label7 = new Label();
            btnLimpiar = new Button();
            label6 = new Label();
            btnBuscar = new Button();
            comboBoxTipoDenuncia = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnConsultarDenuncia = new Button();
            btnNuevaSolicitud = new Button();
            btnSalir = new Button();
            btnInicio = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelBotonesSuperior
            // 
            panelBotonesSuperior.Size = new Size(1062, 32);
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(1062, 562);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvCodigo, dgvFechaRegistro, dgvCategoria, dgvRemitente, dgvEfectivoPolicial, dgvEstado });
            dataGridView1.Location = new Point(355, 283);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(680, 216);
            dataGridView1.TabIndex = 4;
            // 
            // dgvCodigo
            // 
            dgvCodigo.HeaderText = "CODIGO";
            dgvCodigo.MinimumWidth = 6;
            dgvCodigo.Name = "dgvCodigo";
            dgvCodigo.ReadOnly = true;
            // 
            // dgvFechaRegistro
            // 
            dgvFechaRegistro.HeaderText = "FECHA DE REGISTRO";
            dgvFechaRegistro.MinimumWidth = 6;
            dgvFechaRegistro.Name = "dgvFechaRegistro";
            dgvFechaRegistro.ReadOnly = true;
            // 
            // dgvCategoria
            // 
            dgvCategoria.HeaderText = "CATEGORIA";
            dgvCategoria.MinimumWidth = 6;
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.ReadOnly = true;
            // 
            // dgvRemitente
            // 
            dgvRemitente.HeaderText = "REMITENTE";
            dgvRemitente.MinimumWidth = 6;
            dgvRemitente.Name = "dgvRemitente";
            dgvRemitente.ReadOnly = true;
            // 
            // dgvEfectivoPolicial
            // 
            dgvEfectivoPolicial.HeaderText = "EFECTIVO A CARGO";
            dgvEfectivoPolicial.MinimumWidth = 6;
            dgvEfectivoPolicial.Name = "dgvEfectivoPolicial";
            dgvEfectivoPolicial.ReadOnly = true;
            // 
            // dgvEstado
            // 
            dgvEstado.HeaderText = "ESTADO";
            dgvEstado.MinimumWidth = 6;
            dgvEstado.Name = "dgvEstado";
            dgvEstado.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(229, 233, 240);
            label5.Font = new Font("Segoe UI", 8F);
            label5.Location = new Point(364, 137);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 3;
            label5.Text = "Filtros de Busquéda";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(229, 233, 240);
            panel3.Controls.Add(txtCodigoDenuncia);
            panel3.Controls.Add(lblTotalRegistros);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(btnLimpiar);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(comboBoxTipoDenuncia);
            panel3.Location = new Point(342, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(694, 74);
            panel3.TabIndex = 2;
            // 
            // txtCodigoDenuncia
            // 
            txtCodigoDenuncia.Font = new Font("Segoe UI", 10F);
            txtCodigoDenuncia.Location = new Point(171, 30);
            txtCodigoDenuncia.Name = "txtCodigoDenuncia";
            txtCodigoDenuncia.Size = new Size(122, 30);
            txtCodigoDenuncia.TabIndex = 5;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Location = new Point(616, 33);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(50, 20);
            lblTotalRegistros.TabIndex = 5;
            lblTotalRegistros.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Location = new Point(529, 33);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 4;
            label8.Text = "Mostrando";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(171, 7);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 4;
            label7.Text = "Codigo";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(425, 28);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 30);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(19, 7);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 4;
            label6.Text = "Tipo";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(313, 26);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(106, 34);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipoDenuncia
            // 
            comboBoxTipoDenuncia.FormattingEnabled = true;
            comboBoxTipoDenuncia.Location = new Point(23, 30);
            comboBoxTipoDenuncia.Name = "comboBoxTipoDenuncia";
            comboBoxTipoDenuncia.Size = new Size(123, 28);
            comboBoxTipoDenuncia.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 91);
            label4.Name = "label4";
            label4.Size = new Size(567, 20);
            label4.TabIndex = 1;
            label4.Text = "Expedientes ingresados y trámites documentarios activos de la dependencia policial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 62);
            label3.Name = "label3";
            label3.Size = new Size(187, 20);
            label3.TabIndex = 0;
            label3.Text = "Bandeja de Mesa de Partes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.home;
            pictureBox1.Location = new Point(34, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(13, 59, 38);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnConsultarDenuncia);
            panel2.Controls.Add(btnNuevaSolicitud);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnInicio);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 562);
            panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.search;
            pictureBox3.Location = new Point(34, 211);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.plus;
            pictureBox2.Location = new Point(34, 160);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnConsultarDenuncia
            // 
            btnConsultarDenuncia.BackColor = Color.FromArgb(18, 69, 46);
            btnConsultarDenuncia.FlatAppearance.BorderColor = Color.FromArgb(26, 90, 61);
            btnConsultarDenuncia.FlatStyle = FlatStyle.Flat;
            btnConsultarDenuncia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnConsultarDenuncia.ForeColor = Color.FromArgb(226, 232, 240);
            btnConsultarDenuncia.Location = new Point(30, 202);
            btnConsultarDenuncia.Name = "btnConsultarDenuncia";
            btnConsultarDenuncia.Padding = new Padding(36, 0, 0, 0);
            btnConsultarDenuncia.Size = new Size(274, 44);
            btnConsultarDenuncia.TabIndex = 1;
            btnConsultarDenuncia.Text = "CONSULTAR DENUNCIA";
            btnConsultarDenuncia.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultarDenuncia.UseVisualStyleBackColor = false;
            // 
            // btnNuevaSolicitud
            // 
            btnNuevaSolicitud.BackColor = Color.FromArgb(18, 69, 46);
            btnNuevaSolicitud.FlatAppearance.BorderColor = Color.FromArgb(26, 90, 61);
            btnNuevaSolicitud.FlatStyle = FlatStyle.Flat;
            btnNuevaSolicitud.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnNuevaSolicitud.ForeColor = Color.FromArgb(226, 232, 240);
            btnNuevaSolicitud.Location = new Point(30, 150);
            btnNuevaSolicitud.Name = "btnNuevaSolicitud";
            btnNuevaSolicitud.Padding = new Padding(36, 0, 0, 0);
            btnNuevaSolicitud.Size = new Size(274, 44);
            btnNuevaSolicitud.TabIndex = 1;
            btnNuevaSolicitud.Text = "NUEVA SOLICITUD";
            btnNuevaSolicitud.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevaSolicitud.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(31, 107, 73);
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(26, 90, 61);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(30, 499);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(114, 44);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Cerrar sesion";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(31, 107, 73);
            btnInicio.FlatAppearance.BorderColor = Color.FromArgb(26, 90, 61);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(30, 98);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(36, 0, 0, 0);
            btnInicio.Size = new Size(274, 44);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "INICIO";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(110, 231, 183);
            label2.Location = new Point(30, 43);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 0;
            label2.Text = "Dipincri Independencia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 0;
            label1.Text = "MESA DE PARTES VIRTUAL";
            // 
            // PanelCentral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1020, 600);
            Name = "PanelCentral";
            Text = "PanelCentral";
            Controls.SetChildIndex(panelBotonesSuperior, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel2, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button btnInicio;
        private Button btnNuevaSolicitud;
        private Button btnConsultarDenuncia;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private ComboBox comboBoxTipoDenuncia;
        private Label label7;
        private Label label6;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Label label8;
        private DataGridView dataGridView1;
        private Label lblTotalRegistros;
        private Button btnSalir;
        private DataGridViewTextBoxColumn dgvCodigo;
        private DataGridViewTextBoxColumn dgvFechaRegistro;
        private DataGridViewTextBoxColumn dgvCategoria;
        private DataGridViewTextBoxColumn dgvRemitente;
        private DataGridViewTextBoxColumn dgvEfectivoPolicial;
        private DataGridViewTextBoxColumn dgvEstado;
        private TextBox txtCodigoDenuncia;
    }
}