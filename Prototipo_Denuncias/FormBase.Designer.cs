namespace Prototipo_Denuncias
{
    partial class FormBase
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
            panelBotonesSuperior = new Panel();
            pictureBoxCerrar = new PictureBox();
            pictureBoxMinimizar = new PictureBox();
            pictureBoxMaximizar = new PictureBox();
            panelBotonesSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaximizar).BeginInit();
            SuspendLayout();
            // 
            // panelBotonesSuperior
            // 
            panelBotonesSuperior.BackColor = Color.FromArgb(13, 59, 38);
            panelBotonesSuperior.Controls.Add(pictureBoxCerrar);
            panelBotonesSuperior.Controls.Add(pictureBoxMinimizar);
            panelBotonesSuperior.Controls.Add(pictureBoxMaximizar);
            panelBotonesSuperior.Dock = DockStyle.Top;
            panelBotonesSuperior.Location = new Point(3, 2);
            panelBotonesSuperior.Margin = new Padding(3, 2, 3, 2);
            panelBotonesSuperior.Name = "panelBotonesSuperior";
            panelBotonesSuperior.Size = new Size(694, 24);
            panelBotonesSuperior.TabIndex = 0;
            panelBotonesSuperior.MouseDown += panelBotonesSuperior_MouseDown;
            panelBotonesSuperior.MouseMove += panelBotonesSuperior_MouseMove;
            panelBotonesSuperior.MouseUp += panelBotonesSuperior_MouseUp;
            // 
            // pictureBoxCerrar
            // 
            pictureBoxCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxCerrar.Image = Properties.Resources.x;
            pictureBoxCerrar.Location = new Point(661, 2);
            pictureBoxCerrar.Margin = new Padding(3, 2, 3, 2);
            pictureBoxCerrar.Name = "pictureBoxCerrar";
            pictureBoxCerrar.Size = new Size(22, 19);
            pictureBoxCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCerrar.TabIndex = 2;
            pictureBoxCerrar.TabStop = false;
            pictureBoxCerrar.Click += pictureBoxCerrar_Click;
            // 
            // pictureBoxMinimizar
            // 
            pictureBoxMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimizar.Image = Properties.Resources.minus;
            pictureBoxMinimizar.Location = new Point(607, 3);
            pictureBoxMinimizar.Margin = new Padding(3, 2, 3, 2);
            pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            pictureBoxMinimizar.Size = new Size(22, 19);
            pictureBoxMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMinimizar.TabIndex = 1;
            pictureBoxMinimizar.TabStop = false;
            pictureBoxMinimizar.Click += pictureBoxMinimizar_Click;
            // 
            // pictureBoxMaximizar
            // 
            pictureBoxMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMaximizar.Image = Properties.Resources.maximize;
            pictureBoxMaximizar.Location = new Point(634, 2);
            pictureBoxMaximizar.Margin = new Padding(3, 2, 3, 2);
            pictureBoxMaximizar.Name = "pictureBoxMaximizar";
            pictureBoxMaximizar.Size = new Size(22, 19);
            pictureBoxMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMaximizar.TabIndex = 1;
            pictureBoxMaximizar.TabStop = false;
            pictureBoxMaximizar.Click += pictureBoxMaximizar_Click;
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(700, 450);
            Controls.Add(panelBotonesSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(700, 450);
            Name = "FormBase";
            Padding = new Padding(3, 2, 3, 2);
            Text = "FormBase";
            panelBotonesSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaximizar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxCerrar;
        private PictureBox pictureBoxMinimizar;
        private PictureBox pictureBoxMaximizar;
        protected Panel panelBotonesSuperior;
    }
}