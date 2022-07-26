using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoDeClientes.Migrations
{
    public partial class CriacaoBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientePerfil = table.Column<int>(nullable: false),
                    ClienteNome = table.Column<string>(nullable: true),
                    ClienteEmpresa = table.Column<string>(nullable: true),
                    ClienteNomeFantasia = table.Column<string>(nullable: true),
                    ClienteCpfCnpj = table.Column<string>(nullable: true),
                    ClienteTelefone = table.Column<string>(nullable: true),
                    ClienteCelular = table.Column<string>(nullable: true),
                    ClienteEmail = table.Column<string>(nullable: true),
                    ClienteRua = table.Column<string>(nullable: true),
                    ClienteNumero = table.Column<string>(nullable: true),
                    ClienteCep = table.Column<string>(nullable: true),
                    ClienteCidade = table.Column<string>(nullable: true),
                    ClienteEstado = table.Column<string>(nullable: true),
                    ClienteEndComplem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
