using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.PacijentSO
{
    public class NadjiPacijenteSO : OpstaSO
    {

        public List<Pacijent> Rezultat { get; private set; }
        public NadjiPacijenteSO()
        {
        }


        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = repository.Pretraga(entity).OfType<Pacijent>().ToList();
        }

    }
}
