using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public void dodajUposlenika(Uposlenik uposlenik)
        {
            Uposlenici.Add(uposlenik);
        }

    }
}
