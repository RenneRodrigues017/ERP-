
using Microsoft.EntityFrameworkCore;
using Exercicios.Data;
using Exercicios.Services;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();
            context.Database.Migrate();
            Console.WriteLine("Banco de dados verificado e migrações aplicadas com sucesso!");

            Menu menu = new();
            menu.ExibirMenu();
        }
    }
}