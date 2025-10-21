// See https://aka.ms/new-console-template for more information
#region positivo e negativo

// var numero = 20;

// Console.WriteLine($"Verificando se o número {numero} é positivo ou negativo");

// if(numero > 0)
// {
//     Console.Write("Esse número é positivo");
// }
// else
// {
//     Console.Write("Esse número é negativo");
// }

#endregion

#region esta choveno

// bool estaChovendo = true;

// Console.Write("Saindo de casa");
// if(estaChovendo)
// {
//     Console.WriteLine("Leve o guarda chuva");
//     Console.Write("Continue o passeio");
// }
// else
// {
//     Console.Write("Continue o passeio");
// }

#endregion

#region atividade if/else

// int temperatura;

// Console.Write("Digite a temperatura em celsius: ");
// temperatura = int.Parse(Console.ReadLine()!);

// if (temperatura < 0)
//     {
//         Console.Write("temperatura negativa");
//     }
// else if (temperatura <= 30)
//     {
//         Console.Write("temperatura amena");
//     }
//     else
//         {
//             Console.Write("temperatura alta");
//         }

#endregion

#region atividade operador ternério


// int numero;

// Console.Write("Digite um número: ");
// numero = int.Parse(Console.ReadLine()!);

// string mensagem = numero > 0 ? $"{numero} É POSITIVO" : numero < 0 ?$ "{numero} É NEGATIVO": "zero"

// Console.Write(mensagem);

#endregion

#region atividade switch

char opcao;
Console.WriteLine("\n*DIGITE A OPÇÃO ABAIXO*\n");
Console.WriteLine("A) Produto alimentício");
Console.WriteLine("B) Produto bebida");
Console.WriteLine("C) Produto limpeza");
Console.WriteLine("D) Produto eletrônico");

opcao = Console.ReadKey().KeyChar;

switch (opcao)
{
    case 'A': Console.Write("\nDescrição do produto alimentício..."); break;
    case 'B': Console.Write("\nDescrição das bebidas...") ;break;
    case 'C': Console.Write("\nDescrição do produto de limpeza..."); break;
    case 'D': Console.Write("\nDescrição do produto eletrônico..."); break;
    default: Console.Write("\nCategoria inválida"); break;
}
#endregion

