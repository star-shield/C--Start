using System.Data;
using System.Transactions;
public class ContaBancaria
{
    private static int s_contaNumeroSerie = 1234567890;
    public string numeroId { get; }
    public string nomeProprietario { get; set; }
    private decimal saldo = 0;
    private readonly decimal _saldoMinimo;
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
    public ContaBancaria(string nome, decimal quantia) :this (nome, quantia, 0){}
    public ContaBancaria(string nome, decimal saldoInicial, decimal saldoMinimo)
    {
        numeroId = s_contaNumeroSerie.ToString();
        s_contaNumeroSerie++;

        nomeProprietario = nome;
        if(saldoInicial > 0)
            FazerDeposito(saldoInicial, DateTime.Now, "Saldo inicial");
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
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(quantia);
        Transacao? rascunhoDeTransacao = ChecarLimiteSaque(Saldo - quantia < _saldoMinimo);
        Transacao? retirada = new (-quantia, date, descricao);
        _todasTransacoes.Add(retirada);
        if(rascunhoDeTransacao != null)
            _todasTransacoes.Add(rascunhoDeTransacao);
    }
    protected virtual Transacao? ChecarLimiteSaque(bool SaqueAcimaDoSaldo)
    {
        if(SaqueAcimaDoSaldo)
            throw new InvalidOperationException("Não tem fundos suficiente para o saque");
        else
        return default;
    }
    public virtual void TransacaoFimDoMes(){}
}