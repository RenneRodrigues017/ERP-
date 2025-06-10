
namespace Testes; 
public class ProdutoTeste
{
    private int _id;
    public int Id
    {
        get => _id;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("O ID do produto deve ser maior que zero.", nameof(Id));
            }
            _id = value;
        }
    }

    private string _nome;
    public string Nome
    {
        get => _nome;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("O nome do produto não pode ser nulo ou vazio.", nameof(Nome));
            }
            _nome = value;
        }
    }

    private int _tamanho;
    public int Tamanho
    {
        get => _tamanho;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("O tamanho do produto deve ser maior que zero.", nameof(Tamanho));
            }
            _tamanho = value;
        }
    }

    private decimal _precoVenda;
    public decimal PrecoVenda
    {
        get => _precoVenda;
        set
        {
            if (value <= 0) 
            {
                throw new ArgumentException("O preço de venda deve ser maior que zero.", nameof(PrecoVenda));
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
            if (value < 0) 
            {
                throw new ArgumentException("A quantidade em estoque não pode ser negativa.", nameof(QtdEstoque));
            }
            _qtdEstoque = value;
        }
    }

    public ProdutoTeste(int id, string nome, int tamanho, decimal precoVenda, int qtdEstoque)
    {
        Id = id; 
        Nome = nome;
        Tamanho = tamanho;
        PrecoVenda = precoVenda;
        QtdEstoque = qtdEstoque;
    }

    
}