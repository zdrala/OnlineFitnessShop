using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Kupac
{
    public class PasswordVM
    {
        [Required]
        public int ID { get; set; }
        public string StariPassword { get; set; }
        [Required]
        public string TempText1 { get; set; }
        public string TempText2 { get; set; }


    }
}
