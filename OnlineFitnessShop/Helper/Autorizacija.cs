using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using OnlineFitnessShop.helpers;
using OnlineFitnessShop.Helpers;
using Microsoft.AspNetCore.Http;
namespace OnlineFitnessShop.Helpers

{
    public class AutorizacijaAttribute : TypeFilterAttribute
{
    public AutorizacijaAttribute(bool admin, bool user) : base(typeof(AuthorizeImpl))
    {
        Arguments = new object[] { admin,user };
    }
}

public class AuthorizeImpl : IAsyncActionFilter
{
    public AuthorizeImpl(bool admin,bool user)
    {
            _admin = admin;
            _user = user;
    }
    private readonly bool _admin;
        private readonly bool _user;
    public async Task OnActionExecutionAsync(ActionExecutingContext context,
        ActionExecutionDelegate next)
    {
        Korisnik k = context.HttpContext.Session.Get<Korisnik>("logiraniKorisnik");
        if (k == null)
        {
            if (context.Controller is Controller controller)
            {
                controller.TempData["error_poruka"] = "Niste logirani!";
            }
            context.Result = new RedirectToActionResult("Index", "Autentifikacija", new { area = "" });
            return;
        }

        //MyContext db = context.HttpContext.RequestServices.GetService<MyContext>(); // if needed

        if (_user && k.KorisnickiNalog.VrstaKorisnikaID == 2)
        {
            await next();
            return;
        }

        if (_admin && k.KorisnickiNalog.VrstaKorisnikaID == 1)
        {
            await next();
            return;
        }

   
        if (context.Controller is Controller c1)
        {
            c1.TempData["error_poruka"] = "Nemate pravo pristupa!";
        }
        context.Result = new RedirectToActionResult("NoPermission", "UserInterface", new { area = "" });
    }
}
}