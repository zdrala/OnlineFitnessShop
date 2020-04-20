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
    public class UsersService :IUsersService
    {
        IAdministratorRepository<Grad> gradoviRepository;
        IAdministratorRepository<Korisnik> korisnikRepository;
        IAdministratorRepository<KorisnikNalog> korisnikNalogRepository;
        public UsersService(IAdministratorRepository<Grad> _gradoviRepository, IAdministratorRepository<Korisnik> _korisnikRepository, IAdministratorRepository<KorisnikNalog> _korisnikNalogRepository)
        {
            gradoviRepository = _gradoviRepository;
            korisnikRepository = _korisnikRepository;
            korisnikNalogRepository = _korisnikNalogRepository;
        }
        public List<SelectListItem> GetAllGradove()
        {
            List<SelectListItem> gradovi = gradoviRepository.GetGrad().Select(g => new SelectListItem
            {
                Value = g.GradID.ToString(),
                Text = g.Naziv
            }).ToList();
            return gradovi;
        }
        public IEnumerable<Korisnik> GetAllKupce()
        {
            return korisnikRepository.GetKorisnike().Where(k => k.KorisnickiNalog.VrstaKorisnikaID == 2);
        }
        public IEnumerable<Korisnik> GetAllAdmine()
        {
            return korisnikRepository.GetKorisnike().Where(k => k.KorisnickiNalog.VrstaKorisnikaID == 1);
        }
        public Korisnik KorisnikFind(string email)
        {
            return korisnikRepository.GetKorisnike().Where(k => k.EmailAdresa == email).SingleOrDefault();
        }
        public Korisnik KorisnikFindByID(int id)
        {
            return korisnikRepository.GetKorisnike().Where(k => k.KorisnikID==id).SingleOrDefault();
        }
        public KorisnikNalog KorisnikNalogFind(string username)
        {
            return korisnikNalogRepository.GetKorisnickeNaloge().Where(n => n.KorisnickoIme == username).SingleOrDefault();
        }
        public KorisnikNalog KorisnikNalogFindByID(int? id)
        {
            return korisnikNalogRepository.GetKorisnickeNaloge().Where(n => n.KorisnikNalogID==id).SingleOrDefault();
        }
        public void dodajKorisnikNalog(KorisnikNalog kn)
        {
            korisnikNalogRepository.Add(kn);
        }
        public void dodajKorisnik(Korisnik k)
        {
            korisnikRepository.Add(k);
        }
        public void KorisnikNalogDelete(KorisnikNalog kn)
        {
            korisnikNalogRepository.Remove(kn);
        }
        public void KorisnikDelete(Korisnik k)
        {
            korisnikRepository.Remove(k);
        }
        public void KorisnikNalogUpdate(KorisnikNalog kn)
        {
            korisnikNalogRepository.Update(kn);
        }
        public void KorisnikUpdate(Korisnik k)
        {
            korisnikRepository.Update(k);
        }
    }
}
