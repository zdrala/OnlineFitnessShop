using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class DodatakDodajVM
    {
        public int ProizvodID { get; set; }
        public int DodatakID { get; set; }


        [Required(ErrorMessage = "Naziv je obavezno polje!")]
        [StringLength(50, MinimumLength = 3,ErrorMessage = "Unesi minimalno 3 slova!")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z .]{1,}")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Unesi cijenu dodatka!")]
        [Range(1, float.MaxValue, ErrorMessage = "Uneci cijenu veću od 0!")]
        public float Cijena { get; set; }

        [Required]
        public int DobavljacID { get; set; }

        public DateTime datumDodavanja { get; set; }


        public List<SelectListItem> dobavljaci { get; set; }


        public IFormFile slika { get; set; }

        [Required(ErrorMessage = "Odaberi tip dodatka!")]
        public string TipDodatka { get; set; }
        

        public List<SelectListItem> tipDodatkaList { get; set; }


        [Required(ErrorMessage = "Unesi količinu na stanju dodatka!")]
        [Range(1, int.MaxValue, ErrorMessage = "Uneci cijenu veću od 0!")]
        public int Kolicina { get; set; }

        [Required(ErrorMessage = "Unesi namjenu dodatka!")]
        public string Namjena { get; set; }

        public string ImageUrl { get; set; }
    }
}
