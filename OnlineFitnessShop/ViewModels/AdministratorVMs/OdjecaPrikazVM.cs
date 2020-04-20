
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class OdjecaPrikazVM
    {
        public List<Odjeca> podaciOdjece { get; set; }

        public class Odjeca
        {
            public int ProizvodID { get; set; }
            public string Naziv { get; set; }


            public float Cijena { get; set; }

            public string ImageUrl { get; set; }

            public int OdjecaID { get; set; }
            public string Spol { get; set; }

            public string Materijal { get; set; }

            public string Brend { get; set; }
            public string Opis { get; set; }
            public List<string> velicine { get; set; }
        }
    }
}
