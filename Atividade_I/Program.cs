// See https://aka.ms/new-console-template for more information
#region questão1

using System.Globalization;
using System.Security.Cryptography;
/*
double a, b, c, area, p;

Console.Write("Digite o primeiro lado: ");
a = double.Parse(Console.ReadLine()!);
Console.Write("Digite o segundo lado: ");
b = double.Parse(Console.ReadLine()!);
Console.Write("Digite o terceiro lado: ");
c = double.Parse(Console.ReadLine()!);

p = (a + b + c) / 2;
area = Math.Sqrt(p*(p - a)*(p - b)*(p - c));

Console.WriteLine($"Perímetro do triângulo: {p}");
Console.Write($"Área do triângulo: {area}");
*/
#endregion

#region questão2

// float horasTrabalho;
// decimal valorHora;

// Console.Write("Digite as horas trabalhadas: ");
// horasTrabalho = float.Parse(Console.ReadLine()!);
// Console.Write("Digite o valor da hora: ");
// valorHora = decimal.Parse(Console.ReadLine()!);


// Console.Write($"O salário bruto é: {(decimal)horasTrabalho * valorHora:F2}");
#endregion

#region questão3
/*
double vKm, t;

Console.Write("Digite a velocidade Km/h: ");
vKm = double.Parse(Console.ReadLine()!);
Console.Write("Digite o tempo percorrido: ");
t = double.Parse(Console.ReadLine()!);

Console.Write($"A distância percorrida foi: {vKm*t}");
*/
#endregion

#region questão4
/*
int raio;

Console.Write("Digite o raio: ");
raio = int.Parse(Console.ReadLine()!);

Console.Write($"O volume da esfera é: {(4/3)*3.14*raio*raio*raio}");
*/
#endregion

#region questão5
/*
float F;

Console.Write("Entre com a temperatura em F: ");
F = float.Parse(Console.ReadLine()!);

Console.Write($"A temperatura convertida é: {(F-32)*5/9:F2}C°");
*/
#endregion

#region questão6
/*
double a, b, c, d;

Console.Write("Digite a primeira nota: ");
a = double.Parse(Console.ReadLine()!);
Console.Write("Digite a segunda nota: ");
b = double.Parse(Console.ReadLine()!);
Console.Write("Digite a terceira nota: ");
c = double.Parse(Console.ReadLine()!);
Console.Write("Digite a quarta nota: ");
d = double.Parse(Console.ReadLine()!);

Console.Write($"A média ponderada é: {(a*1+b*2+c*3+d*4)/(1+2+3+4)}");
*/
#endregion

#region questão7
/*
decimal real, imposto;

Console.Write("Digite o valor R$: ");
real = decimal.Parse(Console.ReadLine()!);

imposto = real * (7 / 100);
Console.Write($"{real + imposto} ");
*/
#endregion

#region questão8

// int s,m,h;

// Console.Write("Digite os segundos: ");
// s = int.Parse(Console.ReadLine()!);
// h = s / 3600;
// m = (s%3600)/60;
// s = s % 60;
// Console.Write($"{h} horas, {m} minutos e {s} segundos ");
#endregion

#region questão9
// double a, b;

// Console.Write("Digite o valor de A: ");
// a = double.Parse(Console.ReadLine()!);
// Console.Write("Digite o valor de B: ");
// b = double.Parse(Console.ReadLine()!);

// Console.Write($"A hipotenusa é: {Math.Sqrt(a*a+b*b)}");
#endregion

#region questão10
// float distancia, tempo;
// Console.Write("Digite a distância em Km: ");
// distancia = float.Parse(Console.ReadLine()!);
// Console.Write("Digite o tempo em segundos: ");
// tempo = float.Parse(Console.ReadLine()!);

// Console.Write($"A velocidade média é: {(distancia/1000)/(tempo/3600):F2} Km/h");
#endregion

#region atividade if/else

// int a;

// Console.Write("Digite um número inteiro: ");
// a = int.Parse(Console.ReadLine()!);
// if (a % 2 == 0)
// {
//     Console.WriteLine("O número é par");
// }
// else if (a % 2 != 0)
// {
//     Console.WriteLine("O número é ímpar");
// }else
// {
//     Console.WriteLine("Zero");
// }

// double nota;

// Console.Write("Digite a nota do aluno: ");
// nota = double.Parse(Console.ReadLine()!);

// if(nota >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }
#endregion

#region atividade com switch

// int a;
// Console.Write("Digite um número de 1 a 7: ");
// a = int.Parse(Console.ReadLine()!);

// switch (a)
// {
//     case 1: Console.Write("domingo"); break;
//     case 2: Console.Write("segunda"); break;
//     case 3: Console.Write("terça"); break;
//     case 4: Console.Write("quarta"); break;
//     case 5: Console.Write("quinta"); break;
//     case 6: Console.Write("sexta"); break;
//     case 7: Console.Write("sábado"); break;
//     default: Console.Write("valor iválido"); break;
// }

// char a;
// string b;
// Console.Write("Informação de combustível");
// Console.Write("A) G) D)");
// a = Console.ReadKey().KeyChar;

// switch (b=a.ToString().ToUpper())
// {
//     case "A": Console.Write("Alcool"); break;
//     case "G": Console.Write("Gasolina"); break;
//     case "D": Console.Write("Diesel"); break;
//     default: Console.Write("valor inválido"); break;
// }
#endregion

#region atividade valor ternário

// int a;

// Console.Write("digite um número ");
// a = int.Parse(Console.ReadLine()!);

// string menssagi = a % 2 == 0 ? "par" : "impar";
// Console.Write(menssagi);
#endregion

#region estruturas de repetição for
//DESAFIO 1
// int numero;

// Console.Write("Digite um número: ");
// numero = int.Parse(Console.ReadLine()!);

// for (int i = 1; i <=10; i++)
// {

//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }

// DESAFIO 2

// int numero;

// Console.Write("Digite um número de 1 a 100: ");
// numero = int.Parse(Console.ReadLine()!);

// for (int i=0; i<=numero; i++)
// {
//     Console.WriteLine(i);
// }

//DESAFIO 3

// int numero, multi;

// Console.Write("Digite um número: ");
// numero = int.Parse(Console.ReadLine()!);
// Console.Write("Digite o multiplicador: ");
// multi = int.Parse(Console.ReadLine()!);

// for (int i = 0; i <= numero; i = i + multi)
// {
//     Console.WriteLine(i);
// }
#endregion

#region estrutura de repetição while

//DESAFIO

Console.WriteLine("JOGADOR DESAFIANTE");
Console.WriteLine("Informe um número de 0 a 9");
int numero = int.Parse(Console.ReadLine());

while (numero > 9)
{
    Console.WriteLine("Número digitado é maior que 9, tente novamente ");
     numero = int.Parse(Console.ReadLine());
}
Console.Clear();

Console.WriteLine("JOGADOR DESAFIADO");
Console.WriteLine("Tente descobrir o número de 0 a 9");
int valor = int.Parse(Console.ReadLine());

while (valor > 9)
{
    Console.WriteLine("Número digitado é maior que 9, tente novamente ");
    valor = int.Parse(Console.ReadLine());
}
while (valor != numero)
{
    Console.WriteLine("Você ERROU! Tente novamente!");
    valor = int.Parse(Console.ReadLine());

}
    Console.WriteLine("PARADCNS, VOCE ACERTOU!");
#endregion