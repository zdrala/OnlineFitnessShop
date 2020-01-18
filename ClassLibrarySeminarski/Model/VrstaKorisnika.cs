using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrarySeminarski.Model
{
    public class VrstaKorisnika
    {
        [Key]
        public int VrstaKorisnikaID { get; set; }
        public string VrstaNaziv { get; set; }
    }
}
