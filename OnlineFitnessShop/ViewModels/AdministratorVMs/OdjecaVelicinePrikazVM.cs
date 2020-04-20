using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class OdjecaVelicinePrikazVM
    {
        public int OdjecaID { get; set; }
        public string imageUrl { get; set; }


        public List<Row> velicine { get; set; }

        public class Row
        {
            public int VelicinaID { get; set; }
            public string Velicina { get; set; }
            public int kolicina { get; set; }
        }
    }
}
