

using SupermarketManagment;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        var supermarket = new Supermarket();
        supermarket.Ime = "Amko";
        supermarket.Lokacija = "Stup";
       

        var uposlenik = new Uposlenik();

        uposlenik.talk();


        Console.WriteLine(supermarket.Ime + ' '+ supermarket.Lokacija);



        string direktoriji = Directory.GetCurrentDirectory();
        string direktorijiBezDodatnihFoldera = Path.Combine(direktoriji, "..", "..", "..");

        string relativnaPutanja = Path.Combine(direktorijiBezDodatnihFoldera, "UposleniciData.xml");
        string apsolutnaPutanja = Path.GetFullPath(relativnaPutanja);


        Console.Write("Unesite korisničko ime: ");
        string username = Console.ReadLine();

        Console.Write("Unesite lozinku: ");
        string password = Console.ReadLine();




        bool uspjesnaPrijava = ProvjeraPrijave(apsolutnaPutanja, username, password);

        if (uspjesnaPrijava)
        {
            Console.WriteLine("Uspešno ste se prijavili!");
        }
        else
        {
            Console.WriteLine("Prijavljivanje nije uspelo. Proverite korisničko ime i lozinku.");
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

