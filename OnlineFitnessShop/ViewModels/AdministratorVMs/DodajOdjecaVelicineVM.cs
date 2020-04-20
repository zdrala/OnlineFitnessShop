using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class DodajOdjecaVelicineVM
    {
        public int OdjecaVelicinaID { get; set; }
        public int OdjecaID { get; set; }

        [Required(ErrorMessage = "Unesi veličinu!")]
        [MinLength(1,ErrorMessage = "Unesi minimalno 1 slovo!")]
        [MaxLength(4,ErrorMessage = "Unesi maksimalno 4 slova!")]
        public string Velicina { get; set; }

        [Required(ErrorMessage = "Količina je obavezna!")]
        [Range(1,int.MaxValue,ErrorMessage = "Količina na stanju mora biti veća od 0!")]
        public int kolicina { get; set; }
    public string imageUrl { get; set; }
        public List<SelectListItem> velicine { get; set; }
    }
}
