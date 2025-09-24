using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.LekKontroler
{
    public class LekController
    {
        private FrmUbaciLek forma;

        public LekController(FrmUbaciLek forma)
        {
            this.forma = forma;
            forma.comboBox1.DataSource = Enum.GetValues(typeof(TipLeka));
          
        }

        public void UbaciLek()
        {
            if (!ValidirajLek()) return;

            TipLeka tipLeka = (TipLeka)forma.comboBox1.SelectedItem;

            Lek lek = new Lek
            {
                Naziv = forma.textBoxNaziv.Text,
                TipLeka = tipLeka,
                SerijaProizvodnje = forma.textBoxSerija.Text,
                Cena = double.Parse(forma.textBoxCena.Text),
                Proizvodjac = forma.textBoxProizvodjac.Text
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ZapamtiLek, lek);
                MessageBox.Show("Sistem je zapamtio lek.", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiFormu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidirajLek()
        {
            if (string.IsNullOrWhiteSpace(forma.textBoxNaziv.Text))
            {
                MessageBox.Show("Naziv leka ne sme biti prazan.");
                return false;
            }

            if (!Regex.IsMatch(forma.textBoxNaziv.Text, @"^[A-ZŠĐČĆŽ][a-zšđčćž0-9\s]+$"))
            {
                MessageBox.Show("Naziv leka mora početi velikim slovom i može sadržavati slova i brojeve.");
                return false;
            }

            if (forma.comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Odaberite tip leka.");
                return false;
            }


            if (!double.TryParse(forma.textBoxCena.Text, out _))
            {
                MessageBox.Show("Cena leka mora biti broj.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(forma.textBoxProizvodjac.Text))
            {
                MessageBox.Show("Proizvođač leka ne sme biti prazan.");
                return false;
            }

            return true;
        }

        private void OcistiFormu()
        {
            forma.textBoxNaziv.Text = "";
            forma.comboBox1.SelectedItem = null;
            forma.textBoxSerija.Text = "";
            forma.textBoxCena.Text = "";
            forma.textBoxProizvodjac.Text = "";
        }
    }
}