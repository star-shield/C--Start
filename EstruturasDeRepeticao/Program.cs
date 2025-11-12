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

#region questão 1
// for (int i=1; i <= 50; i++)
// {
//     if(i % 3==0 && i % 5 == 0)
//     {
//         Console.WriteLine("FizzBuzz");
//         continue;
//     }
//     if (i % 3 == 0)
//     {
//         Console.WriteLine("Fizz");
//         continue;
//     }if(i % 5 == 0)
//     {
//         Console.WriteLine("Buzz");
//         continue;
//     }
//     else
//     {
//         Console.WriteLine(i);
//     }
// }
#endregion

#region questão 2
int numero1, soma = 0;

Console.Write("Digite um número: ");
numero1 = int.Parse(Console.ReadLine()!);

while (numero1 != 0)
{
    Console.Write("Digite outro número: ");
    numero1 = int.Parse(Console.ReadLine()!);
    if (numero1 != 0) soma = numero1 + numero2;
   
}
Console.Write($"A soma dos números é: {soma}");

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

// int[] numeros = new int[5];
// int soma=0;
// for (int i = 0; i < numeros.Length; i++)
// {
//     Console.Write("Digite o número: ");
//     numeros[i] = int.Parse(Console.ReadLine()!);
// }
// foreach (var numero in numeros)
// {
//     soma += numero;
// }
// Console.Write($"A média dos números é: {soma / 5}");

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