using System;
using System.Collections.Generic;
using System.Linq;
using Zajednicki.Domen;

namespace SistemskeOperacije.ReceptSO
{
    public class UcitajRecepteSO : OpstaSO
    {
        public Recept Rezultat { get; private set; }
        private Recept recept;

        public UcitajRecepteSO(Recept r)
        {
            this.recept = r;
        }

        protected override void ExecuteOperation(IEntity entity)
        {
            Rezultat = (Recept)repository.VratiJedan(recept);
            StavkaRecepta s = new StavkaRecepta
            {
                ReceptId = Rezultat.IdRecept
            };
            Rezultat.Stavke = repository.VratiSveZaNekog(s).OfType<StavkaRecepta>().ToList();
        }
    }
}
