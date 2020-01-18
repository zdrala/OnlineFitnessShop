using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Kupac
{
    public class ObucaShopVM
    {
        public List<Obuca> podaciObuca { get; set; }

        public class Obuca
        {
            public int ObucaID { get; set; }
            public int ProizvodID { get; set; }
            public string Naziv { get; set; }
            public float Cijena { get; set; }
            public string Spol { get; set; }
            public string ImageUrl { get; set; }
        }

    }
}
