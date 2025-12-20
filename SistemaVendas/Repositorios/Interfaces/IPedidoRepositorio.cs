using SistemaVendas.Entidades;

namespace SistemaVendas.Repositorios.Interfaces;

public interface IPedidoRepositorio
{
    void Criar(Pedido pedido);
    Pedido? BuscarPorId(int id);
    List<Pedido> Listar();
    void MarcarComoEntregue(Pedido pedido);
}