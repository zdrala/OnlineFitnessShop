using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Kupac
{
    public class DodatakPrikazVM
    {
        
            public int DodatakID { get; set; }
            public int ProizvodID { get; set; }
            public string Naziv { get; set; }
            public float Cijena { get; set; }
            public string TipDodatka { get; set; }
            public string ImageUrl { get; set; }
            public int Kolicina { get; set; }

    }
}
