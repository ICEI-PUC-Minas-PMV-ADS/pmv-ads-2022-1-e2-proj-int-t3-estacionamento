using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webWhyPark.Migrations
{
    public partial class Role_estacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Estacionamentos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Estacionamentos");
        }
    }
}
