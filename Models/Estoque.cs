using System.Globalization;
using System.Xml.Serialization;
using System;

namespace SistemaLojaDeRoupa;

class Estoque : Produto
{
    
    public static Dictionary<int, Produto> estoquePecas  = new Dictionary<int, Produto>(); //Montando um Dictinary para receber o ID, e suas informações 
    
    public virtual void AdicionarProduto() //Metodo de Adicionar Produto
    {
        Console.Write("Codigo: ");
        int.TryParse(Console.ReadLine(), out int Codigo);
        if (estoquePecas.ContainsKey(Codigo))
        {
            Console.Write("Peça  ja existente no estoque.");
            return; //Return volta para o menu 
        }

        Console.Write("Nome: "); string nome = Console.ReadLine();

        Console.Write("Tamanho: "); if (!int.TryParse(Console.ReadLine(), out int tamanho))
        {
            Console.Write("Tamanho invalido"); return;
        }
        Console.Write("Preço Venda: "); if (!decimal.TryParse(Console.ReadLine(), out decimal precoVenda))
        {
            Console.Write("Preço invalido"); return;
        }

        Console.Write("Quantidade Estoque"); if (!int.TryParse(Console.ReadLine(), out int qtdEstoque))
        {
            Console.Write("Quantidade invalida"); return;
        }

        //Adiona as informações adquiridas no Dictionary estoquePecas
        estoquePecas.Add(Codigo, new Produto { Tamanho = tamanho, PrecoVenda = precoVenda, QtdEstoque = qtdEstoque, Nome=nome });
    }
   
    public virtual void DarEntrada(int codigo) //Metodo para dar entrada no estoque
    {
        if (estoquePecas.ContainsKey(codigo)) //Verifica se o codigo esta dentro do Dictionary estoquePecas
        {
            Console.Write("Informe o valor da entrada: "); if (int.TryParse(Console.ReadLine(), out int Entrada))
            {
                Console.Write("Valor incorreto");
                return;
            }
            else
            {
                Produto produto = estoquePecas[codigo];
                produto.QtdEstoque = +Entrada;             //Faz a soma do estoque atual e entrada
                Console.Write("Entrada Realizada.");
            }
        }

    }
    public virtual void RegistrarVenda(int codigo, int quantidade)        //Metodo para registrar venda 
    {
        Produto produto = estoquePecas[codigo]; 
        if (!estoquePecas.ContainsKey(codigo))
        {
            Console.Write("Codigo nao encontrado.");
            return;
        }
        produto.QtdEstoque -= quantidade;                 //Faz a subtração de estoque atual com o da venda 
        Console.WriteLine($"Venda realizada\n Produto {produto.Nome} {codigo}");

    }
    public virtual void ConsultarProduto(int codigoConsulta)          ///Metodo para consultar produto
    {
        if (estoquePecas.ContainsKey(codigoConsulta))
        {
            Produto produto = estoquePecas[codigoConsulta];
            Console.Write($"Informações do item: {codigoConsulta}");
            Console.Write($" nome: {produto.Nome}");
            Console.Write($" tamanho: {produto.Tamanho}");
            Console.Write($" preço: {produto.PrecoVenda:C}");
            Console.WriteLine($" quantidade em estoque: {produto.QtdEstoque}");
        }
        else
        {
            Console.Write("Peça nao encontrada.");
        }
    }

}