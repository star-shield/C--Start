using SistemaVendas.BancoConfig;
using SistemaVendas.Entidades;
using SistemaVendas.Repositorios.Interfaces;

namespace SistemaVendas.Repositorios;

public class ProdutoRepositorio : IProdutoRepositorio
{
    private readonly SistemaVendasContext _context;

    public ProdutoRepositorio(SistemaVendasContext context)
    {
        _context = context;
    }

    public void Criar(Produto produto)
    {
        _context.Produtos.Add(produto);
        _context.SaveChanges();
    }

    public Produto? BuscarPorId(int id)
    {
        return _context.Produtos
            .FirstOrDefault(p => p.Id == id && !p.Deletado);
    }

    public List<Produto> Listar()
    {
        return _context.Produtos
            .Where(p => !p.Deletado)
            .ToList();
    }

    public void Atualizar(Produto produto)
    {
        _context.Produtos.Update(produto);
        _context.SaveChanges();
    }
}
