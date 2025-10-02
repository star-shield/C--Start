// See https://aka.ms/new-console-template for more information
#region boa sorte

    //Console.WriteLine("Hello, World!");

#endregion

#region Tipos de Variáveis
    
    int idade;
    double altura;
    string nome;
    bool estudante;

    Console.Write("Insira seu nome: ");
    nome = Console.ReadLine()!;

    Console.Write("Insira sua idade: ");
    idade = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Seu nome é {nome} e sua idade é {idade}");
#endregion