using Microsoft.Data.SqlClient;
using System;

namespace Zajednicki.Domen
{
    public class Pacijent : IEntity
    {
        public int IdPacijent { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string Pol { get; set; }
        public string Adresa { get; set; }
        public Mesto Mesto { get; set; }
        public string FullName => Ime + " " + Prezime;
        public string NazivTabele => "Pacijent";

        public string Vrednosti =>
       $"('{Ime}', '{Prezime}', '{JMBG}', '{Pol}', '{Adresa}', {(Mesto != null ? Mesto.IdMesto.ToString() : "NULL")})";


        public string Uslov => $"idPacijent={IdPacijent}";
        public string Output => "idPacijent";
        public string Kriterijum => $" jmbgPacijent LIKE '{JMBG}'";
        public string JoinUslov => " join Mesto m on (Pacijent.idMesto=m.idMesto)";

        public string UpdateUslov =>
         $"imePacijent='{Ime}', " +
         $"prezimePacijent='{Prezime}', " +
         $"jmbgPacijent='{JMBG}', " +
         $"pol='{Pol}', " +
         $"adresa='{Adresa}', " +
         $"idMesto={(Mesto != null ? Mesto.IdMesto.ToString() : "NULL")}";

        public string UslovBezAlijasa => $"idPacijent={IdPacijent}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            return new Pacijent
            {
                IdPacijent = (int)citac["idPacijent"],
                Ime = (string)citac["imePacijent"],
                Prezime = (string)citac["prezimePacijent"],
                JMBG = (string)citac["jmbgPacijent"],
                Pol = (string)citac["pol"],
                Adresa = (string)citac["adresa"],
                Mesto = new Mesto
                {
                    IdMesto = (int)citac["idMesto"],
                    Naziv = citac["naziv"] != DBNull.Value ? (string)citac["naziv"] : null,

                }
            };
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
