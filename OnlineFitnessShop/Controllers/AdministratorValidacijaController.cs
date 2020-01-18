using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Mvc;

namespace OnlineFitnessShop.Controllers
{
    public class AdministratorValidacijaController : Controller
    {
        private readonly MyDbContext db;

        public AdministratorValidacijaController(MyDbContext _db)
        {
            db = _db;
        }

        public bool provjeriGrad(int grad)
        {
            Grad g = db.Gradovi.Where(g => g.GradID == grad).SingleOrDefault();
            if (g != null)
                return true;
            return false;

        }
    }
}