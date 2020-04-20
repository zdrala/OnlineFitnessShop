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
using OnlineFitnessShop.helpers;
using OnlineFitnessShop.Core.Interfaces;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Net.Mail;
using System.Net;

namespace OnlineFitnessShop.Controllers
{
    public class AutentifikacijaController : Controller
    {
        IAutentifikacijaService autentifikacijaService;

        public AutentifikacijaController(IAutentifikacijaService _ds)
        {
            autentifikacijaService = _ds;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registracija()
        {
            ProfilVM model = new ProfilVM
            {
                gradovi = autentifikacijaService.GetAllGradove().Select(g => new SelectListItem
                {
                    Value = g.GradID.ToString(),
                    Text = g.Naziv
                }).ToList(),
                spolovi = UserHelper.getSpolList()
            };
            return View(model);
        }

        public IActionResult Snimi(ProfilVM a)
        {
            if (!ModelState.IsValid)
            {
                TempData["error_poruka"] = "Sva polja moraju biti popunjena!";
                a.gradovi = autentifikacijaService.GetAllGradove().Select(g => new SelectListItem
                {
                    Value = g.GradID.ToString(),
                    Text = g.Naziv
                }).ToList();
                a.spolovi = UserHelper.getSpolList();
                return View("Registracija", a);
            }

            

            Korisnik korisnik = autentifikacijaService.GetKorisnikByUsername(a.Username);

            if (korisnik != null)
            {
                TempData["error_poruka"] = "Username je već zauzet!";
                a.gradovi = autentifikacijaService.GetAllGradove().Select(g => new SelectListItem
                {
                    Value = g.GradID.ToString(),
                    Text = g.Naziv
                }).ToList();
                a.spolovi = UserHelper.getSpolList();

                return View("Registracija", a);
            }

            KorisnikNalog kn = new KorisnikNalog();

            kn.KorisnickoIme = a.Username;
            kn.Lozinka = a.Password;
            kn.VrstaKorisnikaID = 2;

            autentifikacijaService.DodajNalog(kn);

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
            k.Spol = a.Spol;
            k.Aktiviran = false;

            if (a.Slika == null)
            {
                if (a.Spol == "Muški")
                    k.imageUrl = "man-avatar.png";
                else
                    k.imageUrl = "female-avatar.png";
            }

            autentifikacijaService.DodajKorisnika(k);

            if (a.Slika != null)
                UploadFile(a.Slika, k);

            SendEmail(k.KorisnikID, k.EmailAdresa,k.Ime,k.Prezime);
            return Redirect("/UserInterface/PorukaUspjesnosti");
        }

        public IActionResult Login(LoginVM input)
        {
            Korisnik korisnik = autentifikacijaService.GetKorisnikByUsernameAndPassword(input.username, input.password);

            if(korisnik == null)
            {
                TempData["error_poruka"] = "Pogrešan username ili password";
                return View("Index",input);
            }

            if(korisnik.Aktiviran == false)
            {
                TempData["error_poruka"] = "Niste aktivirali račun";
                return View("Index", input);
            }

            Autenfikacija.SetLogiraniKorisnik(HttpContext, korisnik);

            if(korisnik.KorisnickiNalog.VrstaKorisnikaID==1)
            {
                return View("~/Views/AdministratorProizvod/Test.cshtml"); 
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

        public ActionResult AktivacijaRacuna(int KorisnikID)
        {
            Korisnik kor = autentifikacijaService.GetKorisnikByID(KorisnikID);

            if (kor == null)
                return RedirectToAction("Registracija");
            else
            {
                if(kor.Aktiviran == true)
                {
                    TempData["porukaE"] = "Vaš račun je već aktiviran!";
                    return View();
                }
                else
                {
                    kor.Aktiviran = true;
                    autentifikacijaService.UpdateKorisnik(kor);
                    TempData["porukaE"] = null;
                    return View();
                }

            }
        }

        public void UploadFile(IFormFile file, Korisnik korisik)
        {
            var fileName = file.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/userPhoto", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            Korisnik kor = autentifikacijaService.GetKorisnikByID(korisik.KorisnikID);
            kor.imageUrl = fileName;
            autentifikacijaService.UpdateKorisnik(kor);
        }

        public void  SendEmail(int KorsinikID ,string toMail,string ime,string prezime)
        {
            var verifyUrl = "/Autentifikacija/AktivacijaRacuna?KorisnikID=" + KorsinikID;

            //for loclahost
            //var link = Request.Host.Host + ":" + Request.Host.Port + verifyUrl;

            //for azure
            var link = Request.Host.Host + verifyUrl;

            var fromEmail = new MailAddress("seminarskirs1test@gmail.com", "Seminarski RS1");
            var toEmail = new MailAddress(toMail);
            string subject = "";
            string body = "";
            var fromEmailPassword = "TestTestRS1";
            subject = "AKTIVACIJA RAČUNA";
            body = "Poštovani/na " + ime + " " + prezime + ",<br/>Vaša nalog je uspješno kreiran.<br/>Molimo potvrdite aktivaciju putem sljedećeg linka: " +
             "<br/>_____________________________________________________<br/><br/>" + "<a href=\"https://" + link + "\">" + link + "</a>" + "<br/>_____________________________________________________<br/>";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
            };

            using (var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
                smtp.Send(message);

        }
    }
}
