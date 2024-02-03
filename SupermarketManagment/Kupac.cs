public class Kupac : Osoba

{
    private string _brojBonusKartice;
    public Kupac(string ime, string prezime, string jmbg, string brojLicneKarte, string brojTelefona, string adresa, string brojBonusKartice) : base(ime, prezime, jmbg, brojLicneKarte, brojTelefona, adresa)
    {
        this._brojBonusKartice = brojBonusKartice;
    }

    public string GetBrojBonusKartice() {  return this._brojBonusKartice;}
    public void SetBrojBonusKartice(string brojBonusKartice)
    {
        this._brojBonusKartice = brojBonusKartice;
    }
}

