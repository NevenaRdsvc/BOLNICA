using DBBroker;
using Server.SO.ReceptSO;
using SistemskeOperacije;
using SistemskeOperacije.BolnicaSO;
using SistemskeOperacije.LekarSO;
using SistemskeOperacije.LekSO;
using SistemskeOperacije.MestoSO;
using SistemskeOperacije.PacijentSO;
using SistemskeOperacije.ReceptSO;
using Zajednicki.Domen;

namespace Server
{
    public class Kontroler
    {
        private IGenerickiRepozitorijum repository;
        private static Kontroler instance;
        private static object _lock = new object();
        private Kontroler()
        {
            repository = new GenerickiRepozitorijum();
        }
        public static Kontroler Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Kontroler();
                        }
                    }
                }
                return instance;
            }
        }
        public Lekar Login(Lekar l)
        {
            PrijavaSO so = new PrijavaSO();
            so.ExecuteTemplate(l);
            return so.Result;
        }
        public void DodajPacijenta(Pacijent p)
        {
            OpstaSO so = new ZapamtiPacijentaSO(p);
            so.ExecuteTemplate(p);
        }
        public List<Pacijent> VratiSvePacijente()
        {
            OpstaSO so = new VratiListuSvihPacijenataSO();
            so.ExecuteTemplate(new Pacijent());
            return ((VratiListuSvihPacijenataSO)so).Rezultat;
        }
        public List<Pacijent> NadjiPacijente(Pacijent p)
        {
            OpstaSO so = new NadjiPacijenteSO();
            so.ExecuteTemplate(p);
            return ((NadjiPacijenteSO)so).Rezultat;
        }
        public Pacijent UcitajPacijente(Pacijent p)
        {
            OpstaSO so = new UcitajPacijenteSO(p);
            so.ExecuteTemplate(new Pacijent());
            return ((UcitajPacijenteSO)so).Rezultat;
        }
        public bool IzmeniPacijenta(Pacijent p)
        {
            OpstaSO so = new IzmeniPacijentaSO(p);
            so.ExecuteTemplate(new Pacijent());
            return ((IzmeniPacijentaSO)so).Rezultat;
        }
        public bool ObrisiPacijenta(Pacijent p)
        {
            OpstaSO so = new ObrisiPacijentaSO(p);
            so.ExecuteTemplate(new Pacijent());
            return ((ObrisiPacijentaSO)so).Rezultat;
        }

        public void DodajLek(Lek l)
        {
            OpstaSO so = new ZapamtiLekSO(l);
            so.ExecuteTemplate(l);
        }

        public void DodajBolnicu(Bolnica b)
        {
            OpstaSO so = new ZapamtiBolnicuSO(b);
            so.ExecuteTemplate(b);
        }

        public List<Mesto> VratiSvaMesta()
        {
            OpstaSO so = new VratiListuSvihMestaSO();
            so.ExecuteTemplate(new Mesto());
            return ((VratiListuSvihMestaSO)so).Rezultat;
        }

        public List<Lek> VratiSveLekove()
        {
            OpstaSO so = new VratiListuSvihLekovaSO();
            so.ExecuteTemplate(new Lek());
            return ((VratiListuSvihLekovaSO)so).Rezultat;
        }
        public void DodajRecept(Recept r)
        {
            OpstaSO so = new ZapamtiReceptSO();
            so.ExecuteTemplate(r);
        }

        public List<Recept> VratiSveRecepte()
        {
            OpstaSO so = new VratiListuSvihRecepataSO();
            so.ExecuteTemplate(new Recept());
            return ((VratiListuSvihRecepataSO)so).Rezultat;
        }

        public List<Lekar> VratiSveLekare()
        {
            OpstaSO so = new VratiListuSvihLekaraSO();
            so.ExecuteTemplate(new Lekar());
            return ((VratiListuSvihLekaraSO)so).Rezultat;
        }

        public List<Recept> NadjiRecepte(Recept recepti)
        {
            OpstaSO so = new NadjiRecepteSO();
            so.ExecuteTemplate(recepti);
            return ((NadjiRecepteSO)so).Rezultat;
        }

        public Recept UcitajRecept(Recept r)
        {
            OpstaSO so = new UcitajRecepteSO(r);
            so.ExecuteTemplate(new Recept());
            return ((UcitajRecepteSO)so).Rezultat;
        }

        public bool IzmeniRecept(Recept r)
        {
            OpstaSO so = new IzmeniReceptSO(r);
            so.ExecuteTemplate(new Recept());
            return ((IzmeniReceptSO)so).Rezultat;
        }



    }
}
