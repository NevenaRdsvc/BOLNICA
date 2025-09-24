using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using Klijent.Sesija;
using System;
using System.Windows.Forms;
using Zajednicki;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.LekarKontroler
{
    public class LekarPrijavaController
    {
        private FrmLogin FrmLogin;
        private FrmGlavna glavna = new FrmGlavna();

        public LekarPrijavaController(FrmLogin login)
        {
            FrmLogin = login;
        }

        public void Login()
        {
            TextBox txtKorisnickoIme = FrmLogin.textBoxUsername;
            TextBox txtSifra = FrmLogin.textBoxPassword;

            if (string.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                MessageBox.Show("Unesite korisničko ime.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtSifra.Text))
            {
                MessageBox.Show("Unesite lozinku.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Zajednicki.Domen.Lekar lekar = new Zajednicki.Domen.Lekar
            {
                KorisnickoIme = txtKorisnickoIme.Text,
                Lozinka = txtSifra.Text
            };

            try
            {
                Communication.Instance.Connect();
                lekar = Communication.Instance.PosaljiZahtevVratiRezultat<Zajednicki.Domen.Lekar>(Operacija.Login, lekar);
                Session.Instance.TrenutnoPrijavljeni = lekar;
                MessageBox.Show("Korisničko ime i šifra su ispravni" + "\n" +
                                "Dobrodošli, " + lekar.Ime + " " + lekar.Prezime + "!",
                                "Uspešna prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin.DialogResult = DialogResult.OK;
            }
            catch (SystemOperationException es)
            {
                MessageBox.Show(es.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FrmLogin.DialogResult = DialogResult.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FrmLogin.DialogResult = DialogResult.None;
            }

            if (FrmLogin.DialogResult == DialogResult.OK)
            {
                FrmLogin.Hide();
                glavna.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ne može da se otvori glavna forma i meni.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
