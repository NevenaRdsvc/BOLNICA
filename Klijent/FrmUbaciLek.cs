using Klijent.GUIKontroler.LekKontroler;
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
    public partial class FrmUbaciLek : Form
    {
        private LekController controller;
        public FrmUbaciLek()
        {
            InitializeComponent();
            controller=new LekController(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.UbaciLek();
        }
    }
}
