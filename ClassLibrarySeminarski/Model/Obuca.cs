using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrarySeminarski.Model
{
    public class Obuca
    {
        [Key]
        public int ObucaID { get; set; }

        public Proizvod Proizvod { get; set; }
        [ForeignKey("ProizvodID")]
        public int ProizvodID { get; set; }
        public string Spol { get; set; }
        public string Brend { get; set; }
        public string Namjena { get; set; }
        public string Opis { get; set; }

        public bool Obrisan { get; set; }

    }
}
