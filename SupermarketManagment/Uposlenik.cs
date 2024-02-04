public class Uposlenik : Osoba
{

    public string Pozicija { get; set; }
    public int Plata { get; set; }
    public string Lozinka { get; set; }


    public Uposlenik(string ime, string prezime, string jmbg, string brojLicneKarte, string brojTelefona, string adresa, string pozicija, int plata, int godina, string lozinka) : base(ime, prezime, jmbg, brojLicneKarte, brojTelefona, adresa, godina)
    {
        this.Plata = plata;
        this.Pozicija = pozicija;
        this.Lozinka = lozinka;
    }
}

    

  

