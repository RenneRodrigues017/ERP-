



// DEIXEI TUDO COMENTADO POR QUE QUERIA TESTAR OUTRAS FORMAS SEM O BANCO DE DADOS








// using Microsoft.EntityFrameworkCore;

// using Microsoft.Extensions.Configuration;

// using Exercicios.Models;

// namespace Exercicios.Data
// {
//     public class AppDbContext : DbContext
//     {
//         public DbSet<Produto> ProdutoDB { get; set; }

//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             if (!optionsBuilder.IsConfigured)
//             {
//                 var builder = new ConfigurationBuilder()
//                     .SetBasePath(Directory.GetCurrentDirectory())
//                     .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

//                 IConfiguration config = builder.Build();

//                 string? connectionString = config.GetConnectionString("DefaultConnection");

//                 if (string.IsNullOrEmpty(connectionString))
//                 {
//                     throw new InvalidOperationException("A string de conexão 'DefaultConnection' não foi encontrada no appsettings.json.");
//                 }

//                 optionsBuilder.UseSqlServer(connectionString);
//             }
//         }
//     }
// }