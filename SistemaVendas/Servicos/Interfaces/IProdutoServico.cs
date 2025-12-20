using SistemaVendas.Entidades;

namespace SistemaVendas.Servicos.Interfaces;

public interface IProdutoServico
{
    void CadastrarProduto(string nome, string precoTexto, string estoqueTexto);
    Produto? BuscarPorId(int id);
    List<Produto> ListarProdutos();
    void AtualizarEstoque(int produtoId, int quantidadeReduzir);
}