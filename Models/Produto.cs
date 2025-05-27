

using System.ComponentModel.DataAnnotations;

namespace Exercicios.Models;

public class Produto
{
    [Key] public int Id { get; set; }
    
    private string? _nome;
    public string Nome               //Tratando o valor da variavel Nome
    {
        get => _nome;
        set
        {
            if (value == null)
            {
                throw new Exception("Nome nulo");
            } _nome = value;
        }
    }
   
    private int _tamanho;
    public int Tamanho         //Tratando o valor da variavel Tamanho
    {
        get=> _tamanho;
        set
        {
            if (value < 0) { throw new Exception("Não aceito. Valor menor que zero"); }  _tamanho=value;
        }
    }
     
    private decimal _precoVenda;
    public decimal PrecoVenda                //Tratando valor da variavel PrecoVenda 
    {
        get=>_precoVenda;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Valor menor que zero.");
            }
            _precoVenda = value;
        }
    }
    public int QtdEstoque { get; set; }


}