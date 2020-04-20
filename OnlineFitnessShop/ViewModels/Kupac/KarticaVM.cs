using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Kupac
{
    public class KarticaVM
    {
        public int KorisnikID { get; set; }

        [Required]
        public string NazivKartice { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{4}$")]
        public string BrojKartice { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{3,4}$")]
        public int Code { get; set; }

        [Required]
        public string MjesecIsteka { get; set; }

        [Required]
        public string GodinaIsteka { get; set; }

        public List<SelectListItem> mjeseci { get; set; }
        public List<SelectListItem> godine { get; set; }
        public List<SelectListItem> vrste { get; set; }



    }
}
