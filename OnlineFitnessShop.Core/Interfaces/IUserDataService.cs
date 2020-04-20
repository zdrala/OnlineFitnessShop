using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace OnlineFitnessShop.Core.Interfaces
{
    public interface IUserDataService
    {
        IEnumerable<Grad> GetAllGradove();
        Korisnik KorisnikFindByID(int id);
        KorisnikNalog NalogFindByNalogID(int id);
        void UpdateKorisnickiNalog(KorisnikNalog a);
        void UpdateKorisnik(Korisnik a);
        KorisnikNalog GetKorisnickiNalogByUsername(string a);
        void DodajKarticu(KorisnikKartice a);
        IEnumerable<KorisnikKartice> GetKarticeByKorisnikID(int id);
        IEnumerable<Narudzba> GetNarudzbeSortirane(int id);
        KorisnikKartice getKarticaById(int id);
        KorisnikKartice getKarticaByBroj(string broj);
        void KarticaUpdate(KorisnikKartice a);
        IEnumerable<Narudzba> GetNarudzbeByKorisnikID(int id);
        IEnumerable<NarudzbaStavke> GetStavkeNarudzbe(int id);
        int GetCountOfNarudzbe(int korisnikID);
    }
}
