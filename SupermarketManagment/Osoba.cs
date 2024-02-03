public abstract class Osoba
{
    private string _ime;
    private string _prezime;
    private string _JMBG;
    private string _brojLicneKarte;
    private string _brojTelefona;
    private string _adresa;

    public Osoba(string ime, string prezime, string jmbg, string brojLicneKarte, string brojTelefona, string adresa)
    {
        this._ime = ime;
        this._prezime = prezime;
        this._JMBG = jmbg;
        this._brojLicneKarte = brojLicneKarte;
        this._brojTelefona = brojTelefona;
        this._adresa = adresa; 
    }

    public void SetName(string ime)
    {
        this._ime = ime;
    }

    public void SetPrezime(string prezime) { 
            this._prezime = prezime;
    }

    public void SetJMBG(string jmbg)
    {
        this._JMBG= jmbg;
    }

    public void SetBrojLicneKarte(string brojLicneKarte)
    {
        this._brojLicneKarte= brojLicneKarte;
    }

    public void SetBrojTelefona(string brojTelefona)
    {
        this._brojTelefona= brojTelefona;
    }

    public void SetAdresa(string adresa)
    {
        this._adresa = adresa;  
    }

    public string GetName()
    {
        return this._ime;
    }
    public string GetPrezime()
    {
        return this._prezime;
    }
    public string GetJMBG()
    {
        return this._JMBG;
    }

    public string GetBrojTelefona()
    {
        return this._brojTelefona;
    }

    public string GetAdresa()
    {
        return this._adresa;
    }

}

