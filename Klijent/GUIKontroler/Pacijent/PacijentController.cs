using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.PacijentKontroler
{
    public class PacijentController
    {
        private FrmUbaciPacijenta forma;

        public PacijentController(FrmUbaciPacijenta forma)
        {
            this.forma = forma;
            Init();
        }

        private void Init()
        {
            try
            {
                var mesta = Communication.Instance.PosaljiZahtevVratiRezultat<List<Mesto>>(Operacija.VratiSvaMesta);
                forma.comboBoxMesto.DataSource = mesta;
                forma.comboBoxMesto.DisplayMember = "Naziv";
                forma.comboBoxMesto.ValueMember = "IdMesto";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UbaciPacijenta()
        {
            if (!ValidirajPacijenta()) return;

            if (forma.comboBoxMesto.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati mesto.");
                return;
            }

            Pacijent p = new Pacijent
            {
                Ime = forma.textBoxIme.Text,
                Prezime = forma.textBoxPrezime.Text,
                JMBG = forma.textBoxJMBG.Text,
                Pol = forma.textBoxPol.Text,
                Adresa = forma.textBoxAdresa.Text,
                Mesto = (Mesto)forma.comboBoxMesto.SelectedItem
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ZapamtiPacijenta, p);
                MessageBox.Show("Sistem je zapamtio pacijenta.", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiFormu();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidirajPacijenta()
        {
            if (string.IsNullOrWhiteSpace(forma.textBoxIme.Text))
            {
                MessageBox.Show("Ime ne sme biti prazno.");
                return false;
            }
            if (!Regex.IsMatch(forma.textBoxIme.Text, @"^[A-ZŠĐČĆŽ][a-zšđčćž]+$"))
            {
                MessageBox.Show("Ime može sadržavati samo slova i mora početi velikim slovom.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(forma.textBoxPrezime.Text))
            {
                MessageBox.Show("Prezime ne sme biti prazno.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(forma.textBoxJMBG.Text))
            {
                MessageBox.Show("JMBG ne sme biti prazan.");
                return false;
            }
            return true;
        }

        private void OcistiFormu()
        {
            forma.textBoxIme.Text = "";
            forma.textBoxPrezime.Text = "";
            forma.textBoxJMBG.Text = "";
            forma.textBoxPol.Text = "";
            forma.textBoxAdresa.Text = "";
            forma.comboBoxMesto.SelectedIndex = -1;
        }
    }
}
