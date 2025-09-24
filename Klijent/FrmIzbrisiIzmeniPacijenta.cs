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
using Klijent.GUIKontroler.PacijentIzmeniObrisiController;

namespace Klijent
{

    public partial class FrmIzbrisiIzmeniPacijenta : Form
    {
        private PacijentIzmeniObrisiController controller;
        public FrmIzbrisiIzmeniPacijenta(Pacijent p)
        {
            InitializeComponent();
            controller = new PacijentIzmeniObrisiController(this, p);
        }

        private void FrmIzbrisiIzmeniPacijenta_Load(object sender, EventArgs e)
        {

        }

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            controller.Obrisi();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            controller.Izmeni();
        }
    }
}
