using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace OnlineFitnessShop.Core.Interfaces
{
    public interface IOrdersService
    {
        IEnumerable<Narudzba> GetAllNarudzbe();
        IEnumerable<NarudzbaStavke> GetAllNarudzbaStavke(int id);
        Narudzba NarudzbaFind(int id);
        Transakcije TransakcijeFindByNarudzbaID(int id);
        void NarudzbaUpdate(Narudzba n);
        void DodajTransakciju(Transakcije t);

        void TransakcijaUpdate(Transakcije t);
    }
}
