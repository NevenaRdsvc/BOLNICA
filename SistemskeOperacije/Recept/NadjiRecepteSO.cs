using System;
using System.Collections.Generic;
using System.Linq;
using Zajednicki.Domen;

namespace SistemskeOperacije.ReceptSO
{
    public class NadjiRecepteSO : OpstaSO
    {

        public List<Recept> Rezultat { get; private set; }
        public NadjiRecepteSO()
        {
        }


        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = repository.Pretraga(entity).OfType<Recept>().ToList();
        }
    }
}
