using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteConquest.Infra.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeCompleto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NomeExibicao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "NomeCompleto", "NomeExibicao" },
                values: new object[,]
                {
                    { 1, "Paulo Coelho", "COELHO, Paulo" },
                    { 2, "Monteiro Lobato", "LOBATO, Monteiro" },
                    { 3, "José de Alencar", "ALENCAR, José de" },
                    { 4, "João Cabral de Melo Neto", "MELO NETO, João Cabral de" },
                    { 5, "Cecília Meireles", "MEIRELES, Cecília" },
                    { 6, "Guimarães", "GUIMARÃES" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autor");
        }
    }
}
