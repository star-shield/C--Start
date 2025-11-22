// See https://aka.ms/new-console-template for more information
#region questão1
// void MostrarMsg(string msg)
// {
//     Console.WriteLine(msg);
// }
// string mensagem = Console.ReadLine()!;
// MostrarMsg(mensagem);

#endregion

#region questão2
// void ExibirSaudacaoHora(string nome)
// {
//     DateTime horaLocal = DateTime.Now;
//     int hora = int.Parse(horaLocal.ToString("HH"));
//     if(hora >= 6 && hora <= 12)
//         Console.WriteLine($"Bom dia, {nome}!");
//     else if(hora > 12 && hora <= 18)
//         Console.WriteLine($"Boa tarde, {nome}!");
//     else Console.WriteLine($"Boa noite, {nome}!");
// }
// string nome = Console.ReadLine()!;

// ExibirSaudacaoHora(nome);
    
#endregion

#region questão3
// int RetornarValorAleatorio(int a, int b)
// {
//     Random random = new Random();
//     return random.Next(a, b);
// }
// int min = int.Parse(Console.ReadLine()!);
// int max = int.Parse(Console.ReadLine()!);

// Console.WriteLine(RetornarValorAleatorio(min, max));
#endregion

#region questão4
// int CalcularCubo(int a)
// {
//     return (int)Math.Pow(a, 3);;
// }
// int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine(CalcularCubo(n));
#endregion

#region questão5
// int MultiDoisNumeros(int n, int n2)
// {
//     return n * n2;
// }
// int numero = int.Parse(Console.ReadLine()!), numero2 = int.Parse(Console.ReadLine()!);

// Console.WriteLine(MultiDoisNumeros(numero, numero2));
#endregion

#region questão6
// int SomaAteN(int numero)
// {
//     int soma = 0;
//     for(int i = 1; i <= numero; i++)
//     {
//         soma += i;
//     }
//     return soma;
// }
// int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine(SomaAteN(n));    
#endregion

#region questão7
// string CocatenarString(string l, int x)
// {
//     string StringRepetida = "";
//     for(int i = 0; i < x; i++)
//     {
//         StringRepetida += l;
//     }
//     return StringRepetida;
// }
// int n = int.Parse(Console.ReadLine()!);
// string letra = Console.ReadLine()!;

// Console.WriteLine(CocatenarString(letra, n));
#endregion

#region questão8
bool VerificarString(string p)
{
    string numeros = "0123456789";
    for(int i = 0; i < p.Length; i++)
    {
        if(numeros.Contains(p[i]))
            return false;
    }
    return true;
}
string palavra = Console.ReadLine()!;
if(VerificarString(palavra))
    Console.WriteLine("contem apenas palavras");
else Console.WriteLine("não contem apenas palavras");
#endregion

#region questão9
// int MenorNumero(int[] n)
// {
//     Array.Sort(n);
//     return n[0];
// }
// int[] numeros = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
// Console.WriteLine(MenorNumero(numeros));
#endregion

#region questão10
// int NumerosDePalvras(string a)
// {
//     int contador = 1;
//     for(int i=0; i < a.Length; i++)
//     {
//         if(a[i] == ' ')
//             contador++;
//     }
//     return contador;
// }
// string frase = Console.ReadLine()!;
// Console.WriteLine(NumerosDePalvras(frase));
#endregion