using ClassLibrarySeminarski.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Kupac
{
    public class NarudzbaVM
    {

        public List<NarudzbaV> stavke;
        public class NarudzbaV
        {
            public int NarudzbaID { get; set; }
            public string VrijemeNarudzbe { get; set; }
            public int StatusNarudzbe { get; set; }
            public float Ukupno { get; set; }
            public string Komentar { get; set; }

        }
        public int UkupnoNarudzbi { get; set; }
        public int TrenutniPage { get; set; }
    }
}
