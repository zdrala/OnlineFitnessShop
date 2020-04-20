using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class DodajVelicinuObuceVM
    {
        public int ObucaVelicinaID { get; set; }
        public int ObucaID { get; set; }

        [Required(ErrorMessage = "Unesi veličinu!")]
        [Range(35,47,ErrorMessage = "Moguće samo brojeve unositi u rangu od 35 do 47!")]
        public string Velicina { get; set; }

        [Required(ErrorMessage = "Količina je obavezna!")]
        [Range(1, int.MaxValue, ErrorMessage = "Količina na stanju mora biti veća od 0!")]
        public int kolicina { get; set; }
        public string imageUrl { get; set; }
    }
}
