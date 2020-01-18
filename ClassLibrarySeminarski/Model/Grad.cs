using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrarySeminarski.Model
{
   public class Grad
    {
        [Key]
        public int GradID { get; set; }

        public string Naziv { get; set; }
        public string PostanskiBroj { get; set; }

        public Kanton Kanton { get; set; }
        [ForeignKey("KantonID")]
        public int KantonID { get; set; }
    }
}
