// void linha()
// {
//     Console.WriteLine("--------------------------------------");
// }
// double ConversorDeTemperatura(double temperatura, string OpcaoEscolhida)
// {
//     double resultado=0;
//     switch (OpcaoEscolhida)
//     {
//         case "1":
//             resultado = (temperatura * 9 / 5) + 32;
//             break;

//         case "2":
//             resultado = (temperatura - 32) * 5 / 9;
//             break;

//         case "3":
//             resultado = temperatura + 273.15;
//             break;

//         case "4":
//             resultado = temperatura - 273.15;
//             break;

//         default:
//             Console.WriteLine("Opção inválida!");
//             break;
//     }
//     return resultado;
// }
// string continuar;
// do
// {
//     linha();
//     Console.WriteLine("Conversor de Temperatura");
//     Console.WriteLine("Escolha a opção de conversão:");
//     Console.WriteLine("1 - Celsius para Fahrenheit");
//     Console.WriteLine("2 - Fahrenheit para Celsius");
//     Console.WriteLine("3 - Celsius para Kelvin");
//     Console.WriteLine("4 - Kelvin para Celsius");
//     Console.Write("Opção: ");
//     string opcao = Console.ReadLine()!;

//     double temperatura;
//     switch (opcao)
//     {
//         case "1":
//             linha();
//             Console.Write("Digite a temperatura em Celsius: ");
//             temperatura = double.Parse(Console.ReadLine()!);
//             Console.WriteLine($"{temperatura}°C = {ConversorDeTemperatura(temperatura, opcao):F2}°F");
//             linha();
//             break;

//         case "2":
//             linha();
//             Console.Write("Digite a temperatura em Fahrenheit: ");
//             temperatura = double.Parse(Console.ReadLine()!);
//             Console.WriteLine($"{temperatura}°F = {ConversorDeTemperatura(temperatura, opcao):F2}°C");
//             linha();
//             break;

//         case "3":
//             linha();
//             Console.Write("Digite a temperatura em Celsius: ");
//             temperatura = double.Parse(Console.ReadLine()!);
//             Console.WriteLine($"{temperatura}°C = {ConversorDeTemperatura(temperatura, opcao):F2}K");
//             linha();
//             break;

//         case "4":
//             linha();
//             Console.Write("Digite a temperatura em Kelvin: ");
//             temperatura = double.Parse(Console.ReadLine()!);
//             Console.WriteLine($"{temperatura}K = {ConversorDeTemperatura(temperatura, opcao):F2}°C");
//             linha();
//             break;

//         default:
//             Console.WriteLine("Opção inválida!");
//             break;
//     }

//     Console.Write("Deseja fazer outra conversão? (S/N): ");
//     continuar = Console.ReadLine()!;
//     Console.WriteLine();

// }while(continuar.Equals("S", StringComparison.OrdinalIgnoreCase));

// Console.WriteLine("Programa encerrado.");

#region questão1

// void ExibirMensagem()
// {
//     Console.WriteLine("Olá, mundo!");
// }
// ExibirMensagem(); 
#endregion

#region questão2

// string nome = Console.ReadLine();
// void ExibirSaudacao(string name)
// {
//     Console.WriteLine($"Olá, {name}!");
// }
// ExibirSaudacao(nome);

#endregion

#region questão3

// int NumeroAleatorio()
// {
//     Random random = new Random();
//     return random.Next(0, 100);
// }
// Console.Write(NumeroAleatorio());
#endregion

#region questão4

// int n = int.Parse(Console.ReadLine());

// int CalcularQuadrado(int numero)
// {
//     return numero * numero;
// }

// Console.WriteLine(CalcularQuadrado(n)); 
#endregion

#region questão5

// int SomarNumeros(int numero, int numero2)
// {
//     return numero + numero2;
// }
// int n1 = int.Parse(Console.ReadLine()), n2 = int.Parse(Console.ReadLine());

// Console.WriteLine(SomarNumeros(n1, n2));

#endregion

#region questão6

// int CalcularFatorial(int numero)
// {
//     int fatorial = 1;

//     for (int i=numero; i > 0; i--)
//     {
//         fatorial *= i;
//     }
//     return fatorial;
// }
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine(CalcularFatorial(n));  
#endregion

#region questão7

// string PalavraIvertida(string palavraNormal)
// {
//     string palavraInversa="";
//     for (int i=palavraNormal.Length - 1; i >=0; i--)
//     {
//         string letra = palavraNormal[i].ToString();
//         palavraInversa += letra;
//     }
//     return palavraInversa;
// }
// string palavra = Console.ReadLine()!;

// Console.WriteLine(PalavraIvertida(palavra));
    
#endregion

#region questão8

// bool EhPalindrome(string p)
// {
//     int LetraInicio = 0, LetraFim = p.Length - 1;
    
//         while (LetraInicio < LetraFim)
//     {
//         if(p[LetraInicio] != p[LetraFim])
//         {
//             return false;
//         }
//         else if (p[LetraInicio] == p[LetraFim])
//         {
//             LetraInicio++;
//             LetraFim--;
//             continue;
//         } 
//     }
//     return true;
//     }

// string palavra = Console.ReadLine()!;

// if (EhPalindrome(palavra))
//     Console.WriteLine("É palíndrome");
// else
//     Console.WriteLine("Não é palíndrome");
    
#endregion

#region questão9
// int ValorMax(int[] numbers)
// {
//     int maior = 0;
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         if(numbers[i] > maior)
//             maior = numbers[i];
//     }
//     return maior;
// }
// int[] numeros = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

// Console.WriteLine(ValorMax(numeros));
#endregion

#region questão 10
int ContadorDeCaracter(string p, char l)
{
    int contador = 0;
    for(int i = 0; i < p.Length; i++)
    {
        if(p[i] == l)
            contador++;
    }
    return contador;
}
Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine()!;
Console.Write("Digite a letra que deseja contar: ");
char letra = char.Parse(Console.ReadLine()!);

Console.WriteLine($"A letra '{letra}' aparece {ContadorDeCaracter(palavra, letra)} vez(es) na palavra");
#endregion