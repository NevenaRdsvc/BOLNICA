using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class StavkaRecepta : IEntity
    {
        public int IdStavka { get; set; }
        public Doza Doza { get; set; }
        public string Uputstvo { get; set; }
        public int ReceptId { get; set; }
        public Lek Lek { get; set; }

        public string NazivLeka => Lek?.Naziv;

        public string NazivTabele => "StavkaRecepta";

        public string Vrednosti => $"({(int)Doza},'{Uputstvo}',{ReceptId},{Lek.IdLek})";

        public string Uslov => $"sr.idRecept={ReceptId}";

        public string Output => "idStavka";

        public string Kriterijum => "";

        public string JoinUslov => "sr join Recept r on (sr.idRecept=r.idRecept) join Lek l on (sr.idLek=l.idLek)";

        public string UpdateUslov => $"doza={(int)Doza}, tipTerapije='{Uputstvo}', idLek={Lek?.IdLek ?? 0}";

        public string UslovBezAlijasa => $"idRecept={ReceptId} and idStavka={IdStavka}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            StavkaRecepta sr = new StavkaRecepta
            {
                IdStavka = (int)citac["idStavka"],
                ReceptId = (int)citac["idRecept"],
                Doza = (Doza)(int)citac["doza"],
                Uputstvo = (string)citac["uputstvo"],
                Lek = new Lek
                {
                    IdLek = (int)citac["idLek"],
                    Naziv = (string)citac["naziv"]
                }
            };
            return sr;
        }
    }
}
