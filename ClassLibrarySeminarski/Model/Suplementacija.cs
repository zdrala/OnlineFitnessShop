using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrarySeminarski.Model
{
   public class Suplementacija
    {
        [Key]
        public int SuplementacijaID { get; set; }
        public Proizvod Proizvod { get; set; }
        [ForeignKey("ProizvodID")]
        public int ProizvodID { get; set; }

        public SuplementacijaKategorije Kategorija { get; set; }
        [ForeignKey("KategorijaID")]
        public int KategorijaID { get; set; }
        public string Brend { get; set; }
        public float Tezina { get; set; }
        public string Uputstvo { get; set; }
        public DateTime RokTrajanja { get; set; }

        public int kolicina { get; set; }

        public bool Obrisan { get; set; }
    }
}
