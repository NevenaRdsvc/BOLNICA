using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;
using System.IO;

namespace Server
{
    public class ClientHandler
    {
        private Socket klijentSoket;
        private bool kraj = false;
        private JsonNetworkSerializer helper;

        public ClientHandler(Socket klijentSoket)
        {
            this.klijentSoket = klijentSoket;
            helper = new JsonNetworkSerializer(klijentSoket);
        }
        private readonly object lockObject = new object();
        public void ObradiZahteve()
        {
            try
            {
                while (true)
                {
                    Zahtev zahtev = helper.Receive<Zahtev>();
                    Odgovor odgovor;
                    try
                    {
                        odgovor = KreirajOdgovor(zahtev);
                    }
                    catch (Exception ex)
                    {
                        odgovor = new Odgovor();
                        odgovor.Signal = false;
                        odgovor.Poruka = ex.Message;
                    }

                    helper.Send(odgovor);

                    lock (lockObject)
                    {
                        if (kraj)
                        {
                            break;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>>>> Klijent zatvorio formu: " + ex.Message);
            }
            finally
            {
                Stop();
            }
        }
        public void Stop()
        {
            if (klijentSoket != null)
            {
                klijentSoket.Shutdown(SocketShutdown.Both);
                klijentSoket.Dispose();
                klijentSoket = null;
                Debug.WriteLine(">>>> Ugasen klijentski soket.");
            }
        }

        private Odgovor KreirajOdgovor(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor();

            switch (zahtev.Operacija)
            {
                case Operacija.Login:
                    Lekar l = JsonSerializer.Deserialize<Lekar>((JsonElement)zahtev.Podaci);
                    odgovor.Podaci = Kontroler.Instance.Login(l);
                    if (odgovor.Podaci == null)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Korisnicko ime i/ili sifra nisu ispravni.";
                    }
                break;
                   
                case Operacija.Kraj:
                kraj = true;
                break;

                case Operacija.VratiListuSvihPacijenata:
                    odgovor.Podaci = Kontroler.Instance.VratiSvePacijente();
                break;

                case Operacija.NadjiPacijente:
                    Pacijent pacijent = JsonSerializer.Deserialize<Pacijent>((JsonElement)zahtev.Podaci);
                    List<Pacijent> pronadjeniPacijenti = Kontroler.Instance.NadjiPacijente(pacijent);
                    if (pronadjeniPacijenti.Count == 0)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da pronadje pacijente po zadatom kriterijumu.";
                    }
                    else
                    {
                        odgovor.Podaci = pronadjeniPacijenti;
                    }
                break;

                case Operacija.UcitajPacijente:
                    Pacijent pac = JsonSerializer.Deserialize<Pacijent>((JsonElement)zahtev.Podaci);
                    odgovor.Podaci = Kontroler.Instance.UcitajPacijente(pac);
                    if (odgovor.Podaci == null)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da ucita pacijenta.";
                    }
                break;

                case Operacija.ZapamtiPacijenta:
                    try
                    {
                        Pacijent p = JsonSerializer.Deserialize<Pacijent>((JsonElement)zahtev.Podaci);
                        Kontroler.Instance.DodajPacijenta(p);
                    }
                    catch (SqlException)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da sacuva pacijenta!";
                    }
                break;

                case Operacija.IzmeniPacijenta:
                    try
                    {
                        Pacijent paci = JsonSerializer.Deserialize<Pacijent>((JsonElement)zahtev.Podaci);
                        if (!Kontroler.Instance.IzmeniPacijenta(paci))
                        {
                            odgovor.Signal = false;
                            odgovor.Poruka = "Sistem ne moze da izmeni pacijenta!";
                        }

                    }
                    catch (SqlException)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da izmeni pacijenta!";
                    }
                break;

                case Operacija.ObrisiPacijenta:
                    try
                    {
                        Pacijent pacc = JsonSerializer.Deserialize<Pacijent>((JsonElement)zahtev.Podaci);
                        if (!Kontroler.Instance.ObrisiPacijenta(pacc))
                        {
                            odgovor.Poruka = "Sistem ne moze da obrise pacijenta!";
                            odgovor.Signal = false;
                        }
                    }
                    catch (SqlException)
                    {
                        odgovor.Poruka = "Sistem ne moze da obrise pacijenta!";
                        odgovor.Signal = false;
                    }

                break;

                case Operacija.ZapamtiBolnicu:
                    try
                    {
                        Bolnica bolnica = JsonSerializer.Deserialize<Bolnica>((JsonElement)zahtev.Podaci);
                        Kontroler.Instance.DodajBolnicu(bolnica);
                    }
                    catch (SqlException)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da sacuva Bolnicu!";
                    }
                break;

                case Operacija.ZapamtiLek:
                    try
                    {
                        Lek lek = JsonSerializer.Deserialize<Lek>((JsonElement)zahtev.Podaci);
                        Kontroler.Instance.DodajLek(lek);
                    }
                    catch (SqlException)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da zapamti lek!";
                    }
                    break;

                case Operacija.VratiSvaMesta:
                    try
                    {
                        odgovor.Podaci = Kontroler.Instance.VratiSvaMesta();
                        if (odgovor.Podaci == null)
                        {
                            odgovor.Signal = false;
                            odgovor.Poruka = "Trenutno nema nijednog mesta.";
                        }
                    }
                    catch (SqlException)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Desila se greska u komunikacija sa bazom.";
                    }
                break;

                case Operacija.VratiListuSvihLekara:
                    try
                    {
                        odgovor.Podaci = Kontroler.Instance.VratiSveLekare();
                        if (odgovor.Podaci == null)
                        {
                            odgovor.Signal = false;
                            odgovor.Poruka = "Trenutno nema nijednog lekara.";
                        }
                    }
                    catch (SqlException)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Desila se greska u komunikacija sa bazom.";
                    }
                    break;

                case Operacija.VratiListuSvihLekova:
                    try
                    {
                        odgovor.Podaci = Kontroler.Instance.VratiSveLekove();
                        if (odgovor.Podaci == null)
                        {
                            odgovor.Signal = false;
                            odgovor.Poruka = "Trenutno nema nijednog leka.";
                        }
                    }
                    catch (SqlException)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Desila se greska u komunikacija sa bazom.";
                    }
                break;

                case Operacija.VratiListuSvihRecepata:
                    odgovor.Podaci = Kontroler.Instance.VratiSveRecepte();
                break;

                case Operacija.NadjiRecepte:
                    Recept recept = JsonSerializer.Deserialize<Recept>((JsonElement)zahtev.Podaci);
                    List<Recept> pronadjeniRecepte = Kontroler.Instance.NadjiRecepte(recept);
                    if (pronadjeniRecepte.Count == 0)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da pronadje pacijente po zadatom kriterijumu.";
                    }
                    else
                    {
                        odgovor.Podaci = pronadjeniRecepte;
                    }
                    break;

                case Operacija.UcitajRecept:
                    Recept receptZaUcitavanje = JsonSerializer.Deserialize<Recept>((JsonElement)zahtev.Podaci);
                    odgovor.Podaci = Kontroler.Instance.UcitajRecept(receptZaUcitavanje);
                    if (odgovor.Podaci == null)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da ucita recept.";
                    }
                    break;

                case Operacija.ZapamtiRecept:
                    try
                    {
                        Recept receptZaCuvanje = JsonSerializer.Deserialize<Recept>((JsonElement)zahtev.Podaci);
                        Kontroler.Instance.DodajRecept(receptZaCuvanje);
                    }
                    catch (SqlException ex)
                    {
                        odgovor.Signal = false;
                        MessageBox.Show(ex.Message);
                        odgovor.Poruka = "Sistem ne moze da sacuva recept!";
                    }
                    break;

                case Operacija.IzmeniRecept:
                    try
                    {
                        Recept receptZaIzmenu = JsonSerializer.Deserialize<Recept>((JsonElement)zahtev.Podaci);
                        if (!Kontroler.Instance.IzmeniRecept(receptZaIzmenu))
                        {
                            odgovor.Signal = false;
                            odgovor.Poruka = "Sistem ne moze da izmeni recept!";
                        }
                    }
                    catch (SqlException)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne moze da izmeni recept!";
                    }
                    break;

            }
            return odgovor;
        }



    }
}
