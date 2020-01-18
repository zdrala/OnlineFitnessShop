using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrarySeminarski.Model;
using Microsoft.EntityFrameworkCore;
using OnlineFitnessShop.ViewModels;
using OnlineFitnessShop.Helpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineFitnessShop.ViewModels.Autentifikacija;

namespace OnlineFitnessShop.Controllers
{
    public class AutentifikacijaController : Controller
    {
        private MyDbContext _db;

        public AutentifikacijaController(MyDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registracija()
        {
            ViewData["Gradovi"] = _db.Gradovi.Select(g => new SelectListItem
            {
                Value = g.GradID.ToString(),
                Text = g.Naziv
            }).ToList();
            return View();
        }

        public IActionResult Snimi(ProfilVM a)
        {
            if (!ModelState.IsValid)
            {
                TempData["error_poruka"] = "Sva polja moraju biti popunjena!";
                ViewData["Gradovi"] = _db.Gradovi.Select(g => new SelectListItem
                {
                    Value = g.GradID.ToString(),
                    Text = g.Naziv
                }).ToList();
                return View("Registracija", a);
            }

            Korisnik korisnik = _db.Korisnik.SingleOrDefault(x => x.KorisnickiNalog.KorisnickoIme == a.Username);

            if (korisnik != null)
            {
                TempData["error_poruka"] = "Username je već zauzet!";
                ViewData["Gradovi"] = _db.Gradovi.Select(g => new SelectListItem
                {
                    Value = g.GradID.ToString(),
                    Text = g.Naziv
                }).ToList();
                return View("Registracija", a);
            }

            KorisnikNalog kn = new KorisnikNalog();

            kn.KorisnickoIme = a.Username;
            kn.Lozinka = a.Password;
            kn.VrstaKorisnika = _db.VrstaKorisnika.Find(2);
            kn.VrstaKorisnikaID = kn.VrstaKorisnika.VrstaKorisnikaID;
            _db.KorisnikNalog.Add(kn);
            _db.SaveChanges();

            Korisnik k = new Korisnik();
            k.Ime = a.Ime;
            k.Prezime = a.Prezime;
            k.DatumRodjenja = a.DatumRodjenja;
            k.EmailAdresa = a.Email;
            k.BrojTelefona = a.BrojTelefona;
            k.Adresa = a.Adresa;
            k.GradID = a.GradID;
            k.KorisnickiNalog = kn;
            k.KorisnikNalogID = kn.KorisnikNalogID;
            _db.Korisnik.Add(k);
            _db.SaveChanges();

            return Redirect("/Kupac/PorukaUspjesnosti");
        }

        public IActionResult Login(LoginVM input)
        {
            Korisnik korisnik = _db.Korisnik.Where(x => x.KorisnickiNalog.KorisnickoIme == input.username && x.KorisnickiNalog.Lozinka == input.password).Include(y => y.KorisnickiNalog).Include(z => z.Grad).SingleOrDefault();

            if(korisnik == null)
            {
                TempData["error_poruka"] = "Pogrešan username ili password";
                return View("Index",input);
            }

            Autenfikacija.SetLogiraniKorisnik(HttpContext, korisnik);

            if(korisnik.KorisnickiNalog.VrstaKorisnikaID==1)
            {
                return RedirectToAction("Index","Administrator");
            }
            else
            {
               return Redirect(url: "/");

            }

        }

        public ActionResult Poruka()
        {
            return View("");
        }

        public IActionResult LogOut()
        {
            Autenfikacija.SetLogiraniKorisnik(HttpContext,null);
            return Redirect(url: "/");
        }

    }
}
