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
   public class ProizvodiService : IProizvodiService
    {
        IAdministratorRepository<Suplementacija> suplementacijaRepository;
        IAdministratorRepository<SuplementacijaKategorije> suplementacijaKategorijeRepository;
        IAdministratorRepository<Odjeca> odjecaRepository;
        IAdministratorRepository<OdjecaVelicine> odjecaVelicineRepository;
        IAdministratorRepository<Proizvod> proizvodRepository;
        IAdministratorRepository<Obuca> obucaRepository;
        IAdministratorRepository<ObucaVelicine> obucaVelicineRepository;
        IAdministratorRepository<Dodatak> dodatakRepository;
        IAdministratorRepository<KomentarProizvod> komentariRepository;
        public ProizvodiService(IAdministratorRepository<Suplementacija> _suplementacijaRepository, IAdministratorRepository<SuplementacijaKategorije> _suplementacijaKategorijeRepository,
            IAdministratorRepository<Proizvod> _proizvodRepository, IAdministratorRepository<Odjeca> _odjecaRepository, IAdministratorRepository<OdjecaVelicine> _odjecaVelicineRepository,
            IAdministratorRepository<Obuca> _obucaRepository, IAdministratorRepository<ObucaVelicine> _obucaVelicineRepository, IAdministratorRepository<Dodatak> _dodatakRepository,
            IAdministratorRepository<KomentarProizvod> _komentariRepository)
        {
            suplementacijaRepository = _suplementacijaRepository;
            suplementacijaKategorijeRepository = _suplementacijaKategorijeRepository;
            proizvodRepository = _proizvodRepository;
            odjecaRepository = _odjecaRepository;
            odjecaVelicineRepository = _odjecaVelicineRepository;
            obucaRepository = _obucaRepository;
            obucaVelicineRepository = _obucaVelicineRepository;
            dodatakRepository = _dodatakRepository;
            komentariRepository = _komentariRepository;
        }

        public IEnumerable<Suplementacija> GetAllSuplemente()
        {
            return suplementacijaRepository.GetSuplementacije();
        }
        public IEnumerable<Odjeca> GetAllOdjecu()
        {
            return odjecaRepository.GetOdjecu();
        }
        public IEnumerable<Obuca> GetAllObucu()
        {
            return obucaRepository.GetObucu();
        }
        public IEnumerable<Dodatak> GetAllDodatke()
        {
            return dodatakRepository.GetDodatke();
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

        public void dodajProizvod(Proizvod p)
        {
            proizvodRepository.Add(p);

        }
        public void dodajSuplement(Suplementacija s)
        {
            suplementacijaRepository.Add(s);
        }
        public void dodajOdjecu(Odjeca o)
        {
            odjecaRepository.Add(o);
        }
        public void dodajObucu(Obuca o)
        {
            obucaRepository.Add(o);
        }
        public void dodajDodatak(Dodatak d)
        {
            dodatakRepository.Add(d);
        }
        public Proizvod ProizvodFind(int id)
        {
            return proizvodRepository.GetProizvode().Where(p => p.ProizvodID == id).SingleOrDefault();
        }
        public void ProizvodUpdate(Proizvod p)
        {
            proizvodRepository.Update(p);
        }
        public void SuplementacijaUpdate(Suplementacija s)
        {
            suplementacijaRepository.Update(s);
        }
        public void OdjecaUpdate(Odjeca o)
        {
            odjecaRepository.Update(o);
        }
        public void ObucaUpdate(Obuca o)
        {
            obucaRepository.Update(o);
        }
        public void DodatakUpdate(Dodatak d)
        {
            dodatakRepository.Update(d);
        }
        public void OdjecaVelicinaUpdate(OdjecaVelicine ov)
        {
            odjecaVelicineRepository.Update(ov);
        }
        public void ObucaVelicinaUpdate(ObucaVelicine ov)
        {
            obucaVelicineRepository.Update(ov);
        }
        public int OdjecaVelicineCount(int id)
        {
            return odjecaVelicineRepository.GetOdjecaVelicine().Where(v => v.OdjecaID == id).Count();
        }
        public int OdjecaVelicineCountOutofStock(int id)
        {
            return odjecaVelicineRepository.GetOdjecaVelicine().Where(v => v.OdjecaID == id&&v.kolicina==0).Count();
        }
        public int ObucaVelicineCountOutofStock(int id)
        {
            return obucaRepository.GetObucaVelicine().Where(v => v.ObucaID == id && v.kolicina == 0).Count();
        }
        public int ObucaVelicineCount(int id)
        {
            return obucaVelicineRepository.GetObucaVelicine().Where(v => v.ObucaID == id).Count();
        }
        public Suplementacija SuplementacijaFind(int id)
        {
            return suplementacijaRepository.GetSuplementacije().Where(s => s.SuplementacijaID == id).SingleOrDefault();
        }
        public Odjeca OdjecaFind(int id)
        {
            return odjecaRepository.GetOdjecu().Where(o => o.OdjecaID == id).SingleOrDefault();
        }
        public Obuca ObucaFind(int id)
        {
            return obucaRepository.GetObucu().Where(o => o.ObucaID == id).SingleOrDefault();
        }
        public Dodatak DodatakFind(int id)
        {
            return dodatakRepository.GetDodatke().Where(d => d.DodatakID == id).SingleOrDefault();
        }
        public OdjecaVelicine OdjecaVelicineFindFirst(int id)
        {
            return odjecaVelicineRepository.GetOdjecaVelicine().Where(o => o.OdjecaID == id).FirstOrDefault();
        }
        public ObucaVelicine ObucaVelicineFindFirst(int id)
        {
            return obucaVelicineRepository.GetObucaVelicine().Where(o => o.ObucaID == id).FirstOrDefault();
        }
        public OdjecaVelicine OdjecaVelicineFind(int id)
        {
            return odjecaVelicineRepository.GetOdjecaVelicine().Where(o => o.OdjecaVelicinaID == id).SingleOrDefault();
        }
        public ObucaVelicine ObucaVelicineFind(int id)
        {
            return obucaVelicineRepository.GetObucaVelicine().Where(o => o.ObucaVelicinaID == id).SingleOrDefault();
        }
        public OdjecaVelicine OdjecaVelicinaIsAdded(int odjecaID, string velicina)
        {
            return odjecaVelicineRepository.GetOdjecaVelicine().Where(o=>o.OdjecaID==odjecaID&&o.Velicina==velicina).SingleOrDefault();
        }
        public ObucaVelicine ObucaVelicinaIsAdded(int obucaID,string velicina)
        {
            return obucaRepository.GetObucaVelicine().Where(o => o.ObucaID == obucaID && o.Velicina == velicina).SingleOrDefault();
        }
        public void OdjecaVelicineDelete(OdjecaVelicine ov)
        {
            odjecaVelicineRepository.Remove(ov);
        }
        public void ObucaVelicineDelete(ObucaVelicine ov)
        {
            obucaVelicineRepository.Remove(ov);
        }
        public void ProizvodDelete(Proizvod p)
        {
            proizvodRepository.Remove(p);
        }
        public void SuplementacijaDelete(Suplementacija s)
        {
            suplementacijaRepository.Remove(s);
        }
        public void OdjecaDelete(Odjeca o)
        {
            odjecaRepository.Remove(o);
        }
        public void ObucaDelete(Obuca o)
        {
            obucaRepository.Remove(o);
        }
        public void DodatakDelete(Dodatak d)
        {
            dodatakRepository.Remove(d);
        }
        public IEnumerable<OdjecaVelicine> GetVelicineOdredjenjeOdjece(int odjecaID)
        {
            return odjecaVelicineRepository.GetOdjecaVelicine().Where(o => o.OdjecaID == odjecaID);
        }
        public IEnumerable<OdjecaVelicine> GetVelicineOdredjenjeOdjeceOutOfStock(int odjecaID)
        {
            return odjecaVelicineRepository.GetOdjecaVelicine().Where(o => o.OdjecaID == odjecaID&&o.kolicina==0);
        }
        public IEnumerable<ObucaVelicine> GetVelicineOdredjenjeObuceOutOfStock(int obucaID)
        {
            return obucaRepository.GetObucaVelicine().Where(o => o.ObucaID == obucaID && o.kolicina == 0);
        }
        public IEnumerable<ObucaVelicine> GetVelicineOdredjenjeObuce(int obucaID)
        {
            return obucaRepository.GetObucaVelicine().Where(o => o.ObucaID == obucaID);
        }
        public void dodajVelicinuOdjece(OdjecaVelicine ov)
        {
            odjecaVelicineRepository.Add(ov);
        }
        public void dodajVelicinuObuce(ObucaVelicine ov)
        {
            obucaVelicineRepository.Add(ov);
        }


        //
        public Odjeca OdjecaFindByProizvodID(int id)
        {
            return odjecaRepository.GetOdjecu().Where(o => o.ProizvodID == id).SingleOrDefault();
        }
        public Obuca ObucaFindByProizvodID(int id)
        {
            return obucaRepository.GetObucu().Where(o => o.ProizvodID == id).SingleOrDefault();
        }
        public Suplementacija SuplementacijaFindByProizvodID(int id)
        {
            return suplementacijaRepository.GetSuplementacije().Where(s => s.ProizvodID == id).SingleOrDefault();
        }
        public Dodatak DodatakFindByProizvodID(int id)
        {
            return dodatakRepository.GetDodatke().Where(d => d.ProizvodID == id).SingleOrDefault();
        }
        public int OdjecaVelicineFindByVel(int OdjecaID, string velicina)
        {
            return odjecaVelicineRepository.GetOdjecaVelicine().Where(v => v.OdjecaID == OdjecaID && v.Velicina == velicina).Select(v=>v.kolicina).SingleOrDefault();
        }
        public int ObucaVelicineFindByVel(int ObucaID, string velicina)
        {
            return obucaVelicineRepository.GetObucaVelicine().Where(v => v.ObucaID == ObucaID && v.Velicina == velicina).Select(v => v.kolicina).SingleOrDefault();
        }

        public OdjecaVelicine OdjecaVelicinaFindByOdjecaID_Velicina(int odjecaID, string velicina)
        {
            return odjecaVelicineRepository.GetOdjecaVelicine().Where(v => v.OdjecaID == odjecaID && v.Velicina == velicina).SingleOrDefault();
        }
        public ObucaVelicine ObucaVelicinaFindByObucaID_Velicina(int obucaID, string velicina)
        {
            return obucaVelicineRepository.GetObucaVelicine().Where(v => v.ObucaID == obucaID && v.Velicina == velicina).SingleOrDefault();
        }

        public IEnumerable<KomentarProizvod> GetAllKomentare()
        {
            return komentariRepository.GetKomentare();
        }
        public KomentarProizvod KomentarProizvodFind(int id)
        {
            return komentariRepository.GetKomentare().Where(k => k.KomentarID == id).SingleOrDefault();
        }
        public void KomentarProizvodDelete(KomentarProizvod kp)
        {
            komentariRepository.Remove(kp);
        }
    }
}
