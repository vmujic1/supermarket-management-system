

using SupermarketManagment;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        var supermarket = new Supermarket();
        supermarket.Naziv = "Amko";
        supermarket.Lokacija = "Stup";

        Asortiman asortiman = new Asortiman();


       










        string direktoriji = Directory.GetCurrentDirectory();
        string direktorijiBezDodatnihFoldera = Path.Combine(direktoriji, "..", "..", "..");

        string relativnaPutanja = Path.Combine(direktorijiBezDodatnihFoldera, "UposleniciData.xml");
        string apsolutnaPutanja = Path.GetFullPath(relativnaPutanja);


       // var uposlenik = new Uposlenik("admin", "Mujic", "2", "2", "2", "2", "sef", 2000, 2001, "admin123");
       // supermarket.dodajUposlenika(uposlenik, apsolutnaPutanja);

        var uposlenici = supermarket.GetAllUposlenici(apsolutnaPutanja);


      




        Console.Write("Unesite korisničko ime: ");
        string username = Console.ReadLine();

        Console.Write("Unesite lozinku: ");
        string password = Console.ReadLine();



        Autentifikacija autentifikacija = new Autentifikacija();

        bool uspjesnaPrijava = autentifikacija.ProvjeraPrijave(apsolutnaPutanja, username, password);

        if (uspjesnaPrijava)
        {
            Console.WriteLine("Uspješno ste se prijavili!");
        }
        else
        {
            Console.WriteLine("Prijavljivanje nije uspjelo. Provjerite korisničko ime i lozinku.");
        }



        static bool ProvjeraPrijave(string xmlFilePath, string username, string password)
        {
            XDocument xdoc = XDocument.Load(xmlFilePath);

            string element = "user";

            
            var user = xdoc.Descendants(element)
                           .FirstOrDefault(u => (string)u.Element("username") == username && (string)u.Element("password") == password);

            return user != null;
        }

    }
}

