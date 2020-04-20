using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.VisualBasic;

namespace OnlineFitnessShop.ViewModels
{
    public class DobavljacDodajVM
    {
        
        public int DobavljacID { get; set; }

        [Required]
        [StringLength(50,MinimumLength = 4)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z.]{1,}")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Unesi broj dobavljača!")]
        [StringLength(16,MinimumLength = 16,ErrorMessage = "Broj telefona se sastoji od 16 znakova(uključujući ' ',-,+")]
        [RegularExpression(@"^\+387 06[0-9]{1}-[0-9]{3}-[0-9]{3}",ErrorMessage = "+387 06X-XXX-XXX")]
        public string BrojTelefona { get; set; }

        [Required(ErrorMessage = "Email je obavezno polje!")]
        [StringLength(80,ErrorMessage = "Email je previše dug!")]
        [RegularExpression("([a-z0-9.]{1,60})@([a-z]{2,}).(com|ba)", ErrorMessage = "Format: nesto@nesto.com(ba)")]
        public string Email { get; set; }

        [Required]
        public int GradID { get; set; }


        public List<SelectListItem> gradovi;

        public List<SelectListItem> dobavljaciKategorije;

        [Required(ErrorMessage = "Unesi adresu!")]
        [StringLength(60,MinimumLength = 5,ErrorMessage = "Unesi 5 slova minimalno!")]
        public string Adresa { get; set; }


        [Required]
        public int DobavljacKategorijaID { get; set; }

    }

   
}
