using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije.LekSO
{
    public class ZapamtiLekSO : OpstaSO
    {

        private Lek lek;

        public ZapamtiLekSO(Lek lek)
        {
            this.lek = lek;
        }

        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Sacuvaj(entity);
        }

    }
}
