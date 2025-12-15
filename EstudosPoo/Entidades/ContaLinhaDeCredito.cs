using System.Transactions;

public class ContaLinhaDeCredito : ContaBancaria
{
    public ContaLinhaDeCredito(string nome, decimal saldoInicial, decimal limiteDeCredito) :base (nome, saldoInicial, -limiteDeCredito)
    {
        
    }

    protected override Transacao? ChecarLimiteSaque(bool saqueAcimaDoSaldo) =>
        saqueAcimaDoSaldo
        ? new Transacao(-20, DateTime.Now, "Aplicado taxa de sobregiro")
        : default;

    public override void TransacaoFimDoMes()
    {
        if(Saldo < 0)
        {
            decimal juros = -Saldo * 0.07m;
            FazerSaque(juros, DateTime.Now, "Cobrança de juros mensal");
        }
    }
}