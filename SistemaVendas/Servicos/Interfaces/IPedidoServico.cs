using SistemaVendas.Entidades;

namespace SistemaVendas.Servicos.Interfaces;

public interface IPedidoServico
{
    void CriarPedido(string nomeCliente, string enderecoEntrega, string tipoPagamento, List<(int produtoId, int quantidade)> itens);
    List<string> ListarPedidos();
    void MarcarComoEntregue(int pedidoId);
}