using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.OData.Edm;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class DodajKupacVM
    {


        public int KorisnikID { get; set; } 
        public int KorisnikNalogID { get; set; }

        [Required(ErrorMessage = "Obavezno unesi ime kupca!")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]{1,}")]
        [MinLength(3,ErrorMessage = "Unesi minimalno 3 slova!")]
        
        public string Ime { get; set; }

        [Required(ErrorMessage = "Obavezno unesi prezime kupca!")]
        [RegularExpression(@"^[A-Ž]+[a-žA-Ž]{1,}")]
        [MinLength(4, ErrorMessage = "Unesi minimalno 4 slova!")]
        public string Prezime { get; set; }

        //[Required(ErrorMessage = "Datum rođenja je obavezno polje!")]
        //public Date DatumRodjenja { get; set; }

        public int DanRodjenja { get; set; }
        public List<SelectListItem> dani { get; set; }

        public int MjesecRodjenja { get; set; }
        public List<SelectListItem> mjeseci { get; set; }

        public int GodinaRodjenja { get; set; }
        public List<SelectListItem> godine { get; set; }

        [Required(ErrorMessage = "Email je obavezno polje!")]
        [StringLength(80,ErrorMessage = "Email je previše dug!")]
        [RegularExpression("([a-z0-9.]{1,60})@([a-z]{2,}).(com|ba)",ErrorMessage = "Format: nesto@nesto.com(ba)")]
        public string EmailAdresa { get; set; }

        [Required(ErrorMessage = "Unesi broj kupca!")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Broj telefona se sastoji od 16 znakova(uključujući ' ',-,+)")]
        [RegularExpression(@"^\+387 06[0-9]{1}-[0-9]{3}-[0-9]{3}", ErrorMessage = "+387 06X-XXX-XXX")]
        public string BrojTelefona { get; set; }

        [Required(ErrorMessage = "Unesi adresu!")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Unesi 5 slova minimalno i maksimalno 60!")]
        public string Adresa { get; set; }

        [Required]
        public int GradID { get; set; }

        public List<SelectListItem> gradovi { get; set; }

        [Required(ErrorMessage = "Obavezno unesi korisničko ime!")]
        public string KorisnickoIme { get; set; }

        [Required(ErrorMessage = "Obavezno unesi lozinku!")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z]{6,}$", ErrorMessage = "Minimalno 6 karaktera , 1 veliko slovo i 1 broj !")]
        public string Lozinka { get; set; }

       
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z]{6,}$", ErrorMessage = "Minimalno 6 karaktera , 1 veliko slovo i 1 broj !")]
        public string Lozinka1 { get; set; }

        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z]{6,}$", ErrorMessage = "Minimalno 6 karaktera , 1 veliko slovo i 1 broj !")]
        public string Lozinka2 { get; set; }

        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z]{6,}$", ErrorMessage = "Minimalno 6 karaktera , 1 veliko slovo i 1 broj !")]
        public string Lozinka3 { get; set; }

    }
}
