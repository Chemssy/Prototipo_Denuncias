namespace Prototipo_Denuncias
{
    public partial class Login : FormBase
    {

        public Login()
        {
            InitializeComponent();
        }


        private void Login_Resize(object sender, EventArgs e)
        {
            panelForm.Left = (this.ClientSize.Width - panelForm.Width) / 2;
            panelForm.Top = (this.ClientSize.Height - panelForm.Height) / 2;
        }

        bool EsFormatoCipValido(string cip)
        {
            return cip.Length == 8 && cip.All(char.IsDigit);
        }

        bool AutenticarUsuario(string cip, string contrasena)
        {
            return usuariosPoliciales.ContainsKey(cip) && usuariosPoliciales[cip] == contrasena;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioCIP = txtUsuario.Text; 
            string contrasena = txtContrasena.Text;

            if (!EsFormatoCipValido(usuarioCIP))
            {
                MessageBox.Show("El Usuario / N° CIP debe contener exactamente 8 digitos numericos",
                                "Validación de Formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; 
            }

            if (AutenticarUsuario(usuarioCIP,contrasena))
            {
                PanelCentral formularioPrincipal = new PanelCentral(); 
                formularioPrincipal.Show(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado o la contraseña es incorrecta.",
                        "Acceso Denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

        }
    }
}
