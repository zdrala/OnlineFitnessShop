using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace OnlineFitnessShop.Core.Interfaces
{
    public interface IDobavljaciService
    {

        void DodajDobavljaca(Dobavljac d);

        Dobavljac DobavljacFind(int id);
        void DobavljacUpdate(Dobavljac d);

        void DobavljacDelete(Dobavljac d);
        IEnumerable<Dobavljac> GetAllDobavljace();

        IEnumerable<Dobavljac> GetDobavljaceSuplementacije();
        IEnumerable<Dobavljac> GetDobavljaceOdjece();
        IEnumerable<Dobavljac> GetDobavljaceObuce();
        IEnumerable<Dobavljac> GetDobavljaceDodataka();

        List<SelectListItem> GetAllGradove();
        List<SelectListItem> GetAllDobavljaciKategorije();
    }
}
