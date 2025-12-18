using SistemaVendas.Entidades;

namespace SistemaVendas.Servicos.Interfaces;

public interface IProdutoServico
{
    void CriarProduto(string nome, decimal preco, int estoque);
    List<Produto> ListarProdutos();
}
