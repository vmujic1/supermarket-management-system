public class Kupac : Osoba

{
    public string BrojBonusKartice { get; set; }
    public Kupac(string ime, string prezime, string jmbg, string brojLicneKarte, string brojTelefona, string adresa, string brojBonusKartice) : base(ime, prezime, jmbg, brojLicneKarte, brojTelefona, adresa)
    {
        this.BrojBonusKartice = brojBonusKartice;
    }

   
}

