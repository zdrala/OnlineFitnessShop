using ClassLibrarySeminarski.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Kupac
{
    public class NarudzbaStavkeVM
    {

        public List<Stavke> stavke;
        public class Stavke
        {
            public string imageUrl { get; set; }
            public int TrazenaKolicina { get; set; }
            public string Velicina { get; set; }
            public string Naziv { get; set; }
            public float Cijena { get; set; }
        }

    }
}
