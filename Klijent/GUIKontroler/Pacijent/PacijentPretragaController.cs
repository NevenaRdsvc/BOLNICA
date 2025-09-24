using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.PretragaPacijentController
{
    public class PacijentPretragaController
    {
        private FrmPretraziPacijente forma;
        private BindingList<Pacijent> pacijenti;

        public PacijentPretragaController(FrmPretraziPacijente forma)
        {
            this.forma = forma;
            Init();
            forma.dgvPacijenti.DataSource = null;
        }

        private void Init()
        {
            try
            {
                InicijalizujDgvPacijenti(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Pacijent>>(
                        Operacija.VratiListuSvihPacijenata));
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InicijalizujDgvPacijenti(List<Pacijent> lista)
        {
            pacijenti = new BindingList<Pacijent>(lista);
            forma.dgvPacijenti.DataSource = pacijenti;

            foreach (var col in new[] { "IdPacijent", "NazivTabele", "Vrednosti", "Uslov", "Output", "Kriterijum", "JoinUslov", "UpdateUslov", "UslovBezAlijasa" })
            {
                if (forma.dgvPacijenti.Columns.Contains(col))
                    forma.dgvPacijenti.Columns[col].Visible = false;
            }

            forma.dgvPacijenti.Columns["Ime"].HeaderText = "Ime";
            forma.dgvPacijenti.Columns["Prezime"].HeaderText = "Prezime";
            forma.dgvPacijenti.Columns["JMBG"].HeaderText = "JMBG";
            forma.dgvPacijenti.Columns["Pol"].HeaderText = "Pol";
            forma.dgvPacijenti.Columns["Adresa"].HeaderText = "Adresa";
        }

        public void PretraziPacijente()
        {
            if (string.IsNullOrEmpty(forma.textBoxPretragaPacijenta.Text))
            {
                MessageBox.Show("Niste uneli kriterijum za pretragu.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Pacijent kriterijumPacijent = new Pacijent
                {
                    JMBG = forma.textBoxPretragaPacijenta.Text.Trim()
                };

                InicijalizujDgvPacijenti(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Pacijent>>(
                        Operacija.NadjiPacijente, kriterijumPacijent));

                MessageBox.Show("Sistem je našao pacijente po zadatom kriterijumu.",
                    "Nađeni pacijenti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da pronađe pacijente po zadatom kriterijumu.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PrikaziPacijenta()
        {
            if (forma.dgvPacijenti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati red u tabeli.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pacijent p = (Pacijent)forma.dgvPacijenti.SelectedRows[0].DataBoundItem;
            try
            {
                p = Communication.Instance.PosaljiZahtevVratiRezultat<Pacijent>(
                    Operacija.UcitajPacijente, p);

                MessageBox.Show("Sistem je našao pacijenta.", "Nađen pacijent",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                PokreniFormu(p);

                InicijalizujDgvPacijenti(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Pacijent>>(
                        Operacija.VratiListuSvihPacijenata));
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da učita pacijenta.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InicijalizujDgvPacijenti(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Pacijent>>(
                        Operacija.VratiListuSvihPacijenata));
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da učita pacijenta.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PokreniFormu(Pacijent p)
        {
            FrmIzbrisiIzmeniPacijenta frm = new FrmIzbrisiIzmeniPacijenta(p);
            frm.ShowDialog();
        }
    }
}