using Klijent.GUIKontroler.LekarKontroler;

namespace Klijent
{
    public partial class FrmLogin : Form
    {
        private LekarPrijavaController prijava;
        public FrmLogin()
        {
            InitializeComponent();
            prijava = new LekarPrijavaController(this);
            textBoxUsername.Text = "dr.Stojanovic";
            textBoxPassword.Text= "Veljko123";
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            prijava.Login();
        }
    }
}
