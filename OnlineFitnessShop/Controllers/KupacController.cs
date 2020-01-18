using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrarySeminarski.Model;
using Microsoft.EntityFrameworkCore;
using OnlineFitnessShop.ViewModels.Kupac;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineFitnessShop.Helpers;
using OnlineFitnessShop.ViewModels.Kupac;

namespace OnlineFitnessShop.Controllers
{
    public class KupacController : Controller
    {
        private readonly MyDbContext db;

        public KupacController(MyDbContext context)
        {
            db = context;
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Korpa()
        {
            return View();
        }

        public ActionResult Info()
        {
            return View();
        }

        public ActionResult DodajForma()
        {
          
            List<Grad> gradovi = db.Gradovi.Include(g => g.Kanton).ToList();

            ViewData["Gradovi"] = gradovi;
            return View("DodajForma");
        }

        public ActionResult Update()
        {


            Korisnik kor = Autenfikacija.GetLogiraniKorisnik(HttpContext);

            KorisnikVM novi = new KorisnikVM();
            novi.ID = kor.KorisnikID;
            novi.Ime = kor.Ime;
            novi.Prezime = kor.Prezime;
            novi.Email = kor.EmailAdresa;
            novi.DatumRodjenja = kor.DatumRodjenja;
            novi.BrojTelefona = kor.BrojTelefona;
            novi.GradID = kor.GradID;
            novi.Adresa = kor.Adresa;

            TempData["Korisnik"] = novi;

            ViewData["Gradovi"] = db.Gradovi.Select(g => new SelectListItem
            {
                Value = g.GradID.ToString(),
                Text = g.Naziv
            }).ToList();
            return View();
        }

        public ActionResult Snimi(KorisnikVM x)
        {
            
            if (!ModelState.IsValid)
            {
                ViewData["Gradovi"] = db.Gradovi.Select(g => new SelectListItem
                {
                    Value = g.GradID.ToString(),
                    Text = g.Naziv
                }).ToList();
                TempData["poruka"] = "Sva polja moraju biti popunjena!";
                TempData["Korisnik"] = x;
                return View("Update");
            }

            Korisnik k = db.Korisnik.Find(x.ID);

            if(k.Ime == x.Ime && k.Prezime == x.Prezime && k.DatumRodjenja == x.DatumRodjenja && k.EmailAdresa ==x.Email && k.BrojTelefona == x.BrojTelefona && k.Adresa==x.Adresa && k.GradID==x.GradID)
            {
                ViewData["Gradovi"] = db.Gradovi.Select(g => new SelectListItem
                {
                    Value = g.GradID.ToString(),
                    Text = g.Naziv
                }).ToList();
                TempData["poruka"] = "Niste napravili nikakvu izmjenu!";
                TempData["Korisnik"] = x;
                return View("Update");

            }
            else {
                k.Ime = x.Ime;
                k.Prezime = x.Prezime;
                k.DatumRodjenja = x.DatumRodjenja;
                k.EmailAdresa = x.Email;
                k.BrojTelefona = x.BrojTelefona;
                k.Adresa = x.Adresa;
                k.GradID = x.GradID;
                db.SaveChanges();
            }

            Korisnik korisnik = db.Korisnik.Where(b => b.KorisnikID == k.KorisnikID).Include(y => y.KorisnickiNalog).Include(z => z.Grad).SingleOrDefault();
            Autenfikacija.SetLogiraniKorisnik(HttpContext, korisnik);
            TempData["poruka2"] = "Podaci su usješno izmijenjeni!";
            ViewData["Gradovi"] = db.Gradovi.Select(g => new SelectListItem
            {
                Value = g.GradID.ToString(),
                Text = g.Naziv
            }).ToList();
            TempData["Korisnik"] = x;
            return View("Update");
        }

        public ActionResult UpdateUsername()
        {
            Korisnik kor = Autenfikacija.GetLogiraniKorisnik(HttpContext);

            PodaciVM novi = new PodaciVM();
            novi.ID = kor.KorisnikID;
            novi.Text = kor.KorisnickiNalog.KorisnickoIme;

            TempData["Korisnik"] = novi;
            return View();
        }

        public ActionResult SnimiUsername(PodaciVM a)
        {
            Korisnik korisnik = db.Korisnik.SingleOrDefault(x => x.KorisnickiNalog.KorisnickoIme == a.Text);

            if (korisnik != null)
            {
                TempData["poruka"] = "Username već postoji!";
                a.Text2 = a.Text;
                TempData["Korisnik"] = a;
                return View("UpdateUsername");
            }
            else
            {

                Korisnik k = db.Korisnik.Where(b => b.KorisnikID == a.ID).Include(y => y.KorisnickiNalog).Include(z => z.Grad).SingleOrDefault();

                k.KorisnickiNalog.KorisnickoIme = a.Text;
                db.SaveChanges();

                Autenfikacija.SetLogiraniKorisnik(HttpContext, k);
                TempData["poruka2"] = "Podaci su usješno izmijenjeni!";
                a.Text2 = null;
                TempData["Korisnik"] = a;
                return View("UpdateUsername");
            }

        }

        public ActionResult UpdatePassword()
        {
            Korisnik kor = Autenfikacija.GetLogiraniKorisnik(HttpContext);

            PasswordVM novi = new PasswordVM();
            novi.ID = kor.KorisnikID;
            novi.StariPassword = null;
            novi.TempText1 = null;
            novi.TempText2 = null;

            TempData["Korisnik"] = novi;
            return View();
        }

        public ActionResult SnimiPassword(PasswordVM a)
        {
            Korisnik k = db.Korisnik.Where(b => b.KorisnikID == a.ID).Include(y => y.KorisnickiNalog).Include(z => z.Grad).SingleOrDefault();

            
            if (k.KorisnickiNalog.Lozinka != a.StariPassword)
            {
                TempData["poruka"] = "Ispravno unesite trenutni password";
                TempData["Korisnik"] = a;
                return View("UpdatePassword");
            }

            if (k.KorisnickiNalog.Lozinka == a.TempText2)
            {
                TempData["poruka"] = "Novi password ne može biti isti kao trenutni !";
                TempData["Korisnik"] = a;
                return View("UpdatePassword");

            }
            
                
            k.KorisnickiNalog.Lozinka = a.TempText2;
            db.SaveChanges();
            Autenfikacija.SetLogiraniKorisnik(HttpContext, k);
            TempData["poruka2"] = "Password je uspješno promijenjen!";
            TempData["Korisnik"] = a;
            return View("UpdatePassword");

        }

        public ActionResult PorukaUspjesnosti()
        {
            return View("PorukaUspjesnosti");
        }

        public ActionResult ShopOdjeca()
        {


            OdjecaShopVM model = new OdjecaShopVM
            {
                podaciOdjeca = db.Odjeca.Select(o => new OdjecaShopVM.Odjeca
                {
                    ProizvodID = o.ProizvodID,
                    Naziv = o.Proizvod.Naziv,
                    Cijena = o.Proizvod.Cijena,
                    ImageUrl = o.Proizvod.ImageUrl,
                    OdjecaID = o.OdjecaID,
                    Spol = o.Spol
                }).ToList()

            };

            return View(model);
        }

        public ActionResult OdjecaPrikaz(int OdjID)
        {
            Korisnik kor = Autenfikacija.GetLogiraniKorisnik(HttpContext);
            Odjeca c = db.Odjeca.Where(c => c.OdjecaID == OdjID).Include(c => c.Proizvod).SingleOrDefault();

            OdjecaPrikazVM model = new OdjecaPrikazVM
            {
                ProizvodID = c.ProizvodID,
                Naziv = c.Proizvod.Naziv,
                Cijena = c.Proizvod.Cijena,
                ImageUrl = c.Proizvod.ImageUrl,
                OdjecaID = c.OdjecaID,
                Spol = c.Spol,
                velicine = db.OdjecaVelicine.Where(o => o.OdjecaID == OdjID).Select(o => new OdjecaPrikazVM.Vel
                {
                    Velicina = o.Velicina,
                    kolicina = o.kolicina

                }).ToList()
            };

            if(kor != null)
            {
                ViewData["log"] = true;
            }
            else
            {
                ViewData["log"] = false;

            }
            return View(model);
        }

        public ActionResult ShopObuca()
        {
            ObucaShopVM model = new ObucaShopVM
            {
                podaciObuca = db.Obuca.Select(o => new ObucaShopVM.Obuca
                {
                    ProizvodID = o.ProizvodID,
                    Naziv = o.Proizvod.Naziv,
                    Cijena = o.Proizvod.Cijena,
                    ImageUrl = o.Proizvod.ImageUrl,
                    ObucaID = o.ObucaID,
                    Spol = o.Spol
                }).ToList()

            };

            return View(model);
        }

        public ActionResult ObucaPrikaz(int ObucaID)
        {
            Korisnik kor = Autenfikacija.GetLogiraniKorisnik(HttpContext);
            Obuca o = db.Obuca.Where(o => o.ObucaID == ObucaID).Include(o => o.Proizvod).SingleOrDefault();

            ObucaPrikazVM model = new ObucaPrikazVM
            {
                ProizvodID = o.ProizvodID,
                Naziv = o.Proizvod.Naziv,
                Cijena = o.Proizvod.Cijena,
                ImageUrl = o.Proizvod.ImageUrl,
                ObucaID = o.ObucaID,
                Spol = o.Spol,
                velicine = db.ObucaVelicine.Where(o => o.ObucaID == ObucaID).Select(o => new ObucaPrikazVM.Vel
                {
                    Velicina = o.Velicina,
                    kolicina = o.kolicina

                }).ToList()
            };

            if (kor != null)
            {
                ViewData["log"] = true;
            }
            else
            {
                ViewData["log"] = false;

            }
            return View(model);
        }

        public ActionResult ShopSuplementacija()
        {
            SuplementacijaShopVM model = new SuplementacijaShopVM
            {
                podaci = db.Suplementacija.Select(o => new SuplementacijaShopVM.Suplementacija
                {
                    ProizvodID = o.ProizvodID,
                    Naziv = o.Proizvod.Naziv,
                    Cijena = o.Proizvod.Cijena,
                    ImageUrl = o.Proizvod.ImageUrl,
                    SuplementacijaID = o.SuplementacijaID,
                    kategorijaSuplementacije = o.Kategorija.SuplementacijaKategorijaNaziv
                    
                }).ToList()

            };

            return View(model);
        }

        public ActionResult SuplementacijaPrikaz(int SuplementacijaID)
        {
            Korisnik kor = Autenfikacija.GetLogiraniKorisnik(HttpContext);
            Suplementacija o = db.Suplementacija.Where(o => o.SuplementacijaID == SuplementacijaID).Include(o => o.Kategorija).Include(o => o.Proizvod).SingleOrDefault();

            SuplementacijaPrikazVM model = new SuplementacijaPrikazVM
            {
                ProizvodID = o.ProizvodID,
                Naziv = o.Proizvod.Naziv,
                Cijena = o.Proizvod.Cijena,
                ImageUrl = o.Proizvod.ImageUrl,
                SuplementacijaID = o.SuplementacijaID,
                Kolicina = o.kolicina,
                Tezina = o.Tezina,
                kategorijaSuplementacije = o.Kategorija.SuplementacijaKategorijaNaziv
            };

            if (kor != null)
            {
                ViewData["log"] = true;
            }
            else
            {
                ViewData["log"] = false;

            }
            return View(model);
        }

        public ActionResult ShopDodatak()
        {
            DodatakShopVM model = new DodatakShopVM
            {
                podaci = db.Dodatak.Select(o => new DodatakShopVM.Dodatak
                {
                    ProizvodID = o.ProizvodID,
                    Naziv = o.Proizvod.Naziv,
                    Cijena = o.Proizvod.Cijena,
                    ImageUrl = o.Proizvod.ImageUrl,
                    DodatakID = o.DodatakID,
                    TipDodatka = o.TipDodatka
                }).ToList()
            };

            return View(model);
        }

        public ActionResult DodatakPrikaz(int DodatakID)
        {
            Korisnik kor = Autenfikacija.GetLogiraniKorisnik(HttpContext);
            Dodatak o = db.Dodatak.Where(o => o.DodatakID == DodatakID).Include(o => o.Proizvod).SingleOrDefault();

            DodatakPrikazVM model = new DodatakPrikazVM
            {
                ProizvodID = o.ProizvodID,
                Naziv = o.Proizvod.Naziv,
                Cijena = o.Proizvod.Cijena,
                ImageUrl = o.Proizvod.ImageUrl,
                DodatakID = o.DodatakID,
                Kolicina = o.Kolicina,
                TipDodatka = o.TipDodatka
            };

            if (kor != null)
            {
                ViewData["log"] = true;
            }
            else
            {
                ViewData["log"] = false;

            }
            return View(model);
        }

    }
}