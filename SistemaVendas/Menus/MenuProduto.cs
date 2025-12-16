using SistemaVendas.Menus;
namespace SistemaVendas.Menus;
public static class MenuProduto
{
    public static void Exibir()
    {
        Console.Clear();
        Console.WriteLine("\n-----Menu de Produtos-----\n");
        Console.WriteLine("[1] - Criar Produto");
        Console.WriteLine("[2] - Lista de Produtos");
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