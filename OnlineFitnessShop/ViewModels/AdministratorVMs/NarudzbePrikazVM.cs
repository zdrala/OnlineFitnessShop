using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class NarudzbePrikazVM
    {
        public List<NarudzbaVM> narudzbeList { get; set; }

        public class NarudzbaVM
        {
            public int NarudzbaID { get;set;}
            public string ImePrezimeKupca { get; set; }
            public DateTime DatumNarucivanja { get;set; }
            public string Grad_Adresa { get; set; }
            public string StatusNarudzbe { get; set; }
            public float IznosNarudzbe { get; set; }

        }
    }
}
