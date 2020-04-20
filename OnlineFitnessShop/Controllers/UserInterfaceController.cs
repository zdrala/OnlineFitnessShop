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
using OnlineFitnessShop.Core.Interfaces;
using OnlineFitnessShop.ViewModels.Kupac;
using OnlineFitnessShop.Helpers;

namespace OnlineFitnessShop.Controllers
{
    public class UserInterfaceController : Controller
    {
        IUserInterfaceService userInterface;

        public UserInterfaceController(IUserInterfaceService _ds)
        {
            userInterface = _ds;
        }
        public ActionResult Home()
        {
            TempData["key"] = null;
            TempData["key2"] = null;
            TempData["key3"] = null;
            TempData["key4"] = null;

            return View();
        }

        public ActionResult Korpa()
        {
            return View();
        }

        public ActionResult ONama()
        {
            return View();
        }

        public ActionResult PorukaUspjesnosti()
        {
            return View("PorukaUspjesnosti");
        }

        public ActionResult NoPermission()
        {
            return View();
        }

        public ActionResult NarudzbaCompleted()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetKorpaItems(List<int> values,List <string> values2, List<int> values3, List<string> values4)
        {
            List<int> a = new List<int>();
            List<string> b = new List<string>();
            List<int> c = new List<int>();
            List<string> d = new List<string>();


            for (int i = 1; i < values.Count; i++)
            {
                a.Add(values[i]);
                b.Add(values2[i]);
                c.Add(values3[i]);
                d.Add(values4[i]);
            }

            TempData["key"] = a;
            TempData["key2"] = b;
            TempData["key3"] = c;
            TempData["key4"] = d;
            return Json(new { message = "Success" });
        }

        public ActionResult NarudjbaDetails()
        {
            Korisnik kor = Autenfikacija.GetLogiraniKorisnik(HttpContext);

            if (kor == null)
            {
                TempData["error_poruka"] = "Niste logirani";
                return View();
            }

            var ids = TempData["key"] as IEnumerable<int>;
            var kol = TempData["key3"] as IEnumerable<int>;

            if (ids == null && kol == null)
            {
                TempData["error_poruka"] = "Prvo potvrdite narudžbu u korpi !";
                return View();

            }
            

            NarudjbaInfoVM model = new NarudjbaInfoVM();

            var nz1 = ids.Zip(kol, (i, k) => new { id = i, kol = k });

            foreach (var item in nz1)
            {
                Proizvod a = userInterface.GetProizvodById(item.id);

                model.IznosBezPDV += a.Cijena * item.kol;
                model.IznosSaPDV += a.Cijena * item.kol;
            }
                
            TempData["key"] = ids;
            TempData["key3"] = kol;


            model.KorisnikID = kor.KorisnikID;
            model.Ime = kor.Ime;
            model.Prezime = kor.Prezime;
            model.Telefon = kor.BrojTelefona;
            model.GradID = kor.Grad.GradID;
            model.Adresa = kor.Adresa;

            model.gradovi = userInterface.GetAllGradove().Select(g => new SelectListItem
            {
                Value = g.GradID.ToString(),
                Text = g.Naziv
            }).ToList();

            model.kartice = userInterface.GetAktivneKarticeByKorisnikID(kor.KorisnikID).Select(g => new SelectListItem
            {
                Value = g.KarticaID.ToString(),
                Text = g.BrojKartice + " - " + "(" + g.NazivKartice + ")" 
            }).ToList();
            return View(model);
        }

        public ActionResult SpremiNarudjbu(NarudjbaInfoVM m)
        {
            #region
            var ids = TempData["key"] as IEnumerable<int>;
            var vrsta = TempData["key2"] as IEnumerable<string>;
            var kol = TempData["key3"] as IEnumerable<int>;
            var vel = TempData["key4"] as IEnumerable<string>;


            if(ids == null | vrsta == null | kol==null | vel==null)
            {
                return RedirectToAction("Korpa");
            }

            var nz1 = ids.Zip(kol, (i, k) => new { id = i, kol = k });
            var nz2 = vrsta.Zip(vel, (vrs, size) => new { vrsta = vrs, velicina = size });
            var podatci = nz1.Zip(nz2, (a, b) => new { Id = a.id, Kolicina = a.kol, Vrsta = b.vrsta, Velicina = b.velicina });

            TempVM model = new TempVM();
            model.stavke = new List<TempVM.ProizvodV>();

            foreach (var item in podatci)
            {
                Proizvod a = userInterface.GetProizvodById(item.Id);
                model.stavke.Add(new TempVM.ProizvodV
                {
                    ProizvodID = a.ProizvodID,
                    VrstaProizvoda = item.Vrsta,
                    TrazenaKolicina = item.Kolicina,
                    Velicina = item.Velicina,
                    Cijena = a.Cijena

                });
            }
            #endregion

            Narudzba nar = new Narudzba
            {
                KorisnikID=m.KorisnikID,
                DatumKreiranjaNarudjbe = DateTime.Now,
                GradID=m.GradID,
                Adresa=m.Adresa,
                IznosBezPDV=m.IznosBezPDV,
                StatusNarudzbeID=1,
                IznosSaPDV=m.IznosSaPDV,
                PotvrdaEmail=true,
                Izbrisano=false,
                Komentar="-"
            };
            if(m.KarticaID != 0)
            {
                nar.KarticaID = m.KarticaID;
            }
            else
            {
                nar.KarticaID = null;
            }
            userInterface.DodajNarudjbu(nar);

            foreach (var item in model.stavke)
            {
                Proizvod c = userInterface.GetProizvodById(item.ProizvodID);
                NarudzbaStavke ns = new NarudzbaStavke 
                {
                    NarudzbaID=nar.NarudzbaID,
                    ProizvodID=c.ProizvodID,
                    Kolicina=item.TrazenaKolicina,
                    CijenaStavke=c.Cijena,
                    Velicina=item.Velicina,
                    VrstaProizvoda=item.VrstaProizvoda
                };

                userInterface.DodajNarudjbaStavku(ns);
            }

            UserHelper.SendSMS(nar.DatumKreiranjaNarudjbe.ToString("g"));
            return View("NarudzbaCompleted");
        }
    }
}
