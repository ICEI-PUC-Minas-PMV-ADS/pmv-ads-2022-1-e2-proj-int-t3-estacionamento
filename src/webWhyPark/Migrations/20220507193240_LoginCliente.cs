using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webWhyPark.Migrations
{
    public partial class LoginCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CadastroClientes",
                table: "CadastroClientes");

            migrationBuilder.RenameTable(
                name: "CadastroClientes",
                newName: "CadastroClientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CadastroClientes",
                table: "CadastroClientes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "LoginClientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CadastroClienteFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginClientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginClientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CadastroClientes",
                table: "CadastroClientes");

            migrationBuilder.RenameTable(
                name: "CadastroClientes",
                newName: "CadastroClientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CadastroClientes",
                table: "CadastroClientes",
                column: "Id");
        }
    }
}
