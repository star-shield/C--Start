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
int s,m,h;

Console.Write("Digite os segundos: ");
s = int.Parse(Console.ReadLine()!);
h = s / 3600;
m = (s%3600)/60;
s = m / 30;
Console.Write($"{h} horas, {m} minutos e {s} segundos ");
#endregion

#region questão9
    
#endregion