using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrarySeminarski.Migrations
{
    public partial class Migracija1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Proizvod",
                nullable: true);

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Proizvod");

           
        }
    }
}
