﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Kupac
{
    public class ObucaPrikazVM
    {
        
            public int ObucaID { get; set; }
            public int ProizvodID { get; set; }
            public string Naziv { get; set; }
            public float Cijena { get; set; }
            public string Spol { get; set; }
            public string ImageUrl { get; set; }

            public List<Vel> velicine { get; set; }

            public class Vel
            {
                public string Velicina { get; set; }
                public int kolicina { get; set; }
            }
        
    }
}
