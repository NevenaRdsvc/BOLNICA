using Microsoft.Data.SqlClient;
using System;

namespace Zajednicki.Domen
{

    public class Lekar : IEntity
    {
        public int IdLekar { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public string FullName => Ime + " " + Prezime;

        public string NazivTabele => "Lekar";

        public string Vrednosti =>
            $"('{Ime}', '{Prezime}', '{JMBG}', '{KorisnickoIme}', '{Lozinka}')";

        public string Uslov => $"idLekar={IdLekar}";

        public string Output => "idLekar";

        public string Kriterijum => " l.ime+' '+l.prezime like";

        public string JoinUslov => "";

        public string UpdateUslov =>
            $"ime='{Ime}', prezime='{Prezime}', jmbg='{JMBG}', korisnickoIme='{KorisnickoIme}', lozinka='{Lozinka}'";

        public string UslovBezAlijasa => $"idLekar={IdLekar}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            Lekar l = new Lekar
            {
                IdLekar = (int)citac["idLekar"],
                Ime = (string)citac["ime"],
                Prezime = (string)citac["prezime"],
                JMBG = (string)citac["jmbg"],
                KorisnickoIme = (string)citac["korisnickoIme"],
                Lozinka = (string)citac["lozinka"]
            };
            return l;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}