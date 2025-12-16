namespace SistemaVendas.Entidades;
public class Pedido : EntidadeBase
{
public string NomeCliente { get; set; } = string.Empty;
public string EnderecoEntrega { get; set; } = string.Empty;
public string TipoPagamento { get; set; } = string.Empty;
public decimal SubTotal { get; set; }
public bool Entregue { get; set; }

public List<ItemPedido> Itens { get; set; } = new();
}