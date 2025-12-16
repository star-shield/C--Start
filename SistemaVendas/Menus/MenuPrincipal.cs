using SistemaVendas.Menus;
namespace SistemaVendas.Menus;
public static class MenuPrincipal
{
    public static void Exibir()
    {   
        Console.Clear();
        Console.WriteLine("\n-----Menu Principal-----\n");
        Console.WriteLine("[1] - Gerenciar Produtos");
        Console.WriteLine("[2] - Gerenciar Pedidos");
        Console.WriteLine("[0] - Sair");
        Console.Write("Digite a opção: ");

        string opcao = Console.ReadLine()!;
        switch (opcao)
        {
            case "1": Console.Clear(); MenuProduto.Exibir(); break;
            case "2": Console.Clear(); MenuPedido.Exibir(); break;
            case "0": Console.Clear(); Console.WriteLine("Saindo do sistema..."); break;
            default: Console.Clear(); Console.WriteLine("Opção inválida. Tente novamente"); Exibir(); break;
        }
    }
}