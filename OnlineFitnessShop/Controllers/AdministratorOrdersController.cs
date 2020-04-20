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
    public class AdministratorOrdersController:Controller
    {
        IOrdersService narudzbeService;
        IProizvodiService proizvodiService;
        public AdministratorOrdersController(IOrdersService _ns,IProizvodiService _ps)
        {
            narudzbeService = _ns;
            proizvodiService = _ps;
        }
        public ActionResult PrikazNarudzbiNaCekanju()
        {
            NarudzbePrikazVM model = new NarudzbePrikazVM
            {
                narudzbeList = narudzbeService.GetAllNarudzbe().Where(n=>n.StatusNarudzbeID==1).Select(n => new NarudzbePrikazVM.NarudzbaVM
                {
                    NarudzbaID = n.NarudzbaID,
                    ImePrezimeKupca = n.Korisnik.Ime + " " + n.Korisnik.Prezime,
                    DatumNarucivanja = n.DatumKreiranjaNarudjbe,
                    Grad_Adresa = n.Grad.Naziv + " | " + n.Adresa,
                    StatusNarudzbe = n.StatusNarudzbe.OpisStanja,
                    IznosNarudzbe = n.IznosSaPDV
                }).ToList()
            };
            return View(model);
        }
        public ActionResult PregledajNarudzbu(int NarudzbaID)
        {
            Narudzba n= narudzbeService.NarudzbaFind(NarudzbaID);
            NarudzbaSoloPrikazVM model = new NarudzbaSoloPrikazVM
            {
                NarudzbaID = n.NarudzbaID,
                ImePrezimeKupca = n.Korisnik.Ime + " " + n.Korisnik.Prezime,
                DatumNarucivanja = n.DatumKreiranjaNarudjbe,
                Grad_Adresa = n.Grad.Naziv + " | " + n.Adresa,
                StatusNarudzbe = n.StatusNarudzbe.OpisStanja,
                IznosNarudzbe = n.IznosSaPDV
            };
            return View(model);
        }
        public ActionResult PrihvatiNarudzbu(int NarudzbaID)
        {
            string error="Narudžbu nije moguće prihvatiti!. ";
            bool baciError = false;
            string proizvodiEmail="";
            NarudzbaStavkePrikazVM model = new NarudzbaStavkePrikazVM
            {
                stavkeList = narudzbeService.GetAllNarudzbaStavke(NarudzbaID).Select(n => new NarudzbaStavkePrikazVM.Stavka
                {
                    proizvodID=n.ProizvodID,
                    VrstaProizvoda=n.VrstaProizvoda,
                    imageUrl = n.Proizvod.ImageUrl,
                    NazivProizvoda = n.Proizvod.Naziv,
                    Velicina = n.Velicina,
                    Kolicina = Convert.ToString(n.Kolicina)
                }).ToList()
            };
            foreach(var x in model.stavkeList)
            {
                if(x.VrstaProizvoda=="Odjeca")
                {
                    Odjeca o = proizvodiService.OdjecaFindByProizvodID(x.proizvodID);
                    int kolicinaVelicine = proizvodiService.OdjecaVelicineFindByVel(o.OdjecaID, x.Velicina);
                    if (kolicinaVelicine <int.Parse(x.Kolicina))
                    {
                        baciError = true;
                        error += "Odjece: "+x.NazivProizvoda+" | "+x.Velicina+" nema dovoljno na stanju. ";
                    }
                }
                if (x.VrstaProizvoda == "Obuca")
                {
                    Obuca o = proizvodiService.ObucaFindByProizvodID(x.proizvodID);
                    int kolicinaVelicine = proizvodiService.ObucaVelicineFindByVel(o.ObucaID, x.Velicina);
                    if (kolicinaVelicine < int.Parse(x.Kolicina))
                    {
                        baciError = true;
                        error += "Obuce: " + x.NazivProizvoda + " | " + x.Velicina + " nema dovoljno na stanju. ";
                    }
                }
                if (x.VrstaProizvoda == "Suplementacija")
                {
                    Suplementacija s = proizvodiService.SuplementacijaFindByProizvodID(x.proizvodID);
                    if (s.kolicina<int.Parse(x.Kolicina))
                    {
                        baciError = true;
                        error += "Suplementacije: " + x.NazivProizvoda + " "+x.Velicina + "kg nema dovoljno na stanju. ";
                    }
                }
                if (x.VrstaProizvoda == "Dodatak")
                {
                    Dodatak d = proizvodiService.DodatakFindByProizvodID(x.proizvodID);
                    if (d.Kolicina< int.Parse(x.Kolicina))
                    {
                        baciError = true;
                        error += "Dodatka: " + x.NazivProizvoda + " nema dovoljno na stanju. ";
                    }
                }
            }
            if(baciError)
            {
                TempData["error_poruka"] = error;
                Narudzba n = narudzbeService.NarudzbaFind(NarudzbaID);
                NarudzbaSoloPrikazVM modelX = new NarudzbaSoloPrikazVM
                {
                    NarudzbaID = n.NarudzbaID,
                    ImePrezimeKupca = n.Korisnik.Ime + " " + n.Korisnik.Prezime,
                    DatumNarucivanja = n.DatumKreiranjaNarudjbe,
                    Grad_Adresa = n.Grad.Naziv + " | " + n.Adresa,
                    StatusNarudzbe = n.StatusNarudzbe.OpisStanja,
                    IznosNarudzbe = n.IznosSaPDV
                };
                return View("NoAcceptingOrder", modelX);
            }
            foreach (var x in model.stavkeList)
            {
                if (x.VrstaProizvoda == "Odjeca")
                {
                    Odjeca o = proizvodiService.OdjecaFindByProizvodID(x.proizvodID);
                    OdjecaVelicine ov = proizvodiService.OdjecaVelicinaFindByOdjecaID_Velicina(o.OdjecaID, x.Velicina);
                    ov.kolicina -= int.Parse(x.Kolicina);
                    proizvodiService.OdjecaVelicinaUpdate(ov);
                    proizvodiEmail += "Odjeca: " + x.NazivProizvoda + " | " + x.Velicina + " | Količina: "+x.Kolicina+ "<br/>";
                }
                if (x.VrstaProizvoda == "Obuca")
                {
                    Obuca o = proizvodiService.ObucaFindByProizvodID(x.proizvodID);
                    ObucaVelicine ov = proizvodiService.ObucaVelicinaFindByObucaID_Velicina(o.ObucaID, x.Velicina);
                    ov.kolicina -= int.Parse(x.Kolicina);
                    proizvodiService.ObucaVelicinaUpdate(ov);
                    proizvodiEmail += "Obuca: " + x.NazivProizvoda + " | " + x.Velicina + " | Količina: " + x.Kolicina + "<br/>";

                }
                if (x.VrstaProizvoda == "Suplementacija")
                {
                    Suplementacija s = proizvodiService.SuplementacijaFindByProizvodID(x.proizvodID);
                   s.kolicina -= int.Parse(x.Kolicina);
                    proizvodiService.SuplementacijaUpdate(s);
                    proizvodiEmail += "Suplementacija: " + x.NazivProizvoda + " | " + x.Velicina + "kg | Količina: " + x.Kolicina + "<br/>";
                }
                if (x.VrstaProizvoda == "Dodatak")
                {
                    Dodatak d = proizvodiService.DodatakFindByProizvodID(x.proizvodID);
                    d.Kolicina -= int.Parse(x.Kolicina);
                    proizvodiService.DodatakUpdate(d);
                    proizvodiEmail += "Dodatak za treniranje: " + x.NazivProizvoda + " | Količina: " + x.Kolicina + "<br/>";
                }
            }

            Narudzba nar = narudzbeService.NarudzbaFind(NarudzbaID);
            nar.StatusNarudzbeID = 2;
            narudzbeService.NarudzbaUpdate(nar);
            string imePrezime = nar.Korisnik.Ime + " " + nar.Korisnik.Prezime;
            string email = nar.Korisnik.EmailAdresa;
            string iznos = Convert.ToString(nar.IznosSaPDV);
            string datumNarucivanja="";
         
            datumNarucivanja = nar.DatumKreiranjaNarudjbe.Day.ToString()+".";
            datumNarucivanja += nar.DatumKreiranjaNarudjbe.Month.ToString() + ".";
            datumNarucivanja += nar.DatumKreiranjaNarudjbe.Year.ToString() + ".";
            AdministratorHelper.SendSuccessTransactionMail(imePrezime, proizvodiEmail,email,iznos);
            AdministratorHelper.SendSMS(imePrezime,datumNarucivanja);
            Transakcije t = new Transakcije
            {
                NarudzbaID = nar.NarudzbaID,
                KorisnikID = nar.KorisnikID,
                DatumTransakcije = DateTime.Now,
                NaplaceniIznos=nar.IznosSaPDV,
                NaplaceniIznosSaPDV=nar.IznosSaPDV,
                Izbrisano=false
            };
            narudzbeService.DodajTransakciju(t);
            return View("OrderAccepted");
        }
        public ActionResult OdbijNarudzbu(int NarudzbaID)
        {
            Narudzba n = narudzbeService.NarudzbaFind(NarudzbaID);
            NarudzbaSoloPrikazVM model = new NarudzbaSoloPrikazVM
            {
                NarudzbaID = n.NarudzbaID,
                ImePrezimeKupca = n.Korisnik.Ime + " " + n.Korisnik.Prezime,
                DatumNarucivanja = n.DatumKreiranjaNarudjbe,
                Grad_Adresa = n.Grad.Naziv + " | " + n.Adresa,
                StatusNarudzbe = n.StatusNarudzbe.OpisStanja,
                IznosNarudzbe = n.IznosSaPDV
            };
            return View(model);
        }
        public ActionResult PrihvatiOdbijanje(int narudzbaID,string komentar)
        {
            Narudzba n = narudzbeService.NarudzbaFind(narudzbaID);
            n.StatusNarudzbeID = 3;
            n.Komentar = komentar;
            narudzbeService.NarudzbaUpdate(n);
            return RedirectToAction("PrikazNarudzbiNaCekanju");
        }
        public ActionResult PrikazOdobrenihNarudzbi()
        {
            ShowAcceptedDeclinedOrdersVM model = new ShowAcceptedDeclinedOrdersVM
            {
                narudzbeList=narudzbeService.GetAllNarudzbe().Where(n=>n.StatusNarudzbeID==2 && !n.Izbrisano).Select(n=>new ShowAcceptedDeclinedOrdersVM.Row
                {
                    NarudzbaID=n.NarudzbaID,
                    KorisnikID=n.KorisnikID,
                    DatumNarucivanja=n.DatumKreiranjaNarudjbe,
                    IznosNarudzbe=n.IznosSaPDV,
                    ImePrezimeKupca=n.Korisnik.Ime+" "+n.Korisnik.Prezime
                }).ToList()
            };

            return View(model);
        }
        public ActionResult PrikazOdbijenihNarudzbi()
        {
            ShowAcceptedDeclinedOrdersVM model = new ShowAcceptedDeclinedOrdersVM
            {
                narudzbeList = narudzbeService.GetAllNarudzbe().Where(n => n.StatusNarudzbeID == 3&&!n.Izbrisano).Select(n => new ShowAcceptedDeclinedOrdersVM.Row
                {
                    NarudzbaID = n.NarudzbaID,
                    KorisnikID = n.KorisnikID,
                    DatumNarucivanja = n.DatumKreiranjaNarudjbe,
                    IznosNarudzbe = n.IznosSaPDV,
                    ImePrezimeKupca = n.Korisnik.Ime + " " + n.Korisnik.Prezime
                }).ToList()
            };
            return View(model);
        }
        public ActionResult PrikaziSveNarudzbeKorisnika(int KorisnikID)
        {
            Narudzba n = narudzbeService.GetAllNarudzbe().Where(n => n.KorisnikID == KorisnikID).FirstOrDefault();
            ShowAcceptedDeclinedOrdersVM model = new ShowAcceptedDeclinedOrdersVM
            {
                imePrezime = n.Korisnik.Ime + " " + n.Korisnik.Prezime,
                narudzbeList = narudzbeService.GetAllNarudzbe().Where(n => n.KorisnikID==KorisnikID&&!n.Izbrisano).Select(n => new ShowAcceptedDeclinedOrdersVM.Row
                {
                    NarudzbaID = n.NarudzbaID,
                    KorisnikID = n.KorisnikID,
                    DatumNarucivanja = n.DatumKreiranjaNarudjbe,
                    IznosNarudzbe = n.IznosSaPDV,
                    ImePrezimeKupca = n.Korisnik.Ime + " " + n.Korisnik.Prezime,
                    StatusNarudzbe=n.StatusNarudzbe.OpisStanja
                }).ToList()
            };
            return View(model);
        }
        public ActionResult ObrisiNarudzbuKorisnika(int narudzbaID,int korisnikID)
        {
            Narudzba n = narudzbeService.NarudzbaFind(narudzbaID);
            n.Izbrisano = true;
            Transakcije t = narudzbeService.TransakcijeFindByNarudzbaID(narudzbaID);
            if(t!=null)
            t.Izbrisano = true;

            narudzbeService.NarudzbaUpdate(n);
            
            if (t != null)
                narudzbeService.TransakcijaUpdate(t);
            return RedirectToAction("PrikaziSveNarudzbeKorisnika", new { KorisnikID = korisnikID });
        }

    }
}
