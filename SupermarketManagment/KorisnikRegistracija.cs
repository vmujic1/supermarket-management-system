using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SupermarketManagment
{
    public class KorisnikRegistracija
    {
        private string xmlPutanja;

        public KorisnikRegistracija(string xmlPutanja)
        {
            this.xmlPutanja = xmlPutanja;
        }

        public bool RegistrujKorisnika(string username, string password, string ime, string prezime, string jmbg, string brojLicneKarte, string brojTelefona, string adresa, int godina)
        {
            XDocument xdoc = XDocument.Load(xmlPutanja);

            var registrovaniKorisnici = xdoc.Descendants("user").Where(u => (string)u.Element("username") == username).Any();
            if (registrovaniKorisnici)
            {
                return false;
            }
            else
            {
                XElement noviKorisnik = new XElement("user",
                    new XElement("username", username),
                    new XElement("password", password),
                    new XElement("ime", ime),
                    new XElement("prezime", prezime),
                    new XElement("jmbg", jmbg),
                    new XElement("brojLicneKarte", brojLicneKarte),
                    new XElement("brojTelefona", brojTelefona),
                    new XElement("adresa", adresa),
                    new XElement("godinaRodjenja", godina)
                );

                xdoc.Element("users").Add(noviKorisnik);
                xdoc.Save(xmlPutanja);

                return true;
            }
        }
    }
}
