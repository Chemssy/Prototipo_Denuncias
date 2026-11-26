namespace Prototipo_Denuncias
{
    partial class FormConsulta
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
            panel3 = new Panel();
            btnBuscar = new Button();
            txtCodigo = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            panelResumen = new GroupBox();
            txtDescripcion = new TextBox();
            txtEstado = new TextBox();
            txtDistrito = new TextBox();
            txtDelito = new TextBox();
            txtDenunciante = new TextBox();
            txtDni = new TextBox();
            txtFechaHora = new TextBox();
            txtCo = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            lblCodigoExpediente = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panelResumen.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelBotonesSuperior
            // 
            panelBotonesSuperior.Size = new Size(870, 32);
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(panelResumen);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(45, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 706);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(txtCodigo);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(45, 93);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(659, 87);
            panel3.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(13, 59, 38);
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(497, 15);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(135, 53);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(167, 27);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(293, 29);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 33);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 0;
            label2.Text = "Codigo de Denuncia:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(600, 645);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 43);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panelResumen
            // 
            panelResumen.Controls.Add(txtDescripcion);
            panelResumen.Controls.Add(txtEstado);
            panelResumen.Controls.Add(txtDistrito);
            panelResumen.Controls.Add(txtDelito);
            panelResumen.Controls.Add(txtDenunciante);
            panelResumen.Controls.Add(txtDni);
            panelResumen.Controls.Add(txtFechaHora);
            panelResumen.Controls.Add(txtCo);
            panelResumen.Controls.Add(label10);
            panelResumen.Controls.Add(label9);
            panelResumen.Controls.Add(label8);
            panelResumen.Controls.Add(label7);
            panelResumen.Controls.Add(label6);
            panelResumen.Controls.Add(label5);
            panelResumen.Controls.Add(label4);
            panelResumen.Controls.Add(label3);
            panelResumen.Location = new Point(45, 208);
            panelResumen.Name = "panelResumen";
            panelResumen.Size = new Size(659, 431);
            panelResumen.TabIndex = 5;
            panelResumen.TabStop = false;
            panelResumen.Text = "RESUMEN DE DENUNCIA";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(206, 275);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(426, 137);
            txtDescripcion.TabIndex = 8;
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Location = new Point(206, 241);
            txtEstado.Margin = new Padding(3, 4, 3, 4);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(220, 27);
            txtEstado.TabIndex = 14;
            // 
            // txtDistrito
            // 
            txtDistrito.Enabled = false;
            txtDistrito.Location = new Point(206, 209);
            txtDistrito.Margin = new Padding(3, 4, 3, 4);
            txtDistrito.Name = "txtDistrito";
            txtDistrito.Size = new Size(220, 27);
            txtDistrito.TabIndex = 13;
            // 
            // txtDelito
            // 
            txtDelito.Enabled = false;
            txtDelito.Location = new Point(206, 173);
            txtDelito.Margin = new Padding(3, 4, 3, 4);
            txtDelito.Name = "txtDelito";
            txtDelito.Size = new Size(220, 27);
            txtDelito.TabIndex = 12;
            // 
            // txtDenunciante
            // 
            txtDenunciante.Enabled = false;
            txtDenunciante.Location = new Point(206, 138);
            txtDenunciante.Margin = new Padding(3, 4, 3, 4);
            txtDenunciante.Name = "txtDenunciante";
            txtDenunciante.Size = new Size(220, 27);
            txtDenunciante.TabIndex = 11;
            // 
            // txtDni
            // 
            txtDni.Enabled = false;
            txtDni.Location = new Point(206, 104);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(220, 27);
            txtDni.TabIndex = 10;
            // 
            // txtFechaHora
            // 
            txtFechaHora.Enabled = false;
            txtFechaHora.Location = new Point(206, 72);
            txtFechaHora.Margin = new Padding(3, 4, 3, 4);
            txtFechaHora.Name = "txtFechaHora";
            txtFechaHora.Size = new Size(220, 27);
            txtFechaHora.TabIndex = 9;
            // 
            // txtCo
            // 
            txtCo.Enabled = false;
            txtCo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCo.Location = new Point(206, 30);
            txtCo.Margin = new Padding(3, 4, 3, 4);
            txtCo.Name = "txtCo";
            txtCo.Size = new Size(220, 29);
            txtCo.TabIndex = 8;
            txtCo.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 289);
            label10.Name = "label10";
            label10.Size = new Size(177, 20);
            label10.TabIndex = 7;
            label10.Text = "Descripcion de Denuncia:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 252);
            label9.Name = "label9";
            label9.Size = new Size(144, 20);
            label9.TabIndex = 6;
            label9.Text = "Estado de Denuncia:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 212);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 5;
            label8.Text = "Distrito:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 176);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 4;
            label7.Text = "Delito:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 141);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 3;
            label6.Text = "Denunciante:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 107);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 2;
            label5.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 75);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 1;
            label4.Text = "Fecha y Hora:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 40);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 0;
            label3.Text = "Codigo:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 235, 242);
            panel2.Controls.Add(lblCodigoExpediente);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(741, 72);
            panel2.TabIndex = 4;
            // 
            // lblCodigoExpediente
            // 
            lblCodigoExpediente.AutoSize = true;
            lblCodigoExpediente.Font = new Font("Segoe UI", 12F);
            lblCodigoExpediente.Location = new Point(222, 17);
            lblCodigoExpediente.Name = "lblCodigoExpediente";
            lblCodigoExpediente.Size = new Size(0, 28);
            lblCodigoExpediente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 0;
            label1.Text = "CONSULTA DE DENUNCIA";
            // 
            // FormConsulta
            // 
            AcceptButton = btnBuscar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(876, 800);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(800, 600);
            Name = "FormConsulta";
            Text = "FormConsulta";
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panelBotonesSuperior, 0);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelResumen.ResumeLayout(false);
            panelResumen.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Button btnCancelar;
        private GroupBox panelResumen;
        private Panel panel2;
        protected Label lblCodigoExpediente;
        protected Label label1;
        private Button btnBuscar;
        private TextBox txtCodigo;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtFechaHora;
        private TextBox txtCo;
        private TextBox txtEstado;
        private TextBox txtDistrito;
        private TextBox txtDelito;
        private TextBox txtDenunciante;
        private TextBox txtDni;
        private TextBox txtDescripcion;
    }
}