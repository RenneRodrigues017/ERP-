using Exercicios.SistemaDeRoupas.Models;
using Microsoft.EntityFrameworkCore;
namespace Exercicios.SistemaDeRoupas.DataBase
{
    public class AppDbContext : DbContext
    {
    
        public DbSet<Produto> ProdutoDB { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura para usar SQLite e especifica o nome do arquivo do banco de dados
            // O arquivo .db será criado na mesma pasta do seu executável.
            optionsBuilder.UseSqlite("Data Source=app_erp.db");
        }
    
         protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Exemplo: Configurar que o nome do produto é obrigatório e tem um tamanho máximo
                modelBuilder.Entity<Produto>()
                    .Property(p => p.Id)
                    .IsRequired()
                    .HasMaxLength(100);
            }

    }
}