

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

<<<<<<< HEAD
        
        Registracija registracija = new Registracija();

        bool uspjesnaRegistracija = registracija.RegistrujKorisnika(apsolutnaPutanja, username, password);
=======
        /*
        Registracija registracija = new Registracija();

        bool uspjesnaRegistracija = registracija.RegistrujKorisnika(apsolutnaPutanja, username, password);

        if (uspjesnaRegistracija)
        {
            Console.WriteLine("Uspjesno ste registrovani!");
        }
        else
        {
            Console.WriteLine("Registracija nije uspjela. U bazi već postoji korisnik sa tim usernameom");
        }
        */
>>>>>>> c43650a039bda1489678515e96b27ab3d7c4f87b

        if (uspjesnaRegistracija)
        {
            Console.WriteLine("Uspjesno ste registrovani!");
        }
        else
        {
            Console.WriteLine("Registracija nije uspjela. U bazi već postoji korisnik sa tim usernameom");
        }
        

        /*
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
        
<<<<<<< HEAD
        */
=======
>>>>>>> c43650a039bda1489678515e96b27ab3d7c4f87b


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

