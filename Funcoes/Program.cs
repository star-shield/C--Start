// See https://aka.ms/new-console-template for more information
void menu()
{
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("Conversor de Temperatura");
    Console.WriteLine("Escolha a opção de conversão:");
    Console.WriteLine("1 - Celsius para Fahrenheit");
    Console.WriteLine("2 - Fahrenheit para Celsius");
    Console.WriteLine("3 - Celsius para Kelvin");
    Console.WriteLine("4 - Kelvin para Celsius");
    Console.Write("Opção: ");

    string opcao = Console.ReadLine()!;
}

int ConversorDeTemperatura(string OpcaoEscolhida)
{
    string continuar;

do
{
    double temperatura, resultado;

    switch (OpcaoEscolhida)
    {
        case "1":
            Console.WriteLine("--------------------------------------");
            Console.Write("Digite a temperatura em Celsius: ");
            temperatura = double.Parse(Console.ReadLine()!);
            resultado = (temperatura * 9 / 5) + 32;
            Console.WriteLine($"{temperatura}°C = {resultado:F2}°F");
            Console.WriteLine("--------------------------------------");
            break;

        case "2":
            Console.WriteLine("--------------------------------------");
            Console.Write("Digite a temperatura em Fahrenheit: ");
            temperatura = double.Parse(Console.ReadLine()!);
            resultado = (temperatura - 32) * 5 / 9;
            Console.WriteLine($"{temperatura}°F = {resultado:F2}°C");
            Console.WriteLine("--------------------------------------");
            break;

        case "3":
            Console.WriteLine("--------------------------------------");
            Console.Write("Digite a temperatura em Celsius: ");
            temperatura = double.Parse(Console.ReadLine()!);
            resultado = temperatura + 273.15;
            Console.WriteLine($"{temperatura}°C = {resultado:F2}K");
            Console.WriteLine("--------------------------------------");
            break;

        case "4":
            Console.WriteLine("--------------------------------------");
            Console.Write("Digite a temperatura em Kelvin: ");
            temperatura = double.Parse(Console.ReadLine()!);
            resultado = temperatura - 273.15;
            Console.WriteLine($"{temperatura}K = {resultado:F2}°C");
            Console.WriteLine("--------------------------------------");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.Write("Deseja fazer outra conversão? (S/N): ");
    continuar = Console.ReadLine()!;
    Console.WriteLine();

} while (continuar.Equals("S", StringComparison.OrdinalIgnoreCase));
}
