﻿public abstract class Osoba
{
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public string JMBG { get; set; }
    public string BrojLicneKarte { get; set; }
    public string BrojTelefona { get; set; }
    public string Adresa { get; set; }
    public int GodinaRodjenja { get; set; }

    public Osoba(string ime, string prezime, string jmbg, string brojLicneKarte, string brojTelefona, string adresa, int godina)
    {
        this.Ime = ime;
        this.Prezime = prezime;
        this.JMBG = jmbg;
        this.BrojLicneKarte = brojLicneKarte;
        this.BrojTelefona = brojTelefona;
        this.Adresa = adresa; 
        this.GodinaRodjenja = godina;
    }

    public int GodineKupca()
    {
        return DateTime.Now.Year - GodinaRodjenja;

    }

    

}

