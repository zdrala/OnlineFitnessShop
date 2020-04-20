using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace OnlineFitnessShop.Core.Interfaces
{
    public interface IUserInterfaceService
    {
        Proizvod GetProizvodById(int id);
        IEnumerable<Grad> GetAllGradove();
        Grad getGradByID(int id);
        void DodajNarudjbaStavku(NarudzbaStavke n);
        void DodajNarudjbu(Narudzba n);
        IEnumerable<KorisnikKartice> GetAktivneKarticeByKorisnikID(int id);

    }
}
