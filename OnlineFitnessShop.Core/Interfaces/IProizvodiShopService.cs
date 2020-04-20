using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace OnlineFitnessShop.Core.Interfaces
{
    public interface IProizvodiShopService
    {
        // GET
        IEnumerable<Suplementacija> GetAllSuplemente();
        IEnumerable<Odjeca> GetAllOdjecu();
        IEnumerable<Obuca> GetAllObucu();
        IEnumerable<Dodatak> GetAllDodatke();
        IEnumerable<OdjecaVelicine> GetVelicineOdredjenjeOdjece(int odjecaID);
        IEnumerable<ObucaVelicine> GetVelicineOdredjenjeObuce(int obucaID);
        List<SelectListItem> GetAllSuplementacijaKategorije();
        Odjeca GetOdjecaByID(int id);
        Obuca GetObucaByID(int id);
        Suplementacija GetSuplementByID(int id);
        Dodatak GetDodatakByID(int id);
        Proizvod GetProizvodById(int id);
        IEnumerable<KomentarProizvod> GetKomentareByProizvodID(int id);
        void DodajKomentar(KomentarProizvod a);
    }
}
