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