using System.Xml.Linq;

namespace SupermarketManagment
{
    public class Registracija
    {

        public bool RegistrujKorisnika(string xmlPutanja, string username, string password)
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
                    new XElement("password", password));


                xdoc.Element("users").Add(noviKorisnik);
                xdoc.Save(xmlPutanja);

                return true;

            }
           

        }
    }
}
