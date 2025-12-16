using SistemaVendas.Menus;
namespace SistemaVendas.Menus;
public static class MenuPedido
{
    public static void Exibir()
    {
        Console.Clear();
        Console.WriteLine("\n-----Menu de Pedido-----\n");
        Console.WriteLine("[1] - Criar Pedido");
        Console.WriteLine("[2] - Lista de Pedido");
        Console.WriteLine("[0] - Voltar");
        Console.Write("Digite a opção: ");

        string opcao = Console.ReadLine()!;

        switch (opcao)
        {
            case "1":  break;
            case "2":  break;
            case "0": Console.Clear(); MenuPrincipal.Exibir(); break;
            default:  break;
        }
    }
}