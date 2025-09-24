using Zajednicki.Domen;

namespace SistemskeOperacije.BolnicaSO
{
    public class ZapamtiBolnicuSO : OpstaSO
    {
        private readonly Bolnica bolnica;

        public ZapamtiBolnicuSO(Bolnica bolnica)
        {
            this.bolnica = bolnica;
        }

        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Sacuvaj(entity);
        }
    }
}
