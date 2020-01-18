using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrarySeminarski.Model
{
    public class Transakcije
    {
        [Key]
        public int TransakcijaID { get; set; }

        public Narudzba Narudzba { get; set; }
        [ForeignKey("NarudzbaID")]
        public int NarudzbaID { get; set; }

        public Korisnik Korisnik { get; set; }        //admin koji je potvrdio narudzbu
        [ForeignKey("KorisnikID")]
        public int KorisnikID { get; set; }
        public DateTime DatumTransakcije { get; set; }
        public float NaplaceniIznos { get; set; }
        public float NaplaceniIznosSaPDV { get; set; }
    }
}
