using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class ObucaVelicinePrikazVM
    {
        public int ObucaID { get; set; }
        public string imageUrl { get; set; }

        public List<Row> velicine { get; set; }

        public class Row
        {
            public string Velicina { get; set; }
            public int kolicina { get; set; }
            public int VelicinaID { get; set; }
        }

    }
}
