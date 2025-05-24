

using Microsoft.EntityFrameworkCore;
using Exercicios.SistemaDeRoupas.Models; 
using Exercicios.SistemaDeRoupas.DataBase;
class Program {
    static void Main(string[] args)
    {

        using var context = new AppDbContext();
        
        context.Database.Migrate();
        
        Console.WriteLine("Banco de dados verificado/atualizado com sucesso!");

        Menu menu = new();
        menu.ExibirMenu();

    }
}
