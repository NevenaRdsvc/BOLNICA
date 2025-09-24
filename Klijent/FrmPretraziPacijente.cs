using Klijent.GUIKontroler.PacijentKontroler;
using Klijent.GUIKontroler.PretragaPacijentController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmPretraziPacijente : Form
    {
        private PacijentPretragaController controller;
        public FrmPretraziPacijente()
        {
            InitializeComponent();
            controller = new PacijentPretragaController(this);
        }

        private void buttonPretraga_Click(object sender, EventArgs e)
        {
            controller.PretraziPacijente();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            controller.PrikaziPacijenta();
        }
    }
}
