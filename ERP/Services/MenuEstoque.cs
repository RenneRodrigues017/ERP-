namespace Exercicios.Services;
class MenuEstoque : Estoque
{
    public void ExibirMenu() //Exibir menu do estoque 
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--Menu--\n--Loja RF Marcas--");
            Console.WriteLine("1-Adiconar produto");
            Console.WriteLine("2-Entrada");
            Console.WriteLine("3-Registrar venda");
            Console.WriteLine("4-Consultar produto");
            Console.WriteLine("5-Listar produtos");
            Console.WriteLine("0-Para sair");
            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                Console.WriteLine("Entrada incorreta. Tente novamente"); return;
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
                            AdicionarProduto(Codigo);
                            break;
                        case 2:
                            while (true)
                            {
                                Console.Write("Quantidade da entrada (ou 0 para sair): ");
                                if (int.TryParse(Console.ReadLine(), out int qtdEntrada))
                                {
                                    if (qtdEntrada == 0)
                                    {
                                        break; // sair do loop
                                    }
                                    // Entrada válida e diferente de zero
                                    DarEntrada(Codigo, qtdEntrada);
                                    break; // após registrar a entrada, sai do loop
                                }
                                else
                                {
                                    Console.WriteLine("Valor inválido. Tente novamente.");
                                }
                            }break;
                        case 4:
                            ConsultarProduto(Codigo);
                            break;
                        case 3:
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