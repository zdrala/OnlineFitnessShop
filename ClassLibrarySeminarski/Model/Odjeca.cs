using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrarySeminarski.Model
{
    public class Odjeca
    {
        [Key]
        public int OdjecaID { get; set; }
        public Proizvod Proizvod { get; set; }
        [ForeignKey("ProizvodID")]
        public int ProizvodID { get; set; }
        public string Spol { get; set; }

        public string Materijal { get; set; }

        public string Brend { get; set; }
        public string Opis { get; set; }

        public bool Obrisan { get; set; }
    }
}
