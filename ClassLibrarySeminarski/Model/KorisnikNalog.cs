using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrarySeminarski.Model
{
    public class KorisnikNalog
    {
        [Key]
        public int KorisnikNalogID { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public VrstaKorisnika VrstaKorisnika { get; set; }
        [ForeignKey("VrstaKorisnikaID")]
        public int VrstaKorisnikaID { get; set; }
        public bool Obrisan { get; set; }
    }
}
