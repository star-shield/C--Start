public class ContaRemunerada : ContaBancaria
{
    public ContaRemunerada(string nome, decimal quantia) :base (nome, quantia)
    {
        
    }
    public override void TransacaoFimDoMes()
    {
        if(Saldo > 500m)
        {
            decimal juros = Saldo * 0.02m;
            FazerDeposito(juros, DateTime.Now, "juros de fim do mês aplicado");

        }
    }
}