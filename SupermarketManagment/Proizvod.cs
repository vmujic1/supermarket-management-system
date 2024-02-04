using System.Xml.Linq;

<<<<<<< HEAD
public class Proizvod
{
=======
public class Proizvod {
>>>>>>> be35143baa8dffe6accaccc6b7ced726121256cf

    public string Naziv { get; set; }
    public double Cijena { get; set; }
    public int Zalihe { get; set; }

    public Proizvod()
    {
<<<<<<< HEAD

    }

    public Proizvod(string naziv, double cijena, int zalihe)
=======
        
    }

    public Proizvod(string naziv, int cijena, int zalihe)
>>>>>>> be35143baa8dffe6accaccc6b7ced726121256cf
    {
        this.Naziv = naziv;
        this.Cijena = cijena;
        this.Zalihe = zalihe;

    }

    public void AzurirajKolicinuNaZalihama(string nazivProizvoda, int novaKolicina)
    {
        string direktoriji = Directory.GetCurrentDirectory();
        string direktorijiBezDodatnihFoldera = Path.Combine(direktoriji, "..", "..", "..");

        string relativnaPutanja = Path.Combine(direktorijiBezDodatnihFoldera, "Asortiman.xml");
        string apsolutnaPutanja = Path.GetFullPath(relativnaPutanja);


        try
        {
            XElement asortimanXml = XElement.Load(apsolutnaPutanja);

            XElement proizvodZaAzuriranje = asortimanXml.Elements("Proizvod")
                .FirstOrDefault(p => p.Element("Naziv")?.Value == nazivProizvoda);

            if (proizvodZaAzuriranje != null)
            {
                proizvodZaAzuriranje.Element("Zalihe").Value = novaKolicina.ToString();
                asortimanXml.Save(apsolutnaPutanja);

                Console.WriteLine($"Količina za proizvod '{nazivProizvoda}' ažurirana na {novaKolicina}.");
            }
            else
            {
                Console.WriteLine($"Proizvod s nazivom '{nazivProizvoda}' nije pronađen.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Greška prilikom ažuriranja količine: {ex.Message}");
        }
    }


    public void AzurirajCijenu(string nazivProizvoda, double novaCijena)
    {
        string direktoriji = Directory.GetCurrentDirectory();
        string direktorijiBezDodatnihFoldera = Path.Combine(direktoriji, "..", "..", "..");

        string relativnaPutanja = Path.Combine(direktorijiBezDodatnihFoldera, "Asortiman.xml");
        string apsolutnaPutanja = Path.GetFullPath(relativnaPutanja);



        try
        {
            XElement asortimanXml = XElement.Load(apsolutnaPutanja);

            XElement proizvodZaAzuriranje = asortimanXml.Elements("Proizvod")
                .FirstOrDefault(p => p.Element("Naziv")?.Value == nazivProizvoda);

            if (proizvodZaAzuriranje != null)
            {
                proizvodZaAzuriranje.Element("Cijena").Value = novaCijena.ToString();
                asortimanXml.Save(apsolutnaPutanja);

                Console.WriteLine($"Cijena za proizvod '{nazivProizvoda}' ažurirana na {novaCijena}.");
            }
            else
            {
                Console.WriteLine($"Proizvod s nazivom '{nazivProizvoda}' nije pronađen.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Greška prilikom ažuriranja cijene: {ex.Message}");
        }
    }

<<<<<<< HEAD
=======

}
>>>>>>> be35143baa8dffe6accaccc6b7ced726121256cf

}