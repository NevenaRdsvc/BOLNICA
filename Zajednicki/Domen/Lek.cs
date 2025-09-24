using Microsoft.Data.SqlClient;
using System;

namespace Zajednicki.Domen
{
    public class Lek : IEntity
    {
        public int IdLek { get; set; }
        public string Naziv { get; set; }
        public TipLeka TipLeka { get; set; }  
        public string SerijaProizvodnje { get; set; }
        public double Cena { get; set; }
        public string Proizvodjac { get; set; }

        public string NazivTabele => "Lek";

        public string Vrednosti =>
            $"('{Naziv}', {(int)TipLeka}, {SerijaProizvodnje}, {Cena}, '{Proizvodjac}')";

        public string Uslov => $"idLek={IdLek}";

        public string Output => "idLek";

        public string Kriterijum => " l.naziv like";

        public string JoinUslov => "";

        public string UpdateUslov =>
            $"naziv='{Naziv}', tipLeka={(int)TipLeka}, serijaProizvodnje={SerijaProizvodnje}, cena={Cena}, proizvodjac='{Proizvodjac}'";

        public string UslovBezAlijasa => $"idLek={IdLek}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            Lek l = new Lek
            {
                IdLek = (int)citac["idLek"],
                Naziv = (string)citac["naziv"],
                TipLeka = (TipLeka)(int)citac["tipLeka"],
                SerijaProizvodnje = (string)citac["serijaProizvodnje"],
                Cena = Convert.ToDouble(citac["cena"]),
                Proizvodjac = (string)citac["proizvodjac"]
            };
            return l;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}