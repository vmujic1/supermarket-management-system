public class Uposlenik : Osoba
{

    public string Pozicija { get; set; }
    public int Plata { get; set; }

    public Uposlenik(string ime, string prezime, string jmbg, string brojLicneKarte, string brojTelefona, string adresa, string pozicija, int plata) : base(ime, prezime, jmbg, brojLicneKarte, brojTelefona, adresa)
    {
        this.Plata = plata;
        this.Pozicija = pozicija;

    }
}

    

  

