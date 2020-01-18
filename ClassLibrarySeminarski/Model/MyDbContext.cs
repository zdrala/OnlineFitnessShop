using Microsoft.EntityFrameworkCore;

namespace ClassLibrarySeminarski.Model
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> x) : base(x)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Dobavljac> Dobavljac { get; set; }
        public DbSet<DobavljacKategorije> DobavljacKategorije { get; set; }
        public DbSet<Dodatak> Dodatak { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Kanton> Kantoni { get; set; }
        public DbSet<KomentarProizvod> KomentarProizvod { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<KorisnikKartice> KorisnikKartice { get; set; }
        public DbSet<KorisnikNalog> KorisnikNalog { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<NarudzbaStavke> NarudzbaStavke { get; set; }
        public DbSet<Obuca> Obuca { get; set; }
        public DbSet<ObucaVelicine> ObucaVelicine { get; set; }
        public DbSet<Odjeca> Odjeca { get; set; }
        public DbSet<OdjecaVelicine> OdjecaVelicine { get; set; }
        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<StatusNarudzbe> StatusNarudzbe { get; set; }
        public DbSet<Suplementacija> Suplementacija { get; set; }
        public DbSet<SuplementacijaKategorije> SuplementacijaKategorije { get; set; }
        public DbSet<Transakcije> Transakcija { get; set; }
        public DbSet<VrstaKorisnika> VrstaKorisnika { get; set; }




        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=localhost;
        //                                                Database=OnlineFitnessShop_Seminarski;
        //                                                Trusted_Connection=True;
        //                                                MultipleActiveResultSets=true;");
        //}
    }

}
