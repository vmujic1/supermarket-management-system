public class Transakcija
{
    public int Id { get; set; }
    public DateTime Vrijeme { get; set; }
    public double Iznos { get; set; }
    public List<Proizvod> KupljeniProizvodi { get; set; }
    public Kupac Kupac { get; set; }
    public Uposlenik Prodavac { get; set; }

    public Transakcija()
    {
        
    }

    public double ObracunajPopust(int bodovi)
    {
        double popust = Iznos * (bodovi / 100);
        Kupac.OduzmiBodove(bodovi);
        return Iznos - popust;
    }

}

