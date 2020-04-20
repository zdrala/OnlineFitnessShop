using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrarySeminarski.Migrations
{
    public partial class AddedAtributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Velicina",
                table: "NarudzbaStavke",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VrstaProizvoda",
                table: "NarudzbaStavke",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Komentar",
                table: "Narudzba",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Velicina",
                table: "NarudzbaStavke");

            migrationBuilder.DropColumn(
                name: "VrstaProizvoda",
                table: "NarudzbaStavke");

            migrationBuilder.DropColumn(
                name: "Komentar",
                table: "Narudzba");
        }
    }
}
