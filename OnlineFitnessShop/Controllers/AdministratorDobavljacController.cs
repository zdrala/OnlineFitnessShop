using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using OnlineFitnessShop.helpers;
using OnlineFitnessShop.ViewModels;
using OnlineFitnessShop.ViewModels.AdministratorVMs;
using OnlineFitnessShop.Core.Interfaces;
using OnlineFitnessShop.Helpers;

namespace OnlineFitnessShop.Controllers
{
    [Autorizacija(admin: true, user: false)]
    public class AdministratorDobavljacController : Controller
    {
        IDobavljaciService dobavljacService;

        public AdministratorDobavljacController(IDobavljaciService _dobavljacService)
        {
            dobavljacService = _dobavljacService;
        }

        #region Dobavljaci
        public IActionResult PrikazDobavljaca()
        {
            PrikazDobavljacaVM model = new PrikazDobavljacaVM
            {
                dobavljaci = dobavljacService.GetAllDobavljace().Where(d=>!d.Obrisan).Select(d => new PrikazDobavljacaVM.Row
                {
                    ID = d.DobavljacID,
                    Naziv = d.Naziv,
                    BrojTelefona = d.BrojTelefona,
                    Email = d.Email,
                    Grad = d.Grad.Naziv,
                    Adresa = d.Adresa,
                    DobavljacKategorija = d.DobavljacKategorija.nazivKategorije

                }).ToList()


            };
            return View(model);
        }
        public ActionResult DodajDobavljaca()
        {

            /* List<Grad> gradovi = db.Gradovi.Include(g => g.Kanton).ToList();
             List<DobavljacKategorije> dobavljaciKategorije = db.DobavljacKategorije.ToList();
             */

            DobavljacDodajVM Model = new DobavljacDodajVM
            {
                gradovi = dobavljacService.GetAllGradove(),
                dobavljaciKategorije = dobavljacService.GetAllDobavljaciKategorije()

            };

            return View(Model);
        }


        public ActionResult Spremi(DobavljacDodajVM x)
        {

            if (!ModelState.IsValid)
            {

                x.gradovi = dobavljacService.GetAllGradove();
                x.dobavljaciKategorije = dobavljacService.GetAllDobavljaciKategorije();

                return View("DodajDobavljaca", x);
            }


            Dobavljac d = new Dobavljac
            {
                Naziv = x.Naziv,
                BrojTelefona = x.BrojTelefona,
                Email = x.Email,
                GradID = x.GradID,
                Adresa = x.Adresa,
                DobavljacKategorijaID = x.DobavljacKategorijaID
            };

            dobavljacService.DodajDobavljaca(d);

            return Redirect("/AdministratorDobavljac/PrikazDobavljaca");
        }
        public ActionResult UrediDobavljaca(int dobavljacid)
        {
            Dobavljac d = dobavljacService.DobavljacFind(dobavljacid);

            if (d == null)
            {
                return Redirect("/Administrator/Index");
            }
            DobavljacDodajVM Model = new DobavljacDodajVM
            {
                DobavljacID = d.DobavljacID,
                Naziv = d.Naziv,
                BrojTelefona = d.BrojTelefona,
                Email = d.Email,
                GradID = d.GradID,
                Adresa = d.Adresa,
                DobavljacKategorijaID = d.DobavljacKategorijaID,
                gradovi = dobavljacService.GetAllGradove(),
                dobavljaciKategorije = dobavljacService.GetAllDobavljaciKategorije()
            };

            return View(Model);
        }
        public ActionResult SpremiEdit(DobavljacDodajVM x)
        {
            if (!ModelState.IsValid)
            {

                x.gradovi = dobavljacService.GetAllGradove();
                x.dobavljaciKategorije = dobavljacService.GetAllDobavljaciKategorije();

                return View("UrediDobavljaca", x);
            }
            Dobavljac d = dobavljacService.DobavljacFind(x.DobavljacID);
            d.Naziv = x.Naziv;
            d.BrojTelefona = x.BrojTelefona;
            d.Email = x.Email;
            d.GradID = x.GradID;
            d.Adresa = x.Adresa;
            d.DobavljacKategorijaID = x.DobavljacKategorijaID;

            dobavljacService.DobavljacUpdate(d);

            return Redirect("/AdministratorDobavljac/PrikazDobavljaca");
        }
        public ActionResult ObrisiDobavljaca(int dobavljacid)
        {

            Dobavljac dob = dobavljacService.DobavljacFind(dobavljacid);
            dob.Obrisan = true;
            dobavljacService.DobavljacUpdate(dob);

            return Redirect("/AdministratorDobavljac/PrikazDobavljaca");
        }



        #endregion
    }
}
