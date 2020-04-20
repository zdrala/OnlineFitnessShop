using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySeminarski.Model;
namespace ClassLibrarySeminarski
{
    public interface IAdministratorRepository<TEntity>
    {
        void Add(TEntity obj);
        void Remove(TEntity obj);
        void Update(TEntity obj);

        IEnumerable<Proizvod> GetProizvode();
        IEnumerable<Dobavljac> GetDobavljac();
        IEnumerable<Grad> GetGrad();
        IEnumerable<DobavljacKategorije> GetKategorijuDobavljaca();

        IEnumerable<Suplementacija> GetSuplementacije();
        IEnumerable<Odjeca> GetOdjecu();
        IEnumerable<Obuca> GetObucu();
        IEnumerable<Dodatak> GetDodatke();
        IEnumerable<OdjecaVelicine> GetOdjecaVelicine();
        IEnumerable<ObucaVelicine> GetObucaVelicine();
        IEnumerable<SuplementacijaKategorije> GetKategorijuSuplementacije();


        IEnumerable<Korisnik> GetKorisnike();
        IEnumerable<KorisnikNalog> GetKorisnickeNaloge();

        //Narudzbe
        IEnumerable<Narudzba> GetNarudzbe();
        IEnumerable<Transakcije> GetTransakcije();
        IEnumerable<NarudzbaStavke> GetNarudzbeStavke();

        //Komentari
        IEnumerable<KomentarProizvod> GetKomentare();
    }
}
