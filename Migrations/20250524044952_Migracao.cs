using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercicios.Migrations
{
    /// <inheritdoc />
    public partial class Migracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProdutoDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", maxLength: 100, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Tamanho = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecoVenda = table.Column<decimal>(type: "TEXT", nullable: false),
                    QtdEstoque = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoDB", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoDB");
        }
    }
}
