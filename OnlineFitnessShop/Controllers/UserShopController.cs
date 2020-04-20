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
    public class UserShopController : Controller
    {
        IProizvodiShopService proizvodishopService;
       
        public UserShopController(IProizvodiShopService _ps)
        {
            proizvodishopService = _ps;
        }

        public ActionResult ShopOdjeca()
        {
            OdjecaShopVM model = new OdjecaShopVM
            {
                podaciOdjeca = proizvodishopService.GetAllOdjecu().Select(o => new OdjecaShopVM.Odjeca
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
            Odjeca c = proizvodishopService.GetOdjecaByID(OdjID);

            OdjecaPrikazVM model = new OdjecaPrikazVM
            {
                ProizvodID = c.ProizvodID,
                Naziv = c.Proizvod.Naziv,
                Cijena = c.Proizvod.Cijena,
                ImageUrl = c.Proizvod.ImageUrl,
                OdjecaID = c.OdjecaID,
                Spol = c.Spol,
                velicine = proizvodishopService.GetVelicineOdredjenjeOdjece(OdjID).Select(o => new OdjecaPrikazVM.Vel
                {
                    Velicina = o.Velicina,
                    kolicina = o.kolicina

                }).ToList(),
                komentari = proizvodishopService.GetKomentareByProizvodID(c.ProizvodID).Select(s => new OdjecaPrikazVM.Komentari
                {
                    ImeKorisnik = s.Korisnik.Ime + " " + s.Korisnik.Prezime,
                    slikaUrl = s.Korisnik.imageUrl,
                    komentarTekst = s.Tekst,
                    DatumKomentarisanja=s.DatumKomentarisanja.ToString("g")
                }).ToList(),
                BrojKomentara =proizvodishopService.GetKomentareByProizvodID(c.ProizvodID).Count()
            };

            if (kor != null)
            {
                model.KorisnikID = kor.KorisnikID;
                ViewData["log"] = true;
            }
            else
            {
                model.KorisnikID = 0;
                ViewData["log"] = false;
            }
            return View(model);
        }

        public ActionResult ShopObuca()
        {
            ObucaShopVM model = new ObucaShopVM
            {
                podaciObuca = proizvodishopService.GetAllObucu().Select(o => new ObucaShopVM.Obuca
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
            Obuca o = proizvodishopService.GetObucaByID(ObucaID);

            ObucaPrikazVM model = new ObucaPrikazVM
            {
                ProizvodID = o.ProizvodID,
                Naziv = o.Proizvod.Naziv,
                Cijena = o.Proizvod.Cijena,
                ImageUrl = o.Proizvod.ImageUrl,
                ObucaID = o.ObucaID,
                Spol = o.Spol,
                velicine = proizvodishopService.GetVelicineOdredjenjeObuce(ObucaID).Select(o => new ObucaPrikazVM.Vel
                {
                    Velicina = o.Velicina,
                    kolicina = o.kolicina

                }).ToList(),
                komentari = proizvodishopService.GetKomentareByProizvodID(o.ProizvodID).Select(s => new ObucaPrikazVM.Komentari
                {
                    ImeKorisnik = s.Korisnik.Ime + " " + s.Korisnik.Prezime,
                    slikaUrl = s.Korisnik.imageUrl,
                    komentarTekst = s.Tekst,
                    DatumKomentarisanja = s.DatumKomentarisanja.ToString("g")
                }).ToList(),
                BrojKomentara = proizvodishopService.GetKomentareByProizvodID(o.ProizvodID).Count()
            };

            if (kor != null)
            {
                model.KorisnikID = kor.KorisnikID;
                ViewData["log"] = true;
            }
            else
            {
                model.KorisnikID = 0;
                ViewData["log"] = false;

            }
            return View(model);
        }

        public ActionResult ShopSuplementacija()
        {
            SuplementacijaShopVM model = new SuplementacijaShopVM
            {
                podaci = proizvodishopService.GetAllSuplemente().Select(o => new SuplementacijaShopVM.Suplementacija
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
            Suplementacija o = proizvodishopService.GetSuplementByID(SuplementacijaID);

            SuplementacijaPrikazVM model = new SuplementacijaPrikazVM
            {
                ProizvodID = o.ProizvodID,
                Naziv = o.Proizvod.Naziv,
                Cijena = o.Proizvod.Cijena,
                ImageUrl = o.Proizvod.ImageUrl,
                SuplementacijaID = o.SuplementacijaID,
                Kolicina = o.kolicina,
                Tezina = o.Tezina,
                kategorijaSuplementacije = o.Kategorija.SuplementacijaKategorijaNaziv,
                komentari = proizvodishopService.GetKomentareByProizvodID(o.ProizvodID).Select(s => new SuplementacijaPrikazVM.Komentari
                {
                    ImeKorisnik = s.Korisnik.Ime + " " + s.Korisnik.Prezime,
                    slikaUrl = s.Korisnik.imageUrl,
                    komentarTekst = s.Tekst,
                    DatumKomentarisanja = s.DatumKomentarisanja.ToString("g")
                }).ToList(),
                BrojKomentara = proizvodishopService.GetKomentareByProizvodID(o.ProizvodID).Count()
            };

            if (kor != null)
            {
                model.KorisnikID = kor.KorisnikID;
                ViewData["log"] = true;
            }
            else
            {
                model.KorisnikID = 0;
                ViewData["log"] = false;

            }
            return View(model);
        }

        public ActionResult ShopDodatak()
        {
            DodatakShopVM model = new DodatakShopVM
            {
                podaci = proizvodishopService.GetAllDodatke().Select(o => new DodatakShopVM.Dodatak
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
            Dodatak o = proizvodishopService.GetDodatakByID(DodatakID);

            DodatakPrikazVM model = new DodatakPrikazVM
            {
                ProizvodID = o.ProizvodID,
                Naziv = o.Proizvod.Naziv,
                Cijena = o.Proizvod.Cijena,
                ImageUrl = o.Proizvod.ImageUrl,
                DodatakID = o.DodatakID,
                Kolicina = o.Kolicina,
                TipDodatka = o.TipDodatka,
                komentari = proizvodishopService.GetKomentareByProizvodID(o.ProizvodID).Select(s => new DodatakPrikazVM.Komentari
                {
                    ImeKorisnik = s.Korisnik.Ime + " " + s.Korisnik.Prezime,
                    slikaUrl = s.Korisnik.imageUrl,
                    komentarTekst = s.Tekst,
                    DatumKomentarisanja = s.DatumKomentarisanja.ToString("g")
                }).ToList(),
                BrojKomentara = proizvodishopService.GetKomentareByProizvodID(o.ProizvodID).Count()
            };

            if (kor != null)
            {
                model.KorisnikID = kor.KorisnikID;
                ViewData["log"] = true;
            }
            else
            {
                model.KorisnikID = 0;
                ViewData["log"] = false;

            }
            return View(model);
        }

        public ActionResult SpremiKomentarOdjeca(OdjecaPrikazVM s)
        {
            if(s.KorisnikID == 0)
            {
                TempData["greška-poruka"] = "Niste logirani !";
                return Redirect(Url.Content("OdjecaPrikaz") + "?OdjID=" + s.OdjecaID + "#komentari");
            }

            if(s.Komentar == null)
            {
                TempData["greška-poruka"] = "Niste unijeli nikakav komentar !";
                return Redirect(Url.Content("OdjecaPrikaz") + "?OdjID=" + s.OdjecaID + "#komentari");
            }
            KomentarProizvod novi = new KomentarProizvod
            {
                ProizvodID = s.ProizvodID,
                KorisnikID = s.KorisnikID,
                Tekst = s.Komentar,
                DatumKomentarisanja = DateTime.Now
            };

            proizvodishopService.DodajKomentar(novi);

            return Redirect(Url.Content("OdjecaPrikaz") + "?OdjID=" + s.OdjecaID + "#komentari");
        }

        public ActionResult SpremiKomentarObuca(ObucaPrikazVM s)
        {
            if (s.KorisnikID == 0)
            {
                TempData["greška-poruka"] = "Niste logirani !";
                return Redirect(Url.Content("ObucaPrikaz") + "?ObucaID=" + s.ObucaID + "#komentari");
            }

            if (s.Komentar == null)
            {
                TempData["greška-poruka"] = "Niste unijeli nikakav komentar !";
                return Redirect(Url.Content("ObucaPrikaz") + "?ObucaID=" + s.ObucaID + "#komentari");

            }
            KomentarProizvod novi = new KomentarProizvod
            {
                ProizvodID = s.ProizvodID,
                KorisnikID = s.KorisnikID,
                Tekst = s.Komentar,
                DatumKomentarisanja = DateTime.Now
            };

            proizvodishopService.DodajKomentar(novi);

            return Redirect(Url.Content("ObucaPrikaz") + "?ObucaID=" + s.ObucaID + "#komentari");
        }

        public ActionResult SpremiKomentarDodatak(DodatakPrikazVM s)
        {
            if (s.KorisnikID == 0)
            {
                TempData["greška-poruka"] = "Niste logirani !";
                return Redirect(Url.Content("DodatakPrikaz") + "?DodatakID=" + s.DodatakID + "#komentari");
            }

            if (s.Komentar == null)
            {
                TempData["greška-poruka"] = "Niste unijeli nikakav komentar !";
                return Redirect(Url.Content("DodatakPrikaz") + "?DodatakID=" + s.DodatakID + "#komentari");

            }
            KomentarProizvod novi = new KomentarProizvod
            {
                ProizvodID = s.ProizvodID,
                KorisnikID = s.KorisnikID,
                Tekst = s.Komentar,
                DatumKomentarisanja = DateTime.Now
            };

            proizvodishopService.DodajKomentar(novi);

            return Redirect(Url.Content("DodatakPrikaz") + "?DodatakID=" + s.DodatakID + "#komentari");
        }

        public ActionResult SpremiKomentarSuplement(SuplementacijaPrikazVM s)
        {
            if (s.KorisnikID == 0)
            {
                TempData["greška-poruka"] = "Niste logirani !";
                return Redirect(Url.Content("SuplementacijaPrikaz") + "?SuplementacijaID=" + s.SuplementacijaID + "#komentari");
            }

            if (s.Komentar == null)
            {
                TempData["greška-poruka"] = "Niste unijeli nikakav komentar !";
                return Redirect(Url.Content("SuplementacijaPrikaz") + "?SuplementacijaID=" + s.SuplementacijaID + "#komentari");


            }
            KomentarProizvod novi = new KomentarProizvod
            {
                ProizvodID = s.ProizvodID,
                KorisnikID = s.KorisnikID,
                Tekst = s.Komentar,
                DatumKomentarisanja = DateTime.Now
            };

            proizvodishopService.DodajKomentar(novi);

            return Redirect(Url.Content("SuplementacijaPrikaz") + "?SuplementacijaID=" + s.SuplementacijaID + "#komentari");

        }
    }
}
