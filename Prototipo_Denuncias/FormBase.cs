using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prototipo_Denuncias
{
    public partial class FormBase : Form
    {

        int x, y;
        bool move;

        public FormBase()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void panelBotonesSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void panelBotonesSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            x = e.X;
            y = e.Y;
        }

        private void panelBotonesSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int bordeGrosor = 10; // Grosor del área para arrastrar en píxeles

            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                // Convertir las coordenadas de la pantalla a las coordenadas del cliente (formulario)
                Point posicionMouse = this.PointToClient(new Point(m.LParam.ToInt32()));

                bool bordeSuperior = posicionMouse.Y <= bordeGrosor;
                bool bordeInferior = posicionMouse.Y >= this.ClientSize.Height - bordeGrosor;
                bool bordeIzquierdo = posicionMouse.X <= bordeGrosor;
                bool bordeDerecho = posicionMouse.X >= this.ClientSize.Width - bordeGrosor;

                // Evaluar las 4 esquinas primero
                if (bordeSuperior && bordeIzquierdo)
                    m.Result = (IntPtr)13; // Esquina superior izquierda
                else if (bordeSuperior && bordeDerecho)
                    m.Result = (IntPtr)14; // Esquina superior derecha
                else if (bordeInferior && bordeIzquierdo)
                    m.Result = (IntPtr)16; // Esquina inferior izquierda
                else if (bordeInferior && bordeDerecho)
                    m.Result = (IntPtr)17; // Esquina inferior derecha

                // Evaluar los 4 lados
                else if (bordeSuperior)
                    m.Result = (IntPtr)12; // Borde superior
                else if (bordeInferior)
                    m.Result = (IntPtr)15; // Borde inferior
                else if (bordeIzquierdo)
                    m.Result = (IntPtr)10; // Borde izquierdo
                else if (bordeDerecho)
                    m.Result = (IntPtr)11; // Borde derecho[cite: 16]
            }
        }

    }
}
