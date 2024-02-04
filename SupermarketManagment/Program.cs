using SupermarketManagment;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {

        string direktoriji = Directory.GetCurrentDirectory();
        string direktorijiBezDodatnihFoldera = Path.Combine(direktoriji, "..", "..", "..");

        string relativnaPutanja = Path.Combine(direktorijiBezDodatnihFoldera, "KorisniciData.xml");
        string apsolutnaPutanja = Path.GetFullPath(relativnaPutanja);



        string relativnaPutanjaUposlenik = Path.Combine(direktorijiBezDodatnihFoldera, "UposleniciData.xml");
        string apsolutnaPutanjaUposlenik = Path.GetFullPath(relativnaPutanjaUposlenik);

        Console.WriteLine("Dobrodošli u Supermarket Management System!");

        Console.WriteLine("\nOdaberite opciju:");
        Console.WriteLine("a. Korisnik");
        Console.WriteLine("b. Uposlenik");

        string opcijaTipaKorisnika = Console.ReadLine();

        if (opcijaTipaKorisnika.ToLower() == "a")
        {
            while (true)
            {
                Console.WriteLine("\nOdaberite opciju:");
                Console.WriteLine("1. Prijavite se");
                Console.WriteLine("2. Kreirajte novi račun");
                Console.WriteLine("3. Izlaz");

                string unos = Console.ReadLine();

                if (unos == "1")
                {
                    Console.Write("Unesite korisničko ime: ");
                    string korisnickoIme = Console.ReadLine();

                    Console.Write("Unesite lozinku: ");
                    string lozinka = Console.ReadLine();

                    Autentifikacija autentifikacija = new Autentifikacija();
                    bool uspjesnaPrijava = autentifikacija.ProvjeraPrijave(apsolutnaPutanja, korisnickoIme, lozinka);

                    if (uspjesnaPrijava)
                    {
                        Console.WriteLine("Uspješna prijava!");


                        Console.WriteLine("Želite li kupovati?");
                        Console.WriteLine("1. Da");
                        Console.WriteLine("2. Ne");

                        string opcijaKupovine = Console.ReadLine();

                        if (opcijaKupovine == "1")
                        {
                            Asortiman asortiman = new Asortiman();
                            Console.WriteLine("Asortiman proizvoda:");

                            for (int i = 0; i < asortiman.ListaProizvoda.Count; i++)
                            {
                                Proizvod proizvod = asortiman.ListaProizvoda[i];
                                Console.WriteLine($"{i + 1}. Naziv: {proizvod.Naziv}, Cijena: {proizvod.Cijena}, Zalihe: {proizvod.Zalihe}");
                            }

                            Console.Write("Odaberite broj proizvoda za kupovinu: ");
                            int brojProizvoda;
                            while (!int.TryParse(Console.ReadLine(), out brojProizvoda) || brojProizvoda < 1 || brojProizvoda > asortiman.ListaProizvoda.Count)
                            {
                                Console.WriteLine("Nevažeći unos. Molimo unesite validan broj proizvoda.");
                                Console.Write("Odaberite broj proizvoda za kupovinu: ");
                            }

                            Proizvod odabraniProizvod = asortiman.ListaProizvoda[brojProizvoda - 1];

                            Console.Write($"Unesite količinu za kupovinu (dostupno: {odabraniProizvod.Zalihe}): ");
                            int kolicina;
                            while (!int.TryParse(Console.ReadLine(), out kolicina) || kolicina < 1 || kolicina > odabraniProizvod.Zalihe)
                            {
                                Console.WriteLine($"Nevažeći unos. Molimo unesite validnu količinu (dostupno: {odabraniProizvod.Zalihe}).");
                                Console.Write($"Unesite količinu za kupovinu: ");
                            }

                            Transakcija novaTransakcija = new Transakcija
                            {
                                Vrijeme = DateTime.Now,
                                Kupac = new Kupac("Ime", "Prezime", "1234567890123", "123", "123456789", "Adresa", 1990),
                                Iznos = odabraniProizvod.Cijena * kolicina,
                                KupljeniProizvodi = new List<Proizvod> { odabraniProizvod },
                                Prodavac = new Uposlenik("ImeUposlenika", "PrezimeUposlenika", "1234567890123", "123", "123456789", "AdresaUposlenika", "Pozicija", 2000, 1995, "Lozinka")
                            };

                            odabraniProizvod.AzurirajKolicinuNaZalihama(odabraniProizvod.Naziv, odabraniProizvod.Zalihe - kolicina);

                            Console.WriteLine($"Transakcija uspješno izvršena. Ukupan iznos: {novaTransakcija.Iznos}");
                        }

                        else if (opcijaKupovine == "2")
                        {
                            Console.WriteLine("Hvala na posjeti. Doviđenja!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nevažeći unos. Molimo unesite validnu opciju.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pogrešno korisničko ime ili lozinka. Pokušajte ponovo.");
                    }
                }
                else if (unos == "2")
                {
                    Console.WriteLine("Unesite korisničko ime:");
                    string novoKorisnickoIme = Console.ReadLine();

                    Console.WriteLine("Unesite lozinku:");
                    string novaLozinka = Console.ReadLine();

                    Console.WriteLine("Unesite ime:");
                    string ime = Console.ReadLine();

                    Console.WriteLine("Unesite prezime:");
                    string prezime = Console.ReadLine();

                    Console.WriteLine("Unesite JMBG:");
                    string jmbg = Console.ReadLine();

                    Console.WriteLine("Unesite broj lične karte:");
                    string brojLicneKarte = Console.ReadLine();

                    Console.WriteLine("Unesite broj telefona:");
                    string brojTelefona = Console.ReadLine();

                    Console.WriteLine("Unesite adresu:");
                    string adresa = Console.ReadLine();

                    Console.WriteLine("Unesite godinu rođenja:");
                    int godina = int.Parse(Console.ReadLine());

                    KorisnikRegistracija registracija = new KorisnikRegistracija(apsolutnaPutanja);

                    if (registracija.RegistrujKorisnika(novoKorisnickoIme, novaLozinka, ime, prezime, jmbg, brojLicneKarte, brojTelefona, adresa, godina))
                    {
                        Console.WriteLine("Registracija uspješna.");
                    }
                    else
                    {
                        Console.WriteLine("Korisnik već postoji.");
                    }
                }
                else if (unos == "3")
                {
                    Console.WriteLine("Hvala što koristite Supermarket Management System. Doviđenja!");
                    break;
                }
                else
                {
                    Console.WriteLine("Nevažeći unos. Molimo unesite validnu opciju.");
                }
            }
        }
        else if (opcijaTipaKorisnika.ToLower() == "b")
        {
            Console.Write("Unesite korisničko ime: ");
            string korisnickoImeUposlenik = Console.ReadLine();

            Console.Write("Unesite lozinku: ");
            string lozinkaUposlenik = Console.ReadLine();

            Autentifikacija autentifikacijaUposlenik = new Autentifikacija();
            bool uspjesnaPrijavaUposlenik = autentifikacijaUposlenik.ProvjeraPrijave(apsolutnaPutanjaUposlenik, korisnickoImeUposlenik, lozinkaUposlenik);

            if (uspjesnaPrijavaUposlenik)
            {
                Console.WriteLine("Uspješna prijava kao uposlenik!");

                while (true)
                {
                    Console.WriteLine("\nIzaberite opciju:");
                    Console.WriteLine("1. Prikaz asortimana");
                    Console.WriteLine("2. Dodaj proizvod u asortiman");
                    Console.WriteLine("3. Izmijeni cijenu ili zalihu nekog proizvoda");
                    Console.WriteLine("4. Izlaz");

                    string unosNakonPrijaveUposlenik = Console.ReadLine();

                    if (unosNakonPrijaveUposlenik == "1")
                    {
                        PrikaziAsortiman();
                    }
                    else if (unosNakonPrijaveUposlenik == "2")
                    {
                        DodajProizvodUAsortimanUposlenik();
                    }
                    else if (unosNakonPrijaveUposlenik == "3")
                    {
                        PrikaziAsortiman();
                        OdabirProizvoda();
                    }
                    else if (unosNakonPrijaveUposlenik == "4")
                    {
                        Console.WriteLine("Doviđenja!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nevažeći unos. Molimo unesite validnu opciju.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Pogrešno korisničko ime ili lozinka. Pokušajte ponovo.");
            }
        }
    }


    private static void PrikaziAsortiman()
    {
        string direktoriji = Directory.GetCurrentDirectory();
        string direktorijiBezDodatnihFoldera = Path.Combine(direktoriji, "..", "..", "..");

        string relativnaPutanja = Path.Combine(direktorijiBezDodatnihFoldera, "Asortiman.xml");
        string apsolutnaPutanja = Path.GetFullPath(relativnaPutanja);

        try
        {
            XElement asortimanXml = XElement.Load(apsolutnaPutanja);

            Console.WriteLine("\nAsortiman proizvoda:");
            foreach (XElement proizvod in asortimanXml.Elements("Proizvod"))
            {
                Console.WriteLine($"- Naziv: {proizvod.Element("Naziv").Value}, Cijena: {proizvod.Element("Cijena").Value}, Zalihe: {proizvod.Element("Zalihe").Value}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Greška prilikom učitavanja asortimana: {ex.Message}");
        }
    }

    private static void OdabirProizvoda()
    {
        Console.Write("\nUnesite naziv proizvoda za ažuriranje (ili 'q' za izlaz): ");
        string nazivProizvoda = Console.ReadLine();

        if (nazivProizvoda.ToLower() == "q")
        {
            return;
        }

        Console.Write("Unesite novu cijenu proizvoda: ");
        double novaCijena;
        while (!double.TryParse(Console.ReadLine(), out novaCijena))
        {
            Console.Write("Pogrešan unos. Molimo unesite validnu cijenu: ");
        }

        Console.Write("Unesite nove zalihe proizvoda: ");
        int noveZalihe;
        while (!int.TryParse(Console.ReadLine(), out noveZalihe))
        {
            Console.Write("Pogrešan unos. Molimo unesite validne zalihe: ");
        }


        Proizvod proizvod = new Proizvod();
        proizvod.AzurirajCijenu(nazivProizvoda, novaCijena);
        proizvod.AzurirajKolicinuNaZalihama(nazivProizvoda, noveZalihe);
    }

    private static void DodajProizvodUAsortimanUposlenik()
    {
        Console.WriteLine("Unesite podatke o novom proizvodu:");

        Console.Write("Naziv proizvoda: ");
        string nazivProizvoda = Console.ReadLine();

        Console.Write("Cijena proizvoda: ");
        double cijenaProizvoda;
        while (!double.TryParse(Console.ReadLine(), out cijenaProizvoda))
        {
            Console.Write("Pogrešan unos. Molimo unesite validnu cijenu: ");
        }

        Console.Write("Zalihe proizvoda: ");
        int zaliheProizvoda;
        while (!int.TryParse(Console.ReadLine(), out zaliheProizvoda))
        {
            Console.Write("Pogrešan unos. Molimo unesite validne zalihe: ");
        }

        Proizvod noviProizvod = new Proizvod(nazivProizvoda, cijenaProizvoda, zaliheProizvoda);

        Asortiman asortiman = new Asortiman();
        asortiman.DodajProizvod(noviProizvod);

        Console.WriteLine("Proizvod uspešno dodat u asortiman.");
    }

}
