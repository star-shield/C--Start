using SistemaVendas.Menus;
namespace SistemaVendas.Menus;
public static class MenuPedido
{
    public static void Exibir()
    {
        Console.WriteLine("\n-----Menu de Pedido-----\n");
        Console.WriteLine("[1] - Criar Pedido");
        Console.WriteLine("[2] - Lista de Pedidos");
        Console.WriteLine("[3] - Voltar");
        Console.Write("Digite a opção: ");

        int opcao = int.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1:  break;
            case 2:  break;
            case 3: MenuPrincipal.Exibir(); break;
            default:  break;
        }
    }
}