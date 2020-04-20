using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class ShowAcceptedDeclinedOrdersVM
    {
        public List<Row> narudzbeList { get; set; }

        public string imePrezime { get; set; }
        public class Row
        {
            public int NarudzbaID { get; set; }
            public int KorisnikID { get; set; }
            public string ImePrezimeKupca { get; set; }
            public DateTime DatumNarucivanja { get; set; }

            public float IznosNarudzbe { get; set; }
            public string StatusNarudzbe { get; set; }
        }
    }
}
