void linha()
{
    Console.WriteLine("--------------------------------------");
}
double ConversorDeTemperatura(double temperatura, string OpcaoEscolhida)
{
    double resultado=0;
    switch (OpcaoEscolhida)
    {
        case "1":
            resultado = (temperatura * 9 / 5) + 32;
            break;

        case "2":
            resultado = (temperatura - 32) * 5 / 9;
            break;

        case "3":
            resultado = temperatura + 273.15;
            break;

        case "4":
            resultado = temperatura - 273.15;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    return resultado;
}
string continuar;
do
{
    linha();
    Console.WriteLine("Conversor de Temperatura");
    Console.WriteLine("Escolha a opção de conversão:");
    Console.WriteLine("1 - Celsius para Fahrenheit");
    Console.WriteLine("2 - Fahrenheit para Celsius");
    Console.WriteLine("3 - Celsius para Kelvin");
    Console.WriteLine("4 - Kelvin para Celsius");
    Console.Write("Opção: ");
    string opcao = Console.ReadLine()!;
    
    double temperatura;
    switch (opcao)
    {
        case "1":
            linha();
            Console.Write("Digite a temperatura em Celsius: ");
            temperatura = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"{temperatura}°C = {ConversorDeTemperatura(temperatura, opcao):F2}°F");
            linha();
            break;

        case "2":
            linha();
            Console.Write("Digite a temperatura em Fahrenheit: ");
            temperatura = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"{temperatura}°F = {ConversorDeTemperatura(temperatura, opcao):F2}°C");
            linha();
            break;

        case "3":
            linha();
            Console.Write("Digite a temperatura em Celsius: ");
            temperatura = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"{temperatura}°C = {ConversorDeTemperatura(temperatura, opcao):F2}K");
            linha();
            break;

        case "4":
            linha();
            Console.Write("Digite a temperatura em Kelvin: ");
            temperatura = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"{temperatura}K = {ConversorDeTemperatura(temperatura, opcao):F2}°C");
            linha();
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.Write("Deseja fazer outra conversão? (S/N): ");
    continuar = Console.ReadLine()!;
    Console.WriteLine();

}while(continuar.Equals("S", StringComparison.OrdinalIgnoreCase));

Console.WriteLine("Programa encerrado.");