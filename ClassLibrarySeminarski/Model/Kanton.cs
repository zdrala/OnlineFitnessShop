using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrarySeminarski.Model
{
    public class Kanton
    {
        [Key]
        public int KantonID { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
    }
}
