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
   public class UserInterfaceService : IUserInterfaceService
    {
        IKupacRepository<Proizvod> proizvodRepository;
        IKupacRepository<Grad> gradRepository;
        IKupacRepository<Narudzba> narudzbaRepository;
        IKupacRepository<NarudzbaStavke> narudzbaStavkeRepository;
        IKupacRepository<KorisnikKartice> karticeRepository;



        public UserInterfaceService(IKupacRepository<Proizvod> _proizvodRepository, IKupacRepository<Grad> _gradRepository,
           IKupacRepository<Narudzba> _narudzbaRepository, IKupacRepository<NarudzbaStavke> _narudzbaStavkeRepository,
           IKupacRepository<KorisnikKartice> _karticeRepositroy)
        { 
            proizvodRepository = _proizvodRepository;
            gradRepository = _gradRepository;
            narudzbaRepository = _narudzbaRepository;
            narudzbaStavkeRepository = _narudzbaStavkeRepository;
            karticeRepository = _karticeRepositroy;
        }
        public Proizvod GetProizvodById(int id)
        {
            return proizvodRepository.GetProizvode().Where(o => o.ProizvodID == id).SingleOrDefault();
        }

        public IEnumerable<Grad> GetAllGradove()
        {
            return gradRepository.GetGrad();
        }

        public Grad getGradByID(int id)
        {
            return gradRepository.GetGrad().Where(a => a.GradID == id).SingleOrDefault();
        }
        public void DodajNarudjbaStavku(NarudzbaStavke n)
        {
            narudzbaStavkeRepository.Add(n);
        }

        public void DodajNarudjbu(Narudzba n)
        {
            narudzbaRepository.Add(n);
        }

        public IEnumerable<KorisnikKartice> GetAktivneKarticeByKorisnikID(int id)
        {
            return karticeRepository.GetKorisnickeKartice().Where(x => x.KorisnikID == id && x.Aktivna == true);
        }


    }
}
