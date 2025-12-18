using SistemaVendas.Menus;
using SistemaVendas.Repositorios;
using SistemaVendas.Servicos;
using SistemaVendas.BancoConfig;
using SistemaVendas.Entidades;

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

        var opcao = Console.ReadLine()!;

        var context = new SistemaVendasContext();
        var repositorio = new ProdutoRepositorio(context);
        var servico = new ProdutoServico(repositorio);

        switch (opcao)
        {
            case "1": CriarProduto(servico);  break;
            case "2": ListarProdutos(servico);  break;
            case "0": Console.Clear(); MenuPrincipal.Exibir(); return;
        }
        Console.ReadKey();
        Console.Clear();
        Exibir();
    }
    private static void CriarProduto(ProdutoServico servico)
    {
        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("-----Criar Produto-----\n");

                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                decimal preco = decimal.Parse(Console.ReadLine()!);
                Console.Write("Digite a quantidade de estoque do produto: ");
                int estoque = int.Parse(Console.ReadLine()!);

                servico.CriarProduto(nome, preco, estoque);
                Console.WriteLine("Produto cadastrado com sucesso✅");
                Thread.Sleep(2000);
                Exibir();
                break;
            }
            catch
            {
                Console.Write("*Erro em criar produto, clique qualquer tecla para tentar novamente*");
                Console.ReadKey();
            }
        }
    }
    private static void ListarProdutos(ProdutoServico servico)
    {
        Console.Clear();
        Console.WriteLine("-----Listar Produtos-----");
        List<Produto> listaDeProduto = servico.ListarProdutos();
        if (!listaDeProduto.Any())
        {
            Console.Write("A lista está vazia");
            Thread.Sleep(2000);
            Exibir();
        }
        foreach(var produto in listaDeProduto)
        {
            Console.WriteLine($"| ID: {produto.Id} | Nome: {produto.Nome} | Preço: {produto.Preco:F2} | Estoque: {produto.Estoque}");
        }
        Console.Write("*Clique qualquer tecla para voltar ao menu*");
        Console.ReadKey();
        Exibir();
    }
}