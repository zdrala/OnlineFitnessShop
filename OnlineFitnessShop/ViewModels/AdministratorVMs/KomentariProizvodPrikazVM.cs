using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class KomentariProizvodPrikazVM
    {
        public int proizvodID { get; set; }
        public string imageUrl { get; set; }
        public string nazivProizvoda { get; set; }
        public List<Row> komentariProizvod { get; set; }
        public class Row
        {
            public int KomentarID { get; set; }
            public string imePrezimeKorisnika { get; set; }
            public string textKomentara { get; set; }
        };
    }
}
