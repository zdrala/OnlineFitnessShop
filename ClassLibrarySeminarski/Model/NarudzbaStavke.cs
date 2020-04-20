using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrarySeminarski.Model
{
    public class NarudzbaStavke
    {
        [Key]
        public int NarudzbaStavkeID { get; set; }

        public Narudzba Narudzba { get; set; }
        [ForeignKey("NarudzbaID")]
        public int NarudzbaID { get; set; }

        public Proizvod Proizvod { get; set; }
        [ForeignKey("ProizvodID")]
        public int ProizvodID { get; set; }

        public int Kolicina { get; set; }
        public float CijenaStavke { get; set; }

        public string Velicina { get; set; }

        public string VrstaProizvoda { get; set; }
    }
}
