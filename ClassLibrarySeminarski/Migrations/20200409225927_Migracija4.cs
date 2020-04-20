using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrarySeminarski.Migrations
{
    public partial class Migracija4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LikeCounter",
                table: "KomentarProizvod");

            migrationBuilder.AddColumn<string>(
                name: "Tekst",
                table: "KomentarProizvod",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tekst",
                table: "KomentarProizvod");

            migrationBuilder.AddColumn<int>(
                name: "LikeCounter",
                table: "KomentarProizvod",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
