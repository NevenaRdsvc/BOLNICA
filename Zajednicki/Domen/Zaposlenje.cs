using Microsoft.Data.SqlClient;
using Zajednicki.Domen;

public class Zaposlenje : IEntity
{
    public DateOnly DatumPocetka { get; set; }
    public DateOnly? DatumZavrsetka { get; set; }
    public string Pozicija { get; set; }
    public string StatusZaposlenja { get; set; }

    public Lekar Lekar { get; set; }
    public Bolnica Bolnica { get; set; }

    public string NazivTabele => "Zaposlenje";

    public string Vrednosti =>
        $"('{DatumPocetka:yyyy-MM-dd}', " +
        $"{(DatumZavrsetka.HasValue ? $"'{DatumZavrsetka:yyyy-MM-dd}'" : "NULL")}, " +
        $"'{Pozicija}', '{StatusZaposlenja}', {Lekar.IdLekar}, {Bolnica.IdBolnica})";

    public string Uslov =>
        $"datumPocetka='{DatumPocetka:yyyy-MM-dd}' AND idLekar={Lekar.IdLekar} AND idBolnica={Bolnica.IdBolnica}";


    public string Output => "datumPocetka";

    public string Kriterijum => "";

    public string JoinUslov =>
        "z join Lekar l on (z.idLekar=l.idLekar) join Bolnica b on (z.idBolnica=b.idBolnica)";

    public string UpdateUslov =>
        $"datumZavrsetka={(DatumZavrsetka.HasValue ? $"'{DatumZavrsetka:yyyy-MM-dd}'" : "NULL")}, " +
        $"pozicija='{Pozicija}', statusZaposlenja='{StatusZaposlenja}'";

    public string UslovBezAlijasa =>
        $"datumPocetka='{DatumPocetka:yyyy-MM-dd}' AND idLekar={Lekar.IdLekar} AND idBolnica={Bolnica.IdBolnica}";

    public IEntity ProcitajObjekat(SqlDataReader citac)
    {
        return new Zaposlenje
        {
            DatumPocetka = DateOnly.FromDateTime((DateTime)citac["datumPocetka"]),
            DatumZavrsetka = citac["datumZavrsetka"] == DBNull.Value ? null : DateOnly.FromDateTime((DateTime)citac["datumZavrsetka"]),
            Pozicija = (string)citac["pozicija"],
            StatusZaposlenja = (string)citac["statusZaposlenja"],
            Lekar = new Lekar
            {
                IdLekar = (int)citac["idLekar"],
                Ime = (string)citac["imeLekar"],
                Prezime = (string)citac["prezimeLekar"],
                JMBG = (string)citac["jmbgLekar"]
            },
            Bolnica = new Bolnica
            {
                IdBolnica = (int)citac["idBolnica"],
                Naziv = (string)citac["nazivBolnica"],
                Adresa = (string)citac["adresaBolnica"],
                BrojZaposlenih = (int)citac["brojZaposlenih"]
            }
        };
    }
}
