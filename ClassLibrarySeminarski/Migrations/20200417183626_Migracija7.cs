using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrarySeminarski.Migrations
{
    public partial class Migracija7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Aktiviran",
                table: "Korisnik",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aktiviran",
                table: "Korisnik");
        }
    }
}
