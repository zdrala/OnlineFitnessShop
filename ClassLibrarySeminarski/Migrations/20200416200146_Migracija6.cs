using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrarySeminarski.Migrations
{
    public partial class Migracija6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Obrisan",
                table: "Suplementacija",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Obrisan",
                table: "Proizvod",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Obrisan",
                table: "Odjeca",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Obrisan",
                table: "Obuca",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Obrisan",
                table: "KorisnikNalog",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Obrisan",
                table: "Korisnik",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Obrisan",
                table: "Dodatak",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Obrisan",
                table: "Dobavljac",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Obrisan",
                table: "Suplementacija");

            migrationBuilder.DropColumn(
                name: "Obrisan",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Obrisan",
                table: "Odjeca");

            migrationBuilder.DropColumn(
                name: "Obrisan",
                table: "Obuca");

            migrationBuilder.DropColumn(
                name: "Obrisan",
                table: "KorisnikNalog");

            migrationBuilder.DropColumn(
                name: "Obrisan",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Obrisan",
                table: "Dodatak");

            migrationBuilder.DropColumn(
                name: "Obrisan",
                table: "Dobavljac");
        }
    }
}
