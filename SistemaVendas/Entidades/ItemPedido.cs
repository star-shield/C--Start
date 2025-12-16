namespace SistemaVendas.Entidades;
public class ItemPedido : EntidadeBase
{
public int PedidoId { get; set; }
public Pedido Pedido { get; set; } = null!;
public int ProdutoId { get; set; }
public Produto Produto { get; set; } = null!;
public int Quantidade { get; set; }
public decimal PrecoUnitario { get; set; }
}