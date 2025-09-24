using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using System;
using System.Windows.Forms;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler
{
    public class BolnicaController
    {
        private FrmUbaciBolnicu forma;

        public BolnicaController(FrmUbaciBolnicu form)
        {
            forma = form;
            Init();
        }

        private void Init()
        {
            forma.textBoxBrojZaposlenih.Text = "0";
        }

        public void Ubaci()
        {
            try
            {
                if (!ValidirajPodatke())
                {
                    MessageBox.Show("Sistem ne može da zapamti bolnicu.", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Bolnica b = new Bolnica
                {
                    Naziv = forma.textBoxNaziv.Text.Trim(),
                    Adresa = forma.textBoxAdresa.Text.Trim(),
                    BrojZaposlenih = 0
                };

                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ZapamtiBolnicu, b);

                MessageBox.Show("Sistem je zapamtio bolnicu.", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                OcistiFormu();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da zapamti bolnicu.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidirajPodatke()
        {
            if (string.IsNullOrWhiteSpace(forma.textBoxNaziv.Text)) return false;
            if (forma.textBoxNaziv.Text.Length < 3 || forma.textBoxNaziv.Text.Length > 50) return false;

            if (string.IsNullOrWhiteSpace(forma.textBoxAdresa.Text)) return false;
            if (forma.textBoxAdresa.Text.Length < 5 || forma.textBoxAdresa.Text.Length > 100) return false;

            return true;
        }

        private void OcistiFormu()
        {
            forma.textBoxNaziv.Clear();
            forma.textBoxAdresa.Clear();
            forma.textBoxBrojZaposlenih.Text = "0";
        }
    }
}
