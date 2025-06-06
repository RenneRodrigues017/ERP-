namespace Exercicios.Models;

public class Produto 
{
    public int Id { get; set; }
    private string _nome;
    public string Nome             //Tratando o valor da variavel Nome
    {
        get => _nome;
        set
        {
            _nome = value ?? throw new Exception("Nome nulo");
        }
    }
    private int _tamanho;
    public int Tamanho         //Tratando o valor da variavel Tamanho
    {
        get=> _tamanho;
        set
        {
            if (value <= 0) { throw new Exception("Não aceito. Valor menor que zero"); }  _tamanho=value;
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
    private int _qtdEstoque;
    public int QtdEstoque
    {
        get => _qtdEstoque;
        set
        {
            if (value < 0) { throw new ArgumentException("Quantidade menor que zero."); }
            _qtdEstoque = value;
        }
    }
}