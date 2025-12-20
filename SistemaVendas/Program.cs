using SistemaVendas.Menus;
using SistemaVendas.Configuracao;

internal class Program
{
    private static void Main(string[] args)
    {
        using var container = new Container();
        
        MenuPrincipal.Exibir(container);
    }
}