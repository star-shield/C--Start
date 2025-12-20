using SistemaVendas.Entidades;
using SistemaVendas.Servicos.Interfaces;
using SistemaVendas.Repositorios.Interfaces;

namespace SistemaVendas.Servicos;

public class PedidoServico : IPedidoServico
{
    private readonly IPedidoRepositorio _pedidoRepo;
    private readonly IProdutoServico _produtoServico;

    public PedidoServico(IPedidoRepositorio pedidoRepo, IProdutoServico produtoServico)
    {
        _pedidoRepo = pedidoRepo;
        _produtoServico = produtoServico;
    }

    public void CriarPedido(string nomeCliente, string enderecoEntrega, string tipoPagamento, List<(int produtoId, int quantidade)> itens)
    {
        if (string.IsNullOrWhiteSpace(nomeCliente))
            throw new Exception("Nome do cliente é obrigatório.");

        if (string.IsNullOrWhiteSpace(enderecoEntrega))
            throw new Exception("Endereço de entrega é obrigatório.");

        if (string.IsNullOrWhiteSpace(tipoPagamento))
            throw new Exception("Tipo de pagamento é obrigatório.");

        if (itens == null || !itens.Any())
            throw new Exception("O pedido deve conter pelo menos um item.");

        var pedido = new Pedido
        {
            NomeCliente = nomeCliente.Trim(),
            EnderecoEntrega = enderecoEntrega.Trim(),
            TipoPagamento = tipoPagamento.Trim(),
            Entregue = false
        };

        foreach (var (produtoId, quantidade) in itens)
        {
            var produto = _produtoServico.BuscarPorId(produtoId);
            
            if (produto == null)
                throw new Exception($"Produto com ID {produtoId} não encontrado.");

            if (quantidade <= 0)
                throw new Exception("Quantidade deve ser maior que zero.");

            _produtoServico.AtualizarEstoque(produtoId, quantidade);

            var item = new ItemPedido
            {
                ProdutoId = produto.Id,
                Quantidade = quantidade,
                PrecoUnitario = produto.Preco
            };

            pedido.SubTotal += quantidade * produto.Preco;
            pedido.Itens.Add(item);
        }

        _pedidoRepo.Criar(pedido);
    }

    public List<string> ListarPedidos()
    {
        return _pedidoRepo.Listar()
            .Select(p =>
                $"Pedido {p.Id} | Cliente: {p.NomeCliente} | Total: R$ {p.SubTotal:F2} | Entregue: {(p.Entregue ? "Sim" : "Não")}")
            .ToList();
    }

    public void MarcarComoEntregue(int pedidoId)
    {
        var pedido = _pedidoRepo.BuscarPorId(pedidoId);

        if (pedido == null)
            throw new Exception("Pedido não encontrado.");

        if (pedido.Entregue)
            throw new Exception("Pedido já foi entregue.");

        _pedidoRepo.MarcarComoEntregue(pedido);
    }
}
