using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.LekSO
{
    public class VratiListuSvihLekovaSO : OpstaSO
    {
        public List<Lek> Rezultat { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            var lekovi = repository.VratiSve(new Lek());
            Rezultat = lekovi?.OfType<Lek>().ToList() ?? new List<Lek>();
        }


    }
}
