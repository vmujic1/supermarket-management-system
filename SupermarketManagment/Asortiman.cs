public class Asortiman
{
    public List<Proizvod> ListaProizvoda { get; set; }

    public Asortiman()
    {
        this.ListaProizvoda = new List<Proizvod>();
    }

    public void UkloniProizvod(Proizvod proizvod)
    {
        ListaProizvoda.Remove(proizvod);
    }

    public void DodajProizvod(Proizvod proizvod)
    {
        ListaProizvoda.Add(proizvod);

    }


}

