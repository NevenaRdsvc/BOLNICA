using SistemskeOperacije;
using System.Linq;
using Zajednicki.Domen;

namespace Server.SO.ReceptSO
{
    public class ZapamtiReceptSO : OpstaSO
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Recept recept = (Recept)entity;

            int id = repository.Sacuvaj(recept);
            recept.IdRecept = id;

            foreach (var stavka in recept.Stavke)
            {
                stavka.ReceptId = recept.IdRecept;
                repository.Sacuvaj(stavka);
            }
        }
    }
}
