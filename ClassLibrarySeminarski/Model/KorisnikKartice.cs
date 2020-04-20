using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrarySeminarski.Model
{
    public class KorisnikKartice
    {
        [Key]
        public int KarticaID { get; set; }
        public Korisnik Korisnik { get; set; }
        [ForeignKey("KorisnikID")]
        public int KorisnikID { get; set; }
        public string NazivKartice { get; set; }
        public string BrojKartice { get; set; }
        //public DateTime DatumIsteka { get; set; }
        public int Code { get; set; }
        public string MjesecIsteka { get; set; }
        public string GodinaIsteka { get; set; }
        public bool Aktivna { get; set; }
    }
}
