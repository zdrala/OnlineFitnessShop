using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Autentifikacija
{
    public class ProfilVM
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Ime { get; set; }


        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Prezime { get; set; }

        [Required]
        public DateTime DatumRodjenja { get; set; }

        [Required]
        public string Spol { get; set; }

        [Required]
        [RegularExpression("([a-z0-9._-]{1,60})@([a-z]{2,}).(com|ba)")]
        public string Email {get;set;}

        [Required]
        [RegularExpression(@"^\+387 06[0-9]{1}-[0-9]{3}-[0-9]{3}")]
        public string BrojTelefona { get; set; }

        [Required]
        public int GradID { get; set; }

        [Required]
        public string Adresa { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string Username { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 6)]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z]{6,}$")]
        public string Password { get; set; }

        public IFormFile Slika { get; set; }

        public List<SelectListItem> gradovi { get; set; }
        public List<SelectListItem> spolovi { get; set; }
    }
}
