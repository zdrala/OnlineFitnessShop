using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.Kupac
{
    public class SuplementacijaPrikazVM
    {
        
        public int SuplementacijaID { get; set; }
        public int ProizvodID { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public string kategorijaSuplementacije { get; set; }
        public string ImageUrl { get; set; }
        public int Kolicina { get; set; }
        public float Tezina { get; set; }

        public List<Komentari> komentari { get; set; }
        public class Komentari
        {
            public string ImeKorisnik { get; set; }
            public string slikaUrl { get; set; }
            public string komentarTekst { get; set; }
            public string DatumKomentarisanja { get; set; }
        }

        public string Komentar { get; set; }
        public int KorisnikID { get; set; }
        public int BrojKomentara { get; set; }

    }
}
