using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace OnlineFitnessShop.Core.Interfaces
{
    public interface IProizvodiService
    {
        IEnumerable<Suplementacija> GetAllSuplemente();
        IEnumerable<Odjeca> GetAllOdjecu();
        IEnumerable<Obuca> GetAllObucu();
        IEnumerable<Dodatak> GetAllDodatke();
        IEnumerable<OdjecaVelicine> GetVelicineOdredjenjeOdjece(int odjecaID);
        IEnumerable<OdjecaVelicine> GetVelicineOdredjenjeOdjeceOutOfStock(int odjecaID);

        IEnumerable<ObucaVelicine> GetVelicineOdredjenjeObuceOutOfStock(int obucaID);
        IEnumerable<ObucaVelicine> GetVelicineOdredjenjeObuce(int obucaID);

        IEnumerable<KomentarProizvod> GetAllKomentare();

        void dodajProizvod(Proizvod p);

        void dodajSuplement(Suplementacija s);

        void dodajOdjecu(Odjeca o);
        void dodajObucu(Obuca o);
        void dodajDodatak(Dodatak d);
        void dodajVelicinuOdjece(OdjecaVelicine ov);
        void dodajVelicinuObuce(ObucaVelicine ov);
        Proizvod ProizvodFind(int id);
        Suplementacija SuplementacijaFind(int id);
        Odjeca OdjecaFind(int id);
        Obuca ObucaFind(int id);
        Dodatak DodatakFind(int id);
        OdjecaVelicine OdjecaVelicineFindFirst(int id);
        OdjecaVelicine OdjecaVelicineFind(int id);
        OdjecaVelicine OdjecaVelicinaIsAdded(int odjecaID, string velicina);
        ObucaVelicine ObucaVelicineFindFirst(int id);
        ObucaVelicine ObucaVelicineFind(int id);
        ObucaVelicine ObucaVelicinaIsAdded(int obucaID, string velicina);
        void OdjecaVelicineDelete(OdjecaVelicine ov);
        void ObucaVelicineDelete(ObucaVelicine ov);
        void ProizvodUpdate(Proizvod p);

        void SuplementacijaUpdate(Suplementacija s);

        void OdjecaVelicinaUpdate(OdjecaVelicine ov);
        void ObucaVelicinaUpdate(ObucaVelicine ov);
        void OdjecaUpdate(Odjeca o);

        void ObucaUpdate(Obuca o);
        void DodatakUpdate(Dodatak d);
        int OdjecaVelicineCount(int id);
        int OdjecaVelicineCountOutofStock(int id);
        int ObucaVelicineCountOutofStock(int id);
        int ObucaVelicineCount(int id);
        void ProizvodDelete(Proizvod p);
        void SuplementacijaDelete(Suplementacija s);
        void OdjecaDelete(Odjeca o);
        void ObucaDelete(Obuca o);
        void DodatakDelete(Dodatak d);
        List<SelectListItem> GetAllSuplementacijaKategorije();


        //
        Odjeca OdjecaFindByProizvodID(int id);
        Obuca ObucaFindByProizvodID(int id);
        int OdjecaVelicineFindByVel(int OdjecaID,string velicina);
        int ObucaVelicineFindByVel(int ObucaID, string velicina);
        OdjecaVelicine OdjecaVelicinaFindByOdjecaID_Velicina(int odjecaID, string velicina);
        ObucaVelicine ObucaVelicinaFindByObucaID_Velicina(int obucaID, string velicina);
        Suplementacija SuplementacijaFindByProizvodID(int id);
        Dodatak DodatakFindByProizvodID(int id);

        KomentarProizvod KomentarProizvodFind(int id);
        void KomentarProizvodDelete(KomentarProizvod kp);
    }
}
