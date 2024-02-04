using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SupermarketManagment
{
    public class Supermarket
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public List<Uposlenik> Uposlenici { get; set; }
        public Asortiman Asortiman { get; set; }

        public Supermarket()
        {
            
        }

        public Supermarket(int id, string naziv, string lokacija)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Lokacija = lokacija;
            
        }


        public void dodajUposlenika(Uposlenik uposlenik, string putanja)
        {
            XDocument xmlDocument = XDocument.Load(putanja);

            XElement usersElement = xmlDocument.Root;

            XElement noviUposlenikElement = new XElement("user",
                new XElement("username", uposlenik.Ime),
                new XElement("prezime", uposlenik.Prezime),
                new XElement("JMBG", uposlenik.JMBG),
                new XElement("brojLicneKarte", uposlenik.BrojLicneKarte),
                new XElement("brojTelefona", uposlenik.BrojTelefona),
                new XElement("godinaRodjenja", uposlenik.GodinaRodjenja),
                new XElement("adresa", uposlenik.Adresa),
                new XElement("pozicija", uposlenik.Pozicija),
                new XElement("plata", uposlenik.Plata),
                new XElement("password", uposlenik.Lozinka)
                
            ); 

            usersElement.Add(noviUposlenikElement);

            xmlDocument.Save(putanja);
        }
    

        public List<Uposlenik> GetAllUposlenici(string putanja)
        {
            XDocument xmlDocument = XDocument.Load(putanja);

            XElement usersElement = xmlDocument.Root;

            IEnumerable<XElement> userElements = usersElement.Elements("user");

            List<Uposlenik> uposlenici = new List<Uposlenik>();

            foreach (XElement userElement in userElements)
            {
                Uposlenik uposlenik = new Uposlenik
              (


                       userElement.Element("username").Value,
                  userElement.Element("prezime").Value,
                  userElement.Element("JMBG").Value,
                  userElement.Element("brojLicneKarte").Value,
                  userElement.Element("brojTelefona").Value,
                  userElement.Element("adresa").Value,
                  userElement.Element("pozicija").Value,
                  int.Parse(userElement.Element("plata").Value),
                  int.Parse(userElement.Element("godinaRodjenja").Value),
                  userElement.Element("password").Value

              );
                uposlenici.Add(uposlenik);

            }

            return uposlenici;
        }

    }
}
