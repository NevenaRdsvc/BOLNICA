using Klijent.GUIKontroler.Pretraga;
using Klijent.GUIKontroler.Recept;
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

    public partial class FrmPretraziRecept : Form
    {
        private ReceptPretragaController controller;
        public FrmPretraziRecept()
        {
            InitializeComponent();
            controller = new ReceptPretragaController(this);
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            controller.PrikaziRecept();
        }

        private void buttonPretrazi_Click(object sender, EventArgs e)
        {
            controller.NadjiRecept();
        }
    }
}
