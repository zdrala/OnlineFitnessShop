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

    public class DobavljaciService : IDobavljaciService
    {
        IAdministratorRepository<Dobavljac> dobavljacRepository;
        IAdministratorRepository<Grad> gradoviRepository;
        IAdministratorRepository<DobavljacKategorije> dobavljacKategorijeRepository;
        public DobavljaciService(IAdministratorRepository<Dobavljac> _dobavljaciRepository,IAdministratorRepository<Grad> _gradoviRepository,IAdministratorRepository<DobavljacKategorije> _dobavljacKategorijeRepository)
        {
            dobavljacRepository = _dobavljaciRepository;
            gradoviRepository = _gradoviRepository;
            dobavljacKategorijeRepository = _dobavljacKategorijeRepository;
        }

        public void DobavljacDelete(Dobavljac d)
        {
            dobavljacRepository.Remove(d);
        }

        public Dobavljac DobavljacFind(int id)
        {
            return dobavljacRepository.GetDobavljac().Where(d => d.DobavljacID == id).SingleOrDefault();
        }

        public void DobavljacUpdate(Dobavljac d)
        {
            dobavljacRepository.Update(d);
        }

        public void DodajDobavljaca(Dobavljac d)
        {
            dobavljacRepository.Add(d);
        }

        public IEnumerable<Dobavljac> GetAllDobavljace()
        {
            return dobavljacRepository.GetDobavljac();
        }

        public List<SelectListItem> GetAllDobavljaciKategorije()
        {
            List<SelectListItem> dobavljaciKategorije = dobavljacKategorijeRepository.GetKategorijuDobavljaca().Select(d=>new SelectListItem
            {
                Value=d.DobavljacKategorijaID.ToString(),
                Text=d.nazivKategorije
            }).ToList();
            return dobavljaciKategorije;

        }

        public List<SelectListItem> GetAllGradove()
        {
            List<SelectListItem> gradovi = gradoviRepository.GetGrad().Select(g => new SelectListItem
            {
                Value=g.GradID.ToString(),
                Text=g.Naziv
            }).ToList();
            return gradovi;
        }

        public IEnumerable<Dobavljac> GetDobavljaceSuplementacije()
        {
            
           IEnumerable<Dobavljac> dobavljaciSupl= dobavljacRepository.GetDobavljac().Where(d => d.DobavljacKategorijaID == 1);
            return dobavljaciSupl;
        }
        public IEnumerable<Dobavljac> GetDobavljaceOdjece()
        {
            IEnumerable<Dobavljac> dobavljaciOdjece = dobavljacRepository.GetDobavljac().Where(d => d.DobavljacKategorijaID == 2);
            return dobavljaciOdjece;
        }
        public IEnumerable<Dobavljac> GetDobavljaceObuce()
        {
            IEnumerable<Dobavljac> dobavljaciObuce = dobavljacRepository.GetDobavljac().Where(d => d.DobavljacKategorijaID == 3);
            return dobavljaciObuce;
        }
        public IEnumerable<Dobavljac> GetDobavljaceDodataka()
        {
            IEnumerable<Dobavljac> dobavljaciDod = dobavljacRepository.GetDobavljac().Where(d => d.DobavljacKategorijaID == 4);
            return dobavljaciDod;
        }
    }
}
