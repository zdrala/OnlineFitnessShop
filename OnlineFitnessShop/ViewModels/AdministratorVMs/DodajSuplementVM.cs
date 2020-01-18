using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class DodajSuplementVM
    {

        public int ProizvodID { get; set; }
        public int SuplementacijaID { get; set; }


        [Required]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z .]{1,}")]
        public string Naziv { get; set; }

        [Required]
        [Range(1,float.MaxValue,ErrorMessage = "Uneci cijenu veću od 0!")]
        public float Cijena { get; set; }

        [Required]
        public int DobavljacID { get; set; }

        public DateTime datumDodavanja { get; set; }


        public List<SelectListItem> dobavljaci { get; set; }


        public IFormFile slika { get; set; }

        [Required]
        public int KategorijaID { get; set; }

        public List<SelectListItem> KategorijeSuplementacija { get; set; }

        [Required]
        [MinLength(3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z .]{1,}")]
        public string Brend { get; set; }



        [Required]
        [Range(1,50,ErrorMessage = "Unes težinu veću od 0!")]
        public float Tezina { get; set; }

        [Required]
        [MinLength(10,ErrorMessage = "Moras unijeti minimalno 10 slova!")]
        public string Uputstvo { get; set; }
        public DateTime RokTrajanja { get; set; }

        [Required]
        [Range(1,int.MaxValue,ErrorMessage = "Minimalna kolicina na stanju je 1")]
        public int kolicina { get; set; }

        public string imageUrl { get; set; }
    }
}
