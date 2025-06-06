// using Microsoft.EntityFrameworkCore.Migrations;

// #nullable disable

// namespace Exercicios.Migrations
// {
//     /// <inheritdoc />
//     public partial class InitialCreate : Migration
//     {
//         /// <inheritdoc />
//         protected override void Up(MigrationBuilder migrationBuilder)
//         {
//             migrationBuilder.CreateTable(
//                 name: "ProdutoDB",
//                 columns: table => new
//                 {
//                     Id = table.Column<int>(type: "int", nullable: false)
//                         .Annotation("SqlServer:Identity", "1, 1"),
//                     Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                     Tamanho = table.Column<int>(type: "int", nullable: false),
//                     PrecoVenda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
//                     QtdEstoque = table.Column<int>(type: "int", nullable: false)
//                 },
//                 constraints: table =>
//                 {
//                     table.PrimaryKey("PK_ProdutoDB", x => x.Id);
//                 });
//         }

//         /// <inheritdoc />
//         protected override void Down(MigrationBuilder migrationBuilder)
//         {
//             migrationBuilder.DropTable(
//                 name: "ProdutoDB");
//         }
//     }
// }
