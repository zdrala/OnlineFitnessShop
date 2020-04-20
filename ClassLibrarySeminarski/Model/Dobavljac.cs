using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrarySeminarski.Model
{
    public class Dobavljac
    {
        [Key]
        public int DobavljacID { get; set; }
        public string Naziv { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public Grad Grad { get; set; }
        public int GradID { get; set; }
        public string Adresa { get; set; }

        public DobavljacKategorije DobavljacKategorija { get; set; }
        [ForeignKey("DobavljacKategorijaID")]
        public int DobavljacKategorijaID { get; set; }

        public bool Obrisan { get; set; }
    }
}
