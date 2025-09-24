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
using Zajednicki.Domen;

namespace Klijent
{
    public partial class FrmIzmeniRecept : Form
    {
        ReceptIzmeniController controller;
        public FrmIzmeniRecept(Recept recept)
        {
            InitializeComponent();
            controller = new ReceptIzmeniController(this, recept);
        }

        private void buttonIzmeniRecept_Click(object sender, EventArgs e)
        {
            controller.Izmeni();
        }

        private void buttonIzbrisiStavku_Click(object sender, EventArgs e)
        {
            controller.ObrisiStavku();
        }

        private void buttonDodajStavku_Click(object sender, EventArgs e)
        {
            controller.DodajStavku();
        }
    }
}
