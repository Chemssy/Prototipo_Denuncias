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
            panelBotonesSuperior.Location = new Point(0, 0);
            panelBotonesSuperior.Name = "panelBotonesSuperior";
            panelBotonesSuperior.Size = new Size(800, 32);
            panelBotonesSuperior.TabIndex = 0;
            panelBotonesSuperior.MouseDown += panelBotonesSuperior_MouseDown;
            panelBotonesSuperior.MouseMove += panelBotonesSuperior_MouseMove;
            panelBotonesSuperior.MouseUp += panelBotonesSuperior_MouseUp;
            // 
            // pictureBoxCerrar
            // 
            pictureBoxCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxCerrar.Image = Properties.Resources.x;
            pictureBoxCerrar.Location = new Point(763, 3);
            pictureBoxCerrar.Name = "pictureBoxCerrar";
            pictureBoxCerrar.Size = new Size(25, 25);
            pictureBoxCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCerrar.TabIndex = 2;
            pictureBoxCerrar.TabStop = false;
            pictureBoxCerrar.Click += pictureBoxCerrar_Click;
            // 
            // pictureBoxMinimizar
            // 
            pictureBoxMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimizar.Image = Properties.Resources.minus;
            pictureBoxMinimizar.Location = new Point(701, 4);
            pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            pictureBoxMinimizar.Size = new Size(25, 25);
            pictureBoxMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMinimizar.TabIndex = 1;
            pictureBoxMinimizar.TabStop = false;
            pictureBoxMinimizar.Click += pictureBoxMinimizar_Click;
            // 
            // pictureBoxMaximizar
            // 
            pictureBoxMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMaximizar.Image = Properties.Resources.maximize;
            pictureBoxMaximizar.Location = new Point(732, 3);
            pictureBoxMaximizar.Name = "pictureBoxMaximizar";
            pictureBoxMaximizar.Size = new Size(25, 25);
            pictureBoxMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMaximizar.TabIndex = 1;
            pictureBoxMaximizar.TabStop = false;
            pictureBoxMaximizar.Click += pictureBoxMaximizar_Click;
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelBotonesSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBase";
            Text = "FormBase";
            panelBotonesSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaximizar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBotonesSuperior;
        private PictureBox pictureBoxCerrar;
        private PictureBox pictureBoxMinimizar;
        private PictureBox pictureBoxMaximizar;
    }
}