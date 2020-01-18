using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Kupac
{
    public class SuplementacijaShopVM
    {
        public List<Suplementacija> podaci { get; set; }

        public class Suplementacija
        {
            public int SuplementacijaID { get; set; }
            public int ProizvodID { get; set; }
            public string Naziv { get; set; }
            public float Cijena { get; set; }
            public string kategorijaSuplementacije { get; set; }
            public string ImageUrl { get; set; }
        }

    }
}
