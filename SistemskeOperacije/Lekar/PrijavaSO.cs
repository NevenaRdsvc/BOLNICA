using Zajednicki.Domen;

namespace SistemskeOperacije.LekarSO
{
    public class PrijavaSO:OpstaSO
    {
        public Lekar Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Lekar lekar = (Lekar)entity;



            foreach (Lekar l in repository.VratiSve(new Lekar()))
            {
                if (l.KorisnickoIme == lekar.KorisnickoIme && l.Lozinka == lekar.Lozinka)
                {
                    Result = l;
                }
            }
        }
    }
}
