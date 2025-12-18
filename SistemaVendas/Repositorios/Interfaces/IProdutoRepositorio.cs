using SistemaVendas.Entidades;

namespace SistemaVendas.Repositorios.Interfaces;

public interface IProdutoRepositorio
{
    void Criar(Produto produto);
    List<Produto> Listar();
    Produto? BuscarPorId(int id);
}