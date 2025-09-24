using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using System.ComponentModel;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.Pretraga
{
    public class ReceptPretragaController
    {
        private FrmPretraziRecept forma;
        private BindingList<Zajednicki.Domen.Recept> recepti;

        public ReceptPretragaController(FrmPretraziRecept frm)
        {
            forma = frm;
            Init();
            forma.dgvRecepti.DataSource = null;
        }

        private void Init()
        {
            try
            {
                InicijalizujDgvRecepti(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Zajednicki.Domen.Recept>>(
                        Operacija.VratiListuSvihRecepata));
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
        private void InicijalizujDgvRecepti(List<Zajednicki.Domen.Recept> lista)
        {
            recepti = new BindingList<Zajednicki.Domen.Recept>(lista);
            forma.dgvRecepti.DataSource = recepti;


            forma.dgvRecepti.Columns["IdRecept"].Visible = false;
            forma.dgvRecepti.Columns["NazivTabele"].Visible = false;
            forma.dgvRecepti.Columns["Vrednosti"].Visible = false;
            forma.dgvRecepti.Columns["Uslov"].Visible = false;
            forma.dgvRecepti.Columns["Output"].Visible = false;
            forma.dgvRecepti.Columns["Kriterijum"].Visible = false;
            forma.dgvRecepti.Columns["JoinUslov"].Visible = false;
            forma.dgvRecepti.Columns["UpdateUslov"].Visible = false;
            forma.dgvRecepti.Columns["UslovBezAlijasa"].Visible = false;
            forma.dgvRecepti.Columns["Pacijent"].Visible = false;
            forma.dgvRecepti.Columns["DatumIzdavanja"].HeaderText = "Datum izdavanja";
            forma.dgvRecepti.Columns["DatumIsteka"].HeaderText = "Datum isteka";
            forma.dgvRecepti.Columns["VremeTrajanja"].HeaderText = "Vreme trajanja (dani)";
            forma.dgvRecepti.Columns["PacijentFullName"].HeaderText = "Pacijent";
            forma.dgvRecepti.Columns["LekarFullName"].Visible = false;
        }

        public void NadjiRecept()
        {
            if (string.IsNullOrEmpty(forma.textBoxKriterijum.Text))
            {
                MessageBox.Show("Niste uneli kriterijum za pretragu.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!DateTime.TryParse(forma.textBoxKriterijum.Text.Trim(), out DateTime datum))
                {
                    MessageBox.Show("Unesite validan datum u formatu yyyy-MM-dd.",
                        "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Zajednicki.Domen.Recept kriterijumRecept = new Zajednicki.Domen.Recept
                {
                    DatumIzdavanja = datum
                };

                InicijalizujDgvRecepti(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Zajednicki.Domen.Recept>>(
                        Operacija.NadjiRecepte, kriterijumRecept));

                MessageBox.Show("Sistem je našao recepte po zadatom kriterijumu.",
                    "Nađeni recepti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da pronađe recepte po zadatom kriterijumu.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void PrikaziRecept()
        {
            if (forma.dgvRecepti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate da izaberete recept!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Zajednicki.Domen.Recept recept = (Zajednicki.Domen.Recept)forma.dgvRecepti.SelectedRows[0].DataBoundItem;

            try
            {
                recept = Communication.Instance.PosaljiZahtevVratiRezultat<Zajednicki.Domen.Recept>(Operacija.UcitajRecept, recept);

                MessageBox.Show("Sistem je učitao recept!", "Recept učitan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PokreniFormu(recept);

      
                InicijalizujDgvRecepti(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Zajednicki.Domen.Recept>>(Operacija.VratiListuSvihRecepata)
                    .OrderBy(r => r.DatumIzdavanja)
                    .ThenBy(r => r.PacijentFullName)
                    .ToList()
                );
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da učita recept.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PokreniFormu(Zajednicki.Domen.Recept recept)
        {
            FrmIzmeniRecept frm = new FrmIzmeniRecept(recept);
            frm.ShowDialog();
        }
    }
}
