using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagment
{
    public class Supermarket
    {
        private string ime;
        private string lokacija;

        public string Ime { get => ime; set => ime = value; }
        public string Lokacija { get => lokacija; set => lokacija = value; }

        public Supermarket(string ime, string lokacija)
        {
            this.Ime = ime;
            this.Lokacija = lokacija;
            
        }

    }
}
