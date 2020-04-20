using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.WindowsRuntime;

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
    public class AdministratorNabavkaController : Controller
    {

        IProizvodiService proizvodiService;
        public AdministratorNabavkaController(IProizvodiService _proizvodiService)
        {
            proizvodiService = _proizvodiService;
        }

        public ActionResult ShowSuplementsOutOfStock()
        {
            SuplementacijaPrikazVM model = new SuplementacijaPrikazVM
            {
                podaciSuplement = proizvodiService.GetAllSuplemente().Where(s=>s.kolicina==0&&!s.Obrisan).Select(p => new SuplementacijaPrikazVM.Suplementacija
                {
                    ProizvodID = p.ProizvodID,
                    Naziv = p.Proizvod.Naziv,
                    Cijena = p.Proizvod.Cijena,
                    ImageUrl = p.Proizvod.ImageUrl,
                    SuplementacijaID = p.SuplementacijaID,
                    Brend = p.Brend,
                    kategorijaSuplementacije = p.Kategorija.SuplementacijaKategorijaNaziv,
                    Tezina = p.Tezina,
                    kolicina = p.kolicina

                }).ToList()
            };
            
            return View(model);
        }
        public ActionResult PrikazDobavljacaSuplemenata(int id)
        {
            Suplementacija s = proizvodiService.SuplementacijaFind(id);
            SuplementSoloPrikazVM model = new SuplementSoloPrikazVM
            {
                ImageUrl=s.Proizvod.ImageUrl,
                Naziv=s.Proizvod.Naziv,
                Cijena=s.Proizvod.Cijena,
                kategorijaSuplementacije=s.Kategorija.SuplementacijaKategorijaNaziv,
                Tezina=s.Tezina,
                SuplementacijaID=s.SuplementacijaID
            };
            return View(model);
        }
        public ActionResult UvecajKolicinuSuplementa(int id)
        {
            Suplementacija s = proizvodiService.SuplementacijaFind(id);
            SuplementSoloPrikazVM model = new SuplementSoloPrikazVM
            {
                ImageUrl = s.Proizvod.ImageUrl,
                Naziv = s.Proizvod.Naziv,
                Cijena = s.Proizvod.Cijena,
                kategorijaSuplementacije = s.Kategorija.SuplementacijaKategorijaNaziv,
                Tezina = s.Tezina,
                SuplementacijaID = s.SuplementacijaID
            };
            return View(model);
        }
        public ActionResult PrihvatiUnosKolicineNaStanju(int suplementacijaID,string kolicina)
        {
            Suplementacija s = proizvodiService.SuplementacijaFind(suplementacijaID);
            s.kolicina = Int32.Parse(kolicina);
            proizvodiService.SuplementacijaUpdate(s);

            return RedirectToAction("ShowSuplementsOutOfStock");
        }
        //---Clothes
        public ActionResult ShowClothesOutOfStock()
        {
            OdjecaPrikazVM model = new OdjecaPrikazVM
            {
                podaciOdjece = proizvodiService.GetAllOdjecu().Where(o => proizvodiService.OdjecaVelicineCountOutofStock(o.OdjecaID) > 0&&!o.Obrisan).Select(o => new OdjecaPrikazVM.Odjeca
                {
                    ProizvodID = o.ProizvodID,
                    Naziv = o.Proizvod.Naziv,
                    Cijena = o.Proizvod.Cijena,
                    ImageUrl = o.Proizvod.ImageUrl,
                    OdjecaID = o.OdjecaID,
                    Spol = o.Spol,
                    Brend = o.Brend,
                    Materijal = o.Materijal,
                    Opis = o.Opis,
                    velicine = proizvodiService.GetVelicineOdredjenjeOdjeceOutOfStock(o.OdjecaID).Select(v => v.Velicina).ToList()

                }).ToList()

            };
            return View(model);
        }
        public ActionResult PrikazDobavljacaOdjece(int OdjecaID)
        {
            Odjeca o = proizvodiService.OdjecaFind(OdjecaID);
            OdjecaSoloPrikazVM model = new OdjecaSoloPrikazVM
            {
                ProizvodID = o.ProizvodID,
                Naziv = o.Proizvod.Naziv,
                Cijena = o.Proizvod.Cijena,
                ImageUrl = o.Proizvod.ImageUrl,
                OdjecaID = o.OdjecaID,
                Spol = o.Spol,
                Brend = o.Brend,
                Materijal = o.Materijal,
                Opis = o.Opis,
                velicine = proizvodiService.GetVelicineOdredjenjeOdjeceOutOfStock(o.OdjecaID).Select(v => v.Velicina).ToList()
            };
            return View(model);
        }
        //--Obuca
        public ActionResult ShowFootWearsOutOfStock()
        {
            ObucaPrikazVM model = new ObucaPrikazVM
            {
                podaciObuca = proizvodiService.GetAllObucu().Where(o => proizvodiService.ObucaVelicineCountOutofStock(o.ObucaID)>0&&!o.Obrisan).Select(o => new ObucaPrikazVM.Obuca
                {
                    ObucaID = o.ObucaID,
                    ProizvodID = o.ProizvodID,
                    Naziv = o.Proizvod.Naziv,
                    Cijena = o.Proizvod.Cijena,
                    Spol = o.Spol,
                    Brend = o.Brend,
                    imageUrl = o.Proizvod.ImageUrl,
                    velicine=proizvodiService.GetVelicineOdredjenjeObuceOutOfStock(o.ObucaID).Select(v=>v.Velicina).ToList()
                   

                }).ToList()

            };
            return View(model);
        }
        public ActionResult PrikazDobavljacaObuce(int ObucaID)
        {
            Obuca o = proizvodiService.ObucaFind(ObucaID);
            ObucaSoloPrikazVM model = new ObucaSoloPrikazVM
            {
                ObucaID = o.ObucaID,
                ProizvodID = o.ProizvodID,
                Naziv = o.Proizvod.Naziv,
                Cijena = o.Proizvod.Cijena,
                Spol = o.Spol,
                Brend = o.Brend,
                imageUrl = o.Proizvod.ImageUrl,
                velicine = proizvodiService.GetVelicineOdredjenjeObuceOutOfStock(o.ObucaID).Select(v => v.Velicina).ToList()
            };
            return View(model);
        }

        //--Dodatci
        public ActionResult PrikazDodatakaOutofStock()
        {
            DodatakPrikazVM model = new DodatakPrikazVM
            {
                podaciDodatci = proizvodiService.GetAllDodatke().Where(d=>d.Kolicina==0&&!d.Obrisan).Select(d => new DodatakPrikazVM.Row
                {
                    ProizvodID = d.ProizvodID,
                    DodatakID = d.DodatakID,
                    Naziv = d.Proizvod.Naziv,
                    Cijena = d.Proizvod.Cijena,
                    TipDodatka = d.TipDodatka,
                    Kolicina = d.Kolicina,
                    ImageUrl = d.Proizvod.ImageUrl

                }).ToList()

            };
            return View(model);
        }
        public ActionResult PrikazDobavljacaDodataka(int id)
        {
            Dodatak d = proizvodiService.DodatakFind(id);
            DodatakSoloPrikazVM model = new DodatakSoloPrikazVM
            {
                ProizvodID = d.ProizvodID,
                DodatakID = d.DodatakID,
                Naziv = d.Proizvod.Naziv,
                Cijena = d.Proizvod.Cijena,
                TipDodatka = d.TipDodatka,
                Kolicina = d.Kolicina,
                ImageUrl = d.Proizvod.ImageUrl
            };
            return View(model);
        }
        public ActionResult UvecajKolicinuDodatka(int id)
        {
            Dodatak d = proizvodiService.DodatakFind(id);
            DodatakSoloPrikazVM model = new DodatakSoloPrikazVM
            {
                ProizvodID = d.ProizvodID,
                DodatakID = d.DodatakID,
                Naziv = d.Proizvod.Naziv,
                Cijena = d.Proizvod.Cijena,
                TipDodatka = d.TipDodatka,
                Kolicina = d.Kolicina,
                ImageUrl = d.Proizvod.ImageUrl
            };
            return View(model);
        }
        public ActionResult PrihvatiUnosKolicineDodatkaNaStanje(int dodatakID,string kolicina)
        {
            Dodatak d = proizvodiService.DodatakFind(dodatakID);
            d.Kolicina = Int32.Parse(kolicina);
            proizvodiService.DodatakUpdate(d);

            return RedirectToAction("PrikazDodatakaOutofStock");
        }
    }
}