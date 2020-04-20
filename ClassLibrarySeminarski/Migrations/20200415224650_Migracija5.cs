using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrarySeminarski.Migrations
{
    public partial class Migracija5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Spol",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "imageUrl",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumKomentarisanja",
                table: "KomentarProizvod",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Spol",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "imageUrl",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "DatumKomentarisanja",
                table: "KomentarProizvod");
        }
    }
}
