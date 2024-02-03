using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagment
{
    public class Supermarket
    {
        private string _ime;
        private string _lokacija;
        private Asortiman _asortiman;
        private List<Uposlenik> _uposlenici = new List<Uposlenik>();

        public string Ime { get =>  _ime; set => _ime = value; }
        public string Lokacija { get => _lokacija; set => _lokacija = value; }
        public Asortiman Asortiman { get => _asortiman; set => _asortiman = value; }
        public List<Uposlenik> Uposlenici { get => _uposlenici; set => _uposlenici = value; }

        public Supermarket()
        {
            
        }
        public Supermarket(string ime, string lokacija)
        {
            this.Ime = ime;
            this.Lokacija = lokacija;
            
        }

        public void dodajUposlenika(Uposlenik uposlenik)
        {
            Uposlenici.Add(uposlenik);
        }

    }
}
