using SistemaVendas.Servicos;
using SistemaVendas.BancoConfig;
using SistemaVendas.Repositorios;
using SistemaVendas.Servicos.Interfaces;
using SistemaVendas.Repositorios.Interfaces;

namespace SistemaVendas.Configuracao;

public class Container : IDisposable
{
    private readonly SistemaVendasContext _context;
    
    public IProdutoServico ProdutoServico { get; }
    public IPedidoServico PedidoServico { get; }

    public Container()
    {
        _context = new SistemaVendasContext();
        
        IProdutoRepositorio produtoRepo = new ProdutoRepositorio(_context);
        IPedidoRepositorio pedidoRepo = new PedidoRepositorio(_context);
        ProdutoServico = new ProdutoServico(produtoRepo);
        PedidoServico = new PedidoServico(pedidoRepo, ProdutoServico);
    }
    public void Dispose()
    {
        _context?.Dispose();
    }
}