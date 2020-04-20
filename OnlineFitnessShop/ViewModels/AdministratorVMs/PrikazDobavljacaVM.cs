using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class PrikazDobavljacaVM
    {
        public List<Row> dobavljaci { get; set; }

        public class Row
        {
            public int ID { get; set; }
      
            public string Naziv { get; set; }
            public string BrojTelefona { get; set; }
            public string Email { get; set; }
            public string Grad { get; set; }
            public string Adresa { get; set; }

            public string DobavljacKategorija { get; set; }
          
        }
    }
}
