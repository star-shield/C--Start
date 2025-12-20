using SistemaVendas.Configuracao;
using SistemaVendas.Menus;

namespace SistemaVendas.Menus;

public static class MenuProduto
{
    public static void Exibir(Container container)
    {
        bool continuar = true;
        
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("--- Menu Produto ---");
            Console.WriteLine("1. Criar Produto");
            Console.WriteLine("2. Listar Produtos");
            Console.WriteLine("0. Voltar ao Menu Principal");
            Console.Write("Escolha uma opção: ");  
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarProduto(container);
                    break;
                case "2":
                    ListarProdutos(container);
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
    private static void CadastrarProduto(Container container)
    {
        try
        {
            Console.Clear();
            Console.WriteLine("=== CADASTRO DE PRODUTO ===");

            Console.Write("Nome do Produto: ");
            var nome = Console.ReadLine()!;

            Console.Write("Preço: ");
            var preco = Console.ReadLine()!;

            Console.Write("Estoque: ");
            var estoque = Console.ReadLine()!;

            container.ProdutoServico.CadastrarProduto(nome, preco, estoque);

            Console.WriteLine("Produto cadastrado com sucesso!");
            Thread.Sleep(2000);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    private static void ListarProdutos(Container container)
    {
        Console.Clear();
        Console.WriteLine("=== LISTA DE PRODUTOS ===");

        var produtos = container.ProdutoServico.ListarProdutos();

        if (!produtos.Any())
        {
            Console.WriteLine("Nenhum produto cadastrado.");
        }
        else
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine(
                    $"ID: {produto.Id} | {produto.Nome} | R$ {produto.Preco:F2} | Estoque: {produto.Estoque}"
                );
            }
        }

        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}