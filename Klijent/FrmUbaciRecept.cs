using Klijent.GUIKontroler.ReceptiKontroler;
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
    public partial class FrmUbaciRecept : Form
    {
        private ReceptController controller;
        public FrmUbaciRecept()
        {
            InitializeComponent();
            controller = new ReceptController(this);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            controller.DodajStavku();
        }

        private void buttonUbaci_Click(object sender, EventArgs e)
        {
            controller.ObrisiStavku();
        }

        private void buttonUbaciRecept_Click(object sender, EventArgs e)
        {
            controller.KreirajRecept();
        }

        private void buttonIzbrisiStavku_Click(object sender, EventArgs e)
        {
            controller.ObrisiStavku();
        }
    }
}
