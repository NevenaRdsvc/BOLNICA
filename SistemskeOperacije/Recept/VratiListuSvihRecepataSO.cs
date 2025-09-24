using System;
using System.Collections.Generic;
using System.Linq;
using Zajednicki.Domen;

namespace SistemskeOperacije.ReceptSO
{
    public class VratiListuSvihRecepataSO : OpstaSO
    {
        public List<Recept> Rezultat { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = repository.VratiSve(new Recept()).OfType<Recept>().ToList();
        }
    }
}
