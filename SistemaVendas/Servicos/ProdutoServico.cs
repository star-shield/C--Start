using SistemaVendas.Entidades;
using SistemaVendas.Repositorios.Interfaces;
using SistemaVendas.Servicos.Interfaces;

namespace SistemaVendas.Servicos;

public class ProdutoServico : IProdutoServico
{
    private readonly IProdutoRepositorio _repositorio;

    public ProdutoServico(IProdutoRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    public void CriarProduto(string nome, decimal preco, int estoque)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new Exception("Nome do produto é obrigatório.");

        if (preco <= 0)
            throw new Exception("Preço deve ser maior que zero.");

        if (estoque < 0)
            throw new Exception("Estoque não pode ser negativo.");

        var produto = new Produto
        {
            Nome = nome,
            Preco = preco,
            Estoque = estoque
        };

        _repositorio.Criar(produto);
    }

    public List<Produto> ListarProdutos()
    {
        return _repositorio.Listar();
    }
}
