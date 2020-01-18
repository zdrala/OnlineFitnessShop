using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OnlineFitnessShop.ViewModels
{
    public class DodajProizvodVM
    {

        public int ProizvodID { get; set; }
        public string Naziv { get; set; }


        public float Cijena { get; set; }

        public int DobavljacID { get; set; }

        public DateTime datumDodavanja { get; set; }


        public List<SelectListItem> dobavljaci { get; set; }

        public IFormFile slika { get; set; }
    }
}
