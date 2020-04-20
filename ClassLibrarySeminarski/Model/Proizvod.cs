using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrarySeminarski.Model
{
   public class Proizvod
    {
       [Key]
        public int ProizvodID { get; set; }
        public string Naziv { get; set; }


        public float Cijena { get; set; }
        
        public Dobavljac Dobavljac { get; set; }
        [ForeignKey("DobavljacID")]
        public int DobavljacID { get; set; }

        public DateTime datumDodavanja { get; set; }

      public string ImageUrl { get; set; }

        public bool Obrisan { get; set; }
    }
}
