#region questão 1

int a, b, c, maior = 0, menor = 0;

Console.Write("Digite o primeiro número: ");
a = int.Parse(Console.ReadLine()!);
Console.Write("Digite o segundo número: ");
b = int.Parse(Console.ReadLine()!);
Console.Write("Digite o terceiro número: ");
c = int.Parse(Console.ReadLine()!);

if (a > b && b < c)
{
    maior = a;
    menor = b;

}
else if (a > c && c < b)
{
    maior = a;
    menor = c;

}else if (b > a && a < c )
{
    maior = b;
    menor = a;
}else if (b > c && c < a)
{
    maior = b;
    menor = c;
}else if (c > a && a < b)
{
    maior = c;
    menor = a;
}else if (c > b && b < a)
{
    maior = c;
    menor = b;
}
Console.Write($"O maior é: {maior} e o menor é: {menor}");
#endregion

#region questão 2

// int a;

// Console.Write("Entre com o número: ");
// a = int.Parse(Console.ReadLine()!);

// if (a >= 100 && a <= 200)
// {
//     Console.Write(" Está dentro do intervalo");
// }
// else
// {
//     Console.Write("Está fora do intervalo");
// }
#endregion

#region questão 3

// char a;

// Console.Write("Digite um caracter: ");
// a = Console.ReadKey().KeyChar;
// string b;
// switch ( b = a.ToString().ToUpper()){
//     case "A": Console.Write("\nVogal"); break;
//     case "E": Console.Write("\nVogal"); break;
//     case "I": Console.Write("\nVogal"); break;
//     case "O": Console.Write("\nVogal"); break;
//     case "U": Console.Write("\nVogal"); break;
//     default: Console.Write("\nConsoante"); break;
// }
#endregion

#region questão 4

// int a;
// Console.Write("Digite o código do mês de 1 a 12: ");
// a = int.Parse(Console.ReadLine()!);

// if (a >=1 && a <= 3)
// {
//     Console.Write("Verão");

// }else if(a >=4 && a <= 6)
// {
//     Console.Write("Outono");

// }else if ( a >=7 && a <= 9)
// {
//     Console.Write("Inverno");
// }
// else
// {
//     Console.Write("Primavera");
// }
#endregion

#region questão 5

// int a;
// Console.Write("Digite um número: ");
// a = int.Parse(Console.ReadLine()!);

// string msg = a > 0 ? "Positivo" : a < 0 ? "Negativo" : "Zero";

// Console.Write(msg);
#endregion

#region questão 6

// double salario;

// Console.Write("Digite seu salário: ");
// salario = double.Parse(Console.ReadLine()!);

// if (salario >= 2001 && salario <= 3000)
// {
//     Console.WriteLine($"Seu imposto de renda é: R${8 * salario / 100}");
// }
// else if (salario > 3000)
// {
//     Console.Write($"Seu imposto de renda é: R${15 * salario / 100}");
// }
// else
// {
//     Console.WriteLine("Isento");
// }
#endregion

#region questão 7

// int nota;

// Console.Write("Digite uma nota de 0 a 100: ");
// nota = int.Parse(Console.ReadLine()!);

// if (nota >=90 && nota <= 100)
// {
//     Console.Write("A");
// }else if (nota >=80 && nota <= 89)
// {
//     Console.Write("B");
// }else if (nota >= 70 && nota <= 79)
// {
//     Console.Write("C");
// }else if (nota >=60 && nota <=69){

//     Console.Write("D");
// }
// else
// {
//     Console.Write("F");
// }
#endregion

#region questão 8

// char a;

// Console.Write("Digite um caracter qualquer: ");
// a = Console.ReadKey().KeyChar;

// if (a == 'A')
// {
//     Console.Write("\nmaiusculo");
// }
// else if (a == 'a')
// {
//     Console.Write("\nminusculo");
// }
// else
// {
//     Console.Write("\nOutro");
// }
 #endregion

#region questão 9

#endregion