using Exercicios.SistemaDeRoupas.Services;

namespace Exercicios.SistemaDeRoupas.Models;

class Menu : Estoque
{
    public void ExibirMenu()
    {
        while (true)
        {
            Console.WriteLine("Menu\nLoja RF Marcas");
            Console.WriteLine("1-Adiconar Produto");
            Console.WriteLine("2-Dar Entrada");
            Console.WriteLine("3-Registrar Venda");
            Console.WriteLine("4-Consultar Produto");
            Console.WriteLine("5-Listar produtos");
            Console.WriteLine("0-Para sair");
            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                Console.WriteLine("Entrada incorreta."); return;
            }

            if (opcao == 0) break;

            if (opcao != 5)
            {
                Console.WriteLine("Codigo: ");
                if (int.TryParse(Console.ReadLine(), out int Codigo))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            AdicionarProduto(Codigo);
                            break;
                        case 2:
                            Console.Clear();
                            DarEntrada(Codigo);
                            break;
                        case 4:
                            Console.Clear();
                            ConsultarProduto(Codigo);
                            break;
                        case 3:
                            Console.Clear();
                            Console.Write("Informe a quantidade vendida: ");
                            if (int.TryParse(Console.ReadLine(), out int QtdVendida))
                            {
                                RegistrarVenda(Codigo, QtdVendida);
                            } else { Console.WriteLine("Quantidade invalida."); return; }
                            break;
                    }
                }

            }
            else if (opcao == 5) { ListarProdutos(); }
            else
            {
                Console.WriteLine("Opção não encontrada. Digite novamente."); return;
            }
        
        }
    }
}