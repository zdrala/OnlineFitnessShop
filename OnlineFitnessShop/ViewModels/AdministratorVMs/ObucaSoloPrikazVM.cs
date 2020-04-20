using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class ObucaSoloPrikazVM
    {
        public int ObucaID { get; set; }
        public int ProizvodID { get; set; }

        public string Naziv { get; set; }
        public float Cijena { get; set; }

        public string Spol { get; set; }

        public string Brend { get; set; }

        public string imageUrl { get; set; }
        public List<string> velicine { get; set; }
    }
}
