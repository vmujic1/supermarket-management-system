public class Asortiman
{
    private List<Proizvod> proizvodi;

    public List<Proizvod> Proizvodi { get => proizvodi; set => proizvodi = value; }

    public Asortiman()
    {
        this.proizvodi = new List<Proizvod>();
    }

}

