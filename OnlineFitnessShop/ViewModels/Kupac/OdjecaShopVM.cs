using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Kupac
{
    public class OdjecaShopVM
    {
        public List<Odjeca> podaciOdjeca { get; set; }

        public class Odjeca
        {
            public int OdjecaID { get; set; }
            public int ProizvodID { get; set; }
            public string Naziv { get; set; }
            public float Cijena { get; set; }
            public string Spol { get; set; }
            public string ImageUrl { get; set; }
        }

    }
}
