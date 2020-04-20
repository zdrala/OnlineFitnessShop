using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrarySeminarski.Model
{
    public class Dodatak
    {
        [Key]
        public int DodatakID { get; set; }

        public Proizvod Proizvod { get; set; }
        [ForeignKey("ProizvodID")]
        public int ProizvodID { get; set; }

        public string TipDodatka { get; set; }
        public int Kolicina { get; set; }
        public string Namjena { get; set; }


        public bool Obrisan { get; set; }

    }
}
