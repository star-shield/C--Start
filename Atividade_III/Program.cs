// See https://aka.ms/new-console-template for more information
#region questão1

// int numero;

// Console.Write("Digite com um número positivo: ");
// numero = int.Parse(Console.ReadLine()!);

// while (numero < 1)
// {
//     Console.Write("Número inválido, tente novamente: ");
//     numero = int.Parse(Console.ReadLine()!);
// }
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{i} x {numero} = {i * numero}");
// }
#endregion

#region questão2

// int numero = 0;
// do
// {
//     Console.Write("Digite um número:");
//     numero = int.Parse(Console.ReadLine()!);
// } while (numero != 0);
// numero++;
// Console.WriteLine($"A soma dos números é: {numero}");
#endregion

#region questão3

// int num, fator=1;

// Console.Write("Digite um numero: ");
// num = int.Parse(Console.ReadLine()!);

// for (int i = num; i > 0; i--)
// {
//     fator *= i;
// }
// Console.Write(fator);
#endregion

#region questão 4
// Console.Write("Digite uma frase: ");
// string[] palavras = Console.ReadLine().Split(' ');

// foreach (string palavra in palavras)
// {

// }


#endregion
#region questão5

int numero, auxiliar = 1, asteristico =1;

Console.Write("Digite com um número positivo: ");
numero = int.Parse(Console.ReadLine()!);

for (int i= 0; i < numero; i++)
{
    for (int j = 0; j <= asteristico; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
    auxiliar++;
    asteristico = auxiliar + i;   
}


#endregion