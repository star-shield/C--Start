using SistemaVendas.Entidades;
using SistemaVendas.Servicos.Interfaces;
using SistemaVendas.Repositorios.Interfaces;

namespace SistemaVendas.Servicos;

public class ProdutoServico : IProdutoServico
{
    private readonly IProdutoRepositorio _repositorio;

    public ProdutoServico(IProdutoRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    public void CadastrarProduto(string nome, string precoTexto, string estoqueTexto)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new Exception("Nome do produto é obrigatório.");

        if (!decimal.TryParse(precoTexto, out var preco) || preco <= 0)
            throw new Exception("Preço inválido.");

        if (!int.TryParse(estoqueTexto, out var estoque) || estoque < 0)
            throw new Exception("Estoque inválido.");

        var produto = new Produto
        {
            Nome = nome.Trim(),
            Preco = preco,
            Estoque = estoque
        };

        _repositorio.Criar(produto);
    }

    public Produto? BuscarPorId(int id)
    {
        return _repositorio.BuscarPorId(id);
    }

    public List<Produto> ListarProdutos()
    {
        return _repositorio.Listar();
    }

    public void AtualizarEstoque(int produtoId, int quantidadeReduzir)
    {
        var produto = _repositorio.BuscarPorId(produtoId);
        
        if (produto == null)
            throw new Exception("Produto não encontrado.");

        if (produto.Estoque < quantidadeReduzir)
            throw new Exception("Estoque insuficiente.");

        produto.Estoque -= quantidadeReduzir;
        _repositorio.Atualizar(produto);
    }
}
