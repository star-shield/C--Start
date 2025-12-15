public class ContaCartaoPresente : ContaBancaria
{
    private readonly decimal _depositoMensal = 0m;
    public ContaCartaoPresente(string nome, decimal quantia, decimal depositoMensal = 0) :base (nome, quantia)
    {
        _depositoMensal = depositoMensal;
    }
    public override void TransacaoFimDoMes()
    {
        if(_depositoMensal != 0)
            FazerDeposito(_depositoMensal, DateTime.Now, "Adicionado valor mensal");
    }
}