public class Proizvod {

    public string Naziv { get; set; }
    public int Cijena { get; set; }
    public int Zalihe { get; set; }

    public Proizvod(string naziv, int cijena, int zalihe)
    {
        this.Naziv = naziv;
        this.Cijena = cijena;
        this.Zalihe = zalihe;
        
    }

    public void AzurirajKolicinuNaZalihama(int novaKolicina)
    {
        this.Zalihe = novaKolicina;
    }

    public void AzurirajCijenu(int novaCijena)
    {
        this.Cijena = novaCijena;
    }

}

