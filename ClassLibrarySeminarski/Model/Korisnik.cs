using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrarySeminarski.Model
{
    public class Korisnik
    {
        [Key]
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string EmailAdresa { get; set; }
        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }
        public int GradID { get; set; }
        [ForeignKey("GradID")]
        public Grad Grad { get; set; }
        public int? KorisnikNalogID { get; set; }
        [ForeignKey("KorisnikNalogID")]
        public KorisnikNalog KorisnickiNalog { get; set; }

        public string Spol { get; set; }
        public bool Obrisan { get; set; }

        public string imageUrl { get; set; }

        public bool Aktiviran { get; set; }
    }
}
