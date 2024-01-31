using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SupermarketManagment
{
    public class Autentifikacija
    {
        public bool ProvjeraPrijave(string xmlFilePath, string username, string password)
        {
            XDocument xdoc = XDocument.Load(xmlFilePath);

            string element = "user";

            var user = xdoc.Descendants(element)
                           .FirstOrDefault(u => (string)u.Element("username") == username && (string)u.Element("password") == password);

            if (user != null)
            {
                return true;
            }
            return false;
        }
    }
}
