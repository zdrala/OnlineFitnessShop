using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class NarudzbaStavkePrikazVM
    {
        public List<Stavka> stavkeList { get; set; }
        public class Stavka
        {
            public int proizvodID { get; set; }
            public string VrstaProizvoda { get; set; }
            public string imageUrl { get; set; }
            public string NazivProizvoda { get; set; }
            public string Velicina { get; set; }
            public string Kolicina { get; set; }
        }
    }
}
