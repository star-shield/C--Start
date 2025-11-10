// int numero;

// Console.Write("Entre com um número: ");
// numero = int.Parse(Console.ReadLine()!);

// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }
#region list
// List<int> numeros = new List<int>();
// int quantidade = 0;
// for (int i =0; i <=10; i++)
// {
//     Console.Write("Entre com uma lista de 10 números: ");
//     numeros.Add(int.Parse(Console.ReadLine()!));
// }


// foreach (int numero in numeros)
// {
//     if (numero % 2 == 0)
//         quantidade++;
// }
// Console.WriteLine($"A quantidade de números pares é: {quantidade}");
#endregion

#region questão 4

// string[] frutas = { "Maçã", "Banana", "Abacaxi", "Laranja", "Amora" };


// foreach (var fruta in frutas)
// {
//     if (fruta.StartsWith("A"))
//         continue;
//     Console.WriteLine(fruta); 
// }
#endregion

#region questão 5

using System.Security.Cryptography.X509Certificates;
int[] numeros = new int[5];
int soma=0;
for (int i = 0; i < 5; i++)
{
    Console.Write("Digite o número: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}
foreach (var numero in numeros)
{
    soma += numero;
}
Console.Write($"A média dos números é: {soma / 5}");

#endregion
#region questão 6

// int numero;

// Console.Write("Entre com um número positivo: ");
// numero = int.Parse(Console.ReadLine()!);
// do
// {
//     Console.WriteLine(numero);
//     numero --;
// } while (numero > -1);

#endregion