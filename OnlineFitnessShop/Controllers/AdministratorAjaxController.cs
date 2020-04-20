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
    public class AdministratorAjaxController:Controller
    {
        IOrdersService narudzbeService;
        IDobavljaciService dobavljacService;
        public AdministratorAjaxController(IOrdersService _ns,IDobavljaciService _ds)
        {
            narudzbeService = _ns;
            dobavljacService = _ds;
        }
        public ActionResult Index(int NarudzbaID)
        {
            NarudzbaStavkePrikazVM model = new NarudzbaStavkePrikazVM
            {
                stavkeList = narudzbeService.GetAllNarudzbaStavke(NarudzbaID).Select(n => new NarudzbaStavkePrikazVM.Stavka
                {
                    imageUrl=n.Proizvod.ImageUrl,
                    NazivProizvoda=n.Proizvod.Naziv,
                    Velicina=n.Velicina,
                    Kolicina=Convert.ToString(n.Kolicina)
                }).ToList()
            };
            return PartialView(model);
        }
        public ActionResult GetDobavljaceSuplemenata()
        {
            PrikazDobavljacaVM model = new PrikazDobavljacaVM
            {
                dobavljaci = dobavljacService.GetAllDobavljace().Where(d=>d.DobavljacKategorijaID==1&&!d.Obrisan).Select(d => new PrikazDobavljacaVM.Row
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

            return PartialView(model);
        }
        public ActionResult GetDobavljaceOdjece()
        {
            PrikazDobavljacaVM model = new PrikazDobavljacaVM
            {
                dobavljaci = dobavljacService.GetAllDobavljace().Where(d => d.DobavljacKategorijaID == 2 && !d.Obrisan).Select(d => new PrikazDobavljacaVM.Row
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

            return PartialView(model);
        }
        public ActionResult GetDobavljaceObuce()
        {
            PrikazDobavljacaVM model = new PrikazDobavljacaVM
            {
                dobavljaci = dobavljacService.GetAllDobavljace().Where(d => d.DobavljacKategorijaID == 3 && !d.Obrisan).Select(d => new PrikazDobavljacaVM.Row
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
            return PartialView(model);
        }
        public ActionResult GetDobavljaceDodataka()
        {
            PrikazDobavljacaVM model = new PrikazDobavljacaVM
            {
                dobavljaci = dobavljacService.GetAllDobavljace().Where(d => d.DobavljacKategorijaID == 4 && !d.Obrisan).Select(d => new PrikazDobavljacaVM.Row
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
            return PartialView(model);
        }
    }
}
