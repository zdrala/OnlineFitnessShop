using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Kupac
{
    public class PodaciVM
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Text { get; set; }
        public string Text2 { get; set; }


    }
}
