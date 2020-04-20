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
    [Autorizacija(admin: true, user: true)]
    public class UserDataController : Controller
    {
        IUserDataService userdataService;
       
        public UserDataController(IUserDataService _ds)
        {
            userdataService = _ds;
        }

        public ActionResult Informacije()
        {
            Korisnik k = Autenfikacija.GetLogiraniKorisnik(HttpContext);

            KorisnikInformacijeVM model = new KorisnikInformacijeVM
            {
                Ime=k.Ime,
                Prezime=k.Prezime,
                DatumRodjenja=k.DatumRodjenja.ToString("dd/M/yyyy"),
                Email=k.EmailAdresa,
                BrojTelefona=k.BrojTelefona,
                Grad=k.Grad.Naziv,
                Adresa=k.Adresa,
                imgUrl=k.imageUrl
            };
            return View(model);
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

            novi.gradovi= userdataService.GetAllGradove().Select(g => new SelectListItem
            {
                Value = g.GradID.ToString(),
                Text = g.Naziv
            }).ToList();
            return View(novi);
        }

        public ActionResult Snimi(KorisnikVM x)
        {

            if (!ModelState.IsValid)
            {
                x.gradovi = userdataService.GetAllGradove().Select(g => new SelectListItem
                {
                    Value = g.GradID.ToString(),
                    Text = g.Naziv
                }).ToList();
                TempData["poruka"] = "Sva polja moraju biti popunjena!";
                return View("Update",x);
            }

            Korisnik k = userdataService.KorisnikFindByID(x.ID);

            if (k.Ime == x.Ime && k.Prezime == x.Prezime && k.DatumRodjenja == x.DatumRodjenja && k.EmailAdresa == x.Email && k.BrojTelefona == x.BrojTelefona && k.Adresa == x.Adresa && k.GradID == x.GradID)
            {
                if (x.Slika != null)
                {
                    UploadFile(x.Slika, k);
                    Korisnik ss = userdataService.KorisnikFindByID(k.KorisnikID);
                    Autenfikacija.SetLogiraniKorisnik(HttpContext, ss);
                    TempData["poruka2"] = "Slika je usješno izmijenjena!";
                    return View("Update", x);
                }

                x.gradovi = userdataService.GetAllGradove().Select(g => new SelectListItem
                {
                    Value = g.GradID.ToString(),
                    Text = g.Naziv
                }).ToList();
                TempData["poruka"] = "Niste napravili nikakvu izmjenu!";
                return View("Update",x);

            }
            else
            {
                k.Ime = x.Ime;
                k.Prezime = x.Prezime;
                k.DatumRodjenja = x.DatumRodjenja;
                k.EmailAdresa = x.Email;
                k.BrojTelefona = x.BrojTelefona;
                k.Adresa = x.Adresa;
                k.GradID = x.GradID;
                userdataService.UpdateKorisnik(k);

                if (x.Slika != null)
                {
                    UploadFile(x.Slika, k);
                }
            }

            Korisnik korisnik = userdataService.KorisnikFindByID(k.KorisnikID);
            Autenfikacija.SetLogiraniKorisnik(HttpContext, korisnik);
            TempData["poruka2"] = "Podaci su usješno izmijenjeni!";
            x.gradovi = userdataService.GetAllGradove().Select(g => new SelectListItem
            {
                Value = g.GradID.ToString(),
                Text = g.Naziv
            }).ToList();
            return View("Update",x);
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

            KorisnikNalog korisnik = userdataService.GetKorisnickiNalogByUsername(a.Text);
            Korisnik kor = Autenfikacija.GetLogiraniKorisnik(HttpContext);

            if (korisnik != null)
            {
                TempData["poruka"] = "Username već postoji!";
                a.Text2 = a.Text;
                a.Text = kor.KorisnickiNalog.KorisnickoIme;
                TempData["Korisnik"] = a;
                return View("UpdateUsername");
            }

            if (!ModelState.IsValid)
            {
                TempData["poruka"] = "Polja nisu ispravno popunjena!";
                return View("UpdateUsername",a);
            }

            else
            {

                Korisnik k = userdataService.KorisnikFindByID(a.ID);
                KorisnikNalog nalog = userdataService.NalogFindByNalogID(k.KorisnickiNalog.KorisnikNalogID);

                nalog.KorisnickoIme = a.Text;
                userdataService.UpdateKorisnickiNalog(nalog);

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
            Korisnik k = userdataService.KorisnikFindByID(a.ID);
            KorisnikNalog nalog = userdataService.NalogFindByNalogID(k.KorisnickiNalog.KorisnikNalogID);


            if (nalog.Lozinka != a.StariPassword)
            {
                TempData["poruka"] = "Ispravno unesite trenutni password";
                TempData["Korisnik"] = a;
                return View("UpdatePassword");
            }

            if (nalog.Lozinka == a.TempText2)
            {
                TempData["poruka"] = "Novi password ne može biti isti kao trenutni !";
                TempData["Korisnik"] = a;
                return View("UpdatePassword");

            }

            if (!ModelState.IsValid)
            {
                TempData["poruka"] = "Polja nisu ispravno popunjena !";
                return View("UpdatePassword");
            }


            nalog.Lozinka = a.TempText2;
            userdataService.UpdateKorisnickiNalog(nalog);
            Autenfikacija.SetLogiraniKorisnik(HttpContext, k);
            TempData["poruka2"] = "Password je uspješno promijenjen!";
            TempData["Korisnik"] = a;
            return View("UpdatePassword");

        }

        public ActionResult DodajKarticu()
        {
            Korisnik a = Autenfikacija.GetLogiraniKorisnik(HttpContext);

            KarticaVM model = new KarticaVM
            {
                KorisnikID = a.KorisnikID,
                mjeseci = UserHelper.GenerateMonthsList(),
                godine=UserHelper.GenerateYearsList(),
                vrste = UserHelper.getNazivKartica()
            };

            return View(model);
        }

        public ActionResult SnimiKarticu(KarticaVM k)
        {
            KorisnikKartice x = userdataService.getKarticaByBroj(k.BrojKartice);

            if (!ModelState.IsValid) 
            {
                TempData["poruka"] = "Polja nisu ispravno popunjena !";
                return RedirectToAction("DodajKarticu");
            }

            if(x != null)
            {
                TempData["poruka"] = "Kartica je već dodana !";
                return RedirectToAction("DodajKarticu");
            }

            KorisnikKartice nova = new KorisnikKartice
            {
                KorisnikID = k.KorisnikID,
                NazivKartice = k.NazivKartice,
                BrojKartice = k.BrojKartice,
                Code = k.Code,
                MjesecIsteka = k.MjesecIsteka,
                GodinaIsteka = k.GodinaIsteka,
                Aktivna = true
            };

            userdataService.DodajKarticu(nova);

            return RedirectToAction("Kartice");
        }

        public ActionResult Kartice()
        {
            Korisnik k = Autenfikacija.GetLogiraniKorisnik(HttpContext);
            KarticeViewVM model = new KarticeViewVM
            {
                podaciKartice = userdataService.GetKarticeByKorisnikID(k.KorisnikID).Select(a => new KarticeViewVM.Row
                {
                    KarticaID = a.KarticaID,
                    KorisnikID=a.KorisnikID,
                    NazivKartice=a.NazivKartice,
                    BrojKartice=a.BrojKartice,
                    Code=a.Code,
                    MjesecIsteka=a.MjesecIsteka,
                    GodinaIsteka=a.GodinaIsteka,
                    Aktivna=a.Aktivna
                }).ToList()

            };

            return View(model);
        }

        public ActionResult DeaktivirajKarticu(int id)
        {
            KorisnikKartice a = userdataService.getKarticaById(id);
            a.Aktivna = false;
            userdataService.KarticaUpdate(a);

            return RedirectToAction("Kartice");
        }

        public ActionResult AktivirajKarticu(int id)
        {
            KorisnikKartice a = userdataService.getKarticaById(id);
            a.Aktivna = true;
            userdataService.KarticaUpdate(a);

            return RedirectToAction("Kartice");
        }

        public ActionResult Narudzbe(int page)
        {
            Korisnik k = Autenfikacija.GetLogiraniKorisnik(HttpContext);
            NarudzbaVM model = new NarudzbaVM
            {
                stavke = userdataService.GetNarudzbeSortirane(k.KorisnikID).Skip((page-1)*10).Take(10).Select(a => new NarudzbaVM.NarudzbaV
                {
                    NarudzbaID=a.NarudzbaID,
                    VrijemeNarudzbe=a.DatumKreiranjaNarudjbe.ToString("g"),
                    Ukupno=a.IznosSaPDV,
                    StatusNarudzbe=a.StatusNarudzbe.StatusNarudzbeID,
                    Komentar=a.Komentar

                }).ToList()
            };
            model.UkupnoNarudzbi = userdataService.GetCountOfNarudzbe(k.KorisnikID);
            model.TrenutniPage = page;
            return View(model);
        }

        public ActionResult NarudzbaDetalji(int id)
        {
            NarudzbaStavkeVM model = new NarudzbaStavkeVM
            {
                stavke = userdataService.GetStavkeNarudzbe(id).Select(a => new NarudzbaStavkeVM.Stavke
                {
                    imageUrl=a.Proizvod.ImageUrl,
                    Cijena=a.CijenaStavke,
                    TrazenaKolicina=a.Kolicina,
                    Naziv=a.Proizvod.Naziv,
                    Velicina=a.Velicina
                }).ToList()
            };
            return View(model);
        }

        public void UploadFile(IFormFile file, Korisnik korisik)
        {

            var fileName = file.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/userPhoto", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            Korisnik kor = userdataService.KorisnikFindByID(korisik.KorisnikID);
            kor.imageUrl = fileName;
            userdataService.UpdateKorisnik(kor);
        }
    }
}
