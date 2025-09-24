using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.PacijentIzmeniObrisiController
{
    public class PacijentIzmeniObrisiController
    {
        private FrmIzbrisiIzmeniPacijenta forma;
        private Pacijent trenutni;

        public PacijentIzmeniObrisiController(FrmIzbrisiIzmeniPacijenta form, Pacijent p)
        {
            forma = form;
            trenutni = p;
            Init();
        }

        private void Init()
        {
            try
            {
      
                var mesta = Communication.Instance.PosaljiZahtevVratiRezultat<List<Mesto>>(Operacija.VratiSvaMesta);

                forma.comboBoxMesto.DataSource = new BindingList<Mesto>(mesta);
                forma.comboBoxMesto.DisplayMember = "Naziv";
                forma.comboBoxMesto.ValueMember = "IdMesto";

        
                if (trenutni.Mesto != null)
                {
                    forma.comboBoxMesto.SelectedValue = trenutni.Mesto.IdMesto;
                }

                forma.textBoxIme.Text = trenutni.Ime;
                forma.textBoxPrezime.Text = trenutni.Prezime;
                forma.textBoxJMBG.Text = trenutni.JMBG;
                forma.textBoxAdresa.Text = trenutni.Adresa;
                forma.textBoxPol.Text = trenutni.Pol;
                
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void Izmeni()
        {
            if (!ValidirajPodatke()) return;

            Pacijent p = new Pacijent
            {
                IdPacijent = trenutni.IdPacijent,
                Ime = forma.textBoxIme.Text.Trim(),
                Prezime = forma.textBoxPrezime.Text.Trim(),
                Pol = forma.textBoxPol.Text.Trim(),
                Adresa = forma.textBoxAdresa.Text.Trim(),
                JMBG = forma.textBoxJMBG.Text.Trim(),
                Mesto = (Mesto)forma.comboBoxMesto.SelectedItem
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.IzmeniPacijenta, p);
                MessageBox.Show("Sistem je zapamtio pacijenta.", "Izmenjen pacijent",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                forma.Close();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da izmeni pacijenta.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da izmeni pacijenta.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Obrisi()
        {
            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ObrisiPacijenta, trenutni);
                MessageBox.Show("Sistem je obrisao pacijenta.", "Obrisan pacijent",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                forma.Close();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da obriše pacijenta.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da obriše pacijenta.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidirajPodatke()
        {
        
            if (forma.comboBoxMesto.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas izaberite mesto.");
                return false;
            }

    
            if (string.IsNullOrWhiteSpace(forma.textBoxIme.Text))
            {
                MessageBox.Show("Polje za ime ne sme biti prazno.");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex
                .IsMatch(forma.textBoxIme.Text, @"^[A-ZŠĐČĆŽ][a-zšđčćž]+$"))
            {
                MessageBox.Show("Ime može sadržavati samo slova i mora početi velikim slovom.");
                return false;
            }

     
            if (string.IsNullOrWhiteSpace(forma.textBoxPrezime.Text))
            {
                MessageBox.Show("Polje za prezime ne sme biti prazno.");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex
                .IsMatch(forma.textBoxPrezime.Text, @"^[A-ZŠĐČĆŽ][a-zšđčćž]+$"))
            {
                MessageBox.Show("Prezime može sadržavati samo slova i mora početi velikim slovom.");
                return false;
            }

    
            if (string.IsNullOrWhiteSpace(forma.textBoxJMBG.Text))
            {
                MessageBox.Show("Polje za JMBG ne sme biti prazno.");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex
                .IsMatch(forma.textBoxJMBG.Text, @"^\d{13}$"))
            {
                MessageBox.Show("JMBG mora sadržati tačno 13 cifara.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(forma.textBoxPol.Text))
            {
                MessageBox.Show("Polje za pol ne sme biti prazno.");
                return false;
            }
            if (!(forma.textBoxPol.Text.Equals("M", StringComparison.OrdinalIgnoreCase) ||
                  forma.textBoxPol.Text.Equals("Ž", StringComparison.OrdinalIgnoreCase) ||
                  forma.textBoxPol.Text.Equals("Z", StringComparison.OrdinalIgnoreCase))) 
            {
                MessageBox.Show("Pol može biti samo 'M' ili 'Ž'.");
                return false;
            }

           
            if (string.IsNullOrWhiteSpace(forma.textBoxAdresa.Text))
            {
                MessageBox.Show("Polje za adresu ne sme biti prazno.");
                return false;
            }
            if (forma.textBoxAdresa.Text.Length < 3)
            {
                MessageBox.Show("Adresa mora sadržati bar 3 karaktera.");
                return false;
            }

            return true;
        }
    }
}