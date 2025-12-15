using System.ComponentModel;
class Program
{
    static void Main()
    {
        // var conta = new ContaBancaria("Felipe", 1000);
        // Console.WriteLine($"Conta {conta.numeroId} foi criada por {conta.nomeProprietario} com {conta.Saldo} de saldo inicial.");

        // conta.FazerSaque(1500, DateTime.Now, "pagamento do agiota");
        // Console.WriteLine(conta.Saldo);
        // conta.FazerDeposito(100, DateTime.Now, "amigo caloteiro me devolveu");
        // Console.WriteLine(conta.Saldo);

        // Console.WriteLine(conta.ExtratoBancario());


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

        Console.WriteLine("----------- Conta de cartão presente -----------");
        var gificard = new ContaCartaoPresente("gift card", 100, 50);
        gificard.FazerSaque(20, DateTime.Now, "peguei um café");
        gificard.FazerSaque(50, DateTime.Now, "comprei mantimentos");
        gificard.TransacaoFimDoMes();
        gificard.FazerDeposito(27.50m, DateTime.Now, "vendi uma pedra de crack");
        Console.WriteLine(gificard.ExtratoBancario());

        Console.WriteLine("----------- Conta Remunerada -----------");
        var remunerada = new ContaRemunerada("conta salva", 10000);
        remunerada.FazerDeposito(750, DateTime.Now, "salva mais dinheiro");
        remunerada.FazerDeposito(1250, DateTime.Now, "adicionado na carteira");
        remunerada.FazerSaque(250, DateTime.Now, "precisei comprar um ténis");
        remunerada.TransacaoFimDoMes();
        Console.WriteLine(remunerada.ExtratoBancario());

        Console.WriteLine("----------- Conta de Linha de Crédito -----------");
        var lineOfCredit = new ContaLinhaDeCredito("linha de créido", 0, 2000);
        lineOfCredit.FazerSaque(1000m, DateTime.Now, "assaltante me fez passar o cartão");
        lineOfCredit.FazerDeposito(50m, DateTime.Now, "recebi do jogo do bicho");
        lineOfCredit.FazerSaque(5000m, DateTime.Now, "fundo de emergência para reparo do galinheiro josefa");
        lineOfCredit.FazerDeposito(150m, DateTime.Now, "o que sobrou da reforma do galinheiro");
        lineOfCredit.TransacaoFimDoMes();
        Console.WriteLine(lineOfCredit.ExtratoBancario());
        
    }
}