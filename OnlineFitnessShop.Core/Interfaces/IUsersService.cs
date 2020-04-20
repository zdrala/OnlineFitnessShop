using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace OnlineFitnessShop.Core.Interfaces
{
    public interface IUsersService
    {
        List<SelectListItem> GetAllGradove();
        IEnumerable<Korisnik> GetAllKupce();
        IEnumerable<Korisnik> GetAllAdmine();

        Korisnik KorisnikFind(string email);
        Korisnik KorisnikFindByID(int id);
        KorisnikNalog KorisnikNalogFindByID(int? id);
        KorisnikNalog KorisnikNalogFind(string username);

        void dodajKorisnikNalog(KorisnikNalog kn);
        void dodajKorisnik(Korisnik k);


        void KorisnikNalogDelete(KorisnikNalog kn);
        void KorisnikDelete(Korisnik k);

        void KorisnikNalogUpdate(KorisnikNalog kn);
        void KorisnikUpdate(Korisnik k);
    }
}
