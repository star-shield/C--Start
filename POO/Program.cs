class Program
{
    static void Main()
    {
        Carro carro = new Carro(ano: 2020, marca: "toyota", modelo: "corolla");
        Console.WriteLine(carro.Ano);

        Console.WriteLine(carro);
    }
}
