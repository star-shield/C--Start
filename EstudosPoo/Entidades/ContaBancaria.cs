public class ContaBancaria
{
    private static int s_contaNumeroSerie = 1234567890;
     public string numeroId { get; }
    public string nomeProprietario { get; set; }
    public decimal Saldo
    {
        get
        {
            decimal saldo = 0;
            foreach (var item in _todasTransacoes)
            {
                balance += item.quantia;
            }

            return saldo;
        }
    }

    public ContaBancaria(string nome, decimal saldoInicial)
    {
        nomeProprietario = nome;
        if(saldoInicial < 0)
            saldo = 0.0m;
        saldo = saldoInicial;
        numeroId = s_contaNumeroSerie.ToString();
        s_contaNumeroSerie++;
    }
    private List<Transacao> _todasTransacoes = new List<Transacao>();

    public void FazerDeposito(decimal quantia, DateTime date, string descricao)
    {
    }

    public void FazerSaque(decimal quantia, DateTime date, string descricao)
    {
    }
}