using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrarySeminarski.Model
{
    public class KomentarProizvod
    {
        [Key]
        public int KomentarID { get; set; }

        public Proizvod Proizvod { get; set; }
        [ForeignKey("ProizvodID")]
        public int ProizvodID { get; set; }

        public Korisnik Korisnik { get; set; }
        [ForeignKey("KorisnikID")]
        public int KorisnikID { get; set; }

        public string Tekst   { get; set; }

        public DateTime DatumKomentarisanja { get; set; }
    }
}
