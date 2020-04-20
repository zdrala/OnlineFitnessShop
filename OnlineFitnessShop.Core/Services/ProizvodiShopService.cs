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
   public class ProizvodiShopService : IProizvodiShopService
    {
        IKupacRepository<Suplementacija> suplementacijaRepository;
        IKupacRepository<SuplementacijaKategorije> suplementacijaKategorijeRepository;
        IKupacRepository<Odjeca> odjecaRepository;
        IKupacRepository<OdjecaVelicine> odjecaVelicineRepository;
        IKupacRepository<Proizvod> proizvodRepository;
        IKupacRepository<Obuca> obucaRepository;
        IKupacRepository<ObucaVelicine> obucaVelicineRepository;
        IKupacRepository<Dodatak> dodatakRepository;
        IKupacRepository<KomentarProizvod> komentariRepostory;


        public ProizvodiShopService(IKupacRepository<Suplementacija> _suplementacijaRepository, IKupacRepository<SuplementacijaKategorije> _suplementacijaKategorijeRepository,
            IKupacRepository<Proizvod> _proizvodRepository, IKupacRepository<Odjeca> _odjecaRepository, IKupacRepository<OdjecaVelicine> _odjecaVelicineRepository,
            IKupacRepository<Obuca> _obucaRepository, IKupacRepository<ObucaVelicine> _obucaVelicineRepository, IKupacRepository<Dodatak> _dodatakRepository,
            IKupacRepository<KomentarProizvod> _komentariRepository)
        {
            suplementacijaRepository = _suplementacijaRepository;
            suplementacijaKategorijeRepository = _suplementacijaKategorijeRepository;
            proizvodRepository = _proizvodRepository;
            odjecaRepository = _odjecaRepository;
            odjecaVelicineRepository = _odjecaVelicineRepository;
            obucaRepository = _obucaRepository;
            obucaVelicineRepository = _obucaVelicineRepository;
            dodatakRepository = _dodatakRepository;
            komentariRepostory = _komentariRepository;
        }

        public IEnumerable<Suplementacija> GetAllSuplemente()
        {
            return suplementacijaRepository.GetSuplementacije().Where(a => a.Obrisan == false);
        }
        public IEnumerable<Odjeca> GetAllOdjecu()
        {
            return odjecaRepository.GetOdjecu().Where(a => a.Obrisan == false);
        }
        public IEnumerable<Obuca> GetAllObucu()
        {
            return obucaRepository.GetObucu().Where(a => a.Obrisan == false);
        }
        public IEnumerable<Dodatak> GetAllDodatke()
        {
            return dodatakRepository.GetDodatke().Where(a => a.Obrisan == false);
        }
       
        public IEnumerable<OdjecaVelicine> GetVelicineOdredjenjeOdjece(int odjecaID)
        {
            return odjecaVelicineRepository.GetOdjecaVelicine().Where(o => o.OdjecaID == odjecaID && o.kolicina > 0);
        }
        public IEnumerable<ObucaVelicine> GetVelicineOdredjenjeObuce(int obucaID)
        {
            return obucaRepository.GetObucaVelicine().Where(o => o.ObucaID == obucaID && o.kolicina > 0);
        }
        public List<SelectListItem> GetAllSuplementacijaKategorije()
        {
            List<SelectListItem> kategorije = suplementacijaKategorijeRepository.GetKategorijuSuplementacije().Select(g => new SelectListItem
            {
                Value = g.SuplementacijaKategorijaID.ToString(),
                Text = g.SuplementacijaKategorijaNaziv
            }).ToList();
            return kategorije;
        }

        public Odjeca GetOdjecaByID(int id)
        {
            return odjecaRepository.GetOdjecu().Where(o => o.OdjecaID == id).SingleOrDefault();
        }

        public Obuca GetObucaByID(int id)
        {
            return obucaRepository.GetObucu().Where(o => o.ObucaID == id).SingleOrDefault();
        }

        public Suplementacija GetSuplementByID(int id)
        {
            return suplementacijaRepository.GetSuplementacije().Where(o => o.SuplementacijaID == id).SingleOrDefault();
        }

        public Dodatak GetDodatakByID(int id)
        {
            return dodatakRepository.GetDodatke().Where(o => o.DodatakID == id).SingleOrDefault();
        }

        public Proizvod GetProizvodById(int id)
        {
            return proizvodRepository.GetProizvode().Where(o => o.ProizvodID == id).SingleOrDefault();
        }

        public IEnumerable<KomentarProizvod> GetKomentareByProizvodID(int id)
        {
            return komentariRepostory.GetKomentare().Where(o => o.ProizvodID == id).OrderByDescending(n => n.DatumKomentarisanja);
        }

        public void DodajKomentar(KomentarProizvod a)
        {
            komentariRepostory.Add(a);
        }

    }
}
