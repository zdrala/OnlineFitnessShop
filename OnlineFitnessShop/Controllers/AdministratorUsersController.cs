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
    [Autorizacija(admin: true, user:false)]
    public class AdministratorUsersController:Controller
    {
        IUsersService korisniciService;

        public AdministratorUsersController(IUsersService _korisniciService)
        {
            korisniciService = _korisniciService;
        }

        #region Kupac

        public ActionResult DodajKupca()
        {
            DodajKupacVM model = new DodajKupacVM
            {
                gradovi = korisniciService.GetAllGradove(),
                dani = AdministratorHelper.GenerateDaysList(),
                mjeseci = AdministratorHelper.GenerateMonthsList(),
                godine = AdministratorHelper.GenerateYearsList()

            };


            return View(model);
        }

        public ActionResult SpremiKupca(DodajKupacVM x)
        {


            Korisnik kor = korisniciService.KorisnikFind(x.EmailAdresa);


            KorisnikNalog kn = korisniciService.KorisnikNalogFind(x.KorisnickoIme);

            //if (!ModelState.IsValid)
            //{
            //    x.gradovi = _db.Gradovi.Select(g => new SelectListItem
            //    {
            //        Value = g.GradID.ToString(),
            //        Text = g.Naziv

            //    }).ToList();
            //    x.DatumRodjenja = Date.Now;
            //    return View("DodajKupca", x);
            //}

                if (kor != null || kn != null)
                {
                    x.gradovi = korisniciService.GetAllGradove();
                    x.dani = AdministratorHelper.GenerateDaysList();
                    x.mjeseci = AdministratorHelper.GenerateMonthsList();
                    x.godine = AdministratorHelper.GenerateYearsList();
                    if (kor != null)
                        TempData["error_porukaEmail"] = "E-mail adresa " + x.EmailAdresa + " već postoji!";

                    if (kn != null)
                        TempData["error_porukaUser"] = "korisničko ime " + x.KorisnickoIme + " već postoji!";


                    return View("DodajKupca", x);
                }
            
            


                string DatumRodjenja = x.MjesecRodjenja.ToString() + "-" + x.DanRodjenja.ToString() + "-" +
                                       x.GodinaRodjenja.ToString();

                KorisnikNalog k = new KorisnikNalog
                {
                    KorisnickoIme = x.KorisnickoIme,
                    Lozinka = x.Lozinka,
                    VrstaKorisnikaID = 2

                };
            korisniciService.dodajKorisnikNalog(k);
                Korisnik korisnik = new Korisnik
                {
                    Ime = x.Ime,
                    Prezime = x.Prezime,
                    //DatumRodjenja = x.DatumRodjenja,
                    DatumRodjenja = Convert.ToDateTime(DatumRodjenja),
                    EmailAdresa = x.EmailAdresa,
                    BrojTelefona = x.BrojTelefona,
                    Adresa = x.Adresa,
                    GradID = x.GradID,
                    KorisnikNalogID = k.KorisnikNalogID,
                    Spol = "Muški",
                    imageUrl = "man-avatar.png",
                    Aktiviran=true

                };
            korisniciService.dodajKorisnik(korisnik);
            
     


            return RedirectToAction("PrikazKupaca");
        }

        public ActionResult PrikazKupaca()
        {
            KupacPrikazVM model = new KupacPrikazVM
            {
                podaciKupci = korisniciService.GetAllKupce().Where(k=>!k.Obrisan).Select(k => new KupacPrikazVM.Row
                {
                    KorisnikID = k.KorisnikID,
                    Ime = k.Ime,
                    Prezime = k.Prezime,
                    EmailAdresa = k.EmailAdresa,
                    BrojTelefona = k.BrojTelefona

                }).ToList()

            };


            return View(model);
        }

        public ActionResult UrediKupca(int KorisnikID)
        {

            Korisnik k = korisniciService.KorisnikFindByID(KorisnikID);
            DodajKupacVM model = new DodajKupacVM
            {
                KorisnikID = k.KorisnikID,
                KorisnikNalogID = k.KorisnickiNalog.KorisnikNalogID,
                Ime = k.Ime,
                Prezime = k.Prezime,
                DanRodjenja = k.DatumRodjenja.Day,
                MjesecRodjenja = k.DatumRodjenja.Month,
                GodinaRodjenja = k.DatumRodjenja.Year,
                EmailAdresa = k.EmailAdresa,
                BrojTelefona = k.BrojTelefona,
                Adresa = k.Adresa,
                GradID = k.GradID,
                gradovi = korisniciService.GetAllGradove(),
                KorisnickoIme = k.KorisnickiNalog.KorisnickoIme,
                Lozinka = k.KorisnickiNalog.Lozinka,
                dani = AdministratorHelper.GenerateDaysList(),
                mjeseci = AdministratorHelper.GenerateMonthsList(),
                godine = AdministratorHelper.GenerateYearsList()

            };


            return View(model);
        }
        public ActionResult SpremiEditKupca(DodajKupacVM x)
        {
            Korisnik kor = korisniciService.KorisnikFind(x.EmailAdresa);


            KorisnikNalog kn = korisniciService.KorisnikNalogFind(x.KorisnickoIme);

            if (kor != null || kn != null)
            {
                int i = 0;
                x.gradovi = korisniciService.GetAllGradove();
                x.dani = AdministratorHelper.GenerateDaysList();
                x.mjeseci = AdministratorHelper.GenerateMonthsList();
                x.godine = AdministratorHelper.GenerateYearsList();
                if (kor != null)
                {
                    if (kor.KorisnikID != x.KorisnikID)
                    {
                        TempData["error_porukaEmail"] = "E-mail adresa " + x.EmailAdresa + " već postoji!";
                        i = 1;
                    }
                }
                if (kn != null)
                {
                    if (kn.KorisnikNalogID != x.KorisnikNalogID)
                    {
                        TempData["error_porukaUser"] = "korisničko ime " + x.KorisnickoIme + " već postoji!";
                        i = 1;
                    }
                }
                if (i == 1)
                    return View("UrediKupca", x);
            }

            
                string DatumRodjenja = x.MjesecRodjenja.ToString() + "-" + x.DanRodjenja.ToString() + "-" +
                                       x.GodinaRodjenja.ToString();
                Korisnik korisnikUpdate = korisniciService.KorisnikFindByID(x.KorisnikID);
            KorisnikNalog KorisnikNalogUpdate = korisniciService.KorisnikNalogFindByID(korisnikUpdate.KorisnikNalogID);

                KorisnikNalogUpdate.KorisnickoIme = x.KorisnickoIme;

                if (x.Lozinka2 != null)
                    KorisnikNalogUpdate.Lozinka = x.Lozinka2;
            korisniciService.KorisnikNalogUpdate(KorisnikNalogUpdate);

                korisnikUpdate.Ime = x.Ime;
                korisnikUpdate.Prezime = x.Prezime;
                korisnikUpdate.DatumRodjenja = Convert.ToDateTime(DatumRodjenja);
                korisnikUpdate.EmailAdresa = x.EmailAdresa;
                korisnikUpdate.BrojTelefona = x.BrojTelefona;
                korisnikUpdate.Adresa = x.Adresa;
                korisnikUpdate.GradID = x.GradID;
            korisniciService.KorisnikUpdate(korisnikUpdate);

            return RedirectToAction("PrikazKupaca");
        }
        public ActionResult ObrisiKupca(int KorisnikID)
        {
            Korisnik k = korisniciService.KorisnikFindByID(KorisnikID);
            KorisnikNalog kn = korisniciService.KorisnikNalogFindByID(k.KorisnikNalogID);
            k.Obrisan = true;
            kn.Obrisan = true;
            korisniciService.KorisnikNalogUpdate(kn);
            korisniciService.KorisnikUpdate(k);
            return RedirectToAction("PrikazKupaca");
        }
        #endregion

       #region Admin
        public ActionResult DodajAdmina()
        {
            DodajAdminVM model = new DodajAdminVM
            {
                gradovi = korisniciService.GetAllGradove(),
                dani = AdministratorHelper.GenerateDaysList(),
                mjeseci = AdministratorHelper.GenerateMonthsList(),
                godine = AdministratorHelper.GenerateYearsList()

            };


            return View(model);
        }

        public ActionResult SpremiAdmina(DodajAdminVM x)
        {
            Korisnik kor = korisniciService.KorisnikFind(x.EmailAdresa);


            KorisnikNalog kn = korisniciService.KorisnikNalogFind(x.KorisnickoIme);



       
            if (kor != null || kn != null)
            {
              x.gradovi = korisniciService.GetAllGradove();
                   x.dani = AdministratorHelper.GenerateDaysList();
                   x.mjeseci = AdministratorHelper.GenerateMonthsList();
                   x.godine = AdministratorHelper.GenerateYearsList();
                   if (kor != null)
                       TempData["error_porukaEmail"] = "E-mail adresa " + x.EmailAdresa + " već postoji!";

                   if (kn != null)
                       TempData["error_porukaUser"] = "korisničko ime " + x.KorisnickoIme + " već postoji!";


                   return View("DodajAdmina", x);
            }
           
           



        
                string DatumRodjenja = x.MjesecRodjenja.ToString() + "-" + x.DanRodjenja.ToString() + "-" +
                                       x.GodinaRodjenja.ToString();

                KorisnikNalog k = new KorisnikNalog
                {
                    KorisnickoIme = x.KorisnickoIme,
                    Lozinka = x.Lozinka,
                    VrstaKorisnikaID = 1

                };
            korisniciService.dodajKorisnikNalog(k);
                Korisnik korisnik = new Korisnik
                {
                    Ime = x.Ime,
                    Prezime = x.Prezime,
                    DatumRodjenja = Convert.ToDateTime(DatumRodjenja),
                    EmailAdresa = x.EmailAdresa,
                    BrojTelefona = x.BrojTelefona,
                    Adresa = x.Adresa,
                    GradID = x.GradID,
                    KorisnikNalogID = k.KorisnikNalogID,
                    Spol="Muški",
                    imageUrl="man-avatar.png" ,
                    Aktiviran=true
                };
            korisniciService.dodajKorisnik(korisnik);
            
           

            return RedirectToAction("PrikazAdmina");
        }

        public ActionResult UrediAdmina(int AdminID)
        {

            Korisnik k = korisniciService.KorisnikFindByID(AdminID);
            DodajAdminVM model = new DodajAdminVM
            {
                KorisnikID = k.KorisnikID,
                KorisnikNalogID = k.KorisnickiNalog.KorisnikNalogID,
                Ime = k.Ime,
                Prezime = k.Prezime,
                DanRodjenja = k.DatumRodjenja.Day,
                MjesecRodjenja = k.DatumRodjenja.Month,
                GodinaRodjenja = k.DatumRodjenja.Year,
                EmailAdresa = k.EmailAdresa,
                BrojTelefona = k.BrojTelefona,
                Adresa = k.Adresa,
                GradID = k.GradID,
                gradovi = korisniciService.GetAllGradove(),
                KorisnickoIme = k.KorisnickiNalog.KorisnickoIme,
                Lozinka = k.KorisnickiNalog.Lozinka,
                dani = AdministratorHelper.GenerateDaysList(),
                mjeseci = AdministratorHelper.GenerateMonthsList(),
                godine = AdministratorHelper.GenerateYearsList()

            };




            return View(model);
        }
        public ActionResult SpremiEditAdmina(DodajAdminVM x)
        {
            Korisnik kor = korisniciService.KorisnikFind(x.EmailAdresa);
            KorisnikNalog kn = korisniciService.KorisnikNalogFind(x.KorisnickoIme);


            if (kor != null || kn != null)
            {
                int i = 0;
                x.gradovi = korisniciService.GetAllGradove();
                x.dani = AdministratorHelper.GenerateDaysList();
                x.mjeseci = AdministratorHelper.GenerateMonthsList();
                x.godine = AdministratorHelper.GenerateYearsList();
                if (kor != null)
                {
                    if (kor.KorisnikID != x.KorisnikID)
                    {
                        TempData["error_porukaEmail"] = "E-mail adresa " + x.EmailAdresa + " već postoji!";
                        i = 1;
                    }
                }

                if (kn != null)
                {
                    if (kn.KorisnikNalogID != x.KorisnikNalogID)
                    {
                        TempData["error_porukaUser"] = "korisničko ime " + x.KorisnickoIme + " već postoji!";
                        i = 1;
                    }
                }

                if (i == 1)
                    return View("UrediAdmina", x);
            }



            string DatumRodjenja = x.MjesecRodjenja.ToString() + "-" + x.DanRodjenja.ToString() + "-" +
                                   x.GodinaRodjenja.ToString();
            Korisnik korisnikUpdate = korisniciService.KorisnikFindByID(x.KorisnikID);
            KorisnikNalog KorisnikNalogUpdate = korisniciService.KorisnikNalogFindByID(korisnikUpdate.KorisnikNalogID);

            KorisnikNalogUpdate.KorisnickoIme = x.KorisnickoIme;

            if (x.Lozinka2 != null)
                KorisnikNalogUpdate.Lozinka = x.Lozinka2;
            korisniciService.KorisnikNalogUpdate(KorisnikNalogUpdate);

            korisnikUpdate.Ime = x.Ime;
            korisnikUpdate.Prezime = x.Prezime;
            korisnikUpdate.DatumRodjenja = Convert.ToDateTime(DatumRodjenja);
            korisnikUpdate.EmailAdresa = x.EmailAdresa;
            korisnikUpdate.BrojTelefona = x.BrojTelefona;
            korisnikUpdate.Adresa = x.Adresa;
            korisnikUpdate.GradID = x.GradID;
            korisniciService.KorisnikUpdate(korisnikUpdate);


            return RedirectToAction("PrikazAdmina");
        }
        public ActionResult ObrisiAdmina(int AdminID)
        {
            Korisnik k = korisniciService.KorisnikFindByID(AdminID);
            Korisnik k2 = Autenfikacija.GetLogiraniKorisnik(HttpContext);
            KorisnikNalog kn = korisniciService.KorisnikNalogFindByID(k.KorisnikNalogID);
            k.Obrisan = true;
            kn.Obrisan = true;
            korisniciService.KorisnikNalogUpdate(kn);
            korisniciService.KorisnikUpdate(k);
            if (k.KorisnikID == k2.KorisnikID)
            {
                Autenfikacija.SetLogiraniKorisnik(HttpContext, null);
                TempData["error_poruka"] = "Logirani admin je izbrisan i više ne postoji!";
                return View("~/Views/Autentifikacija/Index.cshtml");

            }
            return RedirectToAction("PrikazAdmina");
        }
        public ActionResult PrikazAdmina()
        {
            AdminPrikazVM model = new AdminPrikazVM
            {
                podaciAdmin = korisniciService.GetAllAdmine().Where(k=>!k.Obrisan).Select(k =>
                    new AdminPrikazVM.Row
                    {
                        KorisnikID = k.KorisnikID,
                        Ime = k.Ime,
                        Prezime = k.Prezime,
                        EmailAdresa = k.EmailAdresa,
                        BrojTelefona = k.BrojTelefona,
                        KorisnickoIme = k.KorisnickiNalog.KorisnickoIme

                    }).ToList()

            };
            return View(model);
        }

        public ActionResult DodijeliAdmina(int KorisnikID)
        {
            Korisnik k = korisniciService.KorisnikFindByID(KorisnikID);
            KorisnikNalog kn = korisniciService.KorisnikNalogFindByID(k.KorisnikNalogID);
            kn.VrstaKorisnikaID = 1;
            korisniciService.KorisnikNalogUpdate(kn);
            return RedirectToAction("PrikazKupaca");
        }
        public ActionResult UkloniUloguAdmina(int AdminID)
        {
            Korisnik k = korisniciService.KorisnikFindByID(AdminID);
            Korisnik k2 = Autenfikacija.GetLogiraniKorisnik(HttpContext);
            KorisnikNalog kn = korisniciService.KorisnikNalogFindByID(k.KorisnikNalogID);
            kn.VrstaKorisnikaID = 2;
            korisniciService.KorisnikNalogUpdate(kn);

            if(k.KorisnikID == k2.KorisnikID)
            {
                return View("~/Views/UserInterface/NoPermission.cshtml");

            }
            return RedirectToAction("PrikazAdmina");
        }
        #endregion


    }
}
