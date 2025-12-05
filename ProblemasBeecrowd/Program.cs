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

#region media3🌟

// double[] notas = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
// double n1 = notas[0], n2 = notas[1], n3 = notas[2], n4 = notas[3], media = 0, mediaFinal = 0;

// media = Math.Truncate(n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1)/(2+3+4+1);

// Console.WriteLine($"Media: {media:F1}");

// if(media >= 7)
//     Console.WriteLine("Aluno aprovado.");
// else if (media >= 5 && media < 7)
// {   
//     Console.WriteLine("Aluno em exame.");
//     double notaExame = double.Parse(Console.ReadLine());
//     Console.WriteLine($"Nota do exame: {notaExame:F1}");
//     mediaFinal = (media + notaExame) / 2;

//     if(mediaFinal >= 5)
//     {
//         Console.WriteLine("Aluno aprovado.");
//         Console.WriteLine($"Media final: {mediaFinal:F1}");
//     }
//     else
//     {
//         Console.WriteLine("Aluno reprovado.");
//         Console.WriteLine($"Media final: {mediaFinal:F1}");
//     }
// }
// else
//     Console.WriteLine("Aluno reprovado.");
#endregion

#region coordenadas de um ponto

// double[] coordenadas = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
// double x = coordenadas[0], y = coordenadas[1];

// if(x > 0 && y > 0)
//     Console.WriteLine("Q1");
// else if(x < 0 && y > 0)
//     Console.WriteLine("Q2");
// else if(x < 0 && y < 0)
//     Console.WriteLine("Q3");
// else if(x > 0 && y < 0)
//     Console.WriteLine("Q4");
// else if(x == 0 && y > 0 || y < 0)
//     Console.WriteLine("Eixo Y");
// else if(x > 0 || x < 0 && y == 0)
//     Console.WriteLine("Eixo X");
// else Console.WriteLine("Origem");
#endregion

#region sort simples

// int[] numeros = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
// int n1 = numeros[0], n2 = numeros[1], n3 = numeros[2];
// Array.Sort(numeros);

// foreach (int n in numeros)
// {
//     Console.WriteLine(n);
// }
// Console.WriteLine();
// Console.WriteLine(n1);
// Console.WriteLine(n2);
// Console.WriteLine(n3);

#endregion

#region triângulo

// double[] lados = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);

// if(lados[0] + lados[1] > lados[2] && lados[0] + lados[2] > lados[1] && lados[2] + lados[1] > lados[0])
//     Console.WriteLine($"Perimetro: {lados[0] + lados[1] + lados[2]:F1}");
// else Console.WriteLine($"Area: {(lados[0] + lados[1])*lados[2]/2:F1}");
    
#endregion

#region múltiplo

// int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

// if(n[0] % n[1] == 0 || n[1] % n[0] == 0)
//     Console.WriteLine("Sao Multiplos");
// else Console.WriteLine("Nao sao Multiplos");
#endregion

#region tipos de triangulo

// double[] lados = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
// Array.Sort(lados);
// Array.Reverse(lados);

// if(lados[0] >= lados[1] + lados[2])
//     Console.WriteLine("NAO FORMA TRIANGULO");
// else if(Math.Pow(lados[0], 2) == Math.Pow(lados[1], 2) + Math.Pow(lados[2], 2))
//     Console.WriteLine("TRIANGULO RETANGULO");
// else if(Math.Pow(lados[0], 2) > Math.Pow(lados[1], 2) + Math.Pow(lados[2], 2))
//     Console.WriteLine("TRIANGULO OBTUSANGULO");
// else if(Math.Pow(lados[0], 2) < Math.Pow(lados[1], 2) + Math.Pow(lados[2], 2))
//     Console.WriteLine("TRIANGULO ACUTANGULO");

// if(lados[0] == lados[1] && lados[1] == lados[2])
//     Console.WriteLine("TRIANGULO EQUILATERO");
// else if(lados[0] != lados[1] && lados[1] == lados[2] || lados[1] != lados[2] && lados[2] == lados[0] || lados[2] != lados[0] && lados[0] == lados[1])
//     Console.WriteLine("TRIANGULO ISOSCELES");
#endregion

#region tempo de jogo

// int[] hora = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

// if(hora[0] > hora[1])
//     Console.WriteLine($"O JOGO DUROU {(hora[1] + 24)- hora[0]} HORA(S)");
// else if(hora[0] < hora[1])
//     Console.WriteLine($"O JOGO DUROU {hora[1] - hora[0]} HORA(S)");
// else if(hora[0] == hora[1])
//     Console.WriteLine($"O JOGO DUROU 24 HORA(S)");
#endregion

#region tempo de jogo com minutos

// int[] tempo = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
// int HrA = tempo[0], MinA = tempo[1], HrB = tempo[2], MinB = tempo[3], temp = 0;

// temp = ((HrB*60)+MinB) - ((HrA*60)+MinA);

// if (temp <= 0)
//     temp += 24 * 60;
        
// Console.WriteLine($"O JOGO DUROU {temp/60} HORA(S) E {temp%60} MINUTO(S)");
#endregion

#region aumento de salário

// double salario = double.Parse(Console.ReadLine());

// if(salario > 0 && salario <= 400)
//     Console.WriteLine($"Novo salario: {(15 * salario)/100 + salario:F2}\nReajuste ganho: {(15 * salario)/100:F2}\nEm percentual: 15 %");
// else if (salario > 400 && salario <= 800)
//     Console.WriteLine($"Novo salario: {(12 * salario)/100 + salario:F2}\nReajuste ganho: {(12 * salario)/100:F2}\nEm percentual: 12 %");
// else if (salario > 800 && salario <= 1200)
//     Console.WriteLine($"Novo salario: {(10 * salario)/100 + salario:F2}\nReajuste ganho: {(10 * salario)/100:F2}\nEm percentual: 10 %");
// else if (salario > 1200 && salario <= 2000)
//     Console.WriteLine($"Novo salario: {(7 * salario)/100 + salario:F2}\nReajuste ganho: {(7 * salario)/100:F2}\nEm percentual: 7 %");
// else if (salario > 2000)
//     Console.WriteLine($"Novo salario: {(4 * salario)/100 + salario:F2}\nReajuste ganho: {(4 * salario)/100:F2}\nEm percentual: 4 %");
#endregion

#region animal

// string tipoEsqueleto = Console.ReadLine();     
// string classeAnimal = Console.ReadLine();      
// string tipoAlimentacao = Console.ReadLine();

// if (tipoEsqueleto == "vertebrado")
//     if(classeAnimal == "ave")
//         if(tipoAlimentacao == "carnivoro")
//             Console.WriteLine("aguia");
//         else Console.WriteLine("pomba");
//     else
//         if (tipoAlimentacao == "onivoro")
//             Console.WriteLine("homem");
//         else Console.WriteLine("vaca");
// else
//     if(classeAnimal == "inseto")
//         if(tipoAlimentacao == "hematofago")
//             Console.WriteLine("pulga");
//         else Console.WriteLine("lagarta");
//     else
//         if (tipoAlimentacao == "hematofago")
//             Console.WriteLine("sanguessuga");
//         else Console.WriteLine("minhoca");
#endregion

#region ddd

// int ddd = int.Parse(Console.ReadLine());

// switch (ddd)
// {
//     case 61: Console.WriteLine("Brasilia"); break;
//     case 71: Console.WriteLine("Salvador"); break;
//     case 11: Console.WriteLine("Sao Paulo"); break;
//     case 21: Console.WriteLine("Rio de Janeiro"); break;
//     case 32: Console.WriteLine("Juiz de Fora"); break;
//     case 19: Console.WriteLine("Campinas"); break;
//     case 27: Console.WriteLine("Vitoria"); break;
//     case 31: Console.WriteLine("Belo Horizonte"); break;
//     default: Console.WriteLine("DDD nao cadastrado"); break;
// }
#endregion

#region imposto de renda

// double salario = double.Parse(Console.ReadLine());

// if(salario <= 2000)
//     Console.WriteLine($"Isento");
// else if (salario <= 3000)
//     Console.WriteLine($"R$ {(salario - 2000)*0.08:F2}");
// else if (salario <= 4500)
//     Console.WriteLine($"R$ {1000 * 0.08 + (salario - 3000) * 0.18:F2}");
// else Console.WriteLine($"R$ {1000 * 0.08 + 1500 * 0.18 +(salario - 4500) * 0.28:F2}");
#endregion

#region mês

// int mes = int.Parse(Console.ReadLine());

// switch (mes)
// {
//     case 1: Console.WriteLine("January"); break;
//     case 2: Console.WriteLine("February"); break;
//     case 3: Console.WriteLine("March"); break;
//     case 4: Console.WriteLine("April"); break;
//     case 5: Console.WriteLine("May"); break;
//     case 6: Console.WriteLine("June"); break;
//     case 7: Console.WriteLine("July"); break;
//     case 8: Console.WriteLine("August"); break;
//     case 9: Console.WriteLine("September"); break;
//     case 10: Console.WriteLine("October"); break;
//     case 11: Console.WriteLine("November"); break;
//     case 12: Console.WriteLine("December"); break;
//     default: break;
// }
#endregion

#region numeros pares

// for(int i = 1; i <= 100; i++)
// {
//     if(i % 2 == 0)
//         Console.WriteLine(i);
// }
#endregion

#region numeros positivos

// int contador = 0;

// for(int i = 0; i < 6; i++)
// {
//     double numero = double.Parse(Console.ReadLine());
//     if(numero > 0)
//         contador++;
// }
// Console.WriteLine($"{contador} valores positivos");
#endregion

#region tempo de um evento

// string[] diaInicio = Console.ReadLine().Split(' ');
// int diaI = int.Parse(diaInicio[1]);

// string[] horaInicio = Console.ReadLine().Split(' ', ':');
// int horaI = int.Parse(horaInicio[0]);
// int minI = int.Parse(horaInicio[2]);
// int segI = int.Parse(horaInicio[4]);

// string[] diaFim = Console.ReadLine().Split(' ');
// int diaF = int.Parse(diaFim[1]);

// string[] horaFim = Console.ReadLine().Split(' ', ':');
// int horaF = int.Parse(horaFim[0]);
// int minF = int.Parse(horaFim[2]);
// int segF = int.Parse(horaFim[4]);

// int inicio = segI + minI * 60 + horaI * 3600 + diaI * 86400;
// int fim = segF + minF * 60 + horaF * 3600 + diaF * 86400;

// int duracao = fim - inicio;

// int dias = duracao / 86400;
// duracao %= 86400;

// int horas = duracao / 3600;
// duracao %= 3600;

// int minutos = duracao / 60;
// int segundos = duracao % 60;

// Console.WriteLine($"{dias} dia(s)");
// Console.WriteLine($"{horas} hora(s)");
// Console.WriteLine($"{minutos} minuto(s)");
// Console.WriteLine($"{segundos} segundo(s)");
#endregion

#region positivos e média

// double soma = 0, numero;
// int contador = 0;

// for(int i = 0; i < 6; i++)
// {
//     numero = double.Parse(Console.ReadLine());
//     if(numero > 0)
//     {
//         soma+=numero;
//         contador++;
//     }
// }
// Console.WriteLine($"{contador} valores positivos");
// Console.WriteLine($"{soma / contador:F1}");
#endregion

#region pares entre cinco numeros

// int contador = 0;

// for(int i = 0; i < 5; i++)
// {
//     int numero = int.Parse(Console.ReadLine());
//     if(numero % 2 == 0)
//         contador++;
// }
// Console.WriteLine($"{contador} valores pares");
#endregion

#region pares, impares, positivos e negativos

// int par = 0, impar = 0, positivo = 0, negativo = 0;

// for(int i = 0; i < 5; i++)
// {
//     int n = int.Parse(Console.ReadLine());
//     if(n % 2 == 0)
//         par++;
//     if(n % 2 != 0)
//         impar++;
//     if(n > 0)
//         positivo++;
//     if(n < 0)
//         negativo++;
// }
// Console.WriteLine($"{par} valor(es) par(es)");
// Console.WriteLine($"{impar} valor(es) impar(es)");
// Console.WriteLine($"{positivo} valor(es) positivo(s)");
// Console.WriteLine($"{negativo} valor(es) negativo(s)");
#endregion

#region numeros impares

// int n = int.Parse(Console.ReadLine());

// for(int i = 1; i <= n; i++)
// {
//     if(i % 2 != 0)
//         Console.WriteLine(i);
// }
#endregion

#region seis numeros impares

// int n = int.Parse(Console.ReadLine());

// for(int i = n; i <= n+11; i++)
// {
//     if(i % 2 != 0)
//         Console.WriteLine(i);
// }
#endregion

#region soma de impares consecutivos

// int x = int.Parse(Console.ReadLine()), y = int.Parse(Console.ReadLine()), soma = 0;

// for(int i = x-1; i > y; i--)
// {
//     if(i % 2 != 0)
//         soma+=i;
// }
// Console.WriteLine(soma);
#endregion

#region intervalo 2

// int n = int.Parse(Console.ReadLine()), inp = 0, outp = 0;

// for (int i = 0; i < n; i++)
// {
//     int x = int.Parse(Console.ReadLine());
//     if(x >= 10 && x <= 20)
//         inp++;
//     else outp++;
// }
// Console.WriteLine($"{inp} in\n{outp} out");
#endregion

#region quadrado de pares

// int n = int.Parse(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//     if (i % 2 == 0)
//         Console.WriteLine($"{i} ^ 2 = {Math.Pow(i, 2)}");
// }
#endregion

#region par ou impar

// int n = int.Parse(Console.ReadLine());

// for (int i = 0; i < n; i++)
// {
//     int x = int.Parse(Console.ReadLine());
//     if(x % 2 == 0 && x > 0)
//         Console.WriteLine("EVEN POSITIVE");
//     else if(x % 2 == 0 && x < 0)
//         Console.WriteLine("EVEN NEGATIVE");
//     else if(x % 2 != 0 && x > 0)
//         Console.WriteLine("ODD POSITIVE");
//     else if(x % 2 != 0 && x < 0)
//         Console.WriteLine("ODD NEGATIVE");
//     else Console.WriteLine("NULL");
// }
#endregion

#region resto2

// int n = int.Parse(Console.ReadLine());

// for(int i = 1; i <= 10000; i++)
// {
//     if(i % n == 2)
//         Console.WriteLine(i);
// }
#endregion

#region tabuada

// int n = int.Parse(Console.ReadLine());

// for(int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{i} x {n} = {i*n}");
// }
#endregion

#region media ponderada

// int n = int.Parse(Console.ReadLine());

// for(int i = 0; i < n; i++)
// {
//     double[] x = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
//     Console.WriteLine($"{(x[0]*2 + x[1]*3 + x[2]*5)/(2+3+5):F1}");
// }
#endregion

#region maior e posição

// int maior = 0, posicao = 0;

// for(int i = 1; i <= 100; i++)
// {
//     int x = int.Parse(Console.ReadLine());
//     if(x > maior)
//     {
//         maior = x;
//         posicao = i;
//     }
// }
// Console.WriteLine(maior);
// Console.WriteLine(posicao);
#endregion

#region experiencias

// int n = int.Parse(Console.ReadLine()), soma = 0, coelho = 0, sapo = 0, rato = 0;

// for(int i = 0; i < n; i++)
// {
//     string[] x = Console.ReadLine().Split(' ');
//     int quantia = int.Parse(x[0]);
//     char tipo = char.Parse(x[1]);

//     if(tipo == 'R')
//         rato += quantia;
//     else if (tipo == 'S')
//         sapo += quantia;
//     else if (tipo == 'C')
//         coelho += quantia;
//     soma += quantia;
// }
// Console.WriteLine($"Total: {soma} cobaias");
// Console.WriteLine($"Total de coelhos: {coelho}");
// Console.WriteLine($"Total de ratos: {rato}");
// Console.WriteLine($"Total de sapos: {sapo}");
// Console.WriteLine($"Percentual de coelhos: {(double)coelho/(double)soma*100:F2} %");
// Console.WriteLine($"Percentual de ratos: {(double)rato/(double)soma*100:F2} %");
// Console.WriteLine($"Percentual de sapos: {(double)sapo/(double)soma*100:F2} %");
#endregion

#region sequencia ij1
// int j = 60;
// for (int i = 1; j >= 0; i += 3)
// {
//     Console.WriteLine($"I={i} J={j}");
//     j-=5;
// }
#endregion

#region sequencia ij2
// int j = 7;
// for (int i = 1; i < 10; i += 2)
// {
//     for(int x = 0; x < 3; x++)
//     {
//         Console.WriteLine($"I={i} J={j}");
//         j--;
//     }
//     j=7;
// }
#endregion

#region sequencia ij3
// int j = 7, aux = 0;
// for (int i = 1; i < 10; i += 2)
// {
//     for(int x = 0; x < 3; x++)
//     {
//         Console.WriteLine($"I={i} J={j}");
//         j--;
//     }
//     aux = j + 5;
//     j = aux; 
// }
#endregion

#region sequencia ij4
// double i = 0;

// while (i <= 2.0 + 0.0001) // margem para evitar erro de ponto flutuante
// {
//     double j1 = 1 + i;
//     double j2 = 2 + i;
//     double j3 = 3 + i;

//     if (Math.Abs(i - Math.Round(i)) < 0.0001)
//     {
//         Console.WriteLine($"I={i:0} J={j1:0}");
//         Console.WriteLine($"I={i:0} J={j2:0}");
//         Console.WriteLine($"I={i:0} J={j3:0}");
//     }
//     else
//     {
//         Console.WriteLine($"I={i:0.0} J={j1:0.0}");
//         Console.WriteLine($"I={i:0.0} J={j2:0.0}");
//         Console.WriteLine($"I={i:0.0} J={j3:0.0}");
//     }

//     i += 0.2;
// }

#endregion

#region soma de impares consecutivos II
// int n = int.Parse(Console.ReadLine());

// for(int i = 0; i < n; i++)
// {
//     int soma = 0;
//     int[] xEy = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
//     if(xEy[0] <= xEy[1])
//     {
//         for(int x = xEy[0]+1; x < xEy[1]; x++)
//         {
//         if(x % 2 != 0)
//             soma += x;
//         }
//     }
//     else
//     {
//         for(int x = xEy[1]+1; x < xEy[0]; x++)
//         {
//         if(x % 2 != 0)
//             soma += x;
//         }
//     }
//     Console.WriteLine(soma);
// }
#endregion

#region sequencia de numeros e soma
int[] xEy = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int soma = 0;
while(xEy[0] > 0 && xEy[1] > 0)
{
    if(xEy[0] < xEy[1])
    {
        for(int i = xEy[0]; i <= xEy[1]; i++)
        {
            Console.Write($"{i} ");
            soma += i;
        }
        Console.WriteLine($"Sum={soma}");
    }
    else
    {
        for(int i = xEy[1]; i <= xEy[0]; i++)
        {
            Console.Write($"{i} ");
            soma += i;
        }
        Console.WriteLine($"Sum={soma}");
    }
    soma = 0;
    xEy = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
}
#endregion