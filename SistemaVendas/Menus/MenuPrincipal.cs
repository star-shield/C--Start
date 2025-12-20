using SistemaVendas.Configuracao;

namespace SistemaVendas.Menus;

public static class MenuPrincipal
{
    public static void Exibir(Container container)
    {
        bool continuar = true;
        
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("--- Menu Principal ---");
            Console.WriteLine("1. Gerenciar Produtos");
            Console.WriteLine("2. Gerenciar Pedidos");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");  
            string opcao = Console.ReadLine();
            
            switch (opcao)
            {
                case "1":
                    MenuProduto.Exibir(container);
                    break;
                case "2":
                    MenuPedido.Exibir(container);
                    break;
                case "0":
                    Console.WriteLine("Saindo do sistema...");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }
}