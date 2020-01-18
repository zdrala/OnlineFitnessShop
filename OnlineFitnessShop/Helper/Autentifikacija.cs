using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineFitnessShop.Models;
using Microsoft.AspNetCore.Http;
using ClassLibrarySeminarski.Model;
using OnlineFitnessShop.Helpers;

namespace OnlineFitnessShop.Helpers
{
    public class Autenfikacija
    {
        public static void SetLogiraniKorisnik(HttpContext context, Korisnik korisnik)
        {
            context.Session.Set("logiraniKorisnik", korisnik);
        }

        public static Korisnik GetLogiraniKorisnik(HttpContext context)
        {
            return context.Session.Get<Korisnik>("logiraniKorisnik");
        }
    }
}