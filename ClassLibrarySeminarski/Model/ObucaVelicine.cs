using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrarySeminarski.Model
{
    public class ObucaVelicine
    {
        [Key]
        public int ObucaVelicinaID { get; set; }
        public Obuca Obuca { get; set; }
        [ForeignKey("ObucaID")]
        public int ObucaID { get; set; }
        public string Velicina { get; set; }
        public int kolicina { get; set; }
    }
}
