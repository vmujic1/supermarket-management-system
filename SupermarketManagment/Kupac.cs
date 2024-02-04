public class Kupac : Osoba

{
    public int SkupljeniBodovi { get; set; }
    public Kupac(string ime, string prezime, string jmbg, string brojLicneKarte, string brojTelefona, string adresa) : base(ime, prezime, jmbg, brojLicneKarte, brojTelefona, adresa)
    {
        this.SkupljeniBodovi = 0;
    }

    public void DodajBodove(int iznos)
    {
        if(iznos >= 0 && iznos < 10)
        {
            SkupljeniBodovi += 1;
        } else if(iznos > 10 && iznos < 50)
        {
            SkupljeniBodovi += 2;
        }else if(iznos >= 50 && iznos < 100)
        {
            SkupljeniBodovi += 3;
        }
    }

    public void OduzmiBodove(int iskoristeniBodovi)
    {
        SkupljeniBodovi -= iskoristeniBodovi;
    }


}

