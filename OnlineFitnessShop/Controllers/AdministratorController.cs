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

namespace OnlineFitnessShop.Controllers
{
    public class AdministratorController: Controller
    {
        private readonly MyDbContext _db;

        public AdministratorController(MyDbContext db)
        {
            _db = db;
        }
        #region TEST

        public ActionResult Index()
        {
            return View("Test");
        }

        #endregion

        #region Dobavljaci
        //public IActionResult Index()
        //{
        //    return View("Index");
        //}
        public ActionResult PrikazDobavljaca()
        {
            
            List<Dobavljac> dobavljaci = _db.Dobavljac.Include(d => d.Grad).Include(d => d.DobavljacKategorija).ToList();
         
           

            //ViewData["Dobavljaci"] = dobavljaci;
            return View(dobavljaci);
        }
        public ActionResult DodajDobavljaca()
        {
            
           /* List<Grad> gradovi = db.Gradovi.Include(g => g.Kanton).ToList();
            List<DobavljacKategorije> dobavljaciKategorije = db.DobavljacKategorije.ToList();
            */
           ViewData["Gradovi"] = _db.Gradovi.Select(g => new SelectListItem
               {
               Value= g.GradID.ToString(),
               Text = g.Naziv
               }).ToList();
            ViewData["DobavljaciKategorije"] = _db.DobavljacKategorije.Select(d => new SelectListItem()
            {
               Value= d.DobavljacKategorijaID.ToString(),
               Text = d.nazivKategorije
            }).ToList();
            DobavljacDodajVM Model=new DobavljacDodajVM();

            return View(Model);
        }
        //public ActionResult Spremi(string nazivD,string BrojT,string Email,string Grad,string Adresa,string DobavljacK)
        //{
        //    Dobavljac dob = new Dobavljac
        //    {
        //        Naziv = nazivD,
        //        BrojTelefona = BrojT,
        //        Email = Email,
        //        Adresa = Adresa
        //    };
        //    MyDbContext db = new MyDbContext();
        //    List<Grad> gradovi = db.Gradovi.Include(g => g.Kanton).ToList();
        //    List<DobavljacKategorije> dobavljaciKategorije = db.DobavljacKategorije.ToList();
        //    foreach(Grad g in gradovi)
        //    {
        //        if(Grad==g.Naziv)
        //        {
        //            dob.Grad = g;
        //            dob.GradID = dob.Grad.GradID;
        //            break;
        //        }
        //    }
        //    foreach(DobavljacKategorije k in dobavljaciKategorije)
        //    {
        //        if(k.nazivKategorije==DobavljacK)
        //        {
        //            dob.DobavljacKategorija = k;
        //            dob.DobavljacKategorijaID = dob.DobavljacKategorija.DobavljacKategorijaID;
        //            break;
        //        }
        //    }
        //    db.Dobavljac.Add(dob);
        //    db.SaveChanges();
        //    return Redirect("/Administrator/PorukaUspjesno");
        //}

        public ActionResult Spremi(DobavljacDodajVM x)
        {

            if (!ModelState.IsValid)
            {
                ViewData["Gradovi"] = _db.Gradovi.Select(g => new SelectListItem
                {
                    Value = g.GradID.ToString(),
                    Text = g.Naziv
                }).ToList();
                ViewData["DobavljaciKategorije"] = _db.DobavljacKategorije.Select(d => new SelectListItem()
                {
                    Value = d.DobavljacKategorijaID.ToString(),
                    Text = d.nazivKategorije
                }).ToList();
                return View("DodajDobavljaca", x);
            }

            int i= 1;
            Dobavljac d;
            if (x.DobavljacID == 0)
            {
                d=new Dobavljac();
                _db.Dobavljac.Add(d);
            }
            else
            {
                d = _db.Dobavljac.Find(x.DobavljacID);
                i = 2;
            }

            d.Naziv = x.Naziv;
            d.BrojTelefona = x.BrojTelefona;
            d.Email = x.Email;
            d.GradID = x.GradID;
            d.Adresa = x.Adresa;
            d.DobavljacKategorijaID = x.DobavljacKategorijaID;
            @TempData["NazivDobavljaca"] = x.Naziv;
            _db.SaveChanges();
            if (i == 2)
                return Redirect("/Administrator/PrikazDobavljaca");

            return Redirect("/Administrator/PrikazDobavljaca");
        }

        //public ActionResult PorukaUspjesno()
        //{
        //    return View("PorukaUspjesno");
        //}
        //public ActionResult PorukaUpdate()
        //{
        //    return View("PorukaUpdate");
        //}
        //public ActionResult Obrisi()
        //{
        //    MyDbContext db = new MyDbContext();
        //    List<Dobavljac> dobavljaci = db.Dobavljac.Include(d => d.Grad).Include(d => d.DobavljacKategorija).ToList();



        //    ViewData["Dobavljaci"] = dobavljaci;

        //    return View("Obrisi");
        //}
        public ActionResult UrediDobavljaca(int dobavljacid)
        {
          

            ViewData["Gradovi"] = _db.Gradovi.Select(g => new SelectListItem
            {
                Value = g.GradID.ToString(),
                Text = g.Naziv
            }).ToList();
            ViewData["DobavljaciKategorije"] = _db.DobavljacKategorije.Select(d => new SelectListItem()
            {
                Value = d.DobavljacKategorijaID.ToString(),
                Text = d.nazivKategorije
            }).ToList();


            Dobavljac d = _db.Dobavljac.Find(dobavljacid);
            if(d==null)
            {
                return Redirect("/Administrator/Index");
            }
            DobavljacDodajVM Model =new DobavljacDodajVM
            {
                DobavljacID = d.DobavljacID,
                Naziv=d.Naziv,
                BrojTelefona = d.BrojTelefona,
                Email = d.Email,
                GradID = d.GradID,
                Adresa = d.Adresa,
                DobavljacKategorijaID = d.DobavljacKategorijaID
            };

            return View(Model);
        }
        public ActionResult ObrisiDobavljaca(int dobavljacid)
        {
            
            Dobavljac dob = _db.Dobavljac.Find(dobavljacid);
            //TempData["DobavljacObrisan"] = dob.Naziv;

            _db.Dobavljac.Remove(dob);
            _db.SaveChanges();
            return Redirect("/Administrator/PrikazDobavljaca");
        }
        //public ActionResult PorukaDelete()
        //{
        //    return View("PorukaDelete");
        //}


        #endregion

        //public ActionResult DodajProizvod()
        //{


        //    DodajProizvodVM model = new DodajProizvodVM
        //    {
        //        dobavljaci = _db.Dobavljac.Select(d=>new SelectListItem
        //        {
        //            Value = d.DobavljacID.ToString(),
        //            Text=d.Naziv
        //        }).ToList()

        //    };

        //    return View(model);
        //}

        //public ActionResult SpremiProizvod(DodajProizvodVM x)
        //{


        //        Proizvod p = new Proizvod
        //        {
        //            Naziv = x.Naziv,
        //            Cijena = x.Cijena,
        //            DobavljacID = x.DobavljacID,
        //            datumDodavanja = DateTime.Now,
        //            ImageUrl = ""
        //        };
        //        _db.Proizvod.Add(p);
        //        _db.SaveChanges();
        //        UploadFile(x.slika, p);

        //        return RedirectToAction("PrikazProizvod");

        //}

        //public void UploadFile(IFormFile file, Proizvod p)
        //{

        //    var fileName = file.FileName;
        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);
        //    using (var fileStream = new FileStream(path, FileMode.Create))
        //    {
        //        file.CopyTo(fileStream);
        //    }

        //    Proizvod c = _db.Proizvod.Find(p.ProizvodID);
        //    c.ImageUrl = fileName;
        //    _db.SaveChanges();
        //}

        #region Suplementacija
        public ActionResult PrikazSuplementacije()
        {
            SuplementacijaPrikazVM model = new SuplementacijaPrikazVM
            {
                podaciSuplement = _db.Suplementacija.Select(p=>new SuplementacijaPrikazVM.Suplementacija
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


          
            DodajSuplementVM modelSuplement =new DodajSuplementVM
            {
                dobavljaci = _db.Dobavljac.Where(d => d.DobavljacKategorijaID == 1).Select(d => new SelectListItem
                {
                    Value = d.DobavljacID.ToString(),
                    Text = d.Naziv
                }).ToList(),
                KategorijeSuplementacija = _db.SuplementacijaKategorije.Select(s=> new SelectListItem
                {
                    Value = s.SuplementacijaKategorijaID.ToString(),
                    Text = s.SuplementacijaKategorijaNaziv

                }).ToList()
            };

            return View(modelSuplement);
        }
        public ActionResult SpremiSuplementaciju(DodajSuplementVM x)
        {
            if (!ModelState.IsValid)
            {
                return View("DodajSuplementaciju", x);
            }


            Proizvod p;
            Suplementacija s;

            if (x.SuplementacijaID == 0) //Dodavanje
            {
                p = new Proizvod
                {
                    Naziv = x.Naziv,
                    Cijena = x.Cijena,
                    DobavljacID = x.DobavljacID,
                    datumDodavanja = DateTime.Now,
                    ImageUrl = ""
                };
                _db.Proizvod.Add(p);
                _db.SaveChanges();
                s = new Suplementacija
                {
                    ProizvodID = p.ProizvodID,
                    KategorijaID = x.KategorijaID,
                    Brend = x.Brend,
                    Tezina = x.Tezina,
                    Uputstvo = x.Uputstvo,
                    kolicina = x.kolicina,
                    RokTrajanja = p.datumDodavanja.AddYears(2)
                };
                _db.Suplementacija.Add(s);
                _db.SaveChanges();
            }
            else //Izmijena
            {
                s = _db.Suplementacija.Where(s => s.SuplementacijaID == x.SuplementacijaID).SingleOrDefault();
                p = _db.Proizvod.Where(p => p.ProizvodID == s.ProizvodID).SingleOrDefault();

                p.Naziv = x.Naziv;
                p.Cijena = x.Cijena;
                p.DobavljacID = x.DobavljacID;

                s.KategorijaID = x.KategorijaID;
                s.Brend = x.Brend;
                s.Tezina = x.Tezina;
                s.Uputstvo = x.Uputstvo;
                s.kolicina = x.kolicina;
                _db.SaveChanges();
            }

            if(x.slika!=null)
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

            Proizvod c = _db.Proizvod.Find(p.ProizvodID);
            c.ImageUrl = fileName;
            _db.SaveChanges();
        }
        public ActionResult UrediSuplement(int id)
        {
            Suplementacija s = _db.Suplementacija.Where(s => s.SuplementacijaID == id).Include(s => s.Proizvod)
                .SingleOrDefault();

            DodajSuplementVM model = new DodajSuplementVM
            {
                SuplementacijaID = s.SuplementacijaID,
                ProizvodID = s.ProizvodID,
                Naziv = s.Proizvod.Naziv,
                Cijena = s.Proizvod.Cijena,
                DobavljacID = s.Proizvod.DobavljacID,
                dobavljaci = _db.Dobavljac.Where(d => d.DobavljacKategorijaID == 1).Select(d => new SelectListItem
                {
                    Value = d.DobavljacID.ToString(),
                    Text = d.Naziv
                }).ToList(),
                KategorijaID = s.KategorijaID,
                KategorijeSuplementacija = _db.SuplementacijaKategorije.Select(s => new SelectListItem
                {
                    Value = s.SuplementacijaKategorijaID.ToString(),
                    Text = s.SuplementacijaKategorijaNaziv

                }).ToList(),
                imageUrl = s.Proizvod.ImageUrl,
                Brend = s.Brend,
                Tezina = s.Tezina,
                Uputstvo = s.Uputstvo,
                kolicina = s.kolicina

            };

            return View(model);
        }

        public ActionResult ObrisiSuplement(int id)
        {
            Suplementacija s = _db.Suplementacija.Where(s => s.SuplementacijaID == id).SingleOrDefault();
            Proizvod p = _db.Proizvod.Where(p => p.ProizvodID == s.ProizvodID).SingleOrDefault();

            _db.Proizvod.Remove(p);
            _db.Suplementacija.Remove(s);

            _db.SaveChanges();

            return RedirectToAction("PrikazSuplementacije");
        }

        #endregion

        #region Odjeca
        public ActionResult DodajOdjecu()
        {

            DodajOdjecuVM model = new DodajOdjecuVM
            {
                dobavljaci = _db.Dobavljac.Where(d => d.DobavljacKategorijaID == 2).Select(d => new SelectListItem
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
            Odjeca o = _db.Odjeca.Where(o => o.OdjecaID == OdjecaID).Include(o => o.Proizvod).SingleOrDefault();

            DodajOdjecuVM model = new DodajOdjecuVM
            {
                ProizvodID = o.ProizvodID,
                OdjecaID = o.OdjecaID,
                Naziv = o.Proizvod.Naziv,
                Cijena = o.Proizvod.Cijena,
                DobavljacID = o.Proizvod.DobavljacID,
                dobavljaci = _db.Dobavljac.Where(d => d.DobavljacKategorijaID == 2).Select(d => new SelectListItem
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

            Proizvod p;
            Odjeca o;
            
            if (x.OdjecaID == 0)//dodavanje nove odjece
            {
                p = new Proizvod
                {
                    Naziv = x.Naziv,
                    Cijena = x.Cijena,
                    DobavljacID = x.DobavljacID,
                    datumDodavanja = DateTime.Now,
                    ImageUrl = ""
                };
                _db.Proizvod.Add(p);
                _db.SaveChanges();
                o = new Odjeca
                {
                    ProizvodID = p.ProizvodID,
                    Spol = x.Spol,
                    Materijal = x.Materijal,
                    Brend = x.Brend,
                    Opis = x.Opis
                };
                _db.Odjeca.Add(o);
                _db.SaveChanges();
           
            }
            else//izmijena
            {
                o = _db.Odjeca.Where(o => o.OdjecaID == x.OdjecaID).FirstOrDefault();
                p = _db.Proizvod.Where(p => p.ProizvodID == o.ProizvodID).FirstOrDefault();

              

                p.Naziv = x.Naziv;
                p.Cijena = x.Cijena;
                p.DobavljacID = x.DobavljacID;

                o.Spol = x.Spol;
                o.Materijal = x.Materijal;
                o.Brend = x.Brend;
                o.Opis = x.Opis;
                _db.SaveChanges();
            }



            if (x.slika != null)
                UploadFile(x.slika, p);
            return RedirectToAction("PrikazOdjece");
        }

        public ActionResult PrikazOdjece()
        {
            OdjecaPrikazVM model = new OdjecaPrikazVM
            {
                podaciOdjece = _db.Odjeca.Select(o=> new OdjecaPrikazVM.Odjeca
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
            Odjeca o = _db.Odjeca.Where(o => o.OdjecaID == OdjecaID).SingleOrDefault();
            Proizvod p = _db.Proizvod.Where(p => p.ProizvodID == o.ProizvodID).SingleOrDefault();

            int brojac = _db.OdjecaVelicine.Where(o => o.OdjecaID == OdjecaID).Count();
            for (int i = 0; i < brojac; i++)
            {
                OdjecaVelicine ov = _db.OdjecaVelicine.Where(o => o.OdjecaID == OdjecaID).FirstOrDefault();
                _db.OdjecaVelicine.Remove(ov);
                _db.SaveChanges();
            }

            _db.Odjeca.Remove(o);
            _db.Proizvod.Remove(p);
            _db.SaveChanges();


            return RedirectToAction("PrikazOdjece");
        }
        public ActionResult PrikazVelicine(int OdjecaID)
        {
            Odjeca o = _db.Odjeca.Where(o => o.OdjecaID == OdjecaID).Include(o => o.Proizvod).SingleOrDefault(); 


            OdjecaVelicinePrikazVM model = new OdjecaVelicinePrikazVM
            {
                OdjecaID = OdjecaID,
                imageUrl = o.Proizvod.ImageUrl,
                velicine = _db.OdjecaVelicine.Where(o=>o.OdjecaID==OdjecaID).Select(o=>new OdjecaVelicinePrikazVM.Row
                {
                    Velicina = o.Velicina,
                    kolicina = o.kolicina

                }).ToList()


            };


            return View(model);
        }
        public ActionResult DodajVelicinuOdjece(int OdjecaID)
        {
            DodajOdjecaVelicineVM model = new DodajOdjecaVelicineVM
            {
                OdjecaID = OdjecaID
            };
            return View("DodajVelicine", model);
        }

        public ActionResult SpremiVelicinuOdjece(DodajOdjecaVelicineVM x)
        {

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
            _db.OdjecaVelicine.Add(o);
            _db.SaveChanges();


            return Redirect("/Administrator/PrikazVelicine?OdjecaID=" + x.OdjecaID);
        }
        #endregion

        #region Obuca
        public ActionResult DodajObucu()
        {

            DodajObucuVM model = new DodajObucuVM
            {
                dobavljaci = _db.Dobavljac.Where(d => d.DobavljacKategorijaID == 3).Select(d => new SelectListItem
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
            Proizvod p;
            Obuca o;

            if (x.ObucaID == 0)//dodavanje nove obuce
            {
                p = new Proizvod
                {
                    Naziv = x.Naziv,
                    Cijena = x.Cijena,
                    DobavljacID = x.DobavljacID,
                    datumDodavanja = DateTime.Now,
                    ImageUrl = ""
                };
                _db.Proizvod.Add(p);
                _db.SaveChanges();
                o = new Obuca
                {
                    ProizvodID = p.ProizvodID,
                    Spol = x.Spol,
                    Namjena = x.Namjena,
                    Brend = x.Brend,
                    Opis = x.Opis
                };
                _db.Obuca.Add(o);
                _db.SaveChanges();

            }
            else//izmijena
            {
                o = _db.Obuca.Where(o => o.ObucaID == x.ObucaID).FirstOrDefault();
                p = _db.Proizvod.Where(p => p.ProizvodID == o.ProizvodID).FirstOrDefault();



                p.Naziv = x.Naziv;
                p.Cijena = x.Cijena;
                p.DobavljacID = x.DobavljacID;

                o.Spol = x.Spol;
                o.Namjena = x.Namjena;
                o.Brend = x.Brend;
                o.Opis = x.Opis;
                _db.SaveChanges();
            }



            if (x.slika != null)
                UploadFile(x.slika, p);
            return RedirectToAction("PrikazObuce");

        }
        public ActionResult PrikazObuce()
        {
            ObucaPrikazVM model = new ObucaPrikazVM
            {
                podaciObuca = _db.Obuca.Select(o=>new ObucaPrikazVM.Obuca
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
            Obuca o = _db.Obuca.Where(o => o.ObucaID == ObucaID).Include(o => o.Proizvod).SingleOrDefault();

            DodajObucuVM model = new DodajObucuVM
            {
                ProizvodID = o.ProizvodID,
                ObucaID = o.ObucaID,
                Naziv = o.Proizvod.Naziv,
                Cijena = o.Proizvod.Cijena,
                DobavljacID = o.Proizvod.DobavljacID,
                dobavljaci = _db.Dobavljac.Where(d => d.DobavljacKategorijaID == 3).Select(d => new SelectListItem
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

        public ActionResult PrikazVelicinaZaObucu(int ObucaID)
        {
            Obuca o = _db.Obuca.Where(o => o.ObucaID == ObucaID).Include(o => o.Proizvod).SingleOrDefault();
            ObucaVelicinePrikazVM model = new ObucaVelicinePrikazVM
            {
                ObucaID = o.ObucaID,
                imageUrl = o.Proizvod.ImageUrl,
                velicine = _db.ObucaVelicine.Where(o=>o.ObucaID==ObucaID).Select(o=>new ObucaVelicinePrikazVM.Row
                {
                    Velicina = o.Velicina,
                    kolicina = o.kolicina

                }).ToList()

            };
            
            return View(model);
        }

        public ActionResult DodajVelicinuObuce(int ObucaID)
        {

            DodajVelicinuObuceVM model = new DodajVelicinuObuceVM
            {
                ObucaID = ObucaID
            };

            return View(model);
        }

        public ActionResult SpremiVelicinuObuce(DodajVelicinuObuceVM x)
        {
            if (!ModelState.IsValid)
            {
                return View("DodajVelicinuObuce", x);
            }
            ObucaVelicine ov = new ObucaVelicine
            {
                ObucaID = x.ObucaID,
                Velicina = x.Velicina,
                kolicina = x.kolicina
            };
            _db.ObucaVelicine.Add(ov);
            _db.SaveChanges();
            return Redirect("/Administrator/PrikazVelicinaZaObucu?ObucaID=" + x.ObucaID);
        }

        public ActionResult ObrisiObucu(int ObucaID)
        {
            Obuca o = _db.Obuca.Where(o => o.ObucaID == ObucaID).SingleOrDefault();
            Proizvod p = _db.Proizvod.Where(p => p.ProizvodID == o.ProizvodID).SingleOrDefault();

            int brojac = _db.ObucaVelicine.Where(o => o.ObucaID ==ObucaID).Count();
            for (int i = 0; i < brojac; i++)
            {
                ObucaVelicine ov = _db.ObucaVelicine.Where(o => o.ObucaID == ObucaID).FirstOrDefault();
                _db.ObucaVelicine.Remove(ov);
                _db.SaveChanges();
            }

            _db.Obuca.Remove(o);
            _db.Proizvod.Remove(p);
            _db.SaveChanges();


            return RedirectToAction("PrikazObuce");
        }
        #endregion

        #region Dodatci

        public ActionResult DodajDodatak()
        {

            DodatakDodajVM model=new DodatakDodajVM
            {
                dobavljaci = _db.Dobavljac.Where(d => d.DobavljacKategorijaID == 4).Select(d => new SelectListItem
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


            Proizvod p;
            Dodatak d;

            if (x.DodatakID == 0) //Dodavanje
            {
                p = new Proizvod
                {
                    Naziv = x.Naziv,
                    Cijena = x.Cijena,
                    DobavljacID = x.DobavljacID,
                    datumDodavanja = DateTime.Now,
                    ImageUrl = ""
                };
                _db.Proizvod.Add(p);
                _db.SaveChanges();
                d = new Dodatak
                {
                    ProizvodID = p.ProizvodID,
                    TipDodatka = x.TipDodatka,
                    Kolicina = x.Kolicina,
                    Namjena = x.Namjena
                };
                _db.Dodatak.Add(d);
                _db.SaveChanges();
            }
            else //Izmijena
            {
                d = _db.Dodatak.Where(d => d.DodatakID == x.DodatakID).SingleOrDefault();
                p = _db.Proizvod.Where(p => p.ProizvodID == d.ProizvodID).SingleOrDefault();

                p.Naziv = x.Naziv;
                p.Cijena = x.Cijena;
                p.DobavljacID = x.DobavljacID;

                d.TipDodatka = x.TipDodatka;
                d.Kolicina = x.Kolicina;
                d.Namjena = x.Namjena;
                _db.SaveChanges();
            }

            if (x.slika != null)
                UploadFile(x.slika, p);


            return RedirectToAction("PrikazDodataka");
        }
        public ActionResult PrikazDodataka()
        {
            DodatakPrikazVM model = new DodatakPrikazVM
            {
                podaciDodatci = _db.Dodatak.Select(d=>new DodatakPrikazVM.Row
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
            Dodatak d = _db.Dodatak.Where(d => d.DodatakID == id).Include(d => d.Proizvod).SingleOrDefault();
            DodatakDodajVM model=new DodatakDodajVM
            {
                ProizvodID = d.ProizvodID,
                DodatakID = d.DodatakID,
                Naziv = d.Proizvod.Naziv,
                Cijena = d.Proizvod.Cijena,
                DobavljacID = d.Proizvod.DobavljacID,
                dobavljaci = _db.Dobavljac.Where(d => d.DobavljacKategorijaID == 4).Select(d => new SelectListItem
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
        public ActionResult ObrisiDodatak(int id)
        {
            Dodatak d = _db.Dodatak.Where(s => s.DodatakID == id).SingleOrDefault();
            Proizvod p = _db.Proizvod.Where(p => p.ProizvodID == d.ProizvodID).SingleOrDefault();

            _db.Proizvod.Remove(p);
            _db.Dodatak.Remove(d);

            _db.SaveChanges();
            return RedirectToAction("PrikazDodataka");
        } 
       #endregion


        #region Kupac

        public ActionResult DodajKupca()
        {
            DodajKupacVM model = new DodajKupacVM
            {
                gradovi = _db.Gradovi.Select(g=>new SelectListItem
                {
                    Value = g.GradID.ToString(),
                    Text=g.Naziv

                }).ToList(),
        dani=AdministratorHelper.GenerateDaysList(),
        mjeseci = AdministratorHelper.GenerateMonthsList(),
        godine = AdministratorHelper.GenerateYearsList()
             
            };


            return View(model);
        }

        public ActionResult SpremiKupca(DodajKupacVM x)
        {


            Korisnik kor = _db.Korisnik.Where(p => p.EmailAdresa == x.EmailAdresa).SingleOrDefault();


            KorisnikNalog kn = _db.KorisnikNalog.Where(k => k.KorisnickoIme == x.KorisnickoIme).SingleOrDefault();

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

            if (x.KorisnikID == 0)
            {
                if (kor != null || kn != null)
                {
                    x.gradovi = _db.Gradovi.Select(g => new SelectListItem
                    {
                        Value = g.GradID.ToString(),
                        Text = g.Naziv

                    }).ToList();
                    x.dani = AdministratorHelper.GenerateDaysList();
                    x.mjeseci = AdministratorHelper.GenerateMonthsList();
                    x.godine = AdministratorHelper.GenerateYearsList();
                    if (kor != null)
                        TempData["error_porukaEmail"] = "E-mail adresa " + x.EmailAdresa + " već postoji!";

                    if (kn != null)
                        TempData["error_porukaUser"] = "korisničko ime " + x.KorisnickoIme + " već postoji!";


                    return View("DodajKupca", x);
                }
            }
            else
            {
                if (kor != null||kn != null)
                {
                    int i= 0;
                    x.gradovi = _db.Gradovi.Select(g => new SelectListItem
                    {
                        Value = g.GradID.ToString(),
                        Text = g.Naziv

                    }).ToList();
                    x.dani = AdministratorHelper.GenerateDaysList();
                    x.mjeseci = AdministratorHelper.GenerateMonthsList();
                    x.godine = AdministratorHelper.GenerateYearsList();
                    if (kor != null)
                    {
                        if (kor.KorisnikID != x.KorisnikID )
                        {
                            TempData["error_porukaEmail"] = "E-mail adresa " + x.EmailAdresa + " već postoji!";
                            i = 1;
                        }
                    }

                    if (kn != null)
                    {
                        if (kn.KorisnikNalogID != x.KorisnikNalogID )
                        {
                            TempData["error_porukaUser"] = "korisničko ime " + x.KorisnickoIme + " već postoji!";
                            i = 1;
                        }
                    }

                    if(i==1)
                    return View("UrediKupca", x);
                }


            }



            if (x.KorisnikID == 0)
            {

                string DatumRodjenja = x.MjesecRodjenja.ToString() + "-" + x.DanRodjenja.ToString() + "-" +
                                       x.GodinaRodjenja.ToString();

                KorisnikNalog k = new KorisnikNalog
                {
                    KorisnickoIme = x.KorisnickoIme,
                    Lozinka = x.Lozinka,
                    VrstaKorisnikaID = 2

                };
                _db.KorisnikNalog.Add(k);
                _db.SaveChanges();
                Korisnik korisnik=new Korisnik
                {
                    Ime = x.Ime,
                    Prezime = x.Prezime,
                    //DatumRodjenja = x.DatumRodjenja,
                    DatumRodjenja = Convert.ToDateTime(DatumRodjenja),
                    EmailAdresa = x.EmailAdresa,
                    BrojTelefona = x.BrojTelefona,
                    Adresa = x.EmailAdresa,
                    GradID = x.GradID,
                    KorisnikNalogID = k.KorisnikNalogID

                };
                _db.Korisnik.Add(korisnik);
                _db.SaveChanges();
            }
            else
            {
                string DatumRodjenja = x.MjesecRodjenja.ToString() + "-" + x.DanRodjenja.ToString() + "-" +
                                       x.GodinaRodjenja.ToString();
                Korisnik korisnikUpdate = _db.Korisnik.Where(k => k.KorisnikID == x.KorisnikID).SingleOrDefault();
                KorisnikNalog KorisnikNalogUpdate = _db.KorisnikNalog
                    .Where(k => k.KorisnikNalogID == korisnikUpdate.KorisnikNalogID).SingleOrDefault();

                KorisnikNalogUpdate.KorisnickoIme = x.KorisnickoIme;
                
                if (x.Lozinka2 != null)
                    KorisnikNalogUpdate.Lozinka = x.Lozinka2;

                korisnikUpdate.Ime = x.Ime;
                korisnikUpdate.Prezime = x.Prezime;
                korisnikUpdate.DatumRodjenja = Convert.ToDateTime(DatumRodjenja);
                korisnikUpdate.EmailAdresa = x.EmailAdresa;
                korisnikUpdate.BrojTelefona = x.BrojTelefona;
                korisnikUpdate.Adresa = x.Adresa;
                korisnikUpdate.GradID = x.GradID;
                _db.SaveChanges();
            }


            return RedirectToAction("PrikazKupaca");
        }

        public ActionResult PrikazKupaca()
        {
            KupacPrikazVM model = new KupacPrikazVM
            {
                podaciKupci = _db.Korisnik.Where(k=>k.KorisnickiNalog.VrstaKorisnikaID==2).Select(k=>new KupacPrikazVM.Row
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
    
            Korisnik k = _db.Korisnik.Where(k => k.KorisnikID == KorisnikID).Include(k => k.KorisnickiNalog)
                .SingleOrDefault();
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
                gradovi = _db.Gradovi.Select(g => new SelectListItem
                {
                    Value = g.GradID.ToString(),
                    Text = g.Naziv

                }).ToList(),
                KorisnickoIme = k.KorisnickiNalog.KorisnickoIme,
                Lozinka = k.KorisnickiNalog.Lozinka,
                dani = AdministratorHelper.GenerateDaysList(),
                mjeseci = AdministratorHelper.GenerateMonthsList(),
                godine = AdministratorHelper.GenerateYearsList()

            };


            return View(model);
        }

        public ActionResult ObrisiKupca(int KorisnikID)
        {
            Korisnik k = _db.Korisnik.Where(k => k.KorisnikID == KorisnikID).SingleOrDefault();
            KorisnikNalog kn = _db.KorisnikNalog.Where(n => n.KorisnikNalogID == k.KorisnikNalogID).SingleOrDefault();
            _db.Korisnik.Remove(k);
            _db.KorisnikNalog.Remove(kn);
            _db.SaveChanges();
            return RedirectToAction("PrikazKupaca");
        }
        #endregion

        #region Admin
        public ActionResult DodajAdmina()
        {
            DodajAdminVM model = new DodajAdminVM
            {
                gradovi = _db.Gradovi.Select(g => new SelectListItem
                {
                    Value = g.GradID.ToString(),
                    Text = g.Naziv

                }).ToList(),
                dani = AdministratorHelper.GenerateDaysList(),
                mjeseci = AdministratorHelper.GenerateMonthsList(),
                godine = AdministratorHelper.GenerateYearsList()

            };


            return View(model);
        }

        public ActionResult SpremiAdmina(DodajAdminVM x)
        {
            Korisnik kor = _db.Korisnik.Where(p => p.EmailAdresa == x.EmailAdresa).SingleOrDefault();


            KorisnikNalog kn = _db.KorisnikNalog.Where(k => k.KorisnickoIme == x.KorisnickoIme).SingleOrDefault();

         

            if (x.KorisnikID == 0)
            {
                if (kor != null || kn != null)
                {
                    x.gradovi = _db.Gradovi.Select(g => new SelectListItem
                    {
                        Value = g.GradID.ToString(),
                        Text = g.Naziv

                    }).ToList();
                    x.dani = AdministratorHelper.GenerateDaysList();
                    x.mjeseci = AdministratorHelper.GenerateMonthsList();
                    x.godine = AdministratorHelper.GenerateYearsList();
                    if (kor != null)
                        TempData["error_porukaEmail"] = "E-mail adresa " + x.EmailAdresa + " već postoji!";

                    if (kn != null)
                        TempData["error_porukaUser"] = "korisničko ime " + x.KorisnickoIme + " već postoji!";


                    return View("DodajAdmina", x);
                }
            }
            else
            {
                if (kor != null || kn != null)
                {
                    int i = 0;
                    x.gradovi = _db.Gradovi.Select(g => new SelectListItem
                    {
                        Value = g.GradID.ToString(),
                        Text = g.Naziv

                    }).ToList();
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


            }



            if (x.KorisnikID == 0)
            {

                string DatumRodjenja = x.MjesecRodjenja.ToString() + "-" + x.DanRodjenja.ToString() + "-" +
                                       x.GodinaRodjenja.ToString();

                KorisnikNalog k = new KorisnikNalog
                {
                    KorisnickoIme = x.KorisnickoIme,
                    Lozinka = x.Lozinka,
                    VrstaKorisnikaID = 1

                };
                _db.KorisnikNalog.Add(k);
                _db.SaveChanges();
                Korisnik korisnik = new Korisnik
                {
                    Ime = x.Ime,
                    Prezime = x.Prezime,
                    DatumRodjenja = Convert.ToDateTime(DatumRodjenja),
                    EmailAdresa = x.EmailAdresa,
                    BrojTelefona = x.BrojTelefona,
                    Adresa = x.EmailAdresa,
                    GradID = x.GradID,
                    KorisnikNalogID = k.KorisnikNalogID

                };
                _db.Korisnik.Add(korisnik);
                _db.SaveChanges();
            }
            else
            {
                string DatumRodjenja = x.MjesecRodjenja.ToString() + "-" + x.DanRodjenja.ToString() + "-" +
                                       x.GodinaRodjenja.ToString();
                Korisnik korisnikUpdate = _db.Korisnik.Where(k => k.KorisnikID == x.KorisnikID).SingleOrDefault();
                KorisnikNalog KorisnikNalogUpdate = _db.KorisnikNalog
                    .Where(k => k.KorisnikNalogID == korisnikUpdate.KorisnikNalogID).SingleOrDefault();

                KorisnikNalogUpdate.KorisnickoIme = x.KorisnickoIme;

                if(x.Lozinka2!=null)
                KorisnikNalogUpdate.Lozinka = x.Lozinka2;

                korisnikUpdate.Ime = x.Ime;
                korisnikUpdate.Prezime = x.Prezime;
                korisnikUpdate.DatumRodjenja = Convert.ToDateTime(DatumRodjenja);
                korisnikUpdate.EmailAdresa = x.EmailAdresa;
                korisnikUpdate.BrojTelefona = x.BrojTelefona;
                korisnikUpdate.Adresa = x.Adresa;
                korisnikUpdate.GradID = x.GradID;
                _db.SaveChanges();
            }

            return RedirectToAction("PrikazAdmina","Administrator");
        }

        public ActionResult UrediAdmina(int AdminID)
        {

            Korisnik k = _db.Korisnik.Where(k => k.KorisnikID == AdminID).Include(k => k.KorisnickiNalog)
                .SingleOrDefault();
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
                gradovi = _db.Gradovi.Select(g => new SelectListItem
                {
                    Value = g.GradID.ToString(),
                    Text = g.Naziv

                }).ToList(),
                KorisnickoIme = k.KorisnickiNalog.KorisnickoIme,
                Lozinka = k.KorisnickiNalog.Lozinka,
                dani = AdministratorHelper.GenerateDaysList(),
                mjeseci = AdministratorHelper.GenerateMonthsList(),
                godine = AdministratorHelper.GenerateYearsList()

            };




            return View(model);
        }

        public ActionResult ObrisiAdmina(int AdminID)
        {
            Korisnik k = _db.Korisnik.Where(k => k.KorisnikID == AdminID).SingleOrDefault();
            KorisnikNalog kn = _db.KorisnikNalog.Where(n => n.KorisnikNalogID == k.KorisnikNalogID).SingleOrDefault();
            _db.Korisnik.Remove(k);
            _db.KorisnikNalog.Remove(kn);
            _db.SaveChanges();
            return RedirectToAction("PrikazAdmina");
        }
        public ActionResult PrikazAdmina()
        {
            AdminPrikazVM model = new AdminPrikazVM
            {
                podaciAdmin = _db.Korisnik.Where(k => k.KorisnickiNalog.VrstaKorisnikaID == 1).Select(k =>
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
            Korisnik k = _db.Korisnik.Where(k => k.KorisnikID == KorisnikID).SingleOrDefault();
            KorisnikNalog kn = _db.KorisnikNalog.Where(n => n.KorisnikNalogID == k.KorisnikNalogID).SingleOrDefault();
            kn.VrstaKorisnikaID = 1;
            _db.SaveChanges();
            return RedirectToAction("PrikazKupaca");
        }
        public ActionResult UkloniUloguAdmina(int AdminID)
        {
            Korisnik k = _db.Korisnik.Where(k => k.KorisnikID == AdminID).SingleOrDefault();
            KorisnikNalog kn = _db.KorisnikNalog.Where(n => n.KorisnikNalogID == k.KorisnikNalogID).SingleOrDefault();
            kn.VrstaKorisnikaID = 2;
            _db.SaveChanges();
            return RedirectToAction("PrikazAdmina");
        }
        #endregion

    }
}
