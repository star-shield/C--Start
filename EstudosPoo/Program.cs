using System.ComponentModel;
class Program
{
    static void Main()
    {
        var conta = new ContaBancaria("Felipe", 1000);
        Console.WriteLine($"Conta {conta.numeroId} foi criada por {conta.nomeProprietario} com {conta.Saldo} de saldo inicial.");

        conta.FazerSaque(1500, DateTime.Now, "pagamento do agiota");
        Console.WriteLine(conta.Saldo);
        conta.FazerDeposito(100, DateTime.Now, "amigo caloteiro me devolveu");
        Console.WriteLine(conta.Saldo);

        Console.WriteLine(conta.ExtratoBancario());
        //TESTES
        // try
        // {
        //     conta.FazerSaque(700, DateTime.Now, "teste para resultado negativo");
        // }
        // catch (InvalidOperationException e)
        // {
        //     Console.WriteLine("Excessão detectada por tentar ultrapassar fundos disponíveis");
        //     Console.WriteLine(e.ToString());
        // }

        // ContaBancaria contaInvalida;
        // try
        // {
        //     contaInvalida = new ContaBancaria("marselo", -55);
        // }
        // catch (ArgumentOutOfRangeException e)
        // {
        //     Console.WriteLine("Excessão detectada por tentar criar conta com saldo negativo");
        //     Console.WriteLine(e.ToString());
        //     return;
        // }
    }
}