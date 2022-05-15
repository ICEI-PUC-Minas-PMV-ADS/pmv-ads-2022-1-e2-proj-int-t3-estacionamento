using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webWhyPark.Migrations
{
    public partial class Cargo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Clientes",
                newName: "Cargo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cargo",
                table: "Clientes",
                newName: "Role");
        }
    }
}
