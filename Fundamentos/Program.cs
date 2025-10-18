// See https://aka.ms/new-console-template for more information
#region boa sorte

//Console.WriteLine("Hello, World!");

#endregion

#region Tipos de Variáveis

/*
int idade;
double altura;
string nome;
bool estudante;

Console.Write("Insira seu nome: ");
nome = Console.ReadLine()!;
Console.Write("Insira sua idade: ");
idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Seu nome é {nome} e sua idade é {idade}");
*/

#endregion

#region exercicio1✅
/*
string nome;
int idade;

Console.Write("Digite seu nome: ");
nome = Console.ReadLine()!;
Console.Write("Digite sua idade: ");
idade = int.Parse(Console.ReadLine()!);

Console.Write($"Seu nome é {nome} e você tem {idade} anos");
*/
#endregion

#region exercicio2✅
/*
int a, b;

    Console.Write("Digite o primeiro número: ");
    a = int.Parse(Console.ReadLine()!);
    Console.Write("Digite o segundo número: ");
    b = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"O resultado da soma dos algarismos é: {a+b}");
    Console.WriteLine($"O resultado da subtração dos algarismos é: {a-b}");
    Console.WriteLine($"O resultado da multiplicação dos algarismos é: {a*b}");
    Console.WriteLine($"O resultado da divisão dos algarismos é: {a/b}");
    */
#endregion

#region exercicio3✅
/*
int raio;
const double pi = 3.14;

Console.Write("Digite o valor do raio: ");
raio = int.Parse(Console.ReadLine()!);

Console.WriteLine($"O resultado da área é {pi * (raio*raio)} e o perímetro é {2*pi*raio}");
*/
#endregion

#region exercicio4✅
/*
    int temperatura;

Console.Write("Digite a temperatura: ");
temperatura = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"A conversão da temperatura em Fahreheit é {temperatura *9/5+32}");
    */
#endregion

#region questão1✅
/*
    int a, b;

    Console.Write("Digite o primeiro número: ");
    a = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    b = int.Parse(Console.ReadLine());

    Console.Write($"A soma dos números {a} e {b} é {a+b} ");
*/
#endregion

#region questão2✅
/*
    float a;
    double b, c;

    Console.Write("Digite o primeiro número: ");
    a = float.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    b = double.Parse(Console.ReadLine());
    
    c = a;

    Console.Write($"{b + c}");
*/
#endregion

#region questão3✅
/*
    char a;
    
    Console.Write("Digite o caracter: ");
    a = Console.ReadKey().KeyChar;

    Console.WriteLine($"\n O caracter digitado é {a}");
    */
#endregion

#region questão4✅
/*
    string nome;

    Console.Write("Nome: ");
    nome = Console.ReadLine()!;

    Console.Write($"Olá {nome}, seja bem-vindo!.");
*/
#endregion

#region questão5✅
/*
    decimal a, b;

    Console.Write("Digite o primeiro número: ");
    a = decimal.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    b = decimal.Parse(Console.ReadLine());

    Console.Write($"{a*b:F2}");
*/
#endregion

#region questão6✅
/*
int a = 30;

Console.Write($"{a*a}");
*/
#endregion

#region questão7✅
/*
    double a, b;

    Console.Write("Digite o primeiro número: ");
    a = double.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    b = double.Parse(Console.ReadLine());

    Console.Write($"A média é {(a+b)/2}");
*/
#endregion

#region questão8✅
/*
    float a;
    Console.Write("Digite um número: ");
    a = float.Parse(Console.ReadLine());

    Console.Write(a-10.5f);
    */
#endregion

#region questão9✅
/*
    string nome;
    int idade;

    Console.Write("Digite o nome ");
    nome = Console.ReadLine()!;
    Console.Write("Digite a idade ");
    idade = int.Parse(Console.ReadLine());

    Console.Write($"Nome: {nome}, Idade: {idade} ");
    */
#endregion

#region questão10✅
/*
    int a=10;
    char b='a';
    string c = "nome";    

    Console.WriteLine($"{a}, {b}, {c}");
*/
#endregion

#region questão11✅
/*

    double a, b, c;

    Console.Write("Digite o primeiro número: ");
    a = double.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    b = double.Parse(Console.ReadLine());
    Console.Write("Digite o terceiro número: ");
    c = double.Parse(Console.ReadLine());

    Console.Write($"média ponderada: {(a+b+c*5)/(2+3+5)}");
*/
#endregion

#region questão12✅
/*
    float C;

    Console.Write("Digite a temperatura ");
    C = float.Parse(Console.ReadLine());

    Console.Write($"A temperatura em Fahrenheit é {C * 9f/5f + 32f} ");
*/
#endregion

#region raiz✅
/*
double valorRaiz, raiz;
valorRaiz = double.Parse(Console.ReadLine()!);

raiz = Math.Pow(valorRaiz, 0.5);
Console.Write($"{raiz:F1}");
*/
#endregion
