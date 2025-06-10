using Xunit;
using ERP.Commun.Models;
namespace Testes;

public class Teste
{
    [Fact]
    public void ProdutoDeveSerCriadoComDadosValidos()
    {
        int _id = 15;
        string _nome = "Renne";
        int _tamanho = 42;
        decimal _precoVenda = 10;
        int _qtdEstoque = 10;
        ProdutoTeste produto = new ProdutoTeste(_id, _nome, _tamanho, _precoVenda, _qtdEstoque);

        Assert.Equal(produto.Id, _id);
        Assert.Equal(produto.Nome, _nome);
        Assert.Equal(produto.Tamanho, _tamanho);
        Assert.Equal(produto.QtdEstoque, _qtdEstoque);
        Assert.Equal(produto.PrecoVenda, _precoVenda);
    }
    [Fact]
    public void DeveRetornarDadosValido()
    {
        string nome = "Renne";
        var cli = new Cliente(nome);
        Assert.True(cli.Nome == nome);
        Assert.True(cli.Status);
    }
    [Fact]
    public void RetornarException()
    {
        Produto produto = new();
        Assert.Throws<ArgumentNullException>(() => produto.Nome = "");
        Assert.Throws<Exception>(() => produto.Tamanho = -5);
        Assert.Throws<ArgumentException>(() => produto.PrecoVenda = -1);
    }

}