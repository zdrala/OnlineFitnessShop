using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class DodajObucuVM
    {
        public int ProizvodID { get; set; }
        public int ObucaID { get; set; }

        [Required(ErrorMessage = "Naziv je obavezno polje!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Minimalno unesi 3 slova!")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z. ]{1,}", ErrorMessage = "Prvo slovo mora biti veliko!")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Cijena obuće je obavezna!")]
        [Range(1, float.MaxValue, ErrorMessage = "Uneci cijenu veću od 0!")]
        public float Cijena { get; set; }

        [Required]
        public int DobavljacID { get; set; }

        public DateTime datumDodavanja { get; set; }


        public List<SelectListItem> dobavljaci { get; set; }

        public IFormFile slika { get; set; }

        [Required]
        public string Spol { get; set; }
        public List<SelectListItem> spol { get; set; }

        [Required(ErrorMessage = "Unesi brend!")]
        [MinLength(3, ErrorMessage = "Minimalno unesi 3 slova!")]
        public string Brend { get; set; }

        [Required(ErrorMessage = "Unesi namjenu")]
        public string Namjena { get; set; }

        [Required(ErrorMessage = "Unesi opis!")]
        public string Opis { get; set; }

        public string imageUrl { get; set; }
    }
}
