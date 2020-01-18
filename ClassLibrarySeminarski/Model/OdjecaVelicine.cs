using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrarySeminarski.Model
{
    public class OdjecaVelicine
    {
        [Key]
        public int OdjecaVelicinaID { get; set; }
        public Odjeca Odjeca { get; set; }
        [ForeignKey("OdjecaID")]
        public int OdjecaID { get; set; }
        public string Velicina { get; set; }
        public int kolicina { get; set; }
    }
}
