using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrarySeminarski.Model
{
    public class DobavljacKategorije
    {
        [Key]
        public int DobavljacKategorijaID { get; set; }

        public string nazivKategorije { get; set; }
    }
}
