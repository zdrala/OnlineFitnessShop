using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Autentifikacija
{
    public class KorisnikVM
    {

        public int ID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Ime { get; set; }


        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Prezime { get; set; }


        [Required]
        public DateTime DatumRodjenja { get; set; }

        [Required]
        public string Email {get;set;}

        [Required]
        public string BrojTelefona { get; set; }

        [Required]
        public int GradID { get; set; }

        [Required]
        public string Adresa { get; set; }

    }
}
