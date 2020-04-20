using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace OnlineFitnessShop.Core.Interfaces
{
    public interface IAutentifikacijaService
    {
        IEnumerable<Grad> GetAllGradove();
        Grad getGradByID(int id);
        Korisnik GetKorisnikByUsername(string username);
        void DodajNalog(KorisnikNalog nalog);
        void DodajKorisnika(Korisnik kor);
        Korisnik GetKorisnikByUsernameAndPassword(string username, string password);
        Korisnik GetKorisnikByID(int id);
        void UpdateKorisnik(Korisnik k);
    }
}
