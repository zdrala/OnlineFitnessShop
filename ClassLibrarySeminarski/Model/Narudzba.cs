using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrarySeminarski.Model
{
    public class Narudzba
    {
        [Key]
        public int NarudzbaID { get; set; }

        public Korisnik Korisnik { get; set; }
        [ForeignKey("KorisnikID")]
        public int KorisnikID { get; set; }

        public DateTime DatumKreiranjaNarudjbe { get; set; }

        public Grad Grad { get; set; }
        [ForeignKey("GradID")]
        public int GradID { get; set; }

        public string Adresa { get; set; }

        public StatusNarudzbe StatusNarudzbe { get; set; }
        [ForeignKey("StatusNarudzbeID")]
        public int StatusNarudzbeID { get; set; }

        public float IznosBezPDV { get; set; }
        //public float IznosPDV { get; set; }
        public float IznosSaPDV { get; set; }

        public KorisnikKartice Kartica { get; set; }
        [ForeignKey("KarticaID")]
        public int? KarticaID { get; set; }

        public bool PotvrdaEmail { get; set; }

        public bool Izbrisano { get; set; }

        public string Komentar { get; set; }
    }
}
