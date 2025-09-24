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
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void ubaciPacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUbaciPacijenta frmUbaci = new FrmUbaciPacijenta();
            frmUbaci.ShowDialog();
        }

        private void pretraziPacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPretraziPacijente frmPretraziPacijente = new FrmPretraziPacijente();
            frmPretraziPacijente.ShowDialog();
        }

        private void ubaciReceptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUbaciRecept frm = new FrmUbaciRecept();
            frm.ShowDialog();
        }

        private void pretraziReceptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPretraziRecept frm = new FrmPretraziRecept();
            frm.ShowDialog(this);
        }

        private void ubaciLekToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmUbaciLek frmLek = new FrmUbaciLek();
            frmLek.ShowDialog(this);
        }

        private void ubaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUbaciBolnicu frm=new FrmUbaciBolnicu();
            frm.ShowDialog(this);
        }
    }
}
