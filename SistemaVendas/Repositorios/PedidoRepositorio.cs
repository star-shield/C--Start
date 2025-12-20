using SistemaVendas.Entidades;
using SistemaVendas.BancoConfig;
using Microsoft.EntityFrameworkCore;
using SistemaVendas.Repositorios.Interfaces;

namespace SistemaVendas.Repositorios;

public class PedidoRepositorio : IPedidoRepositorio
{
    private readonly SistemaVendasContext _context;

    public PedidoRepositorio(SistemaVendasContext context)
    {
        _context = context;
    }

    public void Criar(Pedido pedido)
    {
        _context.Pedidos.Add(pedido);
        _context.SaveChanges();
    }

    public Pedido? BuscarPorId(int id)
    {
        return _context.Pedidos
            .Include(p => p.Itens)
            .ThenInclude(i => i.Produto)
            .FirstOrDefault(p => p.Id == id && !p.Deletado);
    }

    public List<Pedido> Listar()
    {
        return _context.Pedidos
            .Include(p => p.Itens)
            .ThenInclude(i => i.Produto)
            .Where(p => !p.Deletado)
            .ToList();
    }
    public void MarcarComoEntregue(Pedido pedido){
        pedido.Entregue = true;
        _context.SaveChanges();
    }
}
