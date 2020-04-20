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
    
    public class OrdersService : IOrdersService
    {
        IAdministratorRepository<Narudzba> narudzbeRepository;
        IAdministratorRepository<NarudzbaStavke> narudzbaStavkeRepository;
        IAdministratorRepository<Transakcije> transakcijeRepository;
        public OrdersService(IAdministratorRepository<Narudzba> _narudzbeRepository, IAdministratorRepository<NarudzbaStavke> _narudzbaStavkeRepository,
            IAdministratorRepository<Transakcije> _transakcijeRepository)
        {
            narudzbeRepository = _narudzbeRepository;
            narudzbaStavkeRepository= _narudzbaStavkeRepository;
            transakcijeRepository = _transakcijeRepository;
        }
        public IEnumerable<Narudzba> GetAllNarudzbe()
        {
            return narudzbeRepository.GetNarudzbe();
        }
        public IEnumerable<NarudzbaStavke> GetAllNarudzbaStavke(int id)
        {
            return narudzbaStavkeRepository.GetNarudzbeStavke().Where(n => n.NarudzbaID == id);
        }
        public Narudzba NarudzbaFind(int id)
        {
            return narudzbeRepository.GetNarudzbe().Where(n => n.NarudzbaID == id).SingleOrDefault();
        }
        public void NarudzbaUpdate(Narudzba n)
        {
            narudzbeRepository.Update(n);
        }
        public void DodajTransakciju(Transakcije t)
        {
            transakcijeRepository.Add(t);
        }
        public void TransakcijaUpdate(Transakcije t)
        {
            transakcijeRepository.Update(t);
        }
        public Transakcije TransakcijeFindByNarudzbaID(int id)
        {
            return transakcijeRepository.GetTransakcije().Where(t => t.NarudzbaID == id).SingleOrDefault();
        }
    }
}
