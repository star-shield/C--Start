using SistemaVendas.Entidades;

namespace SistemaVendas.Repositorios.Interfaces;

public interface IProdutoRepositorio
{
    void Criar(Produto produto);
    Produto? BuscarPorId(int id);
    List<Produto> Listar();
    void Atualizar(Produto produto);
}