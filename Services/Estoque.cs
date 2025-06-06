using System.Net;
using Exercicios.Models;

namespace Exercicios.Services
{
    class Estoque
    {
       public static Dictionary<int, Produto> Produtos = new Dictionary<int, Produto>();
        public static void AdicionarProduto(int Codigo) //Metodo de Adicionar Produto
        {
            while (true)
            {
                int id = Codigo;
                Console.WriteLine("--Digite 0 para saie--");
                Console.Write("Nome: "); string? nome = Console.ReadLine();
                if (nome == "0") { Console.WriteLine("Saindo.."); break; }
                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("Nome não pode ser nulo."); continue;
                }

                if (Produtos.ContainsKey(id)) { Console.WriteLine("Produto ja cadastrado."); continue; }

                Console.Write("Tamanho: ");

                if (!int.TryParse(Console.ReadLine(), out int tamanho))
                {
                    Console.Write("Tamanho invalido"); continue;
                }

                Console.Write("Preço venda: ");

                if (!decimal.TryParse(Console.ReadLine(), out decimal precoVenda))
                {
                    Console.Write("Preço invalido"); continue;
                }

                Console.Write("Quantidade estoque: "); if (!int.TryParse(Console.ReadLine(), out int qtdEstoque))
                {
                    Console.Write("Quantidade invalida."); continue;
                }
                try
                {
                    Produto novoProduto = new();
                    novoProduto.Id = id;
                    novoProduto.Nome = nome;
                    novoProduto.Tamanho = tamanho;
                    novoProduto.PrecoVenda = precoVenda;
                    novoProduto.QtdEstoque = qtdEstoque;

                    Produtos.Add(id, novoProduto);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Erro de validação.{ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro inesperado.{ex.Message}");
                }
            }
        }
        public static void DarEntrada(int IdProcurar, int qtdEntrada) //Metodo para dar entrada no estoque
        {
            try
            {
                if (Produtos.ContainsKey(IdProcurar))
                {
                    Produtos[IdProcurar].QtdEstoque += qtdEntrada;
                    Console.WriteLine($"Entrada realizada no ID {IdProcurar}. Estoque total: {Produtos[IdProcurar].QtdEstoque}");
                }
                else
                {
                    Console.WriteLine("Produto não encontrado. Tente novamente"); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado. {ex.Message}");
            }
        }
        public static void RegistrarVenda(int codigo, int quantidade)        //Metodo para registrar venda 
        {
            if (Produtos.ContainsKey(codigo))
            {
                Console.Write("--Venda Realizada--"); Produtos[codigo].QtdEstoque -= quantidade;
                Console.WriteLine("--Cupom--");
                Console.WriteLine($"Produto: {Produtos[codigo].Nome}");
                Console.WriteLine($"ID: {Produtos[codigo].Id}");
                Console.WriteLine($"Tamanho: {Produtos[codigo].Tamanho}");
                Console.WriteLine($"Preço: {Produtos[codigo].PrecoVenda}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado. Tente novamente"); return;
            }
        }
        public static void ConsultarProduto(int codigoConsulta)          ///Metodo para consultar produto
        {
            if (Produtos.ContainsKey(codigoConsulta))
            {
                Console.WriteLine($"Produto: {Produtos[codigoConsulta].Nome}");
                Console.WriteLine($" ID: {Produtos[codigoConsulta].Id}");
                Console.WriteLine($"Tamanho: {Produtos[codigoConsulta].Tamanho}");
                Console.WriteLine($"Preço venda: {Produtos[codigoConsulta].PrecoVenda}");
                Console.WriteLine($"Quantidade Estoque: {Produtos[codigoConsulta].QtdEstoque}");
            }
            else
            {
                Console.WriteLine("Produto não encotrado. Tente novamente.");
            }
        }
        public static void ListarProdutos()
        {
            Console.WriteLine("---Lista de Produtos---");
            foreach (var produtos in Produtos.ToList())
            {
                int IdKey = produtos.Key;
                Produto produto = produtos.Value;

                Console.WriteLine($"ID: {IdKey}\n Produto: {produto.Nome}\n Tamanho: {produto.Tamanho}\n Preço venda: {produto.PrecoVenda}\n Quantidade estoque: {produto.QtdEstoque}");
            }
        }

    }
}