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
    public class UserDataService : IUserDataService
    {
        IKupacRepository<Grad> gradoviRepository;
        IKupacRepository<Korisnik> korisnikRepository;
        IKupacRepository<KorisnikNalog> korisnikNalogRepository;
        IKupacRepository<KorisnikKartice> korisnikKarticeRepository;
        IKupacRepository<Narudzba> narudzbaRepository;
        IKupacRepository<NarudzbaStavke> narudzbaStavkeRepository;
        public UserDataService(IKupacRepository<Grad> _gradoviRepository, IKupacRepository<Korisnik> _korisnikRepository, 
            IKupacRepository<KorisnikNalog> _korisnikNalogRepository, IKupacRepository<KorisnikKartice> _karticeRepository,
            IKupacRepository<Narudzba> _narudzbaRepository, IKupacRepository<NarudzbaStavke> _narudzbaStavkeRepository)
        {
            gradoviRepository = _gradoviRepository;
            korisnikRepository = _korisnikRepository;
            korisnikNalogRepository = _korisnikNalogRepository;
            korisnikKarticeRepository = _karticeRepository;
            narudzbaRepository = _narudzbaRepository;
            narudzbaStavkeRepository = _narudzbaStavkeRepository;
        }
        public IEnumerable<Grad> GetAllGradove()
        {
            return gradoviRepository.GetGrad();
        }
        public Korisnik KorisnikFindByID(int id)
        {
            return korisnikRepository.GetKorisnike().Where(k => k.KorisnikID==id).SingleOrDefault();
        }

        public KorisnikNalog NalogFindByNalogID(int id)
        {
            return korisnikNalogRepository.GetKorisnickeNaloge().Where(o => o.KorisnikNalogID == id).SingleOrDefault();
        }

        public void UpdateKorisnickiNalog(KorisnikNalog a)
        {
            korisnikNalogRepository.Update(a);
        }

        public void UpdateKorisnik (Korisnik a)
        {
            korisnikRepository.Update(a);
        }

        public KorisnikNalog GetKorisnickiNalogByUsername(string a)
        {
            return korisnikNalogRepository.GetKorisnickeNaloge().Where(x => x.KorisnickoIme == a).SingleOrDefault();
        }

        public void DodajKarticu(KorisnikKartice a)
        {
            korisnikKarticeRepository.Add(a);
        }

        public IEnumerable<KorisnikKartice> GetKarticeByKorisnikID(int id)
        {
            return korisnikKarticeRepository.GetKorisnickeKartice().Where(x => x.KorisnikID == id);
        }

        public KorisnikKartice getKarticaById(int id)
        {
            return korisnikKarticeRepository.GetKorisnickeKartice().Where(a => a.KarticaID == id).SingleOrDefault();
        }

        public KorisnikKartice getKarticaByBroj(string broj)
        {
            return korisnikKarticeRepository.GetKorisnickeKartice().Where(a => a.BrojKartice == broj).SingleOrDefault();
        }

        public void KarticaUpdate(KorisnikKartice a)
        {
            korisnikKarticeRepository.Update(a);
        }

        public IEnumerable<Narudzba> GetNarudzbeByKorisnikID(int id)
        {
            return narudzbaRepository.GetNarudzbe().Where(a => a.KorisnikID == id && a.Izbrisano == false);
        }

        public IEnumerable<Narudzba> GetNarudzbeSortirane(int id)
        {
            return narudzbaRepository.GetNarudzbe().Where(a => a.KorisnikID == id && a.Izbrisano == false).OrderByDescending(d => d.DatumKreiranjaNarudjbe);
        }


        public IEnumerable<NarudzbaStavke> GetStavkeNarudzbe(int id)
        {
            return narudzbaStavkeRepository.GetNarudzbaStavke().Where(a => a.NarudzbaID == id);
        }

        public int GetCountOfNarudzbe(int korisnikID)
        {
            return narudzbaRepository.GetNarudzbe().Where(a => a.KorisnikID == korisnikID).Count();
        }
    }
}
