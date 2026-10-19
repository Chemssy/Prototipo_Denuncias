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
    }
}
