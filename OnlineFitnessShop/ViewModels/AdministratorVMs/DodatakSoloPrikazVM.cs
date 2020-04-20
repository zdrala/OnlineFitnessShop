using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class DodatakSoloPrikazVM
    {
        public int ProizvodID { get; set; }
        public int DodatakID { get; set; }

        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public string TipDodatka { get; set; }
        public int Kolicina { get; set; }
        public string ImageUrl { get; set; }
    }
}
