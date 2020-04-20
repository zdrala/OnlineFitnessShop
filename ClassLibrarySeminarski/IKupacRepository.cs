using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySeminarski.Model;
namespace ClassLibrarySeminarski
{
    public interface IKupacRepository<TEntity>
    {
        void Add(TEntity obj);
        void Remove(TEntity obj);
        void Update(TEntity obj);

        IEnumerable<Grad> GetGrad();
        IEnumerable<Proizvod> GetProizvode();
        IEnumerable<Suplementacija> GetSuplementacije();
        IEnumerable<Odjeca> GetOdjecu();
        IEnumerable<Obuca> GetObucu();
        IEnumerable<Dodatak> GetDodatke();
        IEnumerable<OdjecaVelicine> GetOdjecaVelicine();
        IEnumerable<ObucaVelicine> GetObucaVelicine();
        IEnumerable<SuplementacijaKategorije> GetKategorijuSuplementacije();
        IEnumerable<Korisnik> GetKorisnike();
        IEnumerable<KorisnikNalog> GetKorisnickeNaloge();
        IEnumerable<KorisnikKartice> GetKorisnickeKartice();
        IEnumerable<Narudzba> GetNarudzbe();
        IEnumerable<NarudzbaStavke> GetNarudzbaStavke();
        IEnumerable<KomentarProizvod> GetKomentare();

    }
}
