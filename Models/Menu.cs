using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System;

namespace SistemaLojaDeRoupa;

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
             int.TryParse(Console.ReadLine(), out int opcao);
            if (opcao == 1)
            {
                 Console.Clear();
                 AdicionarProduto();
             }

            if (opcao != 1)
            {
                Console.Write("Codigo: "); int.TryParse(Console.ReadLine(), out int codigoEscolhido);
                switch (opcao)
                {
                    case 2:
                        Console.Clear();
                        DarEntrada(codigoEscolhido);
                        break;
                    case 4:
                        Console.Clear();
                        ConsultarProduto(codigoEscolhido);
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Informe a quantidade vendida: ");
                        int.TryParse(Console.ReadLine(), out int QtdVendida);
                        RegistrarVenda(codigoEscolhido, QtdVendida);
                        break;
                }
            }
        }
    }
}