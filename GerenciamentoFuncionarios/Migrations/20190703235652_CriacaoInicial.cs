using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoFuncionarios.Migrations
{
    public partial class CriacaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeCompleto = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Posicao = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    LocalizacaoEscritorio = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}
