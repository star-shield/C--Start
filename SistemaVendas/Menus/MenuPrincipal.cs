using SistemaVendas.Menus;
namespace SistemaVendas.Menus;
public static class MenuPrincipal
{
    public static void Exibir()
    {
        Console.WriteLine("\n-----Menu Principal-----\n");
        Console.WriteLine("[1] - Produtos");
        Console.WriteLine("[2] - Pedidos");
        Console.WriteLine("[3] - Sair");
        Console.Write("Digite a opção: ");

        int opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 1: MenuProduto.Exibir(); break;
            case 2: MenuPedido.Exibir(); break;
            default: break;
        }
    }
}