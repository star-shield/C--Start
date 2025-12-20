using SistemaVendas.Menus;
using SistemaVendas.Configuracao;

namespace SistemaVendas.Menus;

public static class MenuPedido
{
    public static void Exibir(Container container)
    {
        bool continuar = true;
        
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("--- Menu Pedido ---");
            Console.WriteLine("1. Criar Pedido");
            Console.WriteLine("2. Listar Pedidos");
            Console.WriteLine("3. Marcar como Entregue");
            Console.WriteLine("0. Voltar ao Menu Principal");
            Console.Write("Escolha uma opção: ");  
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CriarPedido(container);
                    break;
                case "2":
                    ListarPedidos(container);
                    break;
                case "3":
                    MarcarComoEntregue(container);
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }

    private static void CriarPedido(Container container)
    {
        try
        {
            Console.Clear();
            Console.WriteLine("=== CRIAR PEDIDO ===");

            Console.Write("Nome do Cliente: ");
            var nomeCliente = Console.ReadLine()!;

            Console.Write("Endereço de Entrega: ");
            var enderecoEntrega = Console.ReadLine()!;

            Console.Write("Tipo de Pagamento (Dinheiro/Cartão/PIX): ");
            var tipoPagamento = Console.ReadLine()!;

            var itens = new List<(int produtoId, int quantidade)>();

            Console.WriteLine("\n=== PRODUTOS DISPONÍVEIS ===");
            var produtos = container.ProdutoServico.ListarProdutos();
            foreach (var produto in produtos)
            {
                Console.WriteLine($"ID: {produto.Id} | {produto.Nome} | R$ {produto.Preco:F2} | Estoque: {produto.Estoque}");
            }

            Console.WriteLine("\nAdicione produtos ao pedido:");

            while (true)
            {
                Console.Write("\nID do Produto (0 para finalizar): ");
                if (!int.TryParse(Console.ReadLine(), out var produtoId) || produtoId < 0)
                {
                    Console.WriteLine("ID inválido!");
                    continue;
                }

                if (produtoId == 0) break;

                Console.Write("Quantidade: ");
                if (!int.TryParse(Console.ReadLine(), out var quantidade) || quantidade <= 0)
                {
                    Console.WriteLine("Quantidade inválida!");
                    continue;
                }

                itens.Add((produtoId, quantidade));
                Console.WriteLine("Item adicionado!");
            }

            if (!itens.Any())
            {
                Console.WriteLine("\nPedido cancelado - nenhum item adicionado.");
                Thread.Sleep(2000);
                return;
            }

            container.PedidoServico.CriarPedido(nomeCliente, enderecoEntrega, tipoPagamento, itens);

            Console.WriteLine("\nPedido criado com sucesso!");
            Thread.Sleep(2000);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nErro: {ex.Message}");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    private static void ListarPedidos(Container container)
    {
        Console.Clear();
        Console.WriteLine("=== LISTA DE PEDIDOS ===");

        var pedidos = container.PedidoServico.ListarPedidos();

        if (!pedidos.Any())
        {
            Console.WriteLine("Nenhum pedido cadastrado.");
        }
        else
        {
            foreach (var pedido in pedidos)
            {
                Console.WriteLine(pedido);
            }
        }

        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

    private static void MarcarComoEntregue(Container container)
    {
        try
        {
            Console.Clear();
            Console.WriteLine("=== MARCAR PEDIDO COMO ENTREGUE ===");

            var pedidos = container.PedidoServico.ListarPedidos();
            if (!pedidos.Any())
            {
                Console.WriteLine("Nenhum pedido cadastrado.");
                Thread.Sleep(2000);
                return;
            }

            foreach (var pedido in pedidos)
            {
                Console.WriteLine(pedido);
            }

            Console.Write("\nID do Pedido: ");
            if (!int.TryParse(Console.ReadLine(), out var pedidoId))
            {
                Console.WriteLine("ID inválido!");
                Thread.Sleep(2000);
                return;
            }

            container.PedidoServico.MarcarComoEntregue(pedidoId);

            Console.WriteLine("\nPedido marcado como entregue com sucesso!");
            Thread.Sleep(2000);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nErro: {ex.Message}");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}