using ClassLibrarySeminarski.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Kupac
{
    public class KarticeViewVM
    {
        public List<Row> podaciKartice { get; set; }

        public class Row
        {
            public int KarticaID { get; set; }
            public int KorisnikID { get; set; }
            public string NazivKartice { get; set; }
            public string BrojKartice { get; set; }
            public int Code { get; set; }
            public string MjesecIsteka { get; set; }
            public string GodinaIsteka { get; set; }
            public bool Aktivna { get; set; }
        }
    }
}
