using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrarySeminarski.Model
{
    public class SuplementacijaKategorije
    {
        [Key]
        public int SuplementacijaKategorijaID { get; set; }
        public string SuplementacijaKategorijaNaziv { get; set; }
    }
}
