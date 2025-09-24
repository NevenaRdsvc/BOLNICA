using System.Net.Sockets;

namespace Server
{
    public partial class FrmServer : Form
    {

        private Server s;

        public FrmServer()
        {
            InitializeComponent();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                s.Start();
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                Thread serverNit = new Thread(s.Listen);
                serverNit.IsBackground = true;
                serverNit.Start();
                textBoxStanje.Text = "Server je ukljucen";
            }
            catch (IOException)
            {
                MessageBox.Show("Server ne moze da se pokrene!");
            }
            catch (SocketException)
            {
                MessageBox.Show("Server je vec pokrenut!");
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            s.Stop();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            textBoxStanje.Text = "Server je iskljucen";
            MessageBox.Show("Server je zaustavljen!", "Server iskljucen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
