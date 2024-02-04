using System.Xml.Linq;

public class Asortiman
{
    public List<Proizvod> ListaProizvoda { get; set; }

    public Asortiman()
    {
        UcitajIzXml();
        
    }

    public void UkloniProizvod(string naziv)
    {
        UcitajIzXml();

        Proizvod proizvodZaUkloniti = ListaProizvoda.FirstOrDefault(p => p.Naziv == naziv);
        {
            ListaProizvoda.Remove(proizvodZaUkloniti);
            PohranaUXml();  
        }


    }

    public void DodajProizvod(Proizvod proizvod)
    {
        ListaProizvoda.Add(proizvod);
        
        PohranaUXml();

    }

    public void PohranaUXml()
    {
        string direktoriji = Directory.GetCurrentDirectory();
        string direktorijiBezDodatnihFoldera = Path.Combine(direktoriji, "..", "..", "..");

        string relativnaPutanja = Path.Combine(direktorijiBezDodatnihFoldera, "Asortiman.xml");
        string apsolutnaPutanja = Path.GetFullPath(relativnaPutanja);

        XElement asortimanXml = new XElement("Asortiman",
            from proizvod in ListaProizvoda
            select new XElement("Proizvod",
                new XElement("Naziv", proizvod.Naziv),
                new XElement("Cijena", proizvod.Cijena),
                new XElement("Zalihe", proizvod.Zalihe)));


        asortimanXml.Save(apsolutnaPutanja);
    }

    public void UcitajIzXml()
    {
        string direktoriji = Directory.GetCurrentDirectory();
        string direktorijiBezDodatnihFoldera = Path.Combine(direktoriji, "..", "..", "..");

        string relativnaPutanja = Path.Combine(direktorijiBezDodatnihFoldera, "Asortiman.xml");
        string apsolutnaPutanja = Path.GetFullPath(relativnaPutanja);
        try
        {
            XElement asortimanXml = XElement.Load(apsolutnaPutanja);

            ListaProizvoda = (
                from proizvodXml in asortimanXml.Elements("Proizvod")
                select new Proizvod
                (
                    proizvodXml.Element("Naziv").Value,
                    int.Parse(proizvodXml.Element("Cijena").Value),
                    int.Parse(proizvodXml.Element("Zalihe").Value)
                )).ToList();

        }
        catch (FileNotFoundException)
        {
        }
    }




}

