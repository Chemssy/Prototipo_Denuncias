namespace Prototipo_Denuncias
{
    public partial class Login : FormBase
    {

        public Login()
        {
            InitializeComponent();
        }

        bool EsFormatoCipValido(string cip)
        {
            return cip.Length == 8 && cip.All(char.IsDigit);
        }

        bool AutenticarUsuario(string cip, string contrasena)
        {
            return DatosSistema.usuariosPoliciales.ContainsKey(cip) && DatosSistema.usuariosPoliciales[cip] == contrasena;
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

            if (AutenticarUsuario(usuarioCIP, contrasena))
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

        void AbrirManual()
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro de abrir el manual de Usuario?",
                                                    "Mensaje de confirmacion",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if(respuesta == DialogResult.Yes)
            {
                DatosSistema.AbrirManualUsuario();
            }

        }

        private void btnManualUsuario_Click(object sender, EventArgs e)
        {
            AbrirManual();
        }
    }
}
