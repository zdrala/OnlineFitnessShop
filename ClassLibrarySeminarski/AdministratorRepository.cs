
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySeminarski.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ClassLibrarySeminarski
{
    public class AdministratorRepository<TEntity> : IAdministratorRepository<TEntity> where TEntity : class
    {

        MyDbContext db;
        DbSet<TEntity> dbSet;

        public AdministratorRepository(MyDbContext _context)
        {
            db = _context;
            dbSet = db.Set<TEntity>();

        }
        public void Add(TEntity obj)
        {
            dbSet.Add(obj);
            db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            dbSet.Remove(obj);
            db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
        public IEnumerable<Dobavljac> GetDobavljac()
        {
            IEnumerable<Dobavljac> dobavljaci = db.Dobavljac.Include(x => x.Grad).Include(x => x.DobavljacKategorija);
            return dobavljaci;
        }

        public IEnumerable<Grad> GetGrad()
        {
            IEnumerable<Grad> gradovi = db.Gradovi.Include(g => g.Kanton);
            return gradovi;
        }

        public IEnumerable<DobavljacKategorije> GetKategorijuDobavljaca()
        {
            IEnumerable<DobavljacKategorije> dobavljaciKategorije = db.DobavljacKategorije;
            return dobavljaciKategorije;
        }

        public IEnumerable<Proizvod> GetProizvode()
        {
            IEnumerable<Proizvod> proizvodi = db.Proizvod.Include(p=>p.Dobavljac);
            return proizvodi;
        }
        public IEnumerable<Suplementacija> GetSuplementacije()
        {
            IEnumerable<Suplementacija> suplementacije = db.Suplementacija.Include(s => s.Kategorija).Include(s=>s.Proizvod);
            return suplementacije;
        }
        public IEnumerable<Odjeca> GetOdjecu()
        {
            IEnumerable<Odjeca> odjeca = db.Odjeca.Include(o => o.Proizvod);
            return odjeca;
        }
        public IEnumerable<Obuca> GetObucu()
        {
            IEnumerable<Obuca> obuca = db.Obuca.Include(o => o.Proizvod);
            return obuca;
        }
        public IEnumerable<Dodatak> GetDodatke()
        {
            IEnumerable<Dodatak> dodatci = db.Dodatak.Include(d => d.Proizvod);
            return dodatci;
        }
        public IEnumerable<OdjecaVelicine> GetOdjecaVelicine()
        {
            IEnumerable<OdjecaVelicine> odjecaVel = db.OdjecaVelicine.Include(v => v.Odjeca);
            return odjecaVel;
        }
        public IEnumerable<ObucaVelicine> GetObucaVelicine()
        {
            IEnumerable<ObucaVelicine> obucaVel = db.ObucaVelicine.Include(v => v.Obuca);
            return obucaVel;
        }
        public IEnumerable<SuplementacijaKategorije> GetKategorijuSuplementacije()
        {
            IEnumerable<SuplementacijaKategorije> katSuplementacije = db.SuplementacijaKategorije;
            return katSuplementacije;
        }

        //----Korisnici
        public IEnumerable<Korisnik> GetKorisnike()
        {
            IEnumerable<Korisnik> korisnici = db.Korisnik.Include(k => k.KorisnickiNalog).Include(k=>k.Grad);
            return korisnici;
        }
        public IEnumerable<KorisnikNalog> GetKorisnickeNaloge()
        {
            IEnumerable<KorisnikNalog> nalozi = db.KorisnikNalog.Include(n => n.VrstaKorisnika);
            return nalozi;
        }
        //Narudzbe
        public IEnumerable<Narudzba> GetNarudzbe()
        {
            IEnumerable<Narudzba> narudzbe = db.Narudzba.Include(n => n.Korisnik).Include(n => n.Grad).Include(n => n.Kartica).Include(n => n.StatusNarudzbe);
            return narudzbe;
        }
        public IEnumerable<Transakcije> GetTransakcije()
        {
            IEnumerable<Transakcije> transakcije = db.Transakcija.Include(t => t.Narudzba).Include(t => t.Korisnik);
            return transakcije;
        }
        public IEnumerable<NarudzbaStavke> GetNarudzbeStavke()
        {
            IEnumerable<NarudzbaStavke> nStavke = db.NarudzbaStavke.Include(s => s.Proizvod).Include(s => s.Narudzba);
            return nStavke;
        }

        public IEnumerable<KomentarProizvod> GetKomentare()
        {
            IEnumerable<KomentarProizvod> komentari = db.KomentarProizvod.Include(k => k.Proizvod).Include(k => k.Korisnik);
            return komentari;
        }
    }
}
