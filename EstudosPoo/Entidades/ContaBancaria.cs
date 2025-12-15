using System.Data;
public class ContaBancaria
{
    private static int s_contaNumeroSerie = 1234567890;
    public string numeroId { get; }
    public string nomeProprietario { get; set; }
    private decimal saldo = 0;
    private List<Transacao> _todasTransacoes = new List<Transacao>();
    public decimal Saldo
    {
        get
        {
            foreach (var item in _todasTransacoes)
            {
                saldo += item.quantia;
            }

            return saldo;
        }
    }

    public ContaBancaria(string nome, decimal saldoInicial)
    {
        nomeProprietario = nome;
        FazerDeposito(saldoInicial, DateTime.Now, "Transação inicial");
        numeroId = s_contaNumeroSerie.ToString();
        s_contaNumeroSerie++;
    }
    public string ExtratoBancario()
    {
        var extrato = new System.Text.StringBuilder();
        decimal saldo = 0;
        extrato.AppendLine("Data\t\tQuantia\tSaldo\tDescrição");
        foreach(var item in _todasTransacoes)
        {
            saldo += item.quantia;
            extrato.AppendLine($"{item.data.ToShortDateString()}\t{item.quantia}\t{saldo}\t{item.descricao}");
        }
        return extrato.ToString();
    }

    public void FazerDeposito(decimal quantia, DateTime date, string descricao)
    {
        if(quantia <= 0)
            throw new ArgumentOutOfRangeException (nameof(quantia), "A quantia para o depósito tem que ser positivo");
        var deposito = new Transacao(quantia, date, descricao);
        _todasTransacoes.Add(deposito);
    }

    public void FazerSaque(decimal quantia, DateTime date, string descricao)
    {
        if(quantia <= 0)
            throw new ArgumentOutOfRangeException(nameof(quantia), "A quantia para saque deve ser positiva");
        if(Saldo - quantia < 0)
            throw new InvalidOperationException("Não tem fundos o suficiente para o saque");
        var saque = new Transacao(-quantia, date, descricao);
        _todasTransacoes.Add(saque);
    }
}