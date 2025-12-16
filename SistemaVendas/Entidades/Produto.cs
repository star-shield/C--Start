using SistemaVendas.Entidades;
namespace SistemaVendas.Entidades;
public class Produto : EntidadeBase
{
public string Nome { get; set; } = string.Empty;
public decimal Preco { get; set; }
public int Estoque { get; set; }
public List<ItemPedido> ItensPedido { get; set; } = new();
}