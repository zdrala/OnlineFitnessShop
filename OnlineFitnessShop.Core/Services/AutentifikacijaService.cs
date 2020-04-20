using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySeminarski.Model;
using OnlineFitnessShop.Core.Interfaces;
using ClassLibrarySeminarski;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OnlineFitnessShop.Core.Services
{
   public class AutentifikacijaService : IAutentifikacijaService
    {
        IKupacRepository<Grad> gradRepository;
        IKupacRepository<Korisnik> korisnikRepository;
        IKupacRepository<KorisnikNalog> korisnikNalogRepository;
        IKupacRepository<VrstaKorisnika> vrstaRepository;

        public AutentifikacijaService(IKupacRepository<Grad> _grad, IKupacRepository<Korisnik> _korisnik, IKupacRepository<KorisnikNalog> _nalog,
            IKupacRepository<VrstaKorisnika> _vrsta)
        {
            gradRepository = _grad;
            korisnikRepository = _korisnik;
            korisnikNalogRepository = _nalog;
            vrstaRepository = _vrsta;
        }
        public IEnumerable<Grad> GetAllGradove()
        {
            return gradRepository.GetGrad();
        }

        public Grad getGradByID(int id)
        {
            return gradRepository.GetGrad().Where(a => a.GradID == id).SingleOrDefault();
        }

        public Korisnik GetKorisnikByUsername(string username)
        {
            return korisnikRepository.GetKorisnike().Where(k => k.KorisnickiNalog.KorisnickoIme == username).SingleOrDefault();
        }

        public void DodajNalog(KorisnikNalog nalog)
        {
            korisnikNalogRepository.Add(nalog);
        }

        public void DodajKorisnika(Korisnik kor)
        {
            korisnikRepository.Add(kor);
        }

        public Korisnik GetKorisnikByUsernameAndPassword(string username,string password)
        {
            return korisnikRepository.GetKorisnike().Where(k => k.KorisnickiNalog.KorisnickoIme == username && k.KorisnickiNalog.Lozinka == password).SingleOrDefault();
        }

        public Korisnik GetKorisnikByID(int id)
        {
            return korisnikRepository.GetKorisnike().Where(k => k.KorisnikID == id).SingleOrDefault();
        }

        public void UpdateKorisnik(Korisnik k)
        {
            korisnikRepository.Update(k);
        }
    }
}
