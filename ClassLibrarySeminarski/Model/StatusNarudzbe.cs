using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrarySeminarski.Model
{
    public class StatusNarudzbe
    {
        [Key]
        public int StatusNarudzbeID { get; set; }
        public string OpisStanja { get; set; }
    }
}
