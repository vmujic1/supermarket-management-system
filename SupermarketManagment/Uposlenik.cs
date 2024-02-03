public class Uposlenik : Osoba
{

    private string _pozicija;
    private int _plata;

    public Uposlenik(string ime, string prezime, string jmbg, string brojLicneKarte, string brojTelefona, string adresa, string pozicija, int plata) : base(ime, prezime, jmbg, brojLicneKarte, brojTelefona, adresa)
    {
        this._plata = plata;
        this._pozicija = pozicija;

    }

    public string GetPozicija()
    {
        return this._pozicija;
    }

    public int GetPlata()
    {
        return this._plata;
    }

    public void SetPozicija(string pozicija)
    {
        this._pozicija=pozicija;

    }

    public void SetPlata(int plata)
    {
        this._plata = plata;
    }
}

