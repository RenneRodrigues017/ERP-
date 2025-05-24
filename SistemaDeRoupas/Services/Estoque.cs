using Exercicios.SistemaDeRoupas.Models;
using Exercicios.SistemaDeRoupas.DataBase;
namespace Exercicios.SistemaDeRoupas.Services;

class Estoque
{

    public static void AdicionarProduto(int Codigo) //Metodo de Adicionar Produto
    {
        using var context = new AppDbContext();
        Produto produtoNew = new Produto();
        Console.WriteLine("para sair digite 0...");
        Console.Write("Nome: "); string? nome = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome não pode ser nulo."); return;
        }
        produtoNew.Nome = nome;

        Console.Write("Tamanho: "); if (!int.TryParse(Console.ReadLine(), out int tamanho))
        {
            Console.Write("Tamanho invalido"); return;
        }
        produtoNew.Tamanho = tamanho;

        Console.Write("Preço Venda: ");

        if (!decimal.TryParse(Console.ReadLine(), out decimal precoVenda))
        {
            Console.Write("Preço invalido"); return;
        }
        produtoNew.PrecoVenda = precoVenda;

        Console.Write("Quantidade Estoque: "); if (!int.TryParse(Console.ReadLine(), out int qtdEstoque))
        {
            Console.Write("Quantidade invalida."); return;
        }
        produtoNew.QtdEstoque = qtdEstoque;
        produtoNew.Id = Codigo;

        context.Add(produtoNew);
        context.SaveChanges();
    }
    public static void DarEntrada(int IdProcurar) //Metodo para dar entrada no estoque
    {
        using var context = new AppDbContext();
        Produto? produtoEncontrado = context.ProdutoDB.Find(IdProcurar);
        if (produtoEncontrado == null)
        {
            Console.WriteLine("ID não encontrado."); return;
        }
        else
        {
            Console.Write("Quantidade da entrada: "); if (int.TryParse(Console.ReadLine(), out int qtdEntrada))
            {
                produtoEncontrado.QtdEstoque += qtdEntrada;
            } else { Console.WriteLine("Quantidade Invalida."); return; }
        }
        context.SaveChanges();
        Console.Clear();
    }
    public static void RegistrarVenda(int codigo, int quantidade)        //Metodo para registrar venda 
    {
        using var context = new AppDbContext();
        Produto? produtoVendido = context.ProdutoDB.Find(codigo);
        if (produtoVendido != null)
        {
            Console.Write("Venda Realizada"); produtoVendido.QtdEstoque -= quantidade;
        }
        else
        {
            Console.WriteLine("Produto não encontrado."); return;
        }

        context.SaveChanges();
       
    }
    public static void ConsultarProduto(int codigoConsulta)          ///Metodo para consultar produto
    {
        using var context = new AppDbContext();
        Produto? produtoConsultado = context.ProdutoDB.Find(codigoConsulta);
        if (produtoConsultado != null)
        {
            Console.Write($"Produto: {produtoConsultado.Nome}");
            Console.Write($" ID: {produtoConsultado.Id}");
            Console.Write($" Tamanho: {produtoConsultado.Tamanho}");
            Console.WriteLine($" Preço venda: {produtoConsultado.PrecoVenda}");
            Console.WriteLine($"Quantidade Estoque: {produtoConsultado.QtdEstoque}");
        }
        else
        {
            Console.WriteLine("Produto não encotrado.");
        }
    }

    public static void ListarProdutos()
    {
        Console.WriteLine("---Lista de Produtos---");
        using var context = new AppDbContext();
        
        foreach (var produto in context.ProdutoDB)
        {
            Console.WriteLine($"ID: {produto.Id}\n Produto: {produto.Nome}\n Tamanho: {produto.Tamanho}\n Preço venda: {produto.PrecoVenda}\n Quantidade estoque: {produto.QtdEstoque}");
        }
    }

}