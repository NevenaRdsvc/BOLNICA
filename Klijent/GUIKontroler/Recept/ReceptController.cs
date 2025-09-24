using Klijent.Exceptions;
using Klijent.GUIKontroler.Pretraga;         
using Klijent.ServerKomunikacija;
using Klijent.Sesija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Zajednicki.Domen;
using Zajednicki.Domen;                
using Zajednicki.Komunikacija;


namespace Klijent.GUIKontroler.ReceptiKontroler
{
    public class ReceptController
    {
        private FrmUbaciRecept forma;
        private BindingList<StavkaRecepta> stavke;
        private Zajednicki.Domen.Recept trenutniRecept;

        public ReceptController(FrmUbaciRecept forma)
        {
            this.forma = forma;
            stavke = new BindingList<StavkaRecepta>();
            trenutniRecept = new Zajednicki.Domen.Recept();
            Init();
        }

        private void Init()
        {
            try
            {
                forma.comboBoxPacijent.DataSource = Communication.Instance
                    .PosaljiZahtevVratiRezultat<List<Pacijent>>(Operacija.VratiListuSvihPacijenata);
                forma.comboBoxLek.DataSource = Communication.Instance
                    .PosaljiZahtevVratiRezultat<List<Lek>>(Operacija.VratiListuSvihLekova);
                forma.comboBoxLekari.DataSource = Communication.Instance
                   .PosaljiZahtevVratiRezultat<List<Lekar>>(Operacija.VratiListuSvihLekara);
                forma.comboBoxDoza.DataSource = Enum.GetValues(typeof(Doza))
                     .Cast<Doza>()
                     .Select(d => new
                         {
                             Value = d,
                             Text = d.GetType()
                     .GetField(d.ToString())
                     .GetCustomAttribute<DescriptionAttribute>()?
                     .Description ?? d.ToString()
                    })
                 .ToList();

                forma.comboBoxDoza.DisplayMember = "Text";
                forma.comboBoxDoza.ValueMember = "Value";

                forma.comboBoxPacijent.DisplayMember = "FullName";
                forma.comboBoxLek.DisplayMember = "Naziv";

                forma.dataGridViewStavke.DataSource = stavke;
                forma.dataGridViewStavke.Columns["ReceptId"].Visible = false;

                forma.dataGridViewStavke.Columns["IdStavka"].Visible=false;
                forma.dataGridViewStavke.Columns["Doza"].HeaderText = "Doza";
                forma.dataGridViewStavke.Columns["Uputstvo"].HeaderText = "Uputstvo";
                SakrijNepotrebneKolone();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (selektovanLek == null) return;
            Doza doza = (Doza)forma.comboBoxDoza.SelectedValue;


            StavkaRecepta s = new StavkaRecepta
            {
                Lek = selektovanLek,
                Doza = doza,
                Uputstvo = forma.textBoxUputstvo.Text
              
            };

            stavke.Add(s);
            forma.dataGridViewStavke.Refresh();
            SakrijNepotrebneKolone();
            forma.comboBoxLek.SelectedIndex = -1;
            forma.textBoxUputstvo.Text = "";
            forma.comboBoxDoza.SelectedIndex = -1;
        }

        public void ObrisiStavku()
        {
            if (stavke.Count == 0)
            {
                MessageBox.Show("Nema stavki za brisanje", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (forma.dataGridViewStavke.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali nijednu stavku", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StavkaRecepta selektovana = (StavkaRecepta)forma.dataGridViewStavke.SelectedRows[0].DataBoundItem;

            stavke.Remove(selektovana);
            SakrijNepotrebneKolone();
            forma.dataGridViewStavke.Refresh();
        }

        public void KreirajRecept()
        {
            if (!ValidirajPodatke()) return;

            DateTime datumIzdavanja = forma.dateTimePickerDatumIzdavanja.Value.Date;
            DateTime datumIsteka = forma.dateTimePickerDatumIsteka.Value.Date;

            if (datumIzdavanja > datumIsteka)
            {
                MessageBox.Show("Datum isteka mora biti nakon datuma izdavanja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int trajanje = (datumIsteka - datumIzdavanja).Days;

            Zajednicki.Domen.Recept r = new Zajednicki.Domen.Recept
            {
                Pacijent = (Pacijent)forma.comboBoxPacijent.SelectedItem,
                Lekar = (Lekar)forma.comboBoxLekari.SelectedItem, 
                DatumIzdavanja = datumIzdavanja,
                DatumIsteka = datumIsteka,
                VremeTrajanja = trajanje,
                Napomena = forma.textBoxNapomena.Text,
                Stavke = stavke.ToList()
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ZapamtiRecept, r);

                MessageBox.Show("Sistem je zapamtio recept", "Sacuvan je recept", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiFormu();

            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne moze da zapamti recept.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OcistiFormu();
            }
            catch (Exception es)
            {
                MessageBox.Show("Sistem ne moze da zapamti recept.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OcistiFormu()
        {
            forma.dateTimePickerDatumIzdavanja.Value = DateTime.Now;
            forma.dateTimePickerDatumIsteka.Value = DateTime.Now;
            forma.comboBoxPacijent.SelectedIndex = -1;
            forma.comboBoxLek.SelectedIndex = -1;
            forma.comboBoxDoza.SelectedIndex = -1;
            forma.textBoxUputstvo.Text = "";
            forma.comboBoxDoza.SelectedIndex = -1;
            stavke = new BindingList<StavkaRecepta>();
            forma.dataGridViewStavke.DataSource = stavke;
        }

        private bool ValidirajPodatke()
        {
            if (stavke.Count == 0)
            {
                MessageBox.Show("Recept mora imati bar jednu stavku.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(forma.textBoxNapomena.Text))
            {
                MessageBox.Show("Molim Vas popunite Napomenu, ukoliko je nemate stavite /");
                return false;
            }
            if (forma.comboBoxPacijent.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas da izaberete pacijenta.");
                return false;
            }
            if (Session.Instance.TrenutnoPrijavljeni == null)
            {
                MessageBox.Show("Lekar nije prijavljen.");
                return false;
            }
            return true;
        }
    }
}
