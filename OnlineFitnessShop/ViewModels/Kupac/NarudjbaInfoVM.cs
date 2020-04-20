using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Kupac
{
    public class NarudjbaInfoVM
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public int GradID { get; set; }
        public int KarticaID { get; set; }
        public string Adresa { get; set; }
        public float IznosBezPDV { get; set; }
        public float IznosSaPDV { get; set; }

        public List<SelectListItem> gradovi { get; set; }
        public List<SelectListItem> kartice { get; set; }

    }
}
