using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySeminarski.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ClassLibrarySeminarski
{
    public class KupacRepository<TEntity> : IKupacRepository<TEntity> where TEntity : class
    {

        MyDbContext db;
        DbSet<TEntity> dbSet;

        public KupacRepository(MyDbContext _context)
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

        public IEnumerable<Grad> GetGrad()
        {
            IEnumerable<Grad> gradovi = db.Gradovi.Include(g => g.Kanton);
            return gradovi;
        }

        public IEnumerable<Proizvod> GetProizvode()
        {
            IEnumerable<Proizvod> proizvodi = db.Proizvod.Include(p => p.Dobavljac);
            return proizvodi;
        }
        public IEnumerable<Suplementacija> GetSuplementacije()
        {
            IEnumerable<Suplementacija> suplementacije = db.Suplementacija.Include(s => s.Kategorija).Include(s => s.Proizvod);
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

        public IEnumerable<Korisnik> GetKorisnike()
        {
            IEnumerable<Korisnik> korisnici = db.Korisnik.Include(k => k.KorisnickiNalog).Include(k => k.Grad);
            return korisnici;
        }
        public IEnumerable<KorisnikNalog> GetKorisnickeNaloge()
        {
            IEnumerable<KorisnikNalog> nalozi = db.KorisnikNalog;
            return nalozi;
        }

        public IEnumerable<KorisnikKartice> GetKorisnickeKartice()
        {
            IEnumerable<KorisnikKartice> kartice = db.KorisnikKartice;
            return kartice;
        }

        public IEnumerable<Narudzba> GetNarudzbe()
        {
            IEnumerable<Narudzba> narudzba = db.Narudzba.Include(p => p.StatusNarudzbe);
            return narudzba;
        }

        public IEnumerable<NarudzbaStavke> GetNarudzbaStavke()
        {
            IEnumerable<NarudzbaStavke> narudzba = db.NarudzbaStavke.Include(a=> a.Proizvod);
            return narudzba;
        }

        public IEnumerable<KomentarProizvod> GetKomentare()
        {
            IEnumerable<KomentarProizvod> kom = db.KomentarProizvod.Include(a => a.Korisnik).Include(b => b.Proizvod);
            return kom;
        }
    }
}
