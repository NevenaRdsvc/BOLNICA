using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.LekarSO
{
    public class VratiListuSvihLekaraSO : OpstaSO
    {
        public List<Lekar> Rezultat { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            var lekar = repository.VratiSve(new Lekar());
            Rezultat = lekar?.OfType<Lekar>().ToList() ?? new List<Lekar>();
        }


    }
}
