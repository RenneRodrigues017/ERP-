
using System.Net;
using Exercicios.Services;

namespace Exercicios
{
    class Program
    {
        static void Main()
        {
            GerenciarClientes gerenciador= new();
            Console.WriteLine("--Loja De Roupas--");
            Console.WriteLine("1-Menu Gerenciador de Clientes");
            Console.WriteLine("2-Menu Gerenciador de Estoque");
            Console.WriteLine("0 para sair");
            if (!int.TryParse(Console.ReadLine(), out int opcaoMenu))
            {
                Console.WriteLine("Opção invalida. Tente novamente");
                return;
            }
            switch (opcaoMenu)
            {
                case 0:
                    break;
                case 1:
                    Console.Clear();
                    MenuCliente menuclientes = new(gerenciador);
                    menuclientes.ApresentarMenu();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    MenuEstoque menuEstoque = new();
                    menuEstoque.ExibirMenu();
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opcao invalida. Tente novamente.");
                    Console.Clear();
                    break;
            }
        }
    }
}