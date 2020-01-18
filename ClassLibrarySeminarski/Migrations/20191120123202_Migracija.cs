using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrarySeminarski.Migrations
{
    public partial class Migracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DobavljacKategorije",
                columns: table => new
                {
                    DobavljacKategorijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivKategorije = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DobavljacKategorije", x => x.DobavljacKategorijaID);
                });

            migrationBuilder.CreateTable(
                name: "Kantoni",
                columns: table => new
                {
                    KantonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Oznaka = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kantoni", x => x.KantonID);
                });

            migrationBuilder.CreateTable(
                name: "StatusNarudzbe",
                columns: table => new
                {
                    StatusNarudzbeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpisStanja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusNarudzbe", x => x.StatusNarudzbeID);
                });

            migrationBuilder.CreateTable(
                name: "SuplementacijaKategorije",
                columns: table => new
                {
                    SuplementacijaKategorijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuplementacijaKategorijaNaziv = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuplementacijaKategorije", x => x.SuplementacijaKategorijaID);
                });

            migrationBuilder.CreateTable(
                name: "VrstaKorisnika",
                columns: table => new
                {
                    VrstaKorisnikaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VrstaNaziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaKorisnika", x => x.VrstaKorisnikaID);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    PostanskiBroj = table.Column<string>(nullable: true),
                    KantonID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.GradID);
                    table.ForeignKey(
                        name: "FK_Gradovi_Kantoni_KantonID",
                        column: x => x.KantonID,
                        principalTable: "Kantoni",
                        principalColumn: "KantonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikNalog",
                columns: table => new
                {
                    KorisnikNalogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    Lozinka = table.Column<string>(nullable: true),
                    VrstaKorisnikaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikNalog", x => x.KorisnikNalogID);
                    table.ForeignKey(
                        name: "FK_KorisnikNalog_VrstaKorisnika_VrstaKorisnikaID",
                        column: x => x.VrstaKorisnikaID,
                        principalTable: "VrstaKorisnika",
                        principalColumn: "VrstaKorisnikaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dobavljac",
                columns: table => new
                {
                    DobavljacID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    BrojTelefona = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    GradID = table.Column<int>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    DobavljacKategorijaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljac", x => x.DobavljacID);
                    table.ForeignKey(
                        name: "FK_Dobavljac_DobavljacKategorije_DobavljacKategorijaID",
                        column: x => x.DobavljacKategorijaID,
                        principalTable: "DobavljacKategorije",
                        principalColumn: "DobavljacKategorijaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dobavljac_Gradovi_GradID",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: true),
                    EmailAdresa = table.Column<string>(nullable: true),
                    BrojTelefona = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    GradID = table.Column<int>(nullable: true),
                    KorisnikNalogID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK_Korisnik_Gradovi_GradID",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Korisnik_KorisnikNalog_KorisnikNalogID",
                        column: x => x.KorisnikNalogID,
                        principalTable: "KorisnikNalog",
                        principalColumn: "KorisnikNalogID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    ProizvodID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Cijena = table.Column<float>(nullable: false),
                    DobavljacID = table.Column<int>(nullable: true),
                    datumDodavanja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.ProizvodID);
                    table.ForeignKey(
                        name: "FK_Proizvod_Dobavljac_DobavljacID",
                        column: x => x.DobavljacID,
                        principalTable: "Dobavljac",
                        principalColumn: "DobavljacID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikKartice",
                columns: table => new
                {
                    KarticaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(nullable: false),
                    NazivKartice = table.Column<string>(nullable: false),
                    BrojKartice = table.Column<string>(nullable: false),
                    DatumIsteka = table.Column<DateTime>(nullable: false),
                    Aktivna = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikKartice", x => x.KarticaID);
                    table.ForeignKey(
                        name: "FK_KorisnikKartice_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dodatak",
                columns: table => new
                {
                    DodatakID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodID = table.Column<int>(nullable: false),
                    TipDodatka = table.Column<string>(nullable: true),
                    Kolicina = table.Column<int>(nullable: false),
                    Namjena = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dodatak", x => x.DodatakID);
                    table.ForeignKey(
                        name: "FK_Dodatak_Proizvod_ProizvodID",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KomentarProizvod",
                columns: table => new
                {
                    KomentarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodID = table.Column<int>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    LikeCounter = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KomentarProizvod", x => x.KomentarID);
                    table.ForeignKey(
                        name: "FK_KomentarProizvod_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KomentarProizvod_Proizvod_ProizvodID",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Obuca",
                columns: table => new
                {
                    ObucaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodID = table.Column<int>(nullable: false),
                    Spol = table.Column<string>(nullable: true),
                    Brend = table.Column<string>(nullable: true),
                    Namjena = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obuca", x => x.ObucaID);
                    table.ForeignKey(
                        name: "FK_Obuca_Proizvod_ProizvodID",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Odjeca",
                columns: table => new
                {
                    OdjecaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodID = table.Column<int>(nullable: false),
                    Spol = table.Column<string>(nullable: true),
                    Materijal = table.Column<string>(nullable: true),
                    Brend = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odjeca", x => x.OdjecaID);
                    table.ForeignKey(
                        name: "FK_Odjeca_Proizvod_ProizvodID",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suplementacija",
                columns: table => new
                {
                    SuplementacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodID = table.Column<int>(nullable: false),
                    KategorijaID = table.Column<int>(nullable: false),
                    Brend = table.Column<string>(nullable: true),
                    Tezina = table.Column<float>(nullable: false),
                    Uputstvo = table.Column<string>(nullable: true),
                    RokTrajanja = table.Column<DateTime>(nullable: false),
                    kolicina = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suplementacija", x => x.SuplementacijaID);
                    table.ForeignKey(
                        name: "FK_Suplementacija_SuplementacijaKategorije_KategorijaID",
                        column: x => x.KategorijaID,
                        principalTable: "SuplementacijaKategorije",
                        principalColumn: "SuplementacijaKategorijaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suplementacija_Proizvod_ProizvodID",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Narudzba",
                columns: table => new
                {
                    NarudzbaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(nullable: false),
                    DatumKreiranjaNarudjbe = table.Column<DateTime>(nullable: false),
                    GradID = table.Column<int>(nullable: false),
                    Adresa = table.Column<string>(nullable: true),
                    StatusNarudzbeID = table.Column<int>(nullable: false),
                    IznosBezPDV = table.Column<float>(nullable: false),
                    IznosSaPDV = table.Column<float>(nullable: false),
                    KarticaID = table.Column<int>(nullable: false),
                    PotvrdaEmail = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzba", x => x.NarudzbaID);
                    table.ForeignKey(
                        name: "FK_Narudzba_Gradovi_GradID",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Narudzba_KorisnikKartice_KarticaID",
                        column: x => x.KarticaID,
                        principalTable: "KorisnikKartice",
                        principalColumn: "KarticaID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Narudzba_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Narudzba_StatusNarudzbe_StatusNarudzbeID",
                        column: x => x.StatusNarudzbeID,
                        principalTable: "StatusNarudzbe",
                        principalColumn: "StatusNarudzbeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ObucaVelicine",
                columns: table => new
                {
                    ObucaVelicinaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObucaID = table.Column<int>(nullable: false),
                    Velicina = table.Column<string>(nullable: true),
                    kolicina = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObucaVelicine", x => x.ObucaVelicinaID);
                    table.ForeignKey(
                        name: "FK_ObucaVelicine_Obuca_ObucaID",
                        column: x => x.ObucaID,
                        principalTable: "Obuca",
                        principalColumn: "ObucaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OdjecaVelicine",
                columns: table => new
                {
                    OdjecaVelicinaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OdjecaID = table.Column<int>(nullable: false),
                    Velicina = table.Column<string>(nullable: true),
                    kolicina = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdjecaVelicine", x => x.OdjecaVelicinaID);
                    table.ForeignKey(
                        name: "FK_OdjecaVelicine_Odjeca_OdjecaID",
                        column: x => x.OdjecaID,
                        principalTable: "Odjeca",
                        principalColumn: "OdjecaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NarudzbaStavke",
                columns: table => new
                {
                    NarudzbaStavkeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NarudzbaID = table.Column<int>(nullable: false),
                    ProizvodID = table.Column<int>(nullable: false),
                    Kolicina = table.Column<int>(nullable: false),
                    CijenaStavke = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarudzbaStavke", x => x.NarudzbaStavkeID);
                    table.ForeignKey(
                        name: "FK_NarudzbaStavke_Narudzba_NarudzbaID",
                        column: x => x.NarudzbaID,
                        principalTable: "Narudzba",
                        principalColumn: "NarudzbaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NarudzbaStavke_Proizvod_ProizvodID",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Transakcija",
                columns: table => new
                {
                    TransakcijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NarudzbaID = table.Column<int>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    DatumTransakcije = table.Column<DateTime>(nullable: false),
                    NaplaceniIznos = table.Column<float>(nullable: false),
                    NaplaceniIznosSaPDV = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transakcija", x => x.TransakcijaID);
                    table.ForeignKey(
                        name: "FK_Transakcija_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transakcija_Narudzba_NarudzbaID",
                        column: x => x.NarudzbaID,
                        principalTable: "Narudzba",
                        principalColumn: "NarudzbaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dobavljac_DobavljacKategorijaID",
                table: "Dobavljac",
                column: "DobavljacKategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Dobavljac_GradID",
                table: "Dobavljac",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Dodatak_ProizvodID",
                table: "Dodatak",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_KantonID",
                table: "Gradovi",
                column: "KantonID");

            migrationBuilder.CreateIndex(
                name: "IX_KomentarProizvod_KorisnikID",
                table: "KomentarProizvod",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_KomentarProizvod_ProizvodID",
                table: "KomentarProizvod",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_GradID",
                table: "Korisnik",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_KorisnikNalogID",
                table: "Korisnik",
                column: "KorisnikNalogID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikKartice_KorisnikID",
                table: "KorisnikKartice",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikNalog_VrstaKorisnikaID",
                table: "KorisnikNalog",
                column: "VrstaKorisnikaID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_GradID",
                table: "Narudzba",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KarticaID",
                table: "Narudzba",
                column: "KarticaID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KorisnikID",
                table: "Narudzba",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_StatusNarudzbeID",
                table: "Narudzba",
                column: "StatusNarudzbeID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_NarudzbaID",
                table: "NarudzbaStavke",
                column: "NarudzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_ProizvodID",
                table: "NarudzbaStavke",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_Obuca_ProizvodID",
                table: "Obuca",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_ObucaVelicine_ObucaID",
                table: "ObucaVelicine",
                column: "ObucaID");

            migrationBuilder.CreateIndex(
                name: "IX_Odjeca_ProizvodID",
                table: "Odjeca",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_OdjecaVelicine_OdjecaID",
                table: "OdjecaVelicine",
                column: "OdjecaID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_DobavljacID",
                table: "Proizvod",
                column: "DobavljacID");

            migrationBuilder.CreateIndex(
                name: "IX_Suplementacija_KategorijaID",
                table: "Suplementacija",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Suplementacija_ProizvodID",
                table: "Suplementacija",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcija_KorisnikID",
                table: "Transakcija",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcija_NarudzbaID",
                table: "Transakcija",
                column: "NarudzbaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dodatak");

            migrationBuilder.DropTable(
                name: "KomentarProizvod");

            migrationBuilder.DropTable(
                name: "NarudzbaStavke");

            migrationBuilder.DropTable(
                name: "ObucaVelicine");

            migrationBuilder.DropTable(
                name: "OdjecaVelicine");

            migrationBuilder.DropTable(
                name: "Suplementacija");

            migrationBuilder.DropTable(
                name: "Transakcija");

            migrationBuilder.DropTable(
                name: "Obuca");

            migrationBuilder.DropTable(
                name: "Odjeca");

            migrationBuilder.DropTable(
                name: "SuplementacijaKategorije");

            migrationBuilder.DropTable(
                name: "Narudzba");

            migrationBuilder.DropTable(
                name: "Proizvod");

            migrationBuilder.DropTable(
                name: "KorisnikKartice");

            migrationBuilder.DropTable(
                name: "StatusNarudzbe");

            migrationBuilder.DropTable(
                name: "Dobavljac");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "DobavljacKategorije");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "KorisnikNalog");

            migrationBuilder.DropTable(
                name: "Kantoni");

            migrationBuilder.DropTable(
                name: "VrstaKorisnika");
        }
    }
}
