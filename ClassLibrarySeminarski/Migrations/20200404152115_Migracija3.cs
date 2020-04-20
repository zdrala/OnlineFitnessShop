using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrarySeminarski.Migrations
{
    public partial class Migracija3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_KorisnikKartice_KarticaID",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "DatumIsteka",
                table: "KorisnikKartice");

            migrationBuilder.AddColumn<bool>(
                name: "Izbrisano",
                table: "Transakcija",
                nullable: false,
                defaultValue: false);

         

         

            migrationBuilder.AlterColumn<int>(
                name: "KarticaID",
                table: "Narudzba",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Izbrisano",
                table: "Narudzba",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Code",
                table: "KorisnikKartice",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GodinaIsteka",
                table: "KorisnikKartice",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MjesecIsteka",
                table: "KorisnikKartice",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_KorisnikKartice_KarticaID",
                table: "Narudzba",
                column: "KarticaID",
                principalTable: "KorisnikKartice",
                principalColumn: "KarticaID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_KorisnikKartice_KarticaID",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "Izbrisano",
                table: "Transakcija");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Izbrisano",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "KorisnikKartice");

            migrationBuilder.DropColumn(
                name: "GodinaIsteka",
                table: "KorisnikKartice");

            migrationBuilder.DropColumn(
                name: "MjesecIsteka",
                table: "KorisnikKartice");

            migrationBuilder.AlterColumn<int>(
                name: "SuplementacijaKategorijaNaziv",
                table: "SuplementacijaKategorije",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KarticaID",
                table: "Narudzba",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumIsteka",
                table: "KorisnikKartice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_KorisnikKartice_KarticaID",
                table: "Narudzba",
                column: "KarticaID",
                principalTable: "KorisnikKartice",
                principalColumn: "KarticaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
