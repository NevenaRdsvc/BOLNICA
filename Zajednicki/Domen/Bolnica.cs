using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class Bolnica : IEntity
    {
        public int IdBolnica { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public int BrojZaposlenih { get; set; }
        public string NazivTabele => "Bolnica";
        public string Vrednosti =>
            $"('{Naziv}', '{Adresa}', {BrojZaposlenih})";

        public string Uslov => $"idBolnica={IdBolnica}";

        public string Output => "idBolnica";

        public string Kriterijum => " naziv like";

        public string JoinUslov =>
            " b LEFT JOIN Zaposlenje z ON (b.idBolnica = z.idBolnica)";

        public string UpdateUslov =>
            $"naziv='{Naziv}', adresa='{Adresa}'";

        public string UslovBezAlijasa => $"idBolnica={IdBolnica}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            return new Bolnica
            {
                IdBolnica = (int)citac["idBolnica"],
                Naziv = (string)citac["naziv"],
                Adresa = (string)citac["adresa"],
                BrojZaposlenih = (int)citac["BrojZaposlenih"]
            };
        }
    }
}
