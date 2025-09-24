using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Zajednicki.Domen
{
    public class Recept : IEntity
    {
        public int IdRecept { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public DateTime DatumIsteka { get; set; }
        public string Napomena { get; set; }
        public int VremeTrajanja { get; set; }
        public Lekar Lekar { get; set; }
        public Pacijent Pacijent { get; set; }

        public List<StavkaRecepta> Stavke { get; set; }
        public List<StavkaRecepta> StavkeZaBrisanje { get; set; }

        public string LekarFullName => Lekar != null ? Lekar.Ime + " " + Lekar.Prezime : "";
        public string PacijentFullName => Pacijent != null ? Pacijent.Ime + " " + Pacijent.Prezime : "";


        public string NazivTabele => "Recept";

        public string Vrednosti =>
            $"('{DatumIzdavanja:yyyy-MM-dd}','{DatumIsteka:yyyy-MM-dd}','{Napomena}',{VremeTrajanja},{Lekar?.IdLekar ?? 0},{Pacijent?.IdPacijent ?? 0})";

        public string Uslov => $"idRecept={IdRecept}";

        public string Output => "idRecept";

        public string Kriterijum
        {
            get
            {
                return $"CAST(r.datumIzdavanja AS DATE) = '{DatumIzdavanja:yyyy-MM-dd}'";
            }
        }

        public string JoinUslov => "r join Lekar l on (r.idLekar=l.idLekar) join Pacijent p on (r.idPacijent=p.idPacijent)";

        public string UpdateUslov =>
            $"datumIzdavanja='{DatumIzdavanja:yyyy-MM-dd}', datumIsteka='{DatumIsteka:yyyy-MM-dd}', napomena='{Napomena}', vremeTrajanja={VremeTrajanja}, idLekar={Lekar?.IdLekar ?? 0}, idPacijent={Pacijent?.IdPacijent ?? 0}";

        public string UslovBezAlijasa => $"idRecept={IdRecept}";

        public IEntity ProcitajObjekat(SqlDataReader citac)
        {
            Recept r = new Recept
            {
                IdRecept = (int)citac["idRecept"],
                DatumIzdavanja = (DateTime)citac["datumIzdavanja"],
                DatumIsteka = (DateTime)citac["datumIsteka"],
                Napomena = (string)citac["napomena"],
                VremeTrajanja = (int)citac["vremeTrajanja"],
                Lekar = new Lekar
                {
                    IdLekar = (int)citac["idLekar"],
                    Ime = (string)citac["ime"],
                    Prezime = (string)citac["prezime"],
                    JMBG = (string)citac["jmbg"],
                    KorisnickoIme = (string)citac["korisnickoIme"],
                    Lozinka = (string)citac["lozinka"]
                },
                Pacijent = new Pacijent
                {
                    IdPacijent = (int)citac["idPacijent"],
                    Ime = (string)citac["imePacijent"],
                    Prezime = (string)citac["prezimePacijent"],
                    JMBG = (string)citac["jmbgPacijent"],
                    Pol = (string)citac["pol"],
                    Adresa = (string)citac["adresa"]
                }
            };
            return r;
        }
    }
}
