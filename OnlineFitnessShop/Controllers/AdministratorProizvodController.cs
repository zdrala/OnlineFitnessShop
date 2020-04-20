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
    public class AdministratorProizvodController : Controller
    {
        IProizvodiService proizvodiService;
        IDobavljaciService dobavljaciService;
       
        public AdministratorProizvodController(IProizvodiService _ps,IDobavljaciService _ds)
        {
            proizvodiService = _ps;
            dobavljaciService = _ds;
        }

        public ActionResult Index()
        {
            return View("Test");
        }

              #region Suplementacija
        public ActionResult PrikazSuplementacije()
        {
            SuplementacijaPrikazVM model = new SuplementacijaPrikazVM
            {
                podaciSuplement = proizvodiService.GetAllSuplemente().Where(s=>!s.Obrisan).Select(p => new SuplementacijaPrikazVM.Suplementacija
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



        public ActionResult DodajSuplementaciju()
        {



            DodajSuplementVM modelSuplement = new DodajSuplementVM
            {
                dobavljaci = dobavljaciService.GetDobavljaceSuplementacije().Select(d => new SelectListItem
                {
                    Value = d.DobavljacID.ToString(),
                    Text = d.Naziv
                }).ToList(),
                KategorijeSuplementacija = proizvodiService.GetAllSuplementacijaKategorije()
            };

            return View(modelSuplement);
        }
        public ActionResult SpremiSuplementaciju(DodajSuplementVM x)
        {
            if (!ModelState.IsValid)
            {
                return View("DodajSuplementaciju", x);
            }


            
  

          
               Proizvod p = new Proizvod
                {
                    Naziv = x.Naziv,
                    Cijena = x.Cijena,
                    DobavljacID = x.DobavljacID,
                    datumDodavanja = DateTime.Now,
                    ImageUrl = ""
                };
            proizvodiService.dodajProizvod(p);
            
               Suplementacija s = new Suplementacija
                {
                    ProizvodID = p.ProizvodID,
                    KategorijaID = x.KategorijaID,
                    Brend = x.Brend,
                    Tezina = x.Tezina,
                    Uputstvo = x.Uputstvo,
                    kolicina = x.kolicina,
                    RokTrajanja = p.datumDodavanja.AddYears(2)
                };


            proizvodiService.dodajSuplement(s);


            if (x.slika != null)
                UploadFile(x.slika, p);

            return RedirectToAction("PrikazSuplementacije");
        }
        public void UploadFile(IFormFile file, Proizvod p)
        {

            var fileName = file.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            Proizvod c = proizvodiService.ProizvodFind(p.ProizvodID);
            c.ImageUrl = fileName;
            proizvodiService.ProizvodUpdate(c);
        }
        public ActionResult UrediSuplement(int id)
        {
            Suplementacija s = proizvodiService.SuplementacijaFind(id);

            DodajSuplementVM model = new DodajSuplementVM
            {
                SuplementacijaID = s.SuplementacijaID,
                ProizvodID = s.ProizvodID,
                Naziv = s.Proizvod.Naziv,
                Cijena = s.Proizvod.Cijena,
                DobavljacID = s.Proizvod.DobavljacID,
                dobavljaci = dobavljaciService.GetDobavljaceSuplementacije().Select(d => new SelectListItem
                {
                    Value = d.DobavljacID.ToString(),
                    Text = d.Naziv
                }).ToList(),
                KategorijaID = s.KategorijaID,
                KategorijeSuplementacija = proizvodiService.GetAllSuplementacijaKategorije(),
                imageUrl = s.Proizvod.ImageUrl,
                Brend = s.Brend,
                Tezina = s.Tezina,
                Uputstvo = s.Uputstvo,
                kolicina = s.kolicina

            };

            return View(model);
        }
        public ActionResult SpremiEditSuplementacije(DodajSuplementVM x)
        {
            if (!ModelState.IsValid)
            {
                return View("UrediSuplement", x);
            }
            Suplementacija s = proizvodiService.SuplementacijaFind(x.SuplementacijaID);
               Proizvod p = proizvodiService.ProizvodFind(x.ProizvodID);

            p.Naziv = x.Naziv;
            p.Cijena = x.Cijena;
            p.DobavljacID = x.DobavljacID;
            proizvodiService.ProizvodUpdate(p);

            s.KategorijaID = x.KategorijaID;
            s.Brend = x.Brend;
            s.Tezina = x.Tezina;
            s.Uputstvo = x.Uputstvo;
            s.kolicina = x.kolicina;
            proizvodiService.SuplementacijaUpdate(s);

            if (x.slika != null)
                UploadFile(x.slika, p);

            return RedirectToAction("PrikazSuplementacije");
        }
        public ActionResult ObrisiSuplement(int id)
        {
            Suplementacija s = proizvodiService.SuplementacijaFind(id);
            Proizvod p = proizvodiService.ProizvodFind(s.ProizvodID);

            s.Obrisan = true;
            p.Obrisan = true;
            proizvodiService.SuplementacijaUpdate(s);
            proizvodiService.ProizvodUpdate(p);

            return RedirectToAction("PrikazSuplementacije");
        }

        #endregion

               #region Odjeca
        public ActionResult DodajOdjecu()
        {

            DodajOdjecuVM model = new DodajOdjecuVM
            {
                dobavljaci = dobavljaciService.GetDobavljaceOdjece().Select(d => new SelectListItem
                {
                    Value = d.DobavljacID.ToString(),
                    Text = d.Naziv
                }).ToList(),
                spol = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Value = "Muški",
                                Text = "Muški"
                            },
                            new SelectListItem
                            {
                                Value = "Ženski",
                                Text = "Ženski"
                            }
                        }


            };
            return View(model);
        }

        public ActionResult UrediOdjecu(int OdjecaID)
        {
            Odjeca o = proizvodiService.OdjecaFind(OdjecaID);

            DodajOdjecuVM model = new DodajOdjecuVM
            {
                ProizvodID = o.ProizvodID,
                OdjecaID = o.OdjecaID,
                Naziv = o.Proizvod.Naziv,
                Cijena = o.Proizvod.Cijena,
                DobavljacID = o.Proizvod.DobavljacID,
                dobavljaci = dobavljaciService.GetDobavljaceOdjece().Select(d => new SelectListItem
                {
                    Value = d.DobavljacID.ToString(),
                    Text = d.Naziv
                }).ToList(),
                Spol = o.Spol,
                spol = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Value = "Muški",
                                Text = "Muški"
                            },
                            new SelectListItem
                            {
                                Value = "Ženski",
                                Text = "Ženski"
                            }
                        },
                Materijal = o.Materijal,
                Brend = o.Brend,
                Opis = o.Opis,
                imageUrl = o.Proizvod.ImageUrl


            };

            return View(model);
        }
        public ActionResult SpremiOdjecu(DodajOdjecuVM x)
        {
            if (!ModelState.IsValid)
            {
                return View("DodajOdjecu", x);
            }

         

         
              Proizvod  p = new Proizvod
                {
                    Naziv = x.Naziv,
                    Cijena = x.Cijena,
                    DobavljacID = x.DobavljacID,
                    datumDodavanja = DateTime.Now,
                    ImageUrl = ""
                };
            proizvodiService.dodajProizvod(p);
               Odjeca o = new Odjeca
                {
                    ProizvodID = p.ProizvodID,
                    Spol = x.Spol,
                    Materijal = x.Materijal,
                    Brend = x.Brend,
                    Opis = x.Opis
                };

            proizvodiService.dodajOdjecu(o);
            
         



            if (x.slika != null)
                UploadFile(x.slika, p);

            return RedirectToAction("PrikazOdjece");
        }
        public ActionResult SpremiEditOdjece(DodajOdjecuVM x)
        {
            if (!ModelState.IsValid)
            {
                return View("UrediOdjecu", x);
            }
            Odjeca o = proizvodiService.OdjecaFind(x.OdjecaID);
            Proizvod p = proizvodiService.ProizvodFind(o.ProizvodID);



            p.Naziv = x.Naziv;
            p.Cijena = x.Cijena;
            p.DobavljacID = x.DobavljacID;
            proizvodiService.ProizvodUpdate(p);

            o.Spol = x.Spol;
            o.Materijal = x.Materijal;
            o.Brend = x.Brend;
            o.Opis = x.Opis;

            proizvodiService.OdjecaUpdate(o);

            if (x.slika != null)
                UploadFile(x.slika, p);

            return RedirectToAction("PrikazOdjece");
        }
        public ActionResult PrikazOdjece()
        {
            OdjecaPrikazVM model = new OdjecaPrikazVM
            {
                podaciOdjece = proizvodiService.GetAllOdjecu().Where(o=>!o.Obrisan).Select(o => new OdjecaPrikazVM.Odjeca
                {
                    ProizvodID = o.ProizvodID,
                    Naziv = o.Proizvod.Naziv,
                    Cijena = o.Proizvod.Cijena,
                    ImageUrl = o.Proizvod.ImageUrl,
                    OdjecaID = o.OdjecaID,
                    Spol = o.Spol,
                    Brend = o.Brend,
                    Materijal = o.Materijal,
                    Opis = o.Opis
                }).ToList()

            };

            return View(model);
        }

        public ActionResult ObrisiOdjecu(int OdjecaID)
        {
            Odjeca o = proizvodiService.OdjecaFind(OdjecaID);
            Proizvod p = proizvodiService.ProizvodFind(o.ProizvodID);

            int brojac = proizvodiService.OdjecaVelicineCount(OdjecaID);
            for (int i = 0; i < brojac; i++)
            {
                OdjecaVelicine ov = proizvodiService.OdjecaVelicineFindFirst(OdjecaID);
                proizvodiService.OdjecaVelicineDelete(ov);
            }

            o.Obrisan = true;
            p.Obrisan = true;
            proizvodiService.OdjecaUpdate(o);
            proizvodiService.ProizvodUpdate(p);


            return RedirectToAction("PrikazOdjece");
        }
        public ActionResult PrikazVelicine(int OdjecaID)
        {
            Odjeca o = proizvodiService.OdjecaFind(OdjecaID);


            OdjecaVelicinePrikazVM model = new OdjecaVelicinePrikazVM
            {
                OdjecaID = OdjecaID,
                imageUrl = o.Proizvod.ImageUrl,
                velicine = proizvodiService.GetVelicineOdredjenjeOdjece(OdjecaID).Select(o => new OdjecaVelicinePrikazVM.Row
                {
                    Velicina = o.Velicina,
                    kolicina = o.kolicina,
                    VelicinaID=o.OdjecaVelicinaID

                }).ToList()


            };


            return View(model);
        }
        public ActionResult DodajVelicinuOdjece(int OdjecaID)
        {
            Odjeca o = proizvodiService.OdjecaFind(OdjecaID);

            DodajOdjecaVelicineVM model = new DodajOdjecaVelicineVM
            {
                imageUrl = o.Proizvod.ImageUrl,
                OdjecaID = OdjecaID,
                velicine=AdministratorHelper.getVelicineOdjece()
            };
            return View("DodajVelicine", model);
        }

        public ActionResult SpremiVelicinuOdjece(DodajOdjecaVelicineVM x)
        {
            OdjecaVelicine ov = proizvodiService.OdjecaVelicinaIsAdded(x.OdjecaID, x.Velicina);
            Odjeca oo = proizvodiService.OdjecaFind(x.OdjecaID);

            if (ov != null)
            {
                TempData["error_poruka"] = "Veličina " + x.Velicina + " se nalazi u bazi! Odaberite drugu veličinu.";
                x.imageUrl = oo.Proizvod.ImageUrl;
                x.velicine = AdministratorHelper.getVelicineOdjece();
                return View("DodajVelicine", x);
            }
            if (!ModelState.IsValid)
            {
                return View("DodajVelicine", x);
            }
            OdjecaVelicine o = new OdjecaVelicine
            {
                OdjecaID = x.OdjecaID,
                Velicina = x.Velicina,
                kolicina = x.kolicina
            };
            proizvodiService.dodajVelicinuOdjece(o);


            return Redirect("/AdministratorProizvod/PrikazVelicine?OdjecaID=" + x.OdjecaID);
        }
        public ActionResult SnimiIzmijenuKolicine(int velicinaID,int novaKolicina)
        {
            OdjecaVelicine ov = proizvodiService.OdjecaVelicineFind(velicinaID);
            ov.kolicina = novaKolicina;
            proizvodiService.OdjecaVelicinaUpdate(ov);

            return Redirect("/AdministratorProizvod/PrikazVelicine?OdjecaID=" + ov.OdjecaID);
        }
        #endregion

            #region Obuca
        public ActionResult DodajObucu()
        {

            DodajObucuVM model = new DodajObucuVM
            {
                dobavljaci = dobavljaciService.GetDobavljaceObuce().Select(d => new SelectListItem
                {
                    Value = d.DobavljacID.ToString(),
                    Text = d.Naziv
                }).ToList(),
                spol = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Value = "Muški",
                                Text = "Muški"
                            },
                            new SelectListItem
                            {
                                Value = "Ženski",
                                Text = "Ženski"
                            }
                        }


            };
            return View(model);
        }

        public ActionResult SpremiObucu(DodajObucuVM x)
        {

            if (!ModelState.IsValid)
            {
                return View("DodajObucu", x);
            }
           

           
             Proizvod  p = new Proizvod
                {
                    Naziv = x.Naziv,
                    Cijena = x.Cijena,
                    DobavljacID = x.DobavljacID,
                    datumDodavanja = DateTime.Now,
                    ImageUrl = ""
                };
            proizvodiService.dodajProizvod(p);
               Obuca o = new Obuca
                {
                    ProizvodID = p.ProizvodID,
                    Spol = x.Spol,
                    Namjena = x.Namjena,
                    Brend = x.Brend,
                    Opis = x.Opis
                };
            proizvodiService.dodajObucu(o);

            if (x.slika != null)
                UploadFile(x.slika, p);
            return RedirectToAction("PrikazObuce");

        }
        public ActionResult PrikazObuce()
        {
            ObucaPrikazVM model = new ObucaPrikazVM
            {
                podaciObuca = proizvodiService.GetAllObucu().Where(o => !o.Obrisan).Select(o => new ObucaPrikazVM.Obuca
                {
                    ObucaID = o.ObucaID,
                    ProizvodID = o.ProizvodID,
                    Naziv = o.Proizvod.Naziv,
                    Cijena = o.Proizvod.Cijena,
                    Spol = o.Spol,
                    Brend = o.Brend,
                    imageUrl = o.Proizvod.ImageUrl

                }).ToList()

            };

            return View(model);
        }

        public ActionResult UrediObucu(int ObucaID)
        {
            Obuca o = proizvodiService.ObucaFind(ObucaID);

            DodajObucuVM model = new DodajObucuVM
            {
                ProizvodID = o.ProizvodID,
                ObucaID = o.ObucaID,
                Naziv = o.Proizvod.Naziv,
                Cijena = o.Proizvod.Cijena,
                DobavljacID = o.Proizvod.DobavljacID,
                dobavljaci = dobavljaciService.GetDobavljaceObuce().Select(d => new SelectListItem
                {
                    Value = d.DobavljacID.ToString(),
                    Text = d.Naziv
                }).ToList(),
                Spol = o.Spol,
                spol = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Value = "Muški",
                                Text = "Muški"
                            },
                            new SelectListItem
                            {
                                Value = "Ženski",
                                Text = "Ženski"
                            }
                        },
                Namjena = o.Namjena,
                Brend = o.Brend,
                Opis = o.Opis,
                imageUrl = o.Proizvod.ImageUrl
            };

            return View(model);
        }
        public ActionResult SpremiEditObuce(DodajObucuVM x)
        {
            if (!ModelState.IsValid)
            {
                return View("UrediObucu", x);
            }
            Obuca o = proizvodiService.ObucaFind(x.ObucaID);
            Proizvod p = proizvodiService.ProizvodFind(o.ProizvodID);



            p.Naziv = x.Naziv;
            p.Cijena = x.Cijena;
            p.DobavljacID = x.DobavljacID;
            proizvodiService.ProizvodUpdate(p);

            o.Spol = x.Spol;
            o.Namjena = x.Namjena;
            o.Brend = x.Brend;
            o.Opis = x.Opis;

            proizvodiService.ObucaUpdate(o);

            if (x.slika != null)
                UploadFile(x.slika, p);

            return RedirectToAction("PrikazObuce");
        }
        public ActionResult PrikazVelicinaZaObucu(int ObucaID)
        {
            Obuca o = proizvodiService.ObucaFind(ObucaID);
            ObucaVelicinePrikazVM model = new ObucaVelicinePrikazVM
            {
                ObucaID = o.ObucaID,
                imageUrl = o.Proizvod.ImageUrl,
                velicine = proizvodiService.GetVelicineOdredjenjeObuce(ObucaID).Select(o => new ObucaVelicinePrikazVM.Row
                {
                    Velicina = o.Velicina,
                    kolicina = o.kolicina,
                    VelicinaID=o.ObucaVelicinaID
                    
                }).ToList()

            };

            return View(model);
        }

        public ActionResult DodajVelicinuObuce(int ObucaID)
        {
            Obuca o = proizvodiService.ObucaFind(ObucaID);
            DodajVelicinuObuceVM model = new DodajVelicinuObuceVM
            {
                ObucaID = ObucaID,
                imageUrl=o.Proizvod.ImageUrl
            };

            return View(model);
        }

        public ActionResult SpremiVelicinuObuce(DodajVelicinuObuceVM x)
        {
            ObucaVelicine ov = proizvodiService.ObucaVelicinaIsAdded(x.ObucaID,  x.Velicina);
            Obuca oo = proizvodiService.ObucaFind(x.ObucaID);
            
            if (ov != null)
            {
                TempData["error_poruka"] = "Veličina " + x.Velicina + " se nalazi u bazi! Unesite drugu veličinu.";
                x.ObucaID = oo.ObucaID;
                x.imageUrl = oo.Proizvod.ImageUrl;            
                return View("DodajVelicinuObuce", x);
            }
            if (!ModelState.IsValid)
            {
                return View("DodajVelicinuObuce", x);
            }
            ObucaVelicine o = new ObucaVelicine
            {
                ObucaID = x.ObucaID,
                Velicina = x.Velicina,
                kolicina = x.kolicina
            };
            proizvodiService.dodajVelicinuObuce(o);

            return Redirect("/AdministratorProizvod/PrikazVelicinaZaObucu?ObucaID=" + x.ObucaID);
        }
        public ActionResult SnimiIzmijenuKolicineObuce(int velicinaID, int novaKolicina)
        {
            ObucaVelicine ov = proizvodiService.ObucaVelicineFind(velicinaID);
            ov.kolicina = novaKolicina;
            proizvodiService.ObucaVelicinaUpdate(ov);

            return Redirect("/AdministratorProizvod/PrikazVelicinaZaObucu?ObucaID=" + ov.ObucaID);
        }

        public ActionResult ObrisiObucu(int ObucaID)
        {
            Obuca o = proizvodiService.ObucaFind(ObucaID);
            Proizvod p = proizvodiService.ProizvodFind(o.ProizvodID);

            int brojac = proizvodiService.ObucaVelicineCount(ObucaID);
            for (int i = 0; i < brojac; i++)
            {
                ObucaVelicine ov = proizvodiService.ObucaVelicineFindFirst(ObucaID);
                proizvodiService.ObucaVelicineDelete(ov);
            }
            o.Obrisan = true;
            p.Obrisan = true;
            proizvodiService.ObucaUpdate(o);
            proizvodiService.ProizvodUpdate(p);
            


            return RedirectToAction("PrikazObuce");
        }
        #endregion

        #region Dodatci

        public ActionResult DodajDodatak()
        {

            DodatakDodajVM model = new DodatakDodajVM
            {
                dobavljaci =dobavljaciService.GetDobavljaceDodataka().Select(d => new SelectListItem
                {
                    Value = d.DobavljacID.ToString(),
                    Text = d.Naziv
                }).ToList(),
                tipDodatkaList = AdministratorHelper.getTipoveDodataka()
            };


            return View(model);
        }

        public ActionResult SpremiDodatak(DodatakDodajVM x)
        {
            if (!ModelState.IsValid)
            {
                return View("DodajDodatak", x);
            }


          

         
               Proizvod p = new Proizvod
                {
                    Naziv = x.Naziv,
                    Cijena = x.Cijena,
                    DobavljacID = x.DobavljacID,
                    datumDodavanja = DateTime.Now,
                    ImageUrl = ""
                };
            proizvodiService.dodajProizvod(p);
              Dodatak  d = new Dodatak
                {
                    ProizvodID = p.ProizvodID,
                    TipDodatka = x.TipDodatka,
                    Kolicina = x.Kolicina,
                    Namjena = x.Namjena
                };
            proizvodiService.dodajDodatak(d);
           
     

            if (x.slika != null)
                UploadFile(x.slika, p);


            return RedirectToAction("PrikazDodataka");
        }
        public ActionResult PrikazDodataka()
        {
            DodatakPrikazVM model = new DodatakPrikazVM
            {
                podaciDodatci = proizvodiService.GetAllDodatke().Where(d=>!d.Obrisan).Select(d => new DodatakPrikazVM.Row
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

        public ActionResult UrediDodatak(int id)
        {
            Dodatak d = proizvodiService.DodatakFind(id);
            DodatakDodajVM model = new DodatakDodajVM
            {
                ProizvodID = d.ProizvodID,
                DodatakID = d.DodatakID,
                Naziv = d.Proizvod.Naziv,
                Cijena = d.Proizvod.Cijena,
                DobavljacID = d.Proizvod.DobavljacID,
                dobavljaci =dobavljaciService.GetDobavljaceDodataka().Select(d => new SelectListItem
                {
                    Value = d.DobavljacID.ToString(),
                    Text = d.Naziv
                }).ToList(),
                TipDodatka = d.TipDodatka,
                tipDodatkaList = AdministratorHelper.getTipoveDodataka(),
                Kolicina = d.Kolicina,
                Namjena = d.Namjena,
                ImageUrl = d.Proizvod.ImageUrl
            };
            return View(model);
        }
        public ActionResult SpremiEditDodatka(DodatakDodajVM x)
        {
            if (!ModelState.IsValid)
            {
                return View("UrediDodatak", x);
            }
            Dodatak d = proizvodiService.DodatakFind(x.DodatakID);
            Proizvod p = proizvodiService.ProizvodFind(d.ProizvodID);

            p.Naziv = x.Naziv;
            p.Cijena = x.Cijena;
            p.DobavljacID = x.DobavljacID;

            proizvodiService.ProizvodUpdate(p);

            d.TipDodatka = x.TipDodatka;
            d.Kolicina = x.Kolicina;
            d.Namjena = x.Namjena;

            proizvodiService.DodatakUpdate(d);

            if (x.slika != null)
                UploadFile(x.slika, p);

            return RedirectToAction("PrikazDodataka");
        }
        public ActionResult ObrisiDodatak(int id)
        {
            Dodatak d = proizvodiService.DodatakFind(id);
            Proizvod p = proizvodiService.ProizvodFind(d.ProizvodID);

            d.Obrisan = true;
            p.Obrisan = true;
            proizvodiService.DodatakUpdate(d);
            proizvodiService.ProizvodUpdate(p);
            

            
            return RedirectToAction("PrikazDodataka");
        }
        #endregion

        #region Komentari
        public ActionResult PrikazKomentaraZaProizvod(int id)
        {

            Proizvod p = proizvodiService.ProizvodFind(id);
            KomentariProizvodPrikazVM model = new KomentariProizvodPrikazVM
            {
                proizvodID=p.ProizvodID,
                imageUrl=p.ImageUrl,
                nazivProizvoda=p.Naziv,
                komentariProizvod=proizvodiService.GetAllKomentare().Where(k=>k.ProizvodID==p.ProizvodID).Select(k=>new KomentariProizvodPrikazVM.Row
                {
                    KomentarID=k.KomentarID,
                    imePrezimeKorisnika=k.Korisnik.Ime+" "+k.Korisnik.Prezime,
                    textKomentara=k.Tekst
                }).ToList()
            };
            return View(model);
        }
        public ActionResult ObrisiKomentar(int id)
        {
            KomentarProizvod kp = proizvodiService.KomentarProizvodFind(id);
            int idProizvoda = kp.ProizvodID;
            proizvodiService.KomentarProizvodDelete(kp);
            return Redirect("/AdministratorProizvod/PrikazKomentaraZaProizvod?id="+idProizvoda);
        }
        #endregion


    }
}
