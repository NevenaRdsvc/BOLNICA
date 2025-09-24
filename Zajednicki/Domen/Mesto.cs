using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public class Mesto : IEntity
    {
        public int IdMesto { get; set; }
        public string Naziv { get; set; }

        public string NazivTabele => "Mesto";
        public string Vrednosti => $"('{Naziv}')";
        public string Uslov => $"idMesto={IdMesto}";
        public string Output => "idMesto";
        public string Kriterijum => "";
        public string JoinUslov => "";
        public string UpdateUslov => $"naziv='{Naziv}'";
        public string UslovBezAlijasa => $"idMesto={IdMesto}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            return new Mesto
            {
                IdMesto = citac.GetInt32(0),
                Naziv = citac.GetString(1),
            };
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
