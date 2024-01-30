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
        private Asortiman asortiman;

        public string Ime { get => ime; set => ime = value; }
        public string Lokacija { get => lokacija; set => lokacija = value; }
        public Asortiman Asortiman { get => asortiman; set => asortiman = value; }


        public Supermarket()
        {
            
        }
        public Supermarket(string ime, string lokacija)
        {
            this.Ime = ime;
            this.Lokacija = lokacija;
            
        }

    }
}
