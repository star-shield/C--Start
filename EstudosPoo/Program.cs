class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria("Felipe", 1000);
        Console.WriteLine($"Conta {conta.numeroId} foi criada por {conta.nomeProprietario} com {conta.saldo} de saldo inicial.");
    }
}