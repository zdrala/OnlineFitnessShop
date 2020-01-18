using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class KupacPrikazVM
    {
        public List<Row> podaciKupci { get; set; }

        public class Row
        {
            public int KorisnikID { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public DateTime DatumRodjenja { get; set; }
            public string EmailAdresa { get; set; }
            public string BrojTelefona { get; set; }
            public string Adresa { get; set; }
            public int GradID { get; set; }
        }
    }
}
