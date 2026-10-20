namespace Prototipo_Denuncias
{
    partial class FormNuevaDenuncia
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnRegistrarExpediente = new Button();
            btnCancelar = new Button();
            groupBox3 = new GroupBox();
            txtDescripcion = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            lblCodigoExpediente = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            comboBoxEstado = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBoxDistritoSuceso = new ComboBox();
            comboBoxCategoriaDenuncia = new ComboBox();
            groupBox1 = new GroupBox();
            txtNombreCompleto = new TextBox();
            txtDNI = new TextBox();
            label7 = new Label();
            label6 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelBotonesSuperior
            // 
            panelBotonesSuperior.Size = new Size(1060, 32);
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnRegistrarExpediente);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(75, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 584);
            panel1.TabIndex = 1;
            // 
            // btnRegistrarExpediente
            // 
            btnRegistrarExpediente.BackColor = Color.FromArgb(13, 59, 38);
            btnRegistrarExpediente.FlatStyle = FlatStyle.Flat;
            btnRegistrarExpediente.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarExpediente.ForeColor = Color.White;
            btnRegistrarExpediente.Location = new Point(681, 522);
            btnRegistrarExpediente.Name = "btnRegistrarExpediente";
            btnRegistrarExpediente.Size = new Size(208, 43);
            btnRegistrarExpediente.TabIndex = 6;
            btnRegistrarExpediente.Text = "Registrar Expediente";
            btnRegistrarExpediente.UseVisualStyleBackColor = false;
            btnRegistrarExpediente.Click += btnRegistrarExpediente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(565, 522);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 43);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDescripcion);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(22, 335);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(867, 181);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "DETALLE Y EVIDENCIA";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(22, 60);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(824, 102);
            txtDescripcion.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 37);
            label5.Name = "label5";
            label5.Size = new Size(184, 20);
            label5.TabIndex = 1;
            label5.Text = "Descripción de los Hechos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 235, 242);
            panel2.Controls.Add(lblCodigoExpediente);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 74);
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
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 0;
            label1.Text = "CÓDIGO GENERADO";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxEstado);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBoxDistritoSuceso);
            groupBox2.Controls.Add(comboBoxCategoriaDenuncia);
            groupBox2.Location = new Point(21, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(868, 104);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "CLASIFICACIÓN Y UBICACION";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(604, 50);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(243, 28);
            comboBoxEstado.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(604, 28);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 1;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 28);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 1;
            label3.Text = "Distrito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 28);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 1;
            label2.Text = "Categoria de Denuncia";
            // 
            // comboBoxDistritoSuceso
            // 
            comboBoxDistritoSuceso.FormattingEnabled = true;
            comboBoxDistritoSuceso.Location = new Point(312, 50);
            comboBoxDistritoSuceso.Name = "comboBoxDistritoSuceso";
            comboBoxDistritoSuceso.Size = new Size(243, 28);
            comboBoxDistritoSuceso.TabIndex = 0;
            // 
            // comboBoxCategoriaDenuncia
            // 
            comboBoxCategoriaDenuncia.FormattingEnabled = true;
            comboBoxCategoriaDenuncia.Location = new Point(23, 50);
            comboBoxCategoriaDenuncia.Name = "comboBoxCategoriaDenuncia";
            comboBoxCategoriaDenuncia.Size = new Size(243, 28);
            comboBoxCategoriaDenuncia.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNombreCompleto);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(21, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(868, 104);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DEL CIUDADANO";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Font = new Font("Segoe UI", 10F);
            txtNombreCompleto.Location = new Point(231, 52);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(616, 30);
            txtNombreCompleto.TabIndex = 2;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Segoe UI", 10F);
            txtDNI.Location = new Point(30, 52);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(115, 30);
            txtDNI.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(231, 23);
            label7.Name = "label7";
            label7.Size = new Size(224, 20);
            label7.TabIndex = 1;
            label7.Text = "Nombres y Apellidos Completos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 23);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 1;
            label6.Text = "DNI";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormNuevaDenuncia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 700);
            Controls.Add(panel1);
            Name = "FormNuevaDenuncia";
            Text = "FormNuevaDenuncia";
            Load += FormNuevaDenuncia_Load;
            Controls.SetChildIndex(panelBotonesSuperior, 0);
            Controls.SetChildIndex(panel1, 0);
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        protected Label lblCodigoExpediente;
        protected Label label1;
        private Panel panel2;
        private GroupBox groupBox3;
        private Button btnCancelar;
        private Button btnRegistrarExpediente;
        private ComboBox comboBoxCategoriaDenuncia;
        private ComboBox comboBoxEstado;
        private ComboBox comboBoxDistritoSuceso;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDescripcion;
        private Label label5;
        private ContextMenuStrip contextMenuStrip1;
        private Label label6;
        private TextBox txtNombreCompleto;
        private TextBox txtDNI;
        private Label label7;
    }
}