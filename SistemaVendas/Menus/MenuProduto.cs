using SistemaVendas.Menus;
namespace SistemaVendas.Menus;
public static class MenuProduto
{
    public static void Exibir()
    {
        Console.WriteLine("\n-----Menu de Produtos-----\n");
        Console.WriteLine("[1] - Criar Produto");
        Console.WriteLine("[2] - Lista de Produtos");
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