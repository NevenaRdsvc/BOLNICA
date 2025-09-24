using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.Recept
{
    public class ReceptIzmeniController
    {
        private FrmIzmeniRecept forma;
        private Zajednicki.Domen.Recept trenutni;
        private BindingList<Lekar> lekari;
        private BindingList<Pacijent> pacijenti;

        public ReceptIzmeniController(FrmIzmeniRecept form, Zajednicki.Domen.Recept recept)
        {
            forma = form;
            trenutni = recept;
            trenutni.StavkeZaBrisanje = new List<StavkaRecepta>();
            Init();
        }

        private void Init()
        {
            try
            {
                forma.comboBoxLekar.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Lekar>>(Operacija.VratiListuSvihLekara);
                forma.comboBoxPacijent.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Pacijent>>(Operacija.VratiListuSvihPacijenata);
                forma.comboBoxLek.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Lek>>(Operacija.VratiListuSvihLekova);

                forma.comboBoxPacijent.DisplayMember = "FullName";
                forma.comboBoxLekar.DisplayMember = "FullName";
                forma.comboBoxLek.DisplayMember = "Naziv";
                forma.comboBoxDoza.DataSource = Enum.GetValues(typeof(Doza));

                forma.comboBoxLekar.Text = trenutni.LekarFullName;
                forma.comboBoxPacijent.Text = trenutni.PacijentFullName;
                forma.dateTimePickerDatumIzdavanja.Value = trenutni.DatumIzdavanja;
                forma.dateTimePickerDatumIsteka.Value = trenutni.DatumIsteka;
                forma.textBoxNapomena.Text = trenutni.Napomena;
               

         
                int vremeTrajanja = (trenutni.DatumIsteka - trenutni.DatumIzdavanja).Days;
                forma.textBoxVremeTrajanja.Text = vremeTrajanja.ToString();


                forma.dataGridViewStavke.DataSource = trenutni.Stavke;

                if (trenutni.Stavke.Any())
                {
                    var prvaStavka = trenutni.Stavke.First();
                    forma.comboBoxDoza.SelectedItem = prvaStavka.Doza;
                    forma.textBoxUputstvo.Text = prvaStavka.Uputstvo;
                }

                SakrijNepotrebneKolone();
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SakrijNepotrebneKolone()
        {
            if (forma.dataGridViewStavke.Columns.Count == 0) return;

            forma.dataGridViewStavke.Columns["NazivLeka"].Visible = false;
            forma.dataGridViewStavke.Columns["ReceptId"].Visible = false;
            forma.dataGridViewStavke.Columns["NazivTabele"].Visible = false;
            forma.dataGridViewStavke.Columns["Vrednosti"].Visible = false;
            forma.dataGridViewStavke.Columns["Uslov"].Visible = false;
            forma.dataGridViewStavke.Columns["Output"].Visible = false;
            forma.dataGridViewStavke.Columns["Kriterijum"].Visible = false;
            forma.dataGridViewStavke.Columns["JoinUslov"].Visible = false;
            forma.dataGridViewStavke.Columns["UpdateUslov"].Visible = false;
            forma.dataGridViewStavke.Columns["UslovBezAlijasa"].Visible = false;
            forma.dataGridViewStavke.Columns["idStavka"].Visible = false;
            forma.dataGridViewStavke.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            forma.dataGridViewStavke.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            forma.dataGridViewStavke.Columns["Lek"].HeaderText = "Lek";
            forma.dataGridViewStavke.Columns["Doza"].HeaderText = "Doza";
            
        }

        public void DodajStavku()
        {
            Lek selektovanLek = (Lek)forma.comboBoxLek.SelectedItem;
            if (selektovanLek == null)
            {
                MessageBox.Show("Morate odabrati lek.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (forma.comboBoxDoza.SelectedItem == null)
            {
                MessageBox.Show("Morate odabrati dozu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StavkaRecepta s = new StavkaRecepta
            {
                IdStavka = 0, 
                ReceptId = trenutni.IdRecept,
                Lek = selektovanLek,
                Doza = (Doza)forma.comboBoxDoza.SelectedItem,
                Uputstvo = forma.textBoxUputstvo.Text
            };

            trenutni.Stavke.Add(s);


            forma.dataGridViewStavke.DataSource = null;
            forma.dataGridViewStavke.DataSource = trenutni.Stavke;
            SakrijNepotrebneKolone();

         
            forma.comboBoxLek.SelectedIndex = -1;
            forma.comboBoxDoza.SelectedIndex = -1;
            forma.textBoxUputstvo.Text = "";
        }

        public void ObrisiStavku()
        {
            if (trenutni.Stavke.Count == 0)
            {
                MessageBox.Show("Nema stavke za brisanje", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (forma.dataGridViewStavke.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali nijednu stavku", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StavkaRecepta selektovana = (StavkaRecepta)forma.dataGridViewStavke.SelectedRows[0].DataBoundItem;


            if (selektovana.IdStavka != 0)
                trenutni.StavkeZaBrisanje.Add(selektovana);

            trenutni.Stavke.Remove(selektovana);

            forma.dataGridViewStavke.DataSource = null;
            forma.dataGridViewStavke.DataSource = trenutni.Stavke;
            SakrijNepotrebneKolone();
        }

        public void Izmeni()
        {
            if (!ValidirajPodatke()) return;

            if (forma.dateTimePickerDatumIsteka.Value <= forma.dateTimePickerDatumIzdavanja.Value)
            {
                MessageBox.Show("Datum isteka mora biti posle datuma izdavanja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int vremeTrajanja = (forma.dateTimePickerDatumIsteka.Value - forma.dateTimePickerDatumIzdavanja.Value).Days;

            Zajednicki.Domen.Recept r = new Zajednicki.Domen.Recept
            {
                IdRecept = trenutni.IdRecept,
                Lekar = (Lekar)forma.comboBoxLekar.SelectedItem,
                Pacijent = (Pacijent)forma.comboBoxPacijent.SelectedItem,
                DatumIzdavanja = forma.dateTimePickerDatumIzdavanja.Value,
                DatumIsteka = forma.dateTimePickerDatumIsteka.Value,
                Napomena = forma.textBoxNapomena.Text,
                VremeTrajanja = vremeTrajanja,
                Stavke = trenutni.Stavke,
                StavkeZaBrisanje = trenutni.StavkeZaBrisanje
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.IzmeniRecept, r);
                MessageBox.Show("Sistem je izmenio recept.", "Izmenjen recept", MessageBoxButtons.OK, MessageBoxIcon.Information);
                forma.Close();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da izmeni recept.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da izmeni recept.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidirajPodatke()
        {
            if (trenutni.Stavke.Count == 0)
            {
                MessageBox.Show("Recept mora imati bar 1 stavku.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (forma.comboBoxLekar.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas da izaberete lekara.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (forma.comboBoxPacijent.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas da izaberete pacijenta.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
