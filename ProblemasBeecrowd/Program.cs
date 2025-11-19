#region hello world

// Console.WriteLine("Hello, World!");
#endregion

#region extremamente básico

// int A = int.Parse(Console.ReadLine());
// int B = int.Parse(Console.ReadLine());

// int X = A + B;

// Console.WriteLine("X = " + X);
#endregion

#region área do circulo
// double pi = 3.14159;
// double raio = double.Parse(Console.ReadLine());

// double area = pi * (raio * raio);

// Console.WriteLine($"A={area:F4}");
#endregion

#region soma simples

// int A = int.Parse(Console.ReadLine());
// int B = int.Parse(Console.ReadLine());

// int SOMA = A + B;

// Console.WriteLine($"SOMA = {SOMA}");

#endregion

#region produto simples

// int A = int.Parse(Console.ReadLine());
// int B = int.Parse(Console.ReadLine());

// int PROD = A * B;

// Console.WriteLine($"PROD = {PROD}");
#endregion

#region média 1

// double A = double.Parse(Console.ReadLine());
// double B = double.Parse(Console.ReadLine());

// double MEDIA = (A * 3.5 + B * 7.5) / 11;
// Console.WriteLine($"MEDIA = {MEDIA:F5}");
#endregion

#region media 2

// double A = double.Parse(Console.ReadLine());
// double B = double.Parse(Console.ReadLine());
// double C = double.Parse(Console.ReadLine());

// double MDEIA = (A * 2 + B * 3 + C * 5) / 10;

// Console.WriteLine($"MEDIA = {MDEIA:F1}");
#endregion

#region diferença

// int A = int.Parse(Console.ReadLine());
// int B = int.Parse(Console.ReadLine());
// int C = int.Parse(Console.ReadLine());
// int D = int.Parse(Console.ReadLine());

// int DIFERENCA = (A * B - C * D);

// Console.WriteLine($"DIFERENCA = {DIFERENCA}");
#endregion

#region salário

// int numero = int.Parse(Console.ReadLine());
// int horas = int.Parse(Console.ReadLine());
// double valorPorHora = double.Parse(Console.ReadLine());

// double salario = (horas * valorPorHora);

// Console.WriteLine($"NUMBER = {numero}\nSALARY = U$ {salario:F2}");
#endregion

#region salário com bônus

// string nome = Console.ReadLine();
// double salarioFixo = double.Parse(Console.ReadLine());
// double vendaTotal = double.Parse(Console.ReadLine());

// double valorTotal = ((15 * vendaTotal)/100+(salarioFixo));
// Console.WriteLine($"TOTAL = R$ {valorTotal:F2}");
#endregion

#region cálculo simples🌟

// string[] p1 = new string[2];
// string[] p2 = new string[2];

// p1 = Console.ReadLine().Split(' ');
// p2 = Console.ReadLine().Split(' ');

// int codigo1 = int.Parse(p1[0]);
// int numeroDePecas1 = int.Parse(p1[1]);
// double valorDasPecas1 = double.Parse(p1[2]);

// int codigo2 = int.Parse(p2[0]);
// int numeroDePecas2 = int.Parse(p2[1]);
// double valorDasPecas2 = double.Parse(p2[2]);

// double valor = ((numeroDePecas1 * valorDasPecas1) + (numeroDePecas2 * valorDasPecas2));

// Console.WriteLine($"VALOR A PAGAR: R$ {valor:F2}");

#endregion

#region esfera

// double raio = double.Parse(Console.ReadLine());
// const double pi = 3.14159;

// double volume = (4 / 3.0) * pi * (raio * raio * raio);
// Console.WriteLine($"VOLUME = {volume:F3}");

#endregion

#region área

// string[] n = Console.ReadLine().Split(' ');

// double A = double.Parse(n[0]);
// double B = double.Parse(n[1]);
// double C = double.Parse(n[2]);

// Console.WriteLine($"TRIANGULO: {(A*C)/2:F3}\nCIRCULO: {3.14159* (C*C):F3}\nTRAPEZIO: {(A+B)*C/2:F3}\nQUADRADO: {B*B:F3}\nRETANGULO: {A*B:F3}");
#endregion

#region o maior🌟
    
// int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

// int MaiorAB = (n[0] + n[1] + Math.Abs(n[0] - n[1]))/2;
// int MaiorABC = (MaiorAB + n[2] + Math.Abs(MaiorAB - n[2]))/2;

// Console.WriteLine($"{MaiorABC} eh o maior");
#endregion

#region consumo

// int X = int.Parse(Console.ReadLine());
// double Y = double.Parse(Console.ReadLine()), Z = X;

// Console.WriteLine($"{Z/Y:F3} km/l");

#endregion

#region distância entre dois pontos

// float[] primeiraLinha = Array.ConvertAll(Console.ReadLine().Split(' '), float.Parse);
// float[] segundaLinha = Array.ConvertAll(Console.ReadLine().Split(' '), float.Parse);

// float x1 = primeiraLinha[0], y1 = primeiraLinha[1], x2 = segundaLinha[0], y2 = segundaLinha[1];

// Console.WriteLine($"{Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)):F4}");
    
#endregion

#region distância

// int km = int.Parse(Console.ReadLine());

// Console.WriteLine($"{km*2} minutos");
    
#endregion

#region gasto de combustível

// int horas = int.Parse(Console.ReadLine()), velocidade = int.Parse(Console.ReadLine());

// double distanciaPercorrida = velocidade * horas;

// Console.WriteLine($"{distanciaPercorrida/12:F3}");

#endregion

#region cédulas

// int n = int.Parse(Console.ReadLine()), valorDigitado = n;

// int cem = n/100, um = 0;
// n%=100;

// int cinquenta = n / 50;
// n%=50;

// int vinte = n / 20;
// n%=20;

// int dez = n / 10;
// n%=10;

// int cinco = n / 5;
// n%=5;

// int dois = n / 2;
// n%=2;
// um = n;

// Console.WriteLine($"{valorDigitado}\n{cem} nota(s) de R$ 100,00\n{cinquenta} nota(s) de R$ 50,00\n{vinte} nota(s) de R$ 20,00\n{dez} nota(s) de R$ 10,00\n{cinco} nota(s) de R$ 5,00\n{dois} nota(s) de R$ 2,00\n{um} nota(s) de R$ 1,00");
#endregion

#region conversão de tempo

// int s = int.Parse(Console.ReadLine());

// int horas = s / 3600;
// int minutos = (s%3600) / 60;
// int segundos = s%60;
    
// Console.WriteLine($"{horas}:{minutos}:{segundos}");
#endregion

#region idade em dias

// int dias = int.Parse(Console.ReadLine());

// int ano = dias / 365;
// dias %= 365;

// int mes = dias / 30;
// dias %= 30;

// Console.WriteLine($"{ano} ano (s)\n{mes} mes (es)\n{dias} dia (s)");
    
#endregion

#region notas e moedas🌟

// double dinheiro = double.Parse(Console.ReadLine());
// dinheiro = Math.Round(dinheiro, 2);

// double n100 = dinheiro / 100;
// int nota100 = ((int)n100);
// dinheiro %= 100;

// double n50 = dinheiro / 50;
// int nota50 = ((int)n50);
// dinheiro %= 50;

// double n20 = dinheiro / 20;
// int nota20 = ((int)n20);
// dinheiro %= 20;

// double n10 = dinheiro / 10;
// int nota10 = ((int)n10);
// dinheiro %= 10;

// double n5 = dinheiro / 5;
// int nota5 = ((int)n5);
// dinheiro %= 5;

// double n2 = dinheiro / 2;
// int nota2 = ((int)n2);
// dinheiro %= 2;

// double m1 = dinheiro / 1;
// int moeda1 = ((int)m1);
// dinheiro %= 1;

// double m050 = dinheiro / 0.50;
// int moeda50 = ((int)m050);
// dinheiro %= 0.50;

// double m025 = dinheiro / 0.25;
// int moeda25 = ((int)m025);
// dinheiro %= 0.25;

// double m010 = dinheiro / 0.10;
// int moeda10 = ((int)m010);
// dinheiro %= 0.10;

// double m05 = dinheiro / 0.05;
// int moeda5 = ((int)m05);
// dinheiro %= 0.05;

// double m01 = dinheiro / 0.01;
// int moeda01 = ((int)m01);

// Console.WriteLine("NOTAS:");
// Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
// Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
// Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
// Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
// Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
// Console.WriteLine($"{nota2} nota(s) de R$ 2.00");
// Console.WriteLine("MOEDAS:");
// Console.WriteLine($"{moeda1} moeda(s) de R$ 1.00");
// Console.WriteLine($"{moeda50} moeda(s) de R$ 0.50");
// Console.WriteLine($"{moeda25} moeda(s) de R$ 0.25");
// Console.WriteLine($"{moeda10} moeda(s) de R$ 0.10");
// Console.WriteLine($"{moeda5} moeda(s) de R$ 0.05");
// Console.WriteLine($"{moeda01} moeda(s) de R$ 0.01");
#endregion

#region teste de seleção 1

// int[] numeros = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

// int A = numeros[0], B = numeros[1], C = numeros[2], D = numeros[3];

// int SomaCD = C + D, SomaAB = A + B;

// if (B > C && D > A && SomaCD > SomaAB && C > 0 && D > 0 && A % 2 == 0)
// {
//     Console.WriteLine("valores aceitos");
// }
// else
// {
//     Console.WriteLine("valores nao aceitos");
// }
    
#endregion

#region formula de bhaskara

// double[] numeros = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);

// double A = numeros[0], B = numeros[1], C = numeros[2];

// double delta = Math.Pow(B, 2) - 4 * A * C;

// if (A == 0 || delta < 0)
// {
//     Console.WriteLine("Impossivel calcular");
// }
// else
// {
//     Console.WriteLine($"R1 = {(-B + Math.Sqrt(delta))/(2*A):F5}");
//     Console.WriteLine($"R2 = {(-B - Math.Sqrt(delta))/(2*A):F5}");
// }
#endregion

#region intervalo

// double n = double.Parse(Console.ReadLine());

// if (n > 0 && n <= 25)
//     Console.WriteLine("Intervalo [0,25]");
// else if (n > 25 && n <= 50)
//     Console.WriteLine("Intervalo (25,50]");
// else if (n > 50 && n <= 75)
//     Console.WriteLine("Intervalo (50,75]");
// else if (n > 75 && n <= 100)
//     Console.WriteLine("Intervalo (75,100]");
// else
//     Console.WriteLine("Fora de intervalo");
    
#endregion

#region lanche

// int[] entrada = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

// int codigo = entrada[0], quantidade = entrada[1];

// switch (codigo)
// {
//     case 1: Console.WriteLine($"Total: R$ {4.00 * (double)quantidade:F2}"); break;
//     case 2: Console.WriteLine($"Total: R$ {4.50 * (double)quantidade:F2}"); break;
//     case 3: Console.WriteLine($"Total: R$ {5.00 * (double)quantidade:F2}"); break;
//     case 4: Console.WriteLine($"Total: R$ {2.00 * (double)quantidade:F2}"); break;
//     case 5: Console.WriteLine($"Total: R$ {1.50 * (double)quantidade:F2}"); break;
//     default: Console.WriteLine("Valor inválido"); break;
// }
    
#endregion
