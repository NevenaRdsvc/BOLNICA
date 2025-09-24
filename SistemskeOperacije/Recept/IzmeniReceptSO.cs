using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Zajednicki.Domen;

namespace SistemskeOperacije.ReceptSO
{
    public class IzmeniReceptSO : OpstaSO
    {
        private Recept recept;
        public bool Rezultat { get; private set; }

        public IzmeniReceptSO(Recept r)
        {
            recept = r;
        }

        protected override void ExecuteOperation(IEntity entity)
        {
            if (repository.Izmeni(recept) == 0)
            {
                Rezultat = false;
                return;
            }

            if (recept.StavkeZaBrisanje != null && recept.StavkeZaBrisanje.Count > 0)
            {
                foreach (var stavkaZaBrisanje in recept.StavkeZaBrisanje)
                {
                    if (stavkaZaBrisanje.IdStavka > 0)
                        repository.Izbrisi(stavkaZaBrisanje);
                }
            }

            foreach (var stavka in recept.Stavke)
            {
               if (stavka.IdStavka == 0)
                repository.Sacuvaj(stavka);
            }

            Rezultat = true;
        }
    }
}
