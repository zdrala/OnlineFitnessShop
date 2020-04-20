using ClassLibrarySeminarski.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Kupac
{
    public class TempVM
    {

        public List<ProizvodV> stavke;
        public class ProizvodV
        {
            public int ProizvodID { get; set; }
            public string VrstaProizvoda { get; set; }
            public int TrazenaKolicina { get; set; }
            public string Velicina { get; set; }
            public float Cijena { get; set; }
        }

    }
}
